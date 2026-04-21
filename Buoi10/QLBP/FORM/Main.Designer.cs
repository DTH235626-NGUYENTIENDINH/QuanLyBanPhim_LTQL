namespace QLBP.FORM
{
    partial class frmMain
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
            btnBaoHanh = new Button();
            panelMenu = new Panel();
            panelSubTroGiup = new Panel();
            btnTTPM = new Button();
            btnHDSD = new Button();
            btnTroGiup = new Button();
            panelSubBaoCao = new Panel();
            btnTKDT = new Button();
            btnTKSP = new Button();
            btnBaoCao = new Button();
            panelSubQuanLy = new Panel();
            btnHD = new Button();
            btnNV = new Button();
            btnKH = new Button();
            btnHSX = new Button();
            btnLoaiBP = new Button();
            btnBanPhim = new Button();
            btnQuanLy = new Button();
            panelSubHeThong = new Panel();
            btnThoat = new Button();
            btnLichSu = new Button();
            btnDangXuat = new Button();
            btnDangNhap = new Button();
            btnHeThong = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelParent = new Panel();
            panelTittleBar = new Panel();
            lblTrangThaiOrTen = new Label();
            btnMinimize = new Button();
            btnClose = new Button();
            helpProvider = new HelpProvider();
            panelMenu.SuspendLayout();
            panelSubTroGiup.SuspendLayout();
            panelSubBaoCao.SuspendLayout();
            panelSubQuanLy.SuspendLayout();
            panelSubHeThong.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTittleBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnBaoHanh
            // 
            btnBaoHanh.BackColor = Color.FromArgb(35, 32, 39);
            btnBaoHanh.Dock = DockStyle.Top;
            btnBaoHanh.FlatAppearance.BorderSize = 0;
            btnBaoHanh.FlatStyle = FlatStyle.Flat;
            btnBaoHanh.Font = new Font("Segoe UI", 9.75F);
            btnBaoHanh.ForeColor = Color.LightGray;
            btnBaoHanh.Location = new Point(0, 240);
            btnBaoHanh.Name = "btnBaoHanh";
            btnBaoHanh.Padding = new Padding(35, 0, 0, 0);
            btnBaoHanh.Size = new Size(233, 40);
            btnBaoHanh.TabIndex = 11;
            btnBaoHanh.Text = "Bảo hành sửa chữa";
            btnBaoHanh.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoHanh.UseVisualStyleBackColor = false;
            btnBaoHanh.Click += btnBaoHanh_Click;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelMenu.Controls.Add(panelSubTroGiup);
            panelMenu.Controls.Add(btnTroGiup);
            panelMenu.Controls.Add(panelSubBaoCao);
            panelMenu.Controls.Add(btnBaoCao);
            panelMenu.Controls.Add(panelSubQuanLy);
            panelMenu.Controls.Add(btnQuanLy);
            panelMenu.Controls.Add(panelSubHeThong);
            panelMenu.Controls.Add(btnHeThong);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 740);
            panelMenu.TabIndex = 0;
            // 
            // panelSubTroGiup
            // 
            panelSubTroGiup.BackColor = Color.FromArgb(35, 32, 39);
            panelSubTroGiup.Controls.Add(btnTTPM);
            panelSubTroGiup.Controls.Add(btnHDSD);
            panelSubTroGiup.Dock = DockStyle.Top;
            panelSubTroGiup.Location = new Point(0, 869);
            panelSubTroGiup.Name = "panelSubTroGiup";
            panelSubTroGiup.Size = new Size(233, 87);
            panelSubTroGiup.TabIndex = 8;
            // 
            // btnTTPM
            // 
            btnTTPM.BackColor = Color.FromArgb(35, 32, 39);
            btnTTPM.Dock = DockStyle.Top;
            btnTTPM.FlatAppearance.BorderSize = 0;
            btnTTPM.FlatStyle = FlatStyle.Flat;
            btnTTPM.Font = new Font("Segoe UI", 9.75F);
            btnTTPM.ForeColor = Color.LightGray;
            helpProvider.SetHelpKeyword(btnTTPM, "file:///D:/AGU/2025-2026_hoc_ki_2/LTQL/NopDoANTheoBuoi/Buoi10/docs/index.html#about");
            helpProvider.SetHelpNavigator(btnTTPM, HelpNavigator.Topic);
            btnTTPM.Location = new Point(0, 40);
            btnTTPM.Name = "btnTTPM";
            btnTTPM.Padding = new Padding(35, 0, 0, 0);
            helpProvider.SetShowHelp(btnTTPM, true);
            btnTTPM.Size = new Size(233, 40);
            btnTTPM.TabIndex = 1;
            btnTTPM.Text = "Thông tin phần mềm";
            btnTTPM.TextAlign = ContentAlignment.MiddleLeft;
            btnTTPM.UseVisualStyleBackColor = false;
            btnTTPM.Click += btnTTPM_Click;
            // 
            // btnHDSD
            // 
            btnHDSD.BackColor = Color.FromArgb(35, 32, 39);
            btnHDSD.Dock = DockStyle.Top;
            btnHDSD.FlatAppearance.BorderSize = 0;
            btnHDSD.FlatStyle = FlatStyle.Flat;
            btnHDSD.Font = new Font("Segoe UI", 9.75F);
            btnHDSD.ForeColor = Color.LightGray;
            helpProvider.SetHelpKeyword(btnHDSD, "https://dth235626-nguyentiendinh.github.io/HuongDanSuDungDoAn/#manual");
            helpProvider.SetHelpNavigator(btnHDSD, HelpNavigator.Topic);
            btnHDSD.Location = new Point(0, 0);
            btnHDSD.Name = "btnHDSD";
            btnHDSD.Padding = new Padding(35, 0, 0, 0);
            helpProvider.SetShowHelp(btnHDSD, true);
            btnHDSD.Size = new Size(233, 40);
            btnHDSD.TabIndex = 0;
            btnHDSD.Text = "Hướng dẫn sử dụng";
            btnHDSD.TextAlign = ContentAlignment.MiddleLeft;
            btnHDSD.UseVisualStyleBackColor = false;
            btnHDSD.Click += btnHDSD_Click;
            // 
            // btnTroGiup
            // 
            btnTroGiup.BackColor = Color.Transparent;
            btnTroGiup.Dock = DockStyle.Top;
            btnTroGiup.FlatAppearance.BorderSize = 0;
            btnTroGiup.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 16, 199);
            btnTroGiup.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 13, 163);
            btnTroGiup.FlatStyle = FlatStyle.Flat;
            btnTroGiup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTroGiup.ForeColor = Color.FromArgb(128, 128, 255);
            helpProvider.SetHelpKeyword(btnTroGiup, "");
            btnTroGiup.Location = new Point(0, 824);
            btnTroGiup.Name = "btnTroGiup";
            btnTroGiup.Padding = new Padding(10, 0, 0, 0);
            helpProvider.SetShowHelp(btnTroGiup, true);
            btnTroGiup.Size = new Size(233, 45);
            btnTroGiup.TabIndex = 7;
            btnTroGiup.Text = "Trợ giúp";
            btnTroGiup.TextAlign = ContentAlignment.MiddleLeft;
            btnTroGiup.UseVisualStyleBackColor = false;
            btnTroGiup.Click += btnTroGiup_Click;
            // 
            // panelSubBaoCao
            // 
            panelSubBaoCao.BackColor = Color.FromArgb(35, 32, 39);
            panelSubBaoCao.Controls.Add(btnTKDT);
            panelSubBaoCao.Controls.Add(btnTKSP);
            panelSubBaoCao.Dock = DockStyle.Top;
            panelSubBaoCao.Location = new Point(0, 737);
            panelSubBaoCao.Name = "panelSubBaoCao";
            panelSubBaoCao.Size = new Size(233, 87);
            panelSubBaoCao.TabIndex = 6;
            // 
            // btnTKDT
            // 
            btnTKDT.BackColor = Color.FromArgb(35, 32, 39);
            btnTKDT.Dock = DockStyle.Top;
            btnTKDT.FlatAppearance.BorderSize = 0;
            btnTKDT.FlatStyle = FlatStyle.Flat;
            btnTKDT.Font = new Font("Segoe UI", 9.75F);
            btnTKDT.ForeColor = Color.LightGray;
            btnTKDT.Location = new Point(0, 40);
            btnTKDT.Name = "btnTKDT";
            btnTKDT.Padding = new Padding(35, 0, 0, 0);
            btnTKDT.Size = new Size(233, 40);
            btnTKDT.TabIndex = 1;
            btnTKDT.Text = "Thống kê doanh thu";
            btnTKDT.TextAlign = ContentAlignment.MiddleLeft;
            btnTKDT.UseVisualStyleBackColor = false;
            btnTKDT.Click += btnTKDT_Click;
            // 
            // btnTKSP
            // 
            btnTKSP.BackColor = Color.FromArgb(35, 32, 39);
            btnTKSP.Dock = DockStyle.Top;
            btnTKSP.FlatAppearance.BorderSize = 0;
            btnTKSP.FlatStyle = FlatStyle.Flat;
            btnTKSP.Font = new Font("Segoe UI", 9.75F);
            btnTKSP.ForeColor = Color.LightGray;
            btnTKSP.Location = new Point(0, 0);
            btnTKSP.Name = "btnTKSP";
            btnTKSP.Padding = new Padding(35, 0, 0, 0);
            btnTKSP.Size = new Size(233, 40);
            btnTKSP.TabIndex = 0;
            btnTKSP.Text = "Thống kê sản phẩm";
            btnTKSP.TextAlign = ContentAlignment.MiddleLeft;
            btnTKSP.UseVisualStyleBackColor = false;
            btnTKSP.Click += btnTKSP_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.Transparent;
            btnBaoCao.Dock = DockStyle.Top;
            btnBaoCao.FlatAppearance.BorderSize = 0;
            btnBaoCao.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 16, 199);
            btnBaoCao.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 13, 163);
            btnBaoCao.FlatStyle = FlatStyle.Flat;
            btnBaoCao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBaoCao.ForeColor = Color.FromArgb(128, 128, 255);
            btnBaoCao.Location = new Point(0, 692);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Padding = new Padding(10, 0, 0, 0);
            helpProvider.SetShowHelp(btnBaoCao, true);
            btnBaoCao.Size = new Size(233, 45);
            btnBaoCao.TabIndex = 5;
            btnBaoCao.Text = "Báo cáo - thống kê";
            btnBaoCao.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // panelSubQuanLy
            // 
            panelSubQuanLy.BackColor = Color.FromArgb(35, 32, 39);
            panelSubQuanLy.Controls.Add(btnBaoHanh);
            panelSubQuanLy.Controls.Add(btnHD);
            panelSubQuanLy.Controls.Add(btnNV);
            panelSubQuanLy.Controls.Add(btnKH);
            panelSubQuanLy.Controls.Add(btnHSX);
            panelSubQuanLy.Controls.Add(btnLoaiBP);
            panelSubQuanLy.Controls.Add(btnBanPhim);
            panelSubQuanLy.Dock = DockStyle.Top;
            panelSubQuanLy.Location = new Point(0, 404);
            panelSubQuanLy.Name = "panelSubQuanLy";
            panelSubQuanLy.Size = new Size(233, 288);
            panelSubQuanLy.TabIndex = 4;
            // 
            // btnHD
            // 
            btnHD.BackColor = Color.FromArgb(35, 32, 39);
            btnHD.Dock = DockStyle.Top;
            btnHD.FlatAppearance.BorderSize = 0;
            btnHD.FlatStyle = FlatStyle.Flat;
            btnHD.Font = new Font("Segoe UI", 9.75F);
            btnHD.ForeColor = Color.LightGray;
            btnHD.Location = new Point(0, 200);
            btnHD.Name = "btnHD";
            btnHD.Padding = new Padding(35, 0, 0, 0);
            btnHD.Size = new Size(233, 40);
            btnHD.TabIndex = 10;
            btnHD.Text = "Hoá đơn bán hàng";
            btnHD.TextAlign = ContentAlignment.MiddleLeft;
            btnHD.UseVisualStyleBackColor = false;
            btnHD.Click += btnHD_Click;
            // 
            // btnNV
            // 
            btnNV.BackColor = Color.FromArgb(35, 32, 39);
            btnNV.Dock = DockStyle.Top;
            btnNV.FlatAppearance.BorderSize = 0;
            btnNV.FlatStyle = FlatStyle.Flat;
            btnNV.Font = new Font("Segoe UI", 9.75F);
            btnNV.ForeColor = Color.LightGray;
            btnNV.Location = new Point(0, 160);
            btnNV.Name = "btnNV";
            btnNV.Padding = new Padding(35, 0, 0, 0);
            btnNV.Size = new Size(233, 40);
            btnNV.TabIndex = 9;
            btnNV.Text = "Nhân viên";
            btnNV.TextAlign = ContentAlignment.MiddleLeft;
            btnNV.UseVisualStyleBackColor = false;
            btnNV.Click += btnNV_Click;
            // 
            // btnKH
            // 
            btnKH.BackColor = Color.FromArgb(35, 32, 39);
            btnKH.Dock = DockStyle.Top;
            btnKH.FlatAppearance.BorderSize = 0;
            btnKH.FlatStyle = FlatStyle.Flat;
            btnKH.Font = new Font("Segoe UI", 9.75F);
            btnKH.ForeColor = Color.LightGray;
            btnKH.Location = new Point(0, 120);
            btnKH.Name = "btnKH";
            btnKH.Padding = new Padding(35, 0, 0, 0);
            btnKH.Size = new Size(233, 40);
            btnKH.TabIndex = 8;
            btnKH.Text = "Khách hàng";
            btnKH.TextAlign = ContentAlignment.MiddleLeft;
            btnKH.UseVisualStyleBackColor = false;
            btnKH.Click += btnKH_Click;
            // 
            // btnHSX
            // 
            btnHSX.BackColor = Color.FromArgb(35, 32, 39);
            btnHSX.Dock = DockStyle.Top;
            btnHSX.FlatAppearance.BorderSize = 0;
            btnHSX.FlatStyle = FlatStyle.Flat;
            btnHSX.Font = new Font("Segoe UI", 9.75F);
            btnHSX.ForeColor = Color.LightGray;
            btnHSX.Location = new Point(0, 80);
            btnHSX.Name = "btnHSX";
            btnHSX.Padding = new Padding(35, 0, 0, 0);
            btnHSX.Size = new Size(233, 40);
            btnHSX.TabIndex = 7;
            btnHSX.Text = "Hãng sản  xuất";
            btnHSX.TextAlign = ContentAlignment.MiddleLeft;
            btnHSX.UseVisualStyleBackColor = false;
            btnHSX.Click += btnHSX_Click;
            // 
            // btnLoaiBP
            // 
            btnLoaiBP.BackColor = Color.FromArgb(35, 32, 39);
            btnLoaiBP.Dock = DockStyle.Top;
            btnLoaiBP.FlatAppearance.BorderSize = 0;
            btnLoaiBP.FlatStyle = FlatStyle.Flat;
            btnLoaiBP.Font = new Font("Segoe UI", 9.75F);
            btnLoaiBP.ForeColor = Color.LightGray;
            btnLoaiBP.Location = new Point(0, 40);
            btnLoaiBP.Name = "btnLoaiBP";
            btnLoaiBP.Padding = new Padding(35, 0, 0, 0);
            btnLoaiBP.Size = new Size(233, 40);
            btnLoaiBP.TabIndex = 6;
            btnLoaiBP.Text = "Loại bàn phím";
            btnLoaiBP.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiBP.UseVisualStyleBackColor = false;
            btnLoaiBP.Click += btnLoaiBP_Click;
            // 
            // btnBanPhim
            // 
            btnBanPhim.BackColor = Color.FromArgb(35, 32, 39);
            btnBanPhim.Dock = DockStyle.Top;
            btnBanPhim.FlatAppearance.BorderSize = 0;
            btnBanPhim.FlatStyle = FlatStyle.Flat;
            btnBanPhim.Font = new Font("Segoe UI", 9.75F);
            btnBanPhim.ForeColor = Color.LightGray;
            btnBanPhim.Location = new Point(0, 0);
            btnBanPhim.Name = "btnBanPhim";
            btnBanPhim.Padding = new Padding(35, 0, 0, 0);
            btnBanPhim.Size = new Size(233, 40);
            btnBanPhim.TabIndex = 5;
            btnBanPhim.Text = "Bàn phím";
            btnBanPhim.TextAlign = ContentAlignment.MiddleLeft;
            btnBanPhim.UseVisualStyleBackColor = false;
            btnBanPhim.Click += btnBanPhim_Click;
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackColor = Color.Transparent;
            btnQuanLy.Dock = DockStyle.Top;
            btnQuanLy.FlatAppearance.BorderSize = 0;
            btnQuanLy.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 16, 199);
            btnQuanLy.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 13, 163);
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnQuanLy.ForeColor = Color.FromArgb(128, 128, 255);
            btnQuanLy.Location = new Point(0, 359);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Padding = new Padding(10, 0, 0, 0);
            helpProvider.SetShowHelp(btnQuanLy, true);
            btnQuanLy.Size = new Size(233, 45);
            btnQuanLy.TabIndex = 3;
            btnQuanLy.Text = "Quản  lý";
            btnQuanLy.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // panelSubHeThong
            // 
            panelSubHeThong.BackColor = Color.FromArgb(35, 32, 39);
            panelSubHeThong.Controls.Add(btnThoat);
            panelSubHeThong.Controls.Add(btnLichSu);
            panelSubHeThong.Controls.Add(btnDangXuat);
            panelSubHeThong.Controls.Add(btnDangNhap);
            panelSubHeThong.Dock = DockStyle.Top;
            panelSubHeThong.Location = new Point(0, 230);
            panelSubHeThong.Name = "panelSubHeThong";
            panelSubHeThong.Size = new Size(233, 129);
            panelSubHeThong.TabIndex = 2;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(35, 32, 39);
            btnThoat.Dock = DockStyle.Top;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9.75F);
            btnThoat.ForeColor = Color.LightGray;
            btnThoat.Location = new Point(0, 120);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(35, 0, 0, 0);
            btnThoat.Size = new Size(233, 40);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click_Menu;
            // 
            // btnLichSu
            // 
            btnLichSu.BackColor = Color.FromArgb(35, 32, 39);
            btnLichSu.Dock = DockStyle.Top;
            btnLichSu.FlatAppearance.BorderSize = 0;
            btnLichSu.FlatStyle = FlatStyle.Flat;
            btnLichSu.Font = new Font("Segoe UI", 9.75F);
            btnLichSu.ForeColor = Color.LightGray;
            btnLichSu.Location = new Point(0, 80);
            btnLichSu.Name = "btnLichSu";
            btnLichSu.Padding = new Padding(35, 0, 0, 0);
            btnLichSu.Size = new Size(233, 40);
            btnLichSu.TabIndex = 3;
            btnLichSu.Text = "Lịch sử hoạt động";
            btnLichSu.TextAlign = ContentAlignment.MiddleLeft;
            btnLichSu.UseVisualStyleBackColor = false;
            btnLichSu.Click += btnLichSu_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(35, 32, 39);
            btnDangXuat.Dock = DockStyle.Top;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 9.75F);
            btnDangXuat.ForeColor = Color.LightGray;
            btnDangXuat.Location = new Point(0, 40);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(35, 0, 0, 0);
            btnDangXuat.Size = new Size(233, 40);
            btnDangXuat.TabIndex = 1;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(35, 32, 39);
            btnDangNhap.Dock = DockStyle.Top;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 9.75F);
            btnDangNhap.ForeColor = Color.LightGray;
            btnDangNhap.Location = new Point(0, 0);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Padding = new Padding(35, 0, 0, 0);
            btnDangNhap.Size = new Size(233, 40);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click_Menu;
            // 
            // btnHeThong
            // 
            btnHeThong.BackColor = Color.Transparent;
            btnHeThong.Dock = DockStyle.Top;
            btnHeThong.FlatAppearance.BorderSize = 0;
            btnHeThong.FlatAppearance.MouseDownBackColor = Color.FromArgb(93, 16, 199);
            btnHeThong.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 13, 163);
            btnHeThong.FlatStyle = FlatStyle.Flat;
            btnHeThong.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHeThong.ForeColor = Color.FromArgb(128, 128, 255);
            btnHeThong.Location = new Point(0, 185);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Padding = new Padding(10, 0, 0, 0);
            helpProvider.SetShowHelp(btnHeThong, true);
            btnHeThong.Size = new Size(233, 45);
            btnHeThong.TabIndex = 1;
            btnHeThong.Text = "Hệ thống";
            btnHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnHeThong.UseVisualStyleBackColor = false;
            btnHeThong.Click += btnHeThong_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 185);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelParent
            // 
            panelParent.BackColor = Color.FromArgb(32, 30, 45);
            panelParent.Dock = DockStyle.Fill;
            panelParent.Location = new Point(250, 56);
            panelParent.Name = "panelParent";
            panelParent.Size = new Size(702, 684);
            panelParent.TabIndex = 1;
            // 
            // panelTittleBar
            // 
            panelTittleBar.BackColor = Color.Black;
            panelTittleBar.Controls.Add(lblTrangThaiOrTen);
            panelTittleBar.Controls.Add(btnMinimize);
            panelTittleBar.Controls.Add(btnClose);
            panelTittleBar.Dock = DockStyle.Top;
            panelTittleBar.Location = new Point(250, 0);
            panelTittleBar.Name = "panelTittleBar";
            panelTittleBar.Size = new Size(702, 56);
            panelTittleBar.TabIndex = 2;
            // 
            // lblTrangThaiOrTen
            // 
            lblTrangThaiOrTen.AutoSize = true;
            lblTrangThaiOrTen.Dock = DockStyle.Left;
            lblTrangThaiOrTen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangThaiOrTen.ForeColor = Color.Fuchsia;
            lblTrangThaiOrTen.Location = new Point(0, 0);
            lblTrangThaiOrTen.Name = "lblTrangThaiOrTen";
            lblTrangThaiOrTen.Padding = new Padding(15, 15, 0, 0);
            lblTrangThaiOrTen.Size = new Size(151, 36);
            lblTrangThaiOrTen.TabIndex = 3;
            lblTrangThaiOrTen.Text = "Chưa đăng nhập";
            lblTrangThaiOrTen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.icons8_subtract_26;
            btnMinimize.Location = new Point(578, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(53, 29);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.icons8_x_26;
            btnClose.Location = new Point(637, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(53, 29);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // helpProvider
            // 
            helpProvider.HelpNamespace = "https://dth235626-nguyentiendinh.github.io/HuongDanSuDungDoAn/";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 740);
            Controls.Add(panelParent);
            Controls.Add(panelTittleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMain";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            panelMenu.ResumeLayout(false);
            panelSubTroGiup.ResumeLayout(false);
            panelSubBaoCao.ResumeLayout(false);
            panelSubQuanLy.ResumeLayout(false);
            panelSubHeThong.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTittleBar.ResumeLayout(false);
            panelTittleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel panelSubHeThong;
        private Button btnHeThong;
        private Button btnThoat;
        private Button btnLichSu;
        private Button btnDangXuat;
        private Button btnDangNhap;
        private Panel panelSubQuanLy;
        private Button btnQuanLy;
        private Button btnBanPhim;
        private Panel panelSubBaoCao;
        private Button btnTKSP;
        private Button btnBaoCao;
        private Button btnTKDT;
        private Panel panelSubTroGiup;
        private Button btnTTPM;
        private Button btnHDSD;
        private Button btnTroGiup;
        private Button btnHD;
        private Button btnNV;
        private Button btnKH;
        private Button btnHSX;
        private Button btnLoaiBP;
        private PictureBox pictureBox1;
        private Panel panelParent;
        private Panel panelTittleBar;
        private Button btnClose;
        private Button btnMinimize;
        private Label lblTrangThaiOrTen;
        private Button btnBaoHanh;
        private HelpProvider helpProvider;
    }
}