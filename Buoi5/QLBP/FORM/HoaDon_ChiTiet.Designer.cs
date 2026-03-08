namespace QLBP.FORM
{
    partial class frmHoaDon_ChiTiet
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
            txtGhiChu = new TextBox();
            label3 = new Label();
            cboKhachHang = new ComboBox();
            label1 = new Label();
            cboNhanVien = new ComboBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            numSoLuong = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cboTenBanPhim = new ComboBox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            BanPhimID = new DataGridViewTextBoxColumn();
            TenBanPhim = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new Button();
            btnInHoaDon = new Button();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboKhachHang);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboNhanVien);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 135);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách hoá đơn";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 12F);
            txtGhiChu.Location = new Point(165, 81);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(570, 29);
            txtGhiChu.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(27, 81);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 2);
            label3.Size = new Size(132, 23);
            label3.TabIndex = 26;
            label3.Text = "Ghi chú hoá đơn :";
            // 
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(522, 30);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(213, 29);
            cboKhachHang.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(401, 33);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 2);
            label1.Size = new Size(115, 23);
            label1.TabIndex = 24;
            label1.Text = "Khách hàng (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(165, 30);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(213, 29);
            cboNhanVien.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 33);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 2);
            label2.Size = new Size(130, 23);
            label2.TabIndex = 24;
            label2.Text = "Nhân viên lập (*):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnXacNhanBan);
            groupBox3.Controls.Add(numSoLuong);
            groupBox3.Controls.Add(numGiaBan);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(cboTenBanPhim);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(0, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(895, 119);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách hoá đơn";
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(741, 52);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(64, 31);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.FlatStyle = FlatStyle.Flat;
            btnXacNhanBan.Location = new Point(621, 52);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(114, 31);
            btnXacNhanBan.TabIndex = 27;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.UseVisualStyleBackColor = true;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(457, 52);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(142, 29);
            numSoLuong.TabIndex = 26;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numGiaBan
            // 
            numGiaBan.Location = new Point(278, 52);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(142, 29);
            numGiaBan.TabIndex = 26;
            numGiaBan.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(457, 25);
            label6.Name = "label6";
            label6.Padding = new Padding(0, 0, 0, 2);
            label6.Size = new Size(97, 23);
            label6.TabIndex = 24;
            label6.Text = "Số lượng (*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(278, 25);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 2);
            label5.Size = new Size(87, 23);
            label5.TabIndex = 24;
            label5.Text = "Giá bán (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(27, 25);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 0, 0, 2);
            label4.Size = new Size(100, 23);
            label4.TabIndex = 24;
            label4.Text = "Bàn phím (*):";
            // 
            // cboTenBanPhim
            // 
            cboTenBanPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTenBanPhim.FormattingEnabled = true;
            cboTenBanPhim.Location = new Point(27, 51);
            cboTenBanPhim.Name = "cboTenBanPhim";
            cboTenBanPhim.Size = new Size(213, 29);
            cboTenBanPhim.TabIndex = 25;
            cboTenBanPhim.SelectionChangeCommitted += cboTenBanPhim_SelectionChangeCommitted;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 219);
            groupBox2.TabIndex = 8;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { BanPhimID, TenBanPhim, DonGia, SoLuongBan, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(889, 191);
            dataGridView.TabIndex = 1;
            // 
            // BanPhimID
            // 
            BanPhimID.DataPropertyName = "BanPhimID";
            BanPhimID.FillWeight = 30F;
            BanPhimID.HeaderText = "ID";
            BanPhimID.Name = "BanPhimID";
            BanPhimID.ReadOnly = true;
            // 
            // TenBanPhim
            // 
            TenBanPhim.DataPropertyName = "TenBP";
            TenBanPhim.HeaderText = "Tên bàn phím";
            TenBanPhim.Name = "TenBanPhim";
            TenBanPhim.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle1;
            DonGia.HeaderText = "Đơn giá bán";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = null;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.Name = "SoLuongBan";
            SoLuongBan.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.FlatStyle = FlatStyle.Flat;
            btnLuuHoaDon.ForeColor = Color.FromArgb(0, 0, 192);
            btnLuuHoaDon.Location = new Point(239, 479);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(114, 31);
            btnLuuHoaDon.TabIndex = 28;
            btnLuuHoaDon.Text = "Lưu hoá đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Location = new Point(378, 479);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(114, 31);
            btnInHoaDon.TabIndex = 29;
            btnInHoaDon.Text = "In hoá đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(510, 479);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(114, 31);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 540);
            Controls.Add(btnThoat);
            Controls.Add(btnInHoaDon);
            Controls.Add(btnLuuHoaDon);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoá đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ComboBox cboKhachHang;
        private Label label1;
        private ComboBox cboNhanVien;
        private Label label2;
        private NumericUpDown numGiaBan;
        private TextBox txtGhiChu;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboTenBanPhim;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private NumericUpDown numSoLuong;
        private Label label6;
        private Button btnLuuHoaDon;
        private Button btnInHoaDon;
        private Button btnThoat;
        private DataGridViewTextBoxColumn BanPhimID;
        private DataGridViewTextBoxColumn TenBanPhim;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}