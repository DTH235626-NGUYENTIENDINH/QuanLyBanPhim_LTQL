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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
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
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label14);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1004, 207);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.FromArgb(32, 30, 45);
            txtDiaChi.BorderColor = Color.MediumSlateBlue;
            txtDiaChi.BorderSize = 2;
            txtDiaChi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtDiaChi.ForeColor = Color.White;
            txtDiaChi.Location = new Point(136, 109);
            txtDiaChi.Margin = new Padding(4);
            txtDiaChi.Multiline = false;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Padding = new Padding(7);
            txtDiaChi.PassWordChar = false;
            txtDiaChi.Size = new Size(602, 32);
            txtDiaChi.TabIndex = 39;
            txtDiaChi.UnderlinedStyle = false;
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.FromArgb(32, 30, 45);
            txtSDT.BorderColor = Color.MediumSlateBlue;
            txtSDT.BorderSize = 2;
            txtSDT.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtSDT.ForeColor = Color.White;
            txtSDT.Location = new Point(136, 69);
            txtSDT.Margin = new Padding(4);
            txtSDT.Multiline = false;
            txtSDT.Name = "txtSDT";
            txtSDT.Padding = new Padding(7);
            txtSDT.PassWordChar = false;
            txtSDT.Size = new Size(602, 32);
            txtSDT.TabIndex = 39;
            txtSDT.UnderlinedStyle = false;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BackColor = Color.FromArgb(32, 30, 45);
            txtHoVaTen.BorderColor = Color.MediumSlateBlue;
            txtHoVaTen.BorderSize = 2;
            txtHoVaTen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtHoVaTen.ForeColor = Color.White;
            txtHoVaTen.Location = new Point(136, 29);
            txtHoVaTen.Margin = new Padding(4);
            txtHoVaTen.Multiline = false;
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Padding = new Padding(7);
            txtHoVaTen.PassWordChar = false;
            txtHoVaTen.Size = new Size(602, 32);
            txtHoVaTen.TabIndex = 39;
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
            btnXuat.Location = new Point(877, 148);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(115, 39);
            btnXuat.TabIndex = 38;
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
            btnHuyBo.Location = new Point(877, 103);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(115, 39);
            btnHuyBo.TabIndex = 37;
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
            btnNhap.Location = new Point(756, 148);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 39);
            btnNhap.TabIndex = 36;
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
            btnLuu.Location = new Point(756, 104);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(115, 39);
            btnLuu.TabIndex = 35;
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
            btnTimKiem.Location = new Point(877, 59);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 39);
            btnTimKiem.TabIndex = 34;
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
            btnXoa.Location = new Point(756, 59);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 33;
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
            btnSua.Location = new Point(877, 19);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 32;
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
            btnThem.Location = new Point(756, 19);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 39);
            btnThem.TabIndex = 31;
            btnThem.Text = "Thêm";
            btnThem.TextColor = Color.FromArgb(0, 192, 0);
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.White;
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
            label13.ForeColor = Color.White;
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
            label14.ForeColor = Color.White;
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
            groupBox3.ForeColor = Color.FromArgb(255, 128, 255);
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
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
            BackColor = Color.FromArgb(32, 30, 45);
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
        private Label label11;
        private Label label13;
        private Label label14;
        private GroupBox groupBox3;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private Controls.CustomButon btnXuat;
        private Controls.CustomButon btnHuyBo;
        private Controls.CustomButon btnNhap;
        private Controls.CustomButon btnLuu;
        private Controls.CustomButon btnTimKiem;
        private Controls.CustomButon btnXoa;
        private Controls.CustomButon btnSua;
        private Controls.CustomButon btnThem;
        private Controls.CustomTextbox txtDiaChi;
        private Controls.CustomTextbox txtSDT;
        private Controls.CustomTextbox txtHoVaTen;
    }
}