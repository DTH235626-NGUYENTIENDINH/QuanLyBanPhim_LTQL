namespace QLBP.FORM
{
    partial class frmHoaDon_ChiTiet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle cs1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cs2 = new DataGridViewCellStyle();
            DataGridViewCellStyle cs3 = new DataGridViewCellStyle();

            groupBox1 = new GroupBox();
            txtGhiChu = new QLBP.Controls.CustomTextbox();
            label3 = new Label();
            cboKhachHang = new QLBP.Controls.CustomCombobox();
            label1 = new Label();
            cboNhanVien = new QLBP.Controls.CustomCombobox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnXoa = new QLBP.Controls.CustomButon();
            btnXacNhanBan = new QLBP.Controls.CustomButon();
            numSoLuong = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cboTenBanPhim = new QLBP.Controls.CustomCombobox();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            BanPhimID = new DataGridViewTextBoxColumn();
            TenBanPhim = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            btnLuuHoaDon = new QLBP.Controls.CustomButon();
            btnInHoaDon = new QLBP.Controls.CustomButon();
            btnThoat = new QLBP.Controls.CustomButon();

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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(895, 135);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hoá đơn";

            // 
            // txtGhiChu
            // 
            txtGhiChu.BackColor = Color.FromArgb(32, 30, 45);
            txtGhiChu.BorderColor = Color.MediumSlateBlue;
            txtGhiChu.BorderSize = 2;
            txtGhiChu.Font = new Font("Segoe UI", 12F);
            txtGhiChu.ForeColor = Color.White;
            txtGhiChu.Location = new Point(165, 81);
            txtGhiChu.Multiline = false;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Padding = new Padding(7);
            txtGhiChu.PassWordChar = false;
            txtGhiChu.Size = new Size(570, 36);
            txtGhiChu.TabIndex = 27;
            txtGhiChu.UnderlinedStyle = false;

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 88);
            label3.Name = "label3";
            label3.Size = new Size(132, 21);
            label3.TabIndex = 26;
            label3.Text = "Ghi chú hoá đơn :";

            // 
            // cboKhachHang
            // 
            cboKhachHang.BackColor = Color.FromArgb(32, 30, 45);
            cboKhachHang.BorderColor = Color.MediumSlateBlue;
            cboKhachHang.BorderSize = 2;
            cboKhachHang.Font = new Font("Segoe UI", 11F);
            cboKhachHang.ForeColor = Color.White;
            cboKhachHang.IconColor = Color.Fuchsia;
            cboKhachHang.ListBackColor = Color.FromArgb(128, 128, 255);
            cboKhachHang.ListTextColor = Color.White;
            cboKhachHang.Location = new Point(522, 30);
            cboKhachHang.MinimumSize = new Size(200, 30);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Padding = new Padding(2);
            cboKhachHang.Size = new Size(213, 34);
            cboKhachHang.TabIndex = 25;

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(401, 37);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 24;
            label1.Text = "Khách hàng (*):";

            // 
            // cboNhanVien
            // 
            cboNhanVien.BackColor = Color.FromArgb(32, 30, 45);
            cboNhanVien.BorderColor = Color.MediumSlateBlue;
            cboNhanVien.BorderSize = 2;
            cboNhanVien.Font = new Font("Segoe UI", 11F);
            cboNhanVien.ForeColor = Color.White;
            cboNhanVien.IconColor = Color.Fuchsia;
            cboNhanVien.ListBackColor = Color.FromArgb(128, 128, 255);
            cboNhanVien.ListTextColor = Color.White;
            cboNhanVien.Location = new Point(165, 30);
            cboNhanVien.MinimumSize = new Size(200, 30);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Padding = new Padding(2);
            cboNhanVien.Size = new Size(213, 34);
            cboNhanVien.TabIndex = 25;

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 37);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
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
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox3.Location = new Point(0, 135);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(895, 119);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm sản phẩm";

            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BackgroundColor = Color.Transparent;
            btnXoa.BorderColor = Color.Red;
            btnXoa.BorderRadius = 15;
            btnXoa.BorderSize = 2;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(781, 45);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(84, 40);
            btnXoa.TabIndex = 27;
            btnXoa.Text = "Xoá";
            btnXoa.TextColor = Color.Red;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;

            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.BackColor = Color.Transparent;
            btnXacNhanBan.BackgroundColor = Color.Transparent;
            btnXacNhanBan.BorderColor = Color.FromArgb(0, 192, 0);
            btnXacNhanBan.BorderRadius = 15;
            btnXacNhanBan.BorderSize = 2;
            btnXacNhanBan.FlatAppearance.BorderSize = 0;
            btnXacNhanBan.FlatStyle = FlatStyle.Flat;
            btnXacNhanBan.ForeColor = Color.FromArgb(0, 192, 0);
            btnXacNhanBan.Location = new Point(621, 45);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(144, 40);
            btnXacNhanBan.TabIndex = 27;
            btnXacNhanBan.Text = "Xác nhận bán";
            btnXacNhanBan.TextColor = Color.FromArgb(0, 192, 0);
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;

            // 
            // numSoLuong
            // 
            numSoLuong.BackColor = Color.FromArgb(32, 30, 45);
            numSoLuong.ForeColor = Color.White;
            numSoLuong.Location = new Point(457, 52);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(142, 29);
            numSoLuong.TabIndex = 26;
            numSoLuong.ThousandsSeparator = true;

            // 
            // numGiaBan
            // 
            numGiaBan.BackColor = Color.FromArgb(32, 30, 45);
            numGiaBan.ForeColor = Color.White;
            numGiaBan.Location = new Point(278, 52);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.ReadOnly = true;
            numGiaBan.Size = new Size(142, 29);
            numGiaBan.TabIndex = 26;
            numGiaBan.ThousandsSeparator = true;

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(457, 25);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 24;
            label6.Text = "Số lượng (*):";

            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(278, 25);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 24;
            label5.Text = "Giá bán (*):";

            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 25);
            label4.Name = "label4";
            label4.Size = new Size(100, 21);
            label4.TabIndex = 24;
            label4.Text = "Bàn phím (*):";

            // 
            // cboTenBanPhim
            // 
            cboTenBanPhim.BackColor = Color.FromArgb(32, 30, 45);
            cboTenBanPhim.BorderColor = Color.MediumSlateBlue;
            cboTenBanPhim.BorderSize = 2;
            cboTenBanPhim.Font = new Font("Segoe UI", 11F);
            cboTenBanPhim.ForeColor = Color.White;
            cboTenBanPhim.IconColor = Color.Fuchsia;
            cboTenBanPhim.ListBackColor = Color.FromArgb(128, 128, 255);
            cboTenBanPhim.ListTextColor = Color.White;
            cboTenBanPhim.Location = new Point(27, 49);
            cboTenBanPhim.MinimumSize = new Size(200, 30);
            cboTenBanPhim.Name = "cboTenBanPhim";
            cboTenBanPhim.Padding = new Padding(2);
            cboTenBanPhim.Size = new Size(213, 34);
            cboTenBanPhim.TabIndex = 25;
            cboTenBanPhim.OnSelectedIndexChanged += cboTenBanPhim_SelectionChangeCommitted;

            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox2.Location = new Point(0, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(895, 219);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách bàn phím trong hoá đơn";

            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            
            cs1.BackColor = Color.FromArgb(73, 72, 82);
            cs1.ForeColor = Color.White;
            cs1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridView.AlternatingRowsDefaultCellStyle = cs1;
            
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(56, 52, 79);
            
            cs2.BackColor = Color.FromArgb(116, 41, 145);
            cs2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cs2.ForeColor = Color.White;
            cs2.SelectionBackColor = SystemColors.Highlight;
            cs2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = cs2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { BanPhimID, TenBanPhim, DonGia, SoLuongBan, ThanhTien });
            
            cs3.BackColor = Color.FromArgb(56, 52, 79);
            cs3.ForeColor = Color.White;
            cs3.SelectionBackColor = SystemColors.Highlight;
            dataGridView.DefaultCellStyle = cs3;
            
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(3, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(889, 191);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;

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
            dataGridViewCellStyle3.ForeColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;

            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.BackColor = Color.Transparent;
            btnLuuHoaDon.BackgroundColor = Color.Transparent;
            btnLuuHoaDon.BorderColor = Color.DodgerBlue;
            btnLuuHoaDon.BorderRadius = 15;
            btnLuuHoaDon.BorderSize = 2;
            btnLuuHoaDon.FlatAppearance.BorderSize = 0;
            btnLuuHoaDon.FlatStyle = FlatStyle.Flat;
            btnLuuHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLuuHoaDon.ForeColor = Color.DodgerBlue;
            btnLuuHoaDon.Location = new Point(239, 485);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(134, 40);
            btnLuuHoaDon.TabIndex = 28;
            btnLuuHoaDon.Text = "Lưu hoá đơn";
            btnLuuHoaDon.TextColor = Color.DodgerBlue;
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;

            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.Transparent;
            btnInHoaDon.BackgroundColor = Color.Transparent;
            btnInHoaDon.BorderColor = Color.FromArgb(192, 192, 0);
            btnInHoaDon.BorderRadius = 15;
            btnInHoaDon.BorderSize = 2;
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInHoaDon.ForeColor = Color.FromArgb(192, 192, 0);
            btnInHoaDon.Location = new Point(398, 485);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(134, 40);
            btnInHoaDon.TabIndex = 29;
            btnInHoaDon.Text = "In hoá đơn...";
            btnInHoaDon.TextColor = Color.FromArgb(192, 192, 0);
            btnInHoaDon.UseVisualStyleBackColor = false;

            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BackgroundColor = Color.Transparent;
            btnThoat.BorderColor = Color.Red;
            btnThoat.BorderRadius = 15;
            btnThoat.BorderSize = 2;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(557, 485);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(134, 40);
            btnThoat.TabIndex = 30;
            btnThoat.Text = "Thoát";
            btnThoat.TextColor = Color.Red;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;

            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
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
        private QLBP.Controls.CustomCombobox cboKhachHang;
        private Label label1;
        private QLBP.Controls.CustomCombobox cboNhanVien;
        private Label label2;
        private NumericUpDown numGiaBan;
        private QLBP.Controls.CustomTextbox txtGhiChu;
        private Label label3;
        private Label label4;
        private Label label5;
        private QLBP.Controls.CustomCombobox cboTenBanPhim;
        private QLBP.Controls.CustomButon btnXoa;
        private QLBP.Controls.CustomButon btnXacNhanBan;
        private NumericUpDown numSoLuong;
        private Label label6;
        private QLBP.Controls.CustomButon btnLuuHoaDon;
        private QLBP.Controls.CustomButon btnInHoaDon;
        private QLBP.Controls.CustomButon btnThoat;
        private DataGridViewTextBoxColumn BanPhimID;
        private DataGridViewTextBoxColumn TenBanPhim;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}