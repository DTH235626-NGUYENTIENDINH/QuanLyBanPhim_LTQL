using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore.Storage.Json;
using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
namespace QLBP.FORM
{
    public partial class frmHoaDon : Form
    {
        private NhanVien currentNhanVien;

        public frmHoaDon(NhanVien nv = null)
        {
            InitializeComponent();
            currentNhanVien = nv;
        }
        QLBPDbContext context = new QLBPDbContext();
        int id;

        public void frmHoaDon_Load(object sender, EventArgs e)
        {
            // Phân quyền chi tiết
            if (currentNhanVien != null)
            {
                if (currentNhanVien.VaiTro == 1) // Bán hàng
                {
                    btnTaoBaoHanh.Visible = true; // Cho phép tạo yêu cầu bảo hành
                    btnSua.Enabled = false; // Thường không cho sửa hoá đơn cũ
                    btnXoa.Enabled = false;
                }
                else if (currentNhanVien.VaiTro == 2) // Bảo hành
                {
                    btnLapHoaDonMoi.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnTaoBaoHanh.Visible = false; // Nhân viên kỹ thuật thường không tạo mới yêu cầu tiếp nhận
                }
            }

            dataGridView.AutoGenerateColumns = false;

            List<DanhSachHoaDon> hd = new List<DanhSachHoaDon>();
            hd = context.HoaDon.Select(r => new DanhSachHoaDon
            {
                ID = r.ID,
                NhanVienID = r.NhanVienID,
                TenNhanVien = r.NhanVien.HoVaTen,
                KhachHangID = r.KhachHangID,
                TenKhachHang = r.KhachHang.HoVaTen,
                NgayLap = r.NgayLap,
                GhiChuHoaDon = r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => (double)r.SoLuongBan * (double)r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).ToList();
            dataGridView.DataSource = hd;
        }

        private void btnLapHoaDonMoi_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(0, false))
            {
                chiTiet.ShowDialog();
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null)
            {
                MessageBox.Show("Không có hoá đơn để sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
            {
                chiTiet.ShowDialog();
            }
            frmHoaDon_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xác nhận xoá hoá đơn này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                HoaDon hd = context.HoaDon.Find(id);
                if (hd != null)
                {
                    context.HoaDon.Remove(hd);
                }
                context.SaveChanges();
                frmHoaDon_Load(sender, e);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.Columns[e.ColumnIndex].Name == "ChiTiet" && e.RowIndex >= 0)
            {
                int maHoaDon = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);
                using (frmHoaDon_ChiTiet frm = new frmHoaDon_ChiTiet(maHoaDon,true))
                {
                    frm.ShowDialog();                   
                }
                frmHoaDon_Load(sender,e);   
            } 
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất báo cáo hóa đơn";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "BaoCao_HoaDon_" + DateTime.Now.ToString("dd_MM_yyyy") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // --- BƯỚC 1: TẠO DATA CHO SHEET "HoaDon" ---
                        DataTable dtHD = new DataTable("HoaDon");
                        dtHD.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Mã HĐ", typeof(int)),
                    new DataColumn("Nhân viên", typeof(string)),
                    new DataColumn("Khách hàng", typeof(string)),
                    new DataColumn("Ngày lập", typeof(string)),
                    new DataColumn("Ghi chú", typeof(string)),
                    new DataColumn("Tổng tiền", typeof(double))
                });

                        // --- BƯỚC 2: TẠO DATA CHO SHEET "HoaDon_ChiTiet" ---
                        DataTable dtCT = new DataTable("HoaDon_ChiTiet");
                        dtCT.Columns.AddRange(new DataColumn[] {
                    new DataColumn("Mã HĐ", typeof(int)),
                    new DataColumn("Sản phẩm", typeof(string)),
                    new DataColumn("Số lượng", typeof(int)),
                    new DataColumn("Đơn giá", typeof(double)),
                    new DataColumn("Thành tiền", typeof(double))
                });

                        // --- BƯỚC 3: ĐỔ DỮ LIỆU TỪ DATABASE VÀO 2 TABLE ---
                        // Lấy toàn bộ danh sách hóa đơn bao gồm cả chi tiết và các bảng liên quan
                        var dsHoaDon = context.HoaDon
                        .Include(h => h.NhanVien)      
                        .Include(h => h.KhachHang)     
                        .Include(h => h.HoaDon_ChiTiet)
                        .ThenInclude(ct => ct.BanPhim) 
                        .ToList();

                        foreach (var hd in dsHoaDon)
                        {
                            // Tính tổng tiền cho Sheet HoaDon (giống cách ông làm ở Load)
                            double tongTien = hd.HoaDon_ChiTiet.Sum(x => (double)x.SoLuongBan * x.DonGiaBan);

                            dtHD.Rows.Add(
                                hd.ID,
                                hd.NhanVien?.HoVaTen ?? "N/A",
                                hd.KhachHang?.HoVaTen ?? "N/A",
                                hd.NgayLap.ToString("dd/MM/yyyy HH:mm"),
                                hd.GhiChuHoaDon,
                                tongTien
                            );

                            // Với mỗi hóa đơn, duyệt chi tiết của nó để đổ vào Sheet 2
                            foreach (var ct in hd.HoaDon_ChiTiet)
                            {
                                dtCT.Rows.Add(
                                    ct.HoaDonID,
                                    ct.BanPhim?.TenBP ?? "Sản phẩm đã xóa",
                                    ct.SoLuongBan,
                                    ct.DonGiaBan,
                                    (double)ct.SoLuongBan * ct.DonGiaBan
                                );
                            }
                        }

                        // --- BƯỚC 4: NHÉT VÀO WORKBOOK ---
                        var wsHD = wb.Worksheets.Add(dtHD);
                        wsHD.Columns().AdjustToContents(); // Tự giãn cột cho đẹp

                        var wsCT = wb.Worksheets.Add(dtCT);
                        wsCT.Columns().AdjustToContents();

                        // Lưu file
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra 2 sheet thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTaoBaoHanh_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hoá đơn để tạo phiếu bảo hành!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maHoaDon = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            using (frmBaoHanh frm = new frmBaoHanh(maHoaDon, currentNhanVien))
            {
                frm.ShowDialog();
            }
        }
    }
}
