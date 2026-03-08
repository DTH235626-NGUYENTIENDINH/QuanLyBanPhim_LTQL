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
            gbNhanVien = new GroupBox();
            btnLuu = new Button();
            btnNhap = new Button();
            btnXoa = new Button();
            btnXuat = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            cboQuyenHan = new ComboBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtHoVaTen = new TextBox();
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
            QuyenHan = new DataGridViewTextBoxColumn();
            gbNhanVien.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // gbNhanVien
            // 
            gbNhanVien.Controls.Add(btnLuu);
            gbNhanVien.Controls.Add(btnNhap);
            gbNhanVien.Controls.Add(btnXoa);
            gbNhanVien.Controls.Add(btnXuat);
            gbNhanVien.Controls.Add(btnHuyBo);
            gbNhanVien.Controls.Add(btnSua);
            gbNhanVien.Controls.Add(btnTimKiem);
            gbNhanVien.Controls.Add(btnThem);
            gbNhanVien.Controls.Add(cboQuyenHan);
            gbNhanVien.Controls.Add(txtDiaChi);
            gbNhanVien.Controls.Add(txtSDT);
            gbNhanVien.Controls.Add(txtMatKhau);
            gbNhanVien.Controls.Add(txtTenDangNhap);
            gbNhanVien.Controls.Add(txtHoVaTen);
            gbNhanVien.Controls.Add(label7);
            gbNhanVien.Controls.Add(label6);
            gbNhanVien.Controls.Add(label3);
            gbNhanVien.Controls.Add(label4);
            gbNhanVien.Controls.Add(label5);
            gbNhanVien.Controls.Add(label2);
            gbNhanVien.Dock = DockStyle.Top;
            gbNhanVien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbNhanVien.Location = new Point(0, 0);
            gbNhanVien.Name = "gbNhanVien";
            gbNhanVien.Size = new Size(988, 201);
            gbNhanVien.TabIndex = 1;
            gbNhanVien.TabStop = false;
            gbNhanVien.Text = "Thông tin nhân viên";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(224, 224, 224);
            btnLuu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(860, 66);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 39);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnNhap
            // 
            btnNhap.BackColor = Color.FromArgb(224, 224, 224);
            btnNhap.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnNhap.FlatStyle = FlatStyle.Flat;
            btnNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNhap.ForeColor = Color.Blue;
            btnNhap.Location = new Point(739, 155);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 39);
            btnNhap.TabIndex = 8;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = false;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(224, 224, 224);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXoa.ForeColor = Color.FromArgb(192, 0, 0);
            btnXoa.Location = new Point(739, 110);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.FromArgb(224, 224, 224);
            btnXuat.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(860, 155);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 39);
            btnXuat.TabIndex = 9;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(224, 224, 224);
            btnHuyBo.FlatAppearance.MouseOverBackColor = Color.White;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHuyBo.ForeColor = Color.FromArgb(64, 64, 64);
            btnHuyBo.Location = new Point(860, 110);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 39);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(224, 224, 224);
            btnSua.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 192);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(192, 192, 0);
            btnSua.Location = new Point(739, 65);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(224, 224, 224);
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 224, 192);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.Location = new Point(860, 20);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 39);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(224, 224, 224);
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThem.ForeColor = Color.FromArgb(0, 64, 0);
            btnThem.Location = new Point(739, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 39);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboQuyenHan
            // 
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cboQuyenHan.Location = new Point(477, 119);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(213, 29);
            cboQuyenHan.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(119, 153);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(571, 29);
            txtDiaChi.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(119, 76);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(213, 29);
            txtSDT.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 12F);
            txtMatKhau.Location = new Point(477, 76);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(213, 29);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 12F);
            txtTenDangNhap.Location = new Point(477, 36);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(213, 29);
            txtTenDangNhap.TabIndex = 5;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Segoe UI", 12F);
            txtHoVaTen.Location = new Point(119, 36);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(213, 29);
            txtHoVaTen.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
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
            label6.Location = new Point(339, 120);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 2);
            label6.Size = new Size(110, 23);
            label6.TabIndex = 3;
            label6.Text = "Quyền hạn (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
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
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi, TenDangNhap, QuyenHan });
            dataGridView.Dock = DockStyle.Fill;
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
            // QuyenHan
            // 
            QuyenHan.DataPropertyName = "QuyenHan";
            QuyenHan.FillWeight = 60F;
            QuyenHan.HeaderText = "Quyền hạn";
            QuyenHan.MinimumWidth = 8;
            QuyenHan.Name = "QuyenHan";
            QuyenHan.ReadOnly = true;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private ComboBox cboQuyenHan;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Button btnNhap;
        private Button btnXuat;
        private TextBox txtHoVaTen;
        private Label label5;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn QuyenHan;
    }
}