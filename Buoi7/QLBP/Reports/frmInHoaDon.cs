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
    public partial class frmInHoaDon : Form
    {
        QLBPDbContext context = new QLBPDbContext();
        string reportsFolder = Path.Combine(Application.StartupPath, @"..\..\..\Reports");
        int _maHoaDon;

        public frmInHoaDon(int maHoaDon)
        {
            InitializeComponent();
            _maHoaDon = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(reportsFolder))
                reportsFolder = Path.Combine(Application.StartupPath, "Reports");

            var hoaDon = context.HoaDon
                .Include(h => h.KhachHang)
                .Include(h => h.NhanVien)
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
                    DonGiaBan = ct.DonGiaBan,
                    ThanhTien = ct.SoLuongBan * ct.DonGiaBan
                }).ToList();

                long tongTien = dsChiTiet.Sum(x => (long)x.ThanhTien);
                string tienChu = ChuyenSoThanhChu(tongTien) + " đồng chẵn.";

                ReportDataSource rds = new ReportDataSource("DanhSachHoaDon_ChiTiet", dsChiTiet);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");

                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("NgayLap", string.Format("An Giang, ngày {0} tháng {1} năm {2}", 
                        hoaDon.NgayLap.Day, hoaDon.NgayLap.Month, hoaDon.NgayLap.Year)),
                    new ReportParameter("NguoiBan_Ten", "CÔNG TY BÀN PHÍM CƠ AGU"),
                    new ReportParameter("NguoiBan_DiaChi", "Số 18 Ung Văn Khiêm, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiBan_MaSoThue", "1602162070"),
                    new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.HoVaTen),
                    new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChi ?? "N/A"),
                    new ReportParameter("NguoiMua_MaSoThue", ""),
                    new ReportParameter("TongTien", tongTien.ToString("N0") + " VNĐ (" + tienChu + ")")
                };

                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.RefreshReport();
            }
        }

        // Thuật toán đọc số thành chữ chuyên nghiệp (Vietnamese)
        private string ChuyenSoThanhChu(long number)
        {
            if (number == 0) return "Không";
            if (number < 0) return "Âm " + ChuyenSoThanhChu(Math.Abs(number));

            string[] unitNumbers = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = { "", "nghìn", "triệu", "tỷ" };
            
            string sNumber = number.ToString();
            int len = sNumber.Length;
            int gCount = (len + 2) / 3;
            string[] groups = new string[gCount];

            for (int i = 0; i < gCount; i++)
            {
                int start = Math.Max(0, len - (i + 1) * 3);
                int groupLen = (i == gCount - 1) ? (len % 3 == 0 ? 3 : len % 3) : 3;
                groups[i] = sNumber.Substring(start, groupLen);
            }

            string result = "";
            for (int i = gCount - 1; i >= 0; i--)
            {
                int gVal = int.Parse(groups[i]);
                if (gVal > 0)
                {
                    string gStr = ReadThreeDigits(gVal, i < gCount - 1);
                    result += gStr + " " + placeValues[i % 4] + " ";
                }
            }

            result = result.Trim();
            if (string.IsNullOrEmpty(result)) return "Không";
            return char.ToUpper(result[0]) + result.Substring(1);
        }

        private string ReadThreeDigits(int n, bool hasHigher)
        {
            string[] unitNumbers = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            int h = n / 100;
            int t = (n % 100) / 10;
            int u = n % 10;
            string res = "";

            if (h > 0 || hasHigher) res += unitNumbers[h] + " trăm ";
            
            if (t == 0)
            {
                if (u > 0 && (h > 0 || hasHigher)) res += "lẻ ";
            }
            else if (t == 1) res += "mười ";
            else res += unitNumbers[t] + " mươi ";

            if (u == 1 && t > 1) res += "mốt";
            else if (u == 5 && t > 0) res += "lăm";
            else if (u > 0) res += unitNumbers[u];

            return res.Trim();
        }
    }
}
