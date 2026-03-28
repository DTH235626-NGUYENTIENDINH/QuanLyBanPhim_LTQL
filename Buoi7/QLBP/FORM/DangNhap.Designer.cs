namespace QLBP.FORM
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelForm = new Panel();
            lblError = new Label();
            btnThoat = new QLBP.Controls.CustomButon();
            btnDangNhap = new QLBP.Controls.CustomButon();
            txtMatKhau = new QLBP.Controls.CustomTextbox();
            txtTenDangNhap = new QLBP.Controls.CustomTextbox();
            lblMatKhau = new Label();
            lblTenDangNhap = new Label();
            lblTitle = new Label();
            lblSubTitle = new Label();
            pictureBoxLogo = new PictureBox();
            panelMain.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(22, 20, 35);
            panelMain.Controls.Add(panelForm);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(520, 480);
            panelMain.TabIndex = 0;
            panelMain.Paint += panelMain_Paint;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.None;
            panelForm.BackColor = Color.FromArgb(30, 28, 45);
            panelForm.Controls.Add(lblError);
            panelForm.Controls.Add(btnThoat);
            panelForm.Controls.Add(btnDangNhap);
            panelForm.Controls.Add(txtMatKhau);
            panelForm.Controls.Add(txtTenDangNhap);
            panelForm.Controls.Add(lblMatKhau);
            panelForm.Controls.Add(lblTenDangNhap);
            panelForm.Controls.Add(lblTitle);
            panelForm.Controls.Add(lblSubTitle);
            panelForm.Controls.Add(pictureBoxLogo);
            panelForm.Location = new Point(35, 20);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(450, 440);
            panelForm.TabIndex = 0;
            panelForm.Paint += panelForm_Paint;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(175, 15);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 65);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 85);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(450, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "QUẢN LÝ BÀN PHÍM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Segoe UI", 10F);
            lblSubTitle.ForeColor = Color.FromArgb(160, 160, 200);
            lblSubTitle.Location = new Point(0, 117);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(450, 22);
            lblSubTitle.TabIndex = 2;
            lblSubTitle.Text = "Đăng nhập để tiếp tục";
            lblSubTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.ForeColor = Color.FromArgb(180, 180, 220);
            lblTenDangNhap.Location = new Point(50, 155);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(105, 19);
            lblTenDangNhap.TabIndex = 3;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.FromArgb(40, 38, 58);
            txtTenDangNhap.BorderColor = Color.FromArgb(100, 80, 180);
            txtTenDangNhap.BorderSize = 2;
            txtTenDangNhap.BorderRadius = 15;
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.ForeColor = Color.White;
            txtTenDangNhap.Location = new Point(50, 178);
            txtTenDangNhap.Margin = new Padding(4);
            txtTenDangNhap.Multiline = false;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Padding = new Padding(10, 7, 10, 7);
            txtTenDangNhap.PassWordChar = false;
            txtTenDangNhap.Size = new Size(350, 38);
            txtTenDangNhap.TabIndex = 0;
            txtTenDangNhap.UnderlinedStyle = false;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.ForeColor = Color.FromArgb(180, 180, 220);
            lblMatKhau.Location = new Point(50, 228);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(72, 19);
            lblMatKhau.TabIndex = 5;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(40, 38, 58);
            txtMatKhau.BorderColor = Color.FromArgb(100, 80, 180);
            txtMatKhau.BorderSize = 2;
            txtMatKhau.BorderRadius = 15;
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.ForeColor = Color.White;
            txtMatKhau.Location = new Point(50, 251);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Multiline = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Padding = new Padding(10, 7, 10, 7);
            txtMatKhau.PassWordChar = true;
            txtMatKhau.Size = new Size(350, 38);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UnderlinedStyle = false;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.FromArgb(255, 100, 100);
            lblError.Location = new Point(50, 296);
            lblError.Name = "lblError";
            lblError.Size = new Size(350, 20);
            lblError.TabIndex = 7;
            lblError.Text = "";
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            lblError.Visible = false;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(100, 60, 200);
            btnDangNhap.BackgroundColor = Color.FromArgb(100, 60, 200);
            btnDangNhap.BorderColor = Color.FromArgb(130, 90, 230);
            btnDangNhap.BorderRadius = 20;
            btnDangNhap.BorderSize = 0;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 80, 220);
            btnDangNhap.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 40, 180);
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(50, 325);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(350, 45);
            btnDangNhap.TabIndex = 2;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.TextColor = Color.White;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BackgroundColor = Color.Transparent;
            btnThoat.BorderColor = Color.FromArgb(150, 150, 180);
            btnThoat.BorderRadius = 20;
            btnThoat.BorderSize = 2;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 48, 68);
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F);
            btnThoat.ForeColor = Color.FromArgb(180, 180, 210);
            btnThoat.Location = new Point(150, 385);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 38);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextColor = Color.FromArgb(180, 180, 210);
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // DangNhap
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 20, 35);
            ClientSize = new Size(520, 480);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Quản lý bàn phím";
            panelMain.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelForm;
        private PictureBox pictureBoxLogo;
        private Label lblTitle;
        private Label lblSubTitle;
        private Label lblTenDangNhap;
        private Controls.CustomTextbox txtTenDangNhap;
        private Label lblMatKhau;
        private Controls.CustomTextbox txtMatKhau;
        private Label lblError;
        private Controls.CustomButon btnDangNhap;
        private Controls.CustomButon btnThoat;
    }
}