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
            groupBox1 = new GroupBox();
            numSoLuong = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            picHinhAnh = new PictureBox();
            btnLuu = new Button();
            btnNhap = new Button();
            btnXoa = new Button();
            btnDoiAnh = new Button();
            btnXuat = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnTimKiem = new Button();
            btnThem = new Button();
            cboHSX = new ComboBox();
            cboLoaiPhim = new ComboBox();
            txtLoaiSwitch = new TextBox();
            txtTen = new TextBox();
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
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(numGiaBan);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnNhap);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnDoiAnh);
            groupBox1.Controls.Add(btnXuat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cboHSX);
            groupBox1.Controls.Add(cboLoaiPhim);
            groupBox1.Controls.Add(txtLoaiSwitch);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1024, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bàn phím";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(525, 112);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(213, 29);
            numSoLuong.TabIndex = 22;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numGiaBan
            // 
            numGiaBan.Location = new Point(525, 66);
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
            // btnLuu
            // 
            btnLuu.Location = new Point(497, 174);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 39);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(733, 174);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(115, 39);
            btnNhap.TabIndex = 14;
            btnNhap.Text = "Nhập...";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(258, 174);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDoiAnh.Location = new Point(897, 28);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(78, 27);
            btnDoiAnh.TabIndex = 16;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(854, 174);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(112, 39);
            btnXuat.TabIndex = 16;
            btnXuat.Text = "Xuất...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(615, 174);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(112, 39);
            btnHuyBo.TabIndex = 17;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(137, 174);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 18;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(379, 174);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 39);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(16, 174);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 39);
            btnThem.TabIndex = 20;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // cboHSX
            // 
            cboHSX.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHSX.FormattingEnabled = true;
            cboHSX.Location = new Point(525, 26);
            cboHSX.Name = "cboHSX";
            cboHSX.Size = new Size(213, 29);
            cboHSX.TabIndex = 2;
            // 
            // cboLoaiPhim
            // 
            cboLoaiPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhim.FormattingEnabled = true;
            cboLoaiPhim.Location = new Point(165, 72);
            cboLoaiPhim.Name = "cboLoaiPhim";
            cboLoaiPhim.Size = new Size(213, 29);
            cboLoaiPhim.TabIndex = 2;
            // 
            // txtLoaiSwitch
            // 
            txtLoaiSwitch.Font = new Font("Segoe UI", 12F);
            txtLoaiSwitch.Location = new Point(165, 112);
            txtLoaiSwitch.Name = "txtLoaiSwitch";
            txtLoaiSwitch.Size = new Size(213, 29);
            txtLoaiSwitch.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F);
            txtTen.Location = new Point(165, 32);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(213, 29);
            txtTen.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
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
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenBanPhim, LoaiBanPhim, LoaiSwitch, HangSanXuat, SoLuong, DonGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
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
        private TextBox txtTen;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ComboBox cboHSX;
        private ComboBox cboLoaiPhim;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnLuu;
        private Button btnNhap;
        private Button btnXoa;
        private Button btnXuat;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private PictureBox picHinhAnh;
        private Button btnDoiAnh;
        private NumericUpDown numSoLuong;
        private NumericUpDown numGiaBan;
        private TextBox txtLoaiSwitch;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenBanPhim;
        private DataGridViewTextBoxColumn LoaiBanPhim;
        private DataGridViewTextBoxColumn LoaiSwitch;
        private DataGridViewTextBoxColumn HangSanXuat;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewImageColumn HinhAnh;
    }
}