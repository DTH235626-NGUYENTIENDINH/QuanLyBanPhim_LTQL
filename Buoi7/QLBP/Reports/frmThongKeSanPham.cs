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
    public partial class frmThongKeSanPham : Form
    {
        QLBPDbContext context = new QLBPDbContext();
        string reportsFolder = Path.Combine(Application.StartupPath, @"..\..\..\Reports");

        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        public void LayLoaiSanPhamVaoComboBox()
        {
            var dsLoai = context.LoaiBanPhims.ToList();
            dsLoai.Insert(0, new LoaiBanPhim { ID = 0, TenLoai = "--- Tất cả ---" });
            cboLoaiSanPham.DataSource = dsLoai;
            cboLoaiSanPham.DisplayMember = "TenLoai";
            cboLoaiSanPham.ValueMember = "ID";
            cboLoaiSanPham.SelectedIndex = 0;
        }

        public void LayHangSanXuatVaoComboBox()
        {
            var dsHang = context.HangSanXuat.ToList();
            dsHang.Insert(0, new HangSanXuat { ID = 0, TenHangSanXuat = "--- Tất cả ---" });
            cboHangSanXuat.DataSource = dsHang;
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.ValueMember = "ID";
            cboHangSanXuat.SelectedIndex = 0;
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            LayLoaiSanPhamVaoComboBox();
            LayHangSanXuatVaoComboBox();
            
            if (!Directory.Exists(reportsFolder))
                reportsFolder = Path.Combine(Application.StartupPath, "Reports");

            LoadReportData(0, 0, 0, 0, false, "(Tất cả sản phẩm)");
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            int hangID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
            int loaiID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
            int giaTu = (int)numGiaTu.Value;
            int giaDen = (int)numGiaDen.Value;
            bool chiSapHet = chkSapHetHang.Checked;

            string moTa = $"(Hãng: {cboHangSanXuat.Text} | Loại: {cboLoaiSanPham.Text}";
            if (giaTu > 0 || giaDen > 0) moTa += $" | Giá: {giaTu:N0} - {giaDen:N0}";
            if (chiSapHet) moTa += " | Cảnh báo tồn kho";
            moTa += ")";

            LoadReportData(hangID, loaiID, giaTu, giaDen, chiSapHet, moTa);
        }

        private void LoadReportData(int hangID, int loaiID, int giaTu, int giaDen, bool chiSapHet, string moTa)
        {
            var query = context.BanPhim
                .Include(b => b.HangSanXuat)
                .Include(b => b.LoaiBanPhim)
                .AsQueryable();

            // Áp dụng bộ lọc
            if (hangID > 0) query = query.Where(r => r.HangSanXuatID == hangID);
            if (loaiID > 0) query = query.Where(r => r.LoaiBanPhimID == loaiID);
            if (giaTu > 0) query = query.Where(r => r.GiaBan >= giaTu);
            if (giaDen > 0) query = query.Where(r => r.GiaBan <= giaDen);
            if (chiSapHet) query = query.Where(r => r.SoLuong < 10);

            var danhSach = query.Select(r => new DanhSachBanPhim
            {
                ID = r.ID,
                TenBP = r.TenBP,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenLoaiBanPhim = r.LoaiBanPhim.TenLoai,
                GiaBan = r.GiaBan,
                SoLuong = r.SoLuong
            }).ToList();

            // Tính toán Dashboard
            long tongVon = danhSach.Sum(x => (long)x.GiaBan * x.SoLuong);
            int tongSL = danhSach.Sum(x => x.SoLuong);
            int soSPCanNhap = danhSach.Count(x => x.SoLuong < 5);

            ReportDataSource rds = new ReportDataSource("DanhSachBanPhim", danhSach);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");
            
            List<ReportParameter> p = new List<ReportParameter>
            {
                new ReportParameter("MoTaKetQuaHienThi", moTa),
                new ReportParameter("TongVonTonKho", tongVon.ToString("N0") + " VNĐ"),
                new ReportParameter("TongSoLuong", tongSL.ToString("N0")),
                new ReportParameter("SoSPCanNhap", soSPCanNhap.ToString())
            };
            reportViewer1.LocalReport.SetParameters(p);
            
            reportViewer1.RefreshReport();
        }
    }
}
