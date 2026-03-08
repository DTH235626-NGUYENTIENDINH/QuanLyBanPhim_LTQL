namespace QLBP.FORM
{
    partial class frmKhachHang
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
            groupBox1 = new GroupBox();
            btnLuu = new Button();
            btnNhap = new Button();
            btnXoa = new Button();
            btnXuat = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHoVaTen = new TextBox();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            groupBox3 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 207);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(224, 224, 224);
            btnLuu.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(870, 70);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 39);
            btnLuu.TabIndex = 13;
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
            btnNhap.Location = new Point(750, 160);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 39);
            btnNhap.TabIndex = 14;
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
            btnXoa.Location = new Point(750, 115);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 15;
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
            btnXuat.Location = new Point(870, 160);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 39);
            btnXuat.TabIndex = 16;
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
            btnHuyBo.Location = new Point(870, 115);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 39);
            btnHuyBo.TabIndex = 17;
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
            btnSua.Location = new Point(750, 70);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 18;
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
            btnTimKiem.Location = new Point(870, 25);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 39);
            btnTimKiem.TabIndex = 19;
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
            btnThem.Location = new Point(750, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 39);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F);
            txtDiaChi.Location = new Point(136, 105);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(559, 29);
            txtDiaChi.TabIndex = 4;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F);
            txtSDT.Location = new Point(136, 65);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(559, 29);
            txtSDT.TabIndex = 4;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Segoe UI", 12F);
            txtHoVaTen.Location = new Point(136, 25);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(559, 29);
            txtHoVaTen.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(13, 112);
            label11.Name = "label11";
            label11.Padding = new Padding(0, 0, 0, 2);
            label11.Size = new Size(81, 23);
            label11.TabIndex = 3;
            label11.Text = "Địa chỉ (*):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(13, 72);
            label13.Name = "label13";
            label13.Padding = new Padding(0, 0, 0, 2);
            label13.Size = new Size(105, 23);
            label13.TabIndex = 3;
            label13.Text = "Điện thoại (*):";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(13, 32);
            label14.Name = "label14";
            label14.Padding = new Padding(0, 0, 0, 2);
            label14.Size = new Size(81, 23);
            label14.TabIndex = 3;
            label14.Text = "Họ Tên (*):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1004, 214);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(998, 186);
            dataGridView.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.HeaderText = "Họ tên khách hàng";
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
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 421);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách Hàng";
            Load += frmKhachHang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtHoVaTen;
        private Label label11;
        private Label label13;
        private Label label14;
        private GroupBox groupBox3;
        private Button btnLuu;
        private Button btnNhap;
        private Button btnXoa;
        private Button btnXuat;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}