using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLBP.DATA;
using Microsoft.EntityFrameworkCore;

namespace QLBP.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLBPDbContext context = new QLBPDbContext();
        string reportsFolder = Path.Combine(Application.StartupPath, @"..\..\..\Reports");

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(reportsFolder))
                reportsFolder = Path.Combine(Application.StartupPath, "Reports");

            LoadComboBoxes();
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            LoadReportData(null, null, 0, 0, "(Tất cả thời gian)");
        }

        private void LoadComboBoxes()
        {
            var dsNV = context.NhanVien.ToList();
            dsNV.Insert(0, new NhanVien { ID = 0, HoVaTen = "--- Tất cả nhân viên ---" });
            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";

            var dsKH = context.KhachHang.ToList();
            dsKH.Insert(0, new KhachHang { ID = 0, HoVaTen = "--- Tất cả khách hàng ---" });
            cboKhachHang.DataSource = dsKH;
            cboKhachHang.DisplayMember = "HoVaTen";
            cboKhachHang.ValueMember = "ID";
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            DateTime tu = dtpTuNgay.Value.Date;
            DateTime den = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
            int nvID = Convert.ToInt32(cboNhanVien.SelectedValue);
            int khID = Convert.ToInt32(cboKhachHang.SelectedValue);

            string moTa = $"Kỳ báo cáo: {dtpTuNgay.Text} - {dtpDenNgay.Text}";
            if (nvID > 0) moTa += $" | NV: {cboNhanVien.Text}";
            if (khID > 0) moTa += $" | KH: {cboKhachHang.Text}";

            LoadReportData(tu, den, nvID, khID, moTa);
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            LoadReportData(null, null, 0, 0, "(Tất cả thời gian)");
        }

        private void LoadReportData(DateTime? tu, DateTime? den, int nvID, int khID, string moTa)
        {
            var query = context.HoaDon
                .Include(h => h.NhanVien)
                .Include(h => h.KhachHang)
                .Include(h => h.HoaDon_ChiTiet)
                .AsQueryable();

            if (tu.HasValue) query = query.Where(h => h.NgayLap >= tu.Value && h.NgayLap <= den.Value);
            if (nvID > 0) query = query.Where(h => h.NhanVienID == nvID);
            if (khID > 0) query = query.Where(h => h.KhachHangID == khID);

            var danhSach = query.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                TenNhanVien = r.NhanVien.HoVaTen,
                TenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(ct => (double)ct.SoLuongBan * ct.DonGiaBan)
            }).ToList();

            // Tính toán Dashboard
            double tongDoanhThu = danhSach.Sum(x => x.TongTienHoaDon ?? 0);
            int tongDonHang = danhSach.Count;
            double aov = tongDonHang > 0 ? tongDoanhThu / tongDonHang : 0;
            
            string topNV = "N/A";
            if (tongDonHang > 0)
            {
                var top = danhSach.GroupBy(x => x.TenNhanVien)
                                  .OrderByDescending(g => g.Sum(x => x.TongTienHoaDon))
                                  .FirstOrDefault();
                if (top != null) topNV = top.Key;
            }

            ReportDataSource rds = new ReportDataSource("DanhSachHoaDon", danhSach);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            
            List<ReportParameter> p = new List<ReportParameter>
            {
                new ReportParameter("MoTaKetQuaHienThi", moTa),
                new ReportParameter("TongDoanhThu", tongDoanhThu.ToString("N0") + " VNĐ"),
                new ReportParameter("TongDonHang", tongDonHang.ToString()),
                new ReportParameter("AOV", aov.ToString("N0") + " VNĐ"),
                new ReportParameter("TopNhanVien", topNV)
            };
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.RefreshReport();
        }
    }
}
