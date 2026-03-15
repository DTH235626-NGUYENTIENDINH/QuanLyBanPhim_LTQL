using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QLBP.FORM
{
    public partial class DangNhap : Form
    {
        public NhanVien NhanVienDangNhap { get; private set; }

        public DangNhap()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau))
            {
                ShowError("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            try
            {
                using (var context = new QLBPDbContext())
                {
                    var nv = context.NhanVien.FirstOrDefault(x => x.TenDangNhap == tenDN);
                    if (nv == null)
                    {
                        ShowError("Tên đăng nhập không tồn tại!");
                        txtTenDangNhap.Focus();
                        return;
                    }

                    if (!BC.Verify(matKhau, nv.MatKhau))
                    {
                        ShowError("Mật khẩu không đúng!");
                        txtMatKhau.Focus();
                        return;
                    }

                    NhanVienDangNhap = nv;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
            lblError.Visible = true;
        }

        // Vẽ gradient nền cho panelMain
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panel.ClientRectangle,
                Color.FromArgb(22, 20, 35),
                Color.FromArgb(40, 20, 70),
                LinearGradientMode.ForwardDiagonal))
            {
                e.Graphics.FillRectangle(brush, panel.ClientRectangle);
            }
        }

        // Vẽ bo góc + viền sáng cho panelForm
        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, panel.Width - 1, panel.Height - 1);
            using (GraphicsPath path = RoundedRect(rect, radius))
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(30, 28, 45)))
                {
                    g.FillPath(brush, path);
                }
                using (Pen pen = new Pen(Color.FromArgb(60, 100, 80, 200), 1.5f))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Cho phép kéo di chuyển form không viền
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
    }
}
