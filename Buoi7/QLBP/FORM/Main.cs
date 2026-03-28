using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBP.FORM
{
    public partial class frmMain : Form
    {
        private NhanVien NguoiDungHienTai;
        public bool DaDangXuat { get; set; } = false;

        public frmMain(NhanVien nguoiDung)
        {
            InitializeComponent();
            NguoiDungHienTai = nguoiDung;
            customDesing();
            PhanQuyen();
            CapNhatTrangThai();
        }

        private void CapNhatTrangThai()
        {
            string vaiTro = NguoiDungHienTai.VaiTro switch
            {
                0 => "Quản lý",
                1 => "NV Bán hàng",
                2 => "NV Bảo hành",
                _ => "Không xác định"
            };
            lblTrangThaiOrTen.Text = $"{NguoiDungHienTai.HoVaTen} ({vaiTro})";
        }

        private void PhanQuyen()
        {
            // Quản lý (0): Thấy tất cả
            // NV Bán hàng (1): Bàn phím (xem), Khách hàng, Hóa đơn
            // NV Bảo hành (2): Bàn phím (xem), Khách hàng, Bảo hành

            switch (NguoiDungHienTai.VaiTro)
            {
                case 0: // Quản lý - toàn quyền
                    break;

                case 1: // NV Bán hàng
                    btnNV.Visible = false;
                    btnHSX.Visible = false;
                    btnLoaiBP.Visible = false;
                    btnBaoHanh.Visible = true; // Cho phép tạo yêu cầu bảo hành
                    btnBaoCao.Visible = false;
                    panelSubBaoCao.Visible = false;
                    break;

                case 2: // NV Bảo hành sửa chữa
                    btnNV.Visible = false;
                    btnHSX.Visible = false;
                    btnLoaiBP.Visible = false;
                    btnHD.Visible = true; // Cho phép xem hoá đơn để đối chiếu
                    btnBaoCao.Visible = false;
                    panelSubBaoCao.Visible = false;
                    break;
            }
        }

        private void customDesing()
        {
            panelSubBaoCao.Visible = false;
            panelSubHeThong.Visible = false;
            panelSubQuanLy.Visible = false;
            panelSubTroGiup.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubBaoCao.Visible == true)
                panelSubBaoCao.Visible = false;
            if (panelSubHeThong.Visible == true)
                panelSubHeThong.Visible = false;
            if (panelSubQuanLy.Visible == true)
                panelSubQuanLy.Visible = false;
            if (panelSubTroGiup.Visible == true)
                panelSubTroGiup.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private Form activeForm = null;

        private void moFormCon(Form formCon)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formCon;

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            panelParent.Controls.Add(formCon);
            panelParent.Tag = formCon;

            formCon.BringToFront();
            formCon.Show();
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubHeThong);
        }
        //Phần quản lý
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubQuanLy);
        }

        private void btnBanPhim_Click(object sender, EventArgs e)
        {
            moFormCon(new frmBanPhim(NguoiDungHienTai));
        }

        private void btnHSX_Click(object sender, EventArgs e)
        {
            moFormCon(new frmHangSanXuat());
        }

        private void btnLoaiBP_Click(object sender, EventArgs e)
        {
            moFormCon(new frmLoaiBanPhim());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            moFormCon(new frmKhachHang(NguoiDungHienTai));
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            moFormCon(new frmNhanVien());
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            moFormCon(new frmHoaDon(NguoiDungHienTai));
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            moFormCon(new frmBaoHanh(null, NguoiDungHienTai));
        }

        //Phần báo cáo
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubBaoCao);
        }
        private void btnTKSP_Click(object sender, EventArgs e)
        {
            moFormCon(new Reports.frmThongKeSanPham());
        }

        private void btnTKDT_Click(object sender, EventArgs e)
        {
            moFormCon(new Reports.frmThongKeDoanhThu());
        }

        private void btnTroGiup_Click(object sender, EventArgs e)

        {
            showSubMenu(panelSubTroGiup);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DaDangXuat = false;
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTrangThaiOrTen_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click_Menu(object sender, EventArgs e)
        {
            // Đăng nhập lại (từ menu Hệ thống)
            MessageBox.Show("Bạn đã đăng nhập rồi. Hãy đăng xuất trước nếu muốn đổi tài khoản.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DaDangXuat = true;
                this.Close();
            }
        }

        private void btnThoat_Click_Menu(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DaDangXuat = false;
                Application.Exit();
            }
        }
    }
}
