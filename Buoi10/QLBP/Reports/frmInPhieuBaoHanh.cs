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
    public partial class frmInPhieuBaoHanh : Form
    {
        QLBPDbContext context = new QLBPDbContext();
        string reportsFolder = Path.Combine(Application.StartupPath, @"..\..\..\Reports");
        int _maHoaDon;

        public frmInPhieuBaoHanh(int maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
        }

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmInPhieuBaoHanh
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmInPhieuBaoHanh";
            this.Text = "In Phiếu Bảo Hành";
            this.Load += new System.EventHandler(this.frmInPhieuBaoHanh_Load);
            this.ResumeLayout(false);

        }

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

        private void frmInPhieuBaoHanh_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(reportsFolder))
                reportsFolder = Path.Combine(Application.StartupPath, "Reports");

            var hoaDon = context.HoaDon
                .Include(h => h.KhachHang)
                .Include(h => h.HoaDon_ChiTiet)
                .ThenInclude(ct => ct.BanPhim)
                .FirstOrDefault(h => h.ID == _maHoaDon);

            if (hoaDon != null)
            {
                var dsChiTiet = hoaDon.HoaDon_ChiTiet.Select(ct => new DanhSachHoaDonChiTiet
                {
                    ID = ct.ID,
                    TenBP = ct.BanPhim.TenBP,
                    SoLuongBan = ct.SoLuongBan,
                    ThoiGianBaoHanh = ct.ThoiGianBaoHanh
                }).ToList();

                ReportDataSource rds = new ReportDataSource("DanhSachHoaDon_ChiTiet", dsChiTiet);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhieuBaoHanh.rdlc");

                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", hoaDon.NgayLap.ToString("dd/MM/yyyy")),
                    new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.HoVaTen),
                    new ReportParameter("MaHD", hoaDon.ID.ToString())
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.RefreshReport();
            }
        }
    }
}
