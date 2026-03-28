namespace QLBP.FORM
{
    partial class frmHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnThoat = new QLBP.Controls.CustomButon();
            btnInHoaDon = new QLBP.Controls.CustomButon();
            btnSua = new QLBP.Controls.CustomButon();
            btnXoa = new QLBP.Controls.CustomButon();
            btnTaoBaoHanh = new QLBP.Controls.CustomButon();
            btnTimKiem = new QLBP.Controls.CustomButon();
            btnXuat = new QLBP.Controls.CustomButon();
            btnLapHoaDonMoi = new QLBP.Controls.CustomButon();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NhanVien = new DataGridViewTextBoxColumn();
            KhachHang = new DataGridViewTextBoxColumn();
            NgayLap = new DataGridViewTextBoxColumn();
            TongTien = new DataGridViewTextBoxColumn();
            GhiChuHoaDon = new DataGridViewTextBoxColumn();
            ChiTiet = new DataGridViewLinkColumn();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTaoBaoHanh);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnLapHoaDonMoi);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 56);
            panel1.TabIndex = 1;
            // 
            // 
            // btnLapHoaDonMoi
            // 
            btnLapHoaDonMoi.BackColor = Color.Transparent;
            btnLapHoaDonMoi.BackgroundColor = Color.Transparent;
            btnLapHoaDonMoi.BorderColor = Color.Lime;
            btnLapHoaDonMoi.BorderRadius = 20;
            btnLapHoaDonMoi.BorderSize = 2;
            btnLapHoaDonMoi.FlatAppearance.BorderSize = 0;
            btnLapHoaDonMoi.FlatStyle = FlatStyle.Flat;
            btnLapHoaDonMoi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLapHoaDonMoi.ForeColor = Color.Lime;
            btnLapHoaDonMoi.Location = new Point(10, 7);
            btnLapHoaDonMoi.Name = "btnLapHoaDonMoi";
            btnLapHoaDonMoi.Size = new Size(118, 38);
            btnLapHoaDonMoi.TabIndex = 24;
            btnLapHoaDonMoi.Text = "Lập hoá đơn mới...";
            btnLapHoaDonMoi.TextColor = Color.Lime;
            btnLapHoaDonMoi.UseVisualStyleBackColor = false;
            btnLapHoaDonMoi.Click += btnLapHoaDonMoi_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.BackColor = Color.Transparent;
            btnInHoaDon.BackgroundColor = Color.Transparent;
            btnInHoaDon.BorderColor = Color.FromArgb(255, 128, 255);
            btnInHoaDon.BorderRadius = 20;
            btnInHoaDon.BorderSize = 2;
            btnInHoaDon.FlatAppearance.BorderSize = 0;
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInHoaDon.ForeColor = Color.FromArgb(255, 128, 255);
            btnInHoaDon.Location = new Point(134, 7);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(118, 38);
            btnInHoaDon.TabIndex = 24;
            btnInHoaDon.Text = "In hoá đơn...";
            btnInHoaDon.TextColor = Color.FromArgb(255, 128, 255);
            btnInHoaDon.UseVisualStyleBackColor = false;
            btnInHoaDon.Click += btnInHoaDon_Click;

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
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.FromArgb(192, 192, 0);
            btnSua.Location = new Point(258, 7);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 38);
            btnSua.TabIndex = 24;
            btnSua.Text = "Sửa...";
            btnSua.TextColor = Color.FromArgb(192, 192, 0);
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(382, 7);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 38);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xoá";
            btnXoa.TextColor = Color.Red;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTaoBaoHanh
            // 
            btnTaoBaoHanh.BackColor = Color.Transparent;
            btnTaoBaoHanh.BackgroundColor = Color.Transparent;
            btnTaoBaoHanh.BorderColor = Color.Cyan;
            btnTaoBaoHanh.BorderRadius = 20;
            btnTaoBaoHanh.BorderSize = 2;
            btnTaoBaoHanh.FlatAppearance.BorderSize = 0;
            btnTaoBaoHanh.FlatStyle = FlatStyle.Flat;
            btnTaoBaoHanh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaoBaoHanh.ForeColor = Color.Cyan;
            btnTaoBaoHanh.Location = new Point(506, 7);
            btnTaoBaoHanh.Name = "btnTaoBaoHanh";
            btnTaoBaoHanh.Size = new Size(130, 38);
            btnTaoBaoHanh.TabIndex = 24;
            btnTaoBaoHanh.Text = "Tạo bảo hành";
            btnTaoBaoHanh.TextColor = Color.Cyan;
            btnTaoBaoHanh.UseVisualStyleBackColor = false;
            btnTaoBaoHanh.Click += btnTaoBaoHanh_Click;
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
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimKiem.ForeColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.Location = new Point(642, 7);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(118, 38);
            btnTimKiem.TabIndex = 24;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.TextColor = Color.FromArgb(255, 128, 0);
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnXuat
            // 
            btnXuat.BackColor = Color.Transparent;
            btnXuat.BackgroundColor = Color.Transparent;
            btnXuat.BorderColor = Color.LawnGreen;
            btnXuat.BorderRadius = 20;
            btnXuat.BorderSize = 2;
            btnXuat.FlatAppearance.BorderSize = 0;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXuat.ForeColor = Color.LawnGreen;
            btnXuat.Location = new Point(766, 7);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(118, 38);
            btnXuat.TabIndex = 24;
            btnXuat.Text = "Xuất excel...";
            btnXuat.TextColor = Color.LawnGreen;
            btnXuat.UseVisualStyleBackColor = false;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BackgroundColor = Color.Transparent;
            btnThoat.BorderColor = Color.FromArgb(224, 224, 224);
            btnThoat.BorderRadius = 20;
            btnThoat.BorderSize = 2;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.FromArgb(224, 224, 224);
            btnThoat.Location = new Point(890, 7);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(118, 38);
            btnThoat.TabIndex = 24;
            btnThoat.Text = "Thoát";
            btnThoat.TextColor = Color.FromArgb(224, 224, 224);
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1050, 396);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hoá đơn";
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, NhanVien, KhachHang, NgayLap, TongTien, GhiChuHoaDon, ChiTiet });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(3, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(1044, 368);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 30F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // NhanVien
            // 
            NhanVien.DataPropertyName = "TenNhanVien";
            NhanVien.HeaderText = "Nhân viên";
            NhanVien.Name = "NhanVien";
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "TenKhachHang";
            KhachHang.HeaderText = "Khách hàng";
            KhachHang.Name = "KhachHang";
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle3;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.Name = "NgayLap";
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 128, 255);
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            TongTien.DefaultCellStyle = dataGridViewCellStyle4;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.Name = "TongTien";
            // 
            // GhiChuHoaDon
            // 
            GhiChuHoaDon.DataPropertyName = "GhiChuHoaDon";
            GhiChuHoaDon.HeaderText = "Ghi chú";
            GhiChuHoaDon.Name = "GhiChuHoaDon";
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle5;
            ChiTiet.HeaderText = "Chi tiểt";
            ChiTiet.LinkColor = Color.FromArgb(255, 128, 255);
            ChiTiet.Name = "ChiTiet";
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(1050, 452);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "frmHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hoá đơn";
            Load += frmHoaDon_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Controls.CustomButon btnLapHoaDonMoi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn GhiChuHoaDon;
        private DataGridViewLinkColumn ChiTiet;
        private Controls.CustomButon btnTaoBaoHanh;
        private Controls.CustomButon btnXoa;
        private Controls.CustomButon btnXuat;
        private Controls.CustomButon btnSua;
        private Controls.CustomButon btnThoat;
        private Controls.CustomButon btnTimKiem;
        private Controls.CustomButon btnInHoaDon;
    }
}