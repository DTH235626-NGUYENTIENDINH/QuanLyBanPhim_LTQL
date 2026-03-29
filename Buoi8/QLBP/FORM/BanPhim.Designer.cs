namespace QLBP.FORM
{
    partial class frmBanPhim
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            cboHSX = new QLBP.Controls.CustomCombobox();
            cboLoaiPhim = new QLBP.Controls.CustomCombobox();
            txtLoaiSwitch = new QLBP.Controls.CustomTextbox();
            txtTen = new QLBP.Controls.CustomTextbox();
            btnDoiAnh = new QLBP.Controls.CustomButon();
            btnXuat = new QLBP.Controls.CustomButon();
            btnHuyBo = new QLBP.Controls.CustomButon();
            btnNhap = new QLBP.Controls.CustomButon();
            btnLuu = new QLBP.Controls.CustomButon();
            btnTimKiem = new QLBP.Controls.CustomButon();
            btnXoa = new QLBP.Controls.CustomButon();
            btnSua = new QLBP.Controls.CustomButon();
            btnThem = new QLBP.Controls.CustomButon();
            numSoLuong = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            picHinhAnh = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenBanPhim = new DataGridViewTextBoxColumn();
            LoaiBanPhim = new DataGridViewTextBoxColumn();
            LoaiSwitch = new DataGridViewTextBoxColumn();
            HangSanXuat = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboHSX);
            groupBox1.Controls.Add(cboLoaiPhim);
            groupBox1.Controls.Add(txtLoaiSwitch);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(numGiaBan);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1024, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bàn phím";
            // 
            // cboHSX
            // 
            cboHSX.BackColor = Color.FromArgb(32, 30, 45);
            cboHSX.BorderColor = Color.MediumSlateBlue;
            cboHSX.BorderSize = 2;
            cboHSX.DisplayMember = "";
            cboHSX.DropDownStyle = ComboBoxStyle.DropDown;
            cboHSX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboHSX.ForeColor = Color.White;
            cboHSX.IconColor = Color.Fuchsia;
            cboHSX.IsReadOnly = false;
            cboHSX.ListBackColor = Color.FromArgb(128, 128, 255);
            cboHSX.ListTextColor = Color.White;
            cboHSX.Location = new Point(525, 28);
            cboHSX.MinimumSize = new Size(200, 30);
            cboHSX.Name = "cboHSX";
            cboHSX.Padding = new Padding(2);
            cboHSX.SelectedValue = null;
            cboHSX.Size = new Size(213, 33);
            cboHSX.TabIndex = 35;
            cboHSX.ValueMember = "";
            // 
            // cboLoaiPhim
            // 
            cboLoaiPhim.BackColor = Color.FromArgb(32, 30, 45);
            cboLoaiPhim.BorderColor = Color.MediumSlateBlue;
            cboLoaiPhim.BorderSize = 2;
            cboLoaiPhim.DisplayMember = "";
            cboLoaiPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhim.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboLoaiPhim.ForeColor = Color.White;
            cboLoaiPhim.IconColor = Color.Fuchsia;
            cboLoaiPhim.IsReadOnly = false;
            cboLoaiPhim.ListBackColor = Color.FromArgb(128, 128, 255);
            cboLoaiPhim.ListTextColor = Color.White;
            cboLoaiPhim.Location = new Point(165, 72);
            cboLoaiPhim.MinimumSize = new Size(200, 30);
            cboLoaiPhim.Name = "cboLoaiPhim";
            cboLoaiPhim.Padding = new Padding(2);
            cboLoaiPhim.SelectedValue = null;
            cboLoaiPhim.Size = new Size(213, 33);
            cboLoaiPhim.TabIndex = 34;
            cboLoaiPhim.ValueMember = "";
            // 
            // txtLoaiSwitch
            // 
            txtLoaiSwitch.BackColor = Color.FromArgb(32, 30, 45);
            txtLoaiSwitch.BorderColor = Color.MediumSlateBlue;
            txtLoaiSwitch.BorderSize = 2;
            txtLoaiSwitch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtLoaiSwitch.ForeColor = Color.White;
            txtLoaiSwitch.Location = new Point(165, 112);
            txtLoaiSwitch.Margin = new Padding(4);
            txtLoaiSwitch.Multiline = false;
            txtLoaiSwitch.Name = "txtLoaiSwitch";
            txtLoaiSwitch.Padding = new Padding(7);
            txtLoaiSwitch.PassWordChar = false;
            txtLoaiSwitch.RightToLeft = RightToLeft.No;
            txtLoaiSwitch.Size = new Size(213, 32);
            txtLoaiSwitch.TabIndex = 33;
            txtLoaiSwitch.UnderlinedStyle = false;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.FromArgb(32, 30, 45);
            txtTen.BorderColor = Color.MediumSlateBlue;
            txtTen.BorderSize = 2;
            txtTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtTen.ForeColor = Color.White;
            txtTen.Location = new Point(165, 33);
            txtTen.Margin = new Padding(4);
            txtTen.Multiline = false;
            txtTen.Name = "txtTen";
            txtTen.Padding = new Padding(7);
            txtTen.PassWordChar = false;
            txtTen.RightToLeft = RightToLeft.No;
            txtTen.Size = new Size(213, 32);
            txtTen.TabIndex = 32;
            txtTen.UnderlinedStyle = false;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.Transparent;
            btnDoiAnh.BackgroundColor = Color.Transparent;
            btnDoiAnh.BorderColor = Color.FromArgb(128, 128, 255);
            btnDoiAnh.BorderRadius = 10;
            btnDoiAnh.BorderSize = 1;
            btnDoiAnh.FlatAppearance.BorderSize = 0;
            btnDoiAnh.FlatStyle = FlatStyle.Flat;
            btnDoiAnh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDoiAnh.ForeColor = Color.FromArgb(128, 128, 255);
            btnDoiAnh.Location = new Point(900, 26);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(78, 27);
            btnDoiAnh.TabIndex = 31;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.TextColor = Color.FromArgb(128, 128, 255);
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Transparent;
            btnXuat.BackgroundColor = Color.Transparent;
            btnXuat.BorderColor = Color.Green;
            btnXuat.BorderRadius = 20;
            btnXuat.BorderSize = 2;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(863, 174);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(115, 39);
            btnXuat.TabIndex = 30;
            btnXuat.Text = "Xuất";
            btnXuat.TextColor = Color.Green;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Transparent;
            btnHuyBo.BackgroundColor = Color.Transparent;
            btnHuyBo.BorderColor = Color.FromArgb(192, 192, 0);
            btnHuyBo.BorderRadius = 20;
            btnHuyBo.BorderSize = 2;
            btnHuyBo.FlatAppearance.BorderSize = 0;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.ForeColor = Color.FromArgb(192, 192, 0);
            btnHuyBo.Location = new Point(621, 174);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 39);
            btnHuyBo.TabIndex = 29;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.TextColor = Color.FromArgb(192, 192, 0);
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.Transparent;
            btnNhap.BackgroundColor = Color.Transparent;
            btnNhap.BorderColor = Color.RoyalBlue;
            btnNhap.BorderRadius = 20;
            btnNhap.BorderSize = 2;
            btnNhap.FlatAppearance.BorderSize = 0;
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.ForeColor = Color.RoyalBlue;
            btnNhap.Location = new Point(742, 174);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 39);
            btnNhap.TabIndex = 28;
            btnNhap.Text = "Nhập";
            btnNhap.TextColor = Color.RoyalBlue;
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.BackgroundColor = Color.Transparent;
            btnLuu.BorderColor = Color.DodgerBlue;
            btnLuu.BorderRadius = 20;
            btnLuu.BorderSize = 2;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = Color.DodgerBlue;
            btnLuu.Location = new Point(379, 174);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(115, 39);
            btnLuu.TabIndex = 27;
            btnLuu.Text = "Lưu";
            btnLuu.TextColor = Color.DodgerBlue;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.BackgroundColor = Color.Transparent;
            btnTimKiem.BorderColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.BorderRadius = 20;
            btnTimKiem.BorderSize = 2;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.Location = new Point(500, 174);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 39);
            btnTimKiem.TabIndex = 26;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BackgroundColor = Color.Transparent;
            btnXoa.BorderColor = Color.Red;
            btnXoa.BorderRadius = 20;
            btnXoa.BorderSize = 2;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(258, 174);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 25;
            btnXoa.Text = "Xoá";
            btnXoa.TextColor = Color.Red;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.BackgroundColor = Color.Transparent;
            btnSua.BorderColor = Color.FromArgb(192, 192, 0);
            btnSua.BorderRadius = 20;
            btnSua.BorderSize = 2;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.FromArgb(192, 192, 0);
            btnSua.Location = new Point(137, 174);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa";
            btnSua.TextColor = Color.FromArgb(192, 192, 0);
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.BackgroundColor = Color.Transparent;
            btnThem.BorderColor = Color.FromArgb(0, 192, 0);
            btnThem.BorderRadius = 20;
            btnThem.BorderSize = 2;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.FromArgb(0, 192, 0);
            btnThem.Location = new Point(16, 174);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 39);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.FromArgb(0, 192, 0);
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.BackColor = Color.FromArgb(32, 30, 45);
            numSoLuong.ForeColor = Color.White;
            numSoLuong.Location = new Point(525, 112);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(213, 29);
            numSoLuong.TabIndex = 22;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numGiaBan
            // 
            numGiaBan.BackColor = Color.FromArgb(32, 30, 45);
            numGiaBan.ForeColor = Color.White;
            numGiaBan.Location = new Point(525, 72);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(213, 29);
            numGiaBan.TabIndex = 22;
            numGiaBan.ThousandsSeparator = true;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(784, 26);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(107, 115);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 21;
            picHinhAnh.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(389, 112);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 2);
            label7.Size = new Size(97, 23);
            label7.TabIndex = 0;
            label7.Text = "Số lượng (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(389, 72);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 2);
            label6.Size = new Size(87, 23);
            label6.TabIndex = 0;
            label6.Text = "Giá bán (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 118);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 2);
            label4.Size = new Size(111, 23);
            label4.TabIndex = 0;
            label4.Text = "Loại switch (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 78);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 2);
            label3.Size = new Size(133, 23);
            label3.TabIndex = 0;
            label3.Text = "Loại bàn phím (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(389, 32);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 2);
            label2.Size = new Size(132, 23);
            label2.TabIndex = 0;
            label2.Text = "Hãng sản xuất (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 38);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 2);
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn phím (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox2.Location = new Point(0, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1024, 379);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách bàn phím";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 72, 82);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(116, 41, 145);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenBanPhim, LoaiBanPhim, LoaiSwitch, HangSanXuat, SoLuong, DonGia, HinhAnh });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(3, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(1018, 351);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.DataError += dataGridView_DataError;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenBanPhim
            // 
            TenBanPhim.DataPropertyName = "TenBP";
            TenBanPhim.HeaderText = "Tên bàn phím";
            TenBanPhim.Name = "TenBanPhim";
            TenBanPhim.ReadOnly = true;
            // 
            // LoaiBanPhim
            // 
            LoaiBanPhim.DataPropertyName = "TenLoaiBanPhim";
            LoaiBanPhim.HeaderText = "Loại bàn phím";
            LoaiBanPhim.Name = "LoaiBanPhim";
            LoaiBanPhim.ReadOnly = true;
            // 
            // LoaiSwitch
            // 
            LoaiSwitch.DataPropertyName = "LoaiSwitch";
            LoaiSwitch.HeaderText = "Tên loại switch";
            LoaiSwitch.Name = "LoaiSwitch";
            LoaiSwitch.ReadOnly = true;
            // 
            // HangSanXuat
            // 
            HangSanXuat.DataPropertyName = "TenHangSanXuat";
            HangSanXuat.HeaderText = "Hãng sản xuất";
            HangSanXuat.Name = "HangSanXuat";
            HangSanXuat.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.FillWeight = 70F;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "GiaBan";
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // frmBanPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1024, 611);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmBanPhim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bàn Phím";
            Load += frmBanPhim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox picHinhAnh;
        private NumericUpDown numSoLuong;
        private NumericUpDown numGiaBan;
        private Controls.CustomTextbox txtLoaiSwitch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenBanPhim;
        private DataGridViewTextBoxColumn LoaiBanPhim;
        private DataGridViewTextBoxColumn LoaiSwitch;
        private DataGridViewTextBoxColumn HangSanXuat;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
        private Controls.CustomButon btnThem;
        private Controls.CustomButon btnXoa;
        private Controls.CustomButon btnSua;
        private Controls.CustomButon btnXuat;
        private Controls.CustomButon btnHuyBo;
        private Controls.CustomButon btnNhap;
        private Controls.CustomButon btnLuu;
        private Controls.CustomButon btnTimKiem;
        private Controls.CustomButon btnDoiAnh;
        private Controls.CustomTextbox txtTen;
        private Controls.CustomCombobox cboLoaiPhim;
        private Controls.CustomCombobox cboHSX;
    }
}