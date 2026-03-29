namespace QLBP.FORM
{
    partial class frmNhanVien
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
            gbNhanVien = new GroupBox();
            cboVaiTro = new QLBP.Controls.CustomCombobox();
            txtMatKhau = new QLBP.Controls.CustomTextbox();
            txtTenDangNhap = new QLBP.Controls.CustomTextbox();
            txtDiaChi = new QLBP.Controls.CustomTextbox();
            txtSDT = new QLBP.Controls.CustomTextbox();
            txtHoVaTen = new QLBP.Controls.CustomTextbox();
            btnXuat = new QLBP.Controls.CustomButon();
            btnHuyBo = new QLBP.Controls.CustomButon();
            btnNhap = new QLBP.Controls.CustomButon();
            btnLuu = new QLBP.Controls.CustomButon();
            btnTimKiem = new QLBP.Controls.CustomButon();
            btnXoa = new QLBP.Controls.CustomButon();
            btnSua = new QLBP.Controls.CustomButon();
            btnThem = new QLBP.Controls.CustomButon();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            VaiTro = new DataGridViewTextBoxColumn();
            gbNhanVien.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // gbNhanVien
            // 
            gbNhanVien.Controls.Add(cboVaiTro);
            gbNhanVien.Controls.Add(txtMatKhau);
            gbNhanVien.Controls.Add(txtTenDangNhap);
            gbNhanVien.Controls.Add(txtDiaChi);
            gbNhanVien.Controls.Add(txtSDT);
            gbNhanVien.Controls.Add(txtHoVaTen);
            gbNhanVien.Controls.Add(btnXuat);
            gbNhanVien.Controls.Add(btnHuyBo);
            gbNhanVien.Controls.Add(btnNhap);
            gbNhanVien.Controls.Add(btnLuu);
            gbNhanVien.Controls.Add(btnTimKiem);
            gbNhanVien.Controls.Add(btnXoa);
            gbNhanVien.Controls.Add(btnSua);
            gbNhanVien.Controls.Add(btnThem);
            gbNhanVien.Controls.Add(label7);
            gbNhanVien.Controls.Add(label6);
            gbNhanVien.Controls.Add(label3);
            gbNhanVien.Controls.Add(label4);
            gbNhanVien.Controls.Add(label5);
            gbNhanVien.Controls.Add(label2);
            gbNhanVien.Dock = DockStyle.Top;
            gbNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbNhanVien.ForeColor = Color.FromArgb(255, 128, 255);
            gbNhanVien.Location = new Point(0, 0);
            gbNhanVien.Name = "gbNhanVien";
            gbNhanVien.Size = new Size(988, 201);
            gbNhanVien.TabIndex = 1;
            gbNhanVien.TabStop = false;
            gbNhanVien.Text = "Thông tin nhân viên";
            // 
            // cboVaiTro
            // 
            cboVaiTro.BackColor = Color.FromArgb(32, 30, 45);
            cboVaiTro.BorderColor = Color.MediumSlateBlue;
            cboVaiTro.BorderSize = 2;
            cboVaiTro.DisplayMember = "";
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDown;
            cboVaiTro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cboVaiTro.ForeColor = Color.White;
            cboVaiTro.IconColor = Color.Fuchsia;
            cboVaiTro.IsReadOnly = false;
            cboVaiTro.Items.AddRange(new object[] { "Quản lý", "NV Bán hàng", "NV Bảo hành" });
            cboVaiTro.ListBackColor = Color.FromArgb(128, 128, 255);
            cboVaiTro.ListTextColor = Color.White;
            cboVaiTro.Location = new Point(477, 122);
            cboVaiTro.MinimumSize = new Size(200, 30);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Padding = new Padding(2);
            cboVaiTro.SelectedValue = null;
            cboVaiTro.Size = new Size(213, 30);
            cboVaiTro.TabIndex = 48;
            cboVaiTro.ValueMember = "";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.FromArgb(32, 30, 45);
            txtMatKhau.BorderColor = Color.MediumSlateBlue;
            txtMatKhau.BorderSize = 2;
            txtMatKhau.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMatKhau.ForeColor = Color.White;
            txtMatKhau.Location = new Point(477, 83);
            txtMatKhau.Margin = new Padding(4);
            txtMatKhau.Multiline = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Padding = new Padding(7);
            txtMatKhau.PassWordChar = false;
            txtMatKhau.Size = new Size(213, 32);
            txtMatKhau.TabIndex = 47;
            txtMatKhau.UnderlinedStyle = false;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.FromArgb(32, 30, 45);
            txtTenDangNhap.BorderColor = Color.MediumSlateBlue;
            txtTenDangNhap.BorderSize = 2;
            txtTenDangNhap.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTenDangNhap.ForeColor = Color.White;
            txtTenDangNhap.Location = new Point(477, 43);
            txtTenDangNhap.Margin = new Padding(4);
            txtTenDangNhap.Multiline = false;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Padding = new Padding(7);
            txtTenDangNhap.PassWordChar = false;
            txtTenDangNhap.Size = new Size(213, 32);
            txtTenDangNhap.TabIndex = 47;
            txtTenDangNhap.UnderlinedStyle = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.FromArgb(32, 30, 45);
            txtDiaChi.BorderColor = Color.MediumSlateBlue;
            txtDiaChi.BorderSize = 2;
            txtDiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiaChi.ForeColor = Color.White;
            txtDiaChi.Location = new Point(119, 160);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Multiline = false;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(7);
            txtDiaChi.PassWordChar = false;
            txtDiaChi.Size = new Size(571, 32);
            txtDiaChi.TabIndex = 47;
            txtDiaChi.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.FromArgb(32, 30, 45);
            txtSDT.BorderColor = Color.MediumSlateBlue;
            txtSDT.BorderSize = 2;
            txtSDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSDT.ForeColor = Color.White;
            txtSDT.Location = new Point(119, 83);
            txtSDT.Margin = new Padding(4);
            txtSDT.Multiline = false;
            txtSDT.Name = "txtSDT";
            txtSDT.Padding = new Padding(7);
            txtSDT.PassWordChar = false;
            txtSDT.Size = new Size(213, 32);
            txtSDT.TabIndex = 47;
            txtSDT.UnderlinedStyle = false;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = Color.FromArgb(32, 30, 45);
            txtHoVaTen.BorderColor = Color.MediumSlateBlue;
            txtHoVaTen.BorderSize = 2;
            txtHoVaTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHoVaTen.ForeColor = Color.White;
            txtHoVaTen.Location = new Point(119, 43);
            txtHoVaTen.Margin = new Padding(4);
            txtHoVaTen.Multiline = false;
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Padding = new Padding(7);
            txtHoVaTen.PassWordChar = false;
            txtHoVaTen.Size = new Size(213, 32);
            txtHoVaTen.TabIndex = 47;
            txtHoVaTen.UnderlinedStyle = false;
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
            btnXuat.Location = new Point(867, 153);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(115, 39);
            btnXuat.TabIndex = 46;
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
            btnHuyBo.Location = new Point(867, 108);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 39);
            btnHuyBo.TabIndex = 45;
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
            btnNhap.Location = new Point(746, 153);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 39);
            btnNhap.TabIndex = 44;
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
            btnLuu.Location = new Point(746, 109);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(115, 39);
            btnLuu.TabIndex = 43;
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
            btnTimKiem.Location = new Point(867, 64);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 39);
            btnTimKiem.TabIndex = 42;
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
            btnXoa.Location = new Point(746, 64);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 41;
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
            btnSua.Location = new Point(867, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 40;
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
            btnThem.Location = new Point(746, 24);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 39);
            btnThem.TabIndex = 39;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.FromArgb(0, 192, 0);
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(339, 40);
            label7.Name = "label7";
            label7.Padding = new Padding(0, 0, 0, 2);
            label7.Size = new Size(135, 23);
            label7.TabIndex = 2;
            label7.Text = "Tên đăng nhập (*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(339, 120);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 2);
            label6.Size = new Size(110, 23);
            label6.TabIndex = 3;
            label6.Text = "Vai trò (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 160);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 2);
            label3.Size = new Size(81, 23);
            label3.TabIndex = 3;
            label3.Text = "Địa chỉ (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(339, 80);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 2);
            label4.Size = new Size(99, 23);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(7, 43);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 2);
            label5.Size = new Size(81, 23);
            label5.TabIndex = 3;
            label5.Text = "Họ Tên (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 83);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 2);
            label2.Size = new Size(105, 23);
            label2.TabIndex = 3;
            label2.Text = "Điện thoại (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox2.Location = new Point(0, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 220);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(73, 72, 82);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(116, 41, 145);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, VaiTro });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(982, 192);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ tên nhân viên";
            HoVaTen.MinimumWidth = 8;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            // 
            // DienThoai
            // 
            DienThoai.DataPropertyName = "DienThoai";
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 8;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 8;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.MinimumWidth = 8;
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // VaiTro
            // 
            VaiTro.DataPropertyName = "VaiTro";
            VaiTro.FillWeight = 60F;
            VaiTro.HeaderText = "Vai trò";
            VaiTro.MinimumWidth = 8;
            VaiTro.Name = "VaiTro";
            VaiTro.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(988, 421);
            Controls.Add(groupBox2);
            Controls.Add(gbNhanVien);
            Margin = new Padding(2);
            Name = "frmNhanVien";
            Text = "Nhân viên";
            Load += frmNhanVien_Load;
            gbNhanVien.ResumeLayout(false);
            gbNhanVien.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbNhanVien;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn VaiTro;
        private Controls.CustomButon btnXuat;
        private Controls.CustomButon btnHuyBo;
        private Controls.CustomButon btnNhap;
        private Controls.CustomButon btnLuu;
        private Controls.CustomButon btnTimKiem;
        private Controls.CustomButon btnXoa;
        private Controls.CustomButon btnSua;
        private Controls.CustomButon btnThem;
        private Controls.CustomTextbox txtSDT;
        private Controls.CustomTextbox txtHoVaTen;
        private Controls.CustomTextbox txtMatKhau;
        private Controls.CustomTextbox txtTenDangNhap;
        private Controls.CustomTextbox txtDiaChi;
        private Controls.CustomCombobox cboVaiTro;
    }
}