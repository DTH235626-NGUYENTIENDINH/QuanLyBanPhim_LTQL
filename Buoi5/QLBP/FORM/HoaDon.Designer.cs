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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnXuat = new Button();
            btnTimKiem = new Button();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnInHoaDon = new Button();
            btnLapHoaDonMoi = new Button();
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
            panel1.Controls.Add(btnXuat);
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnInHoaDon);
            panel1.Controls.Add(btnLapHoaDonMoi);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 396);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 56);
            panel1.TabIndex = 1;
            // 
            // btnXuat
            // 
            btnXuat.FlatAppearance.BorderColor = Color.Green;
            btnXuat.FlatStyle = FlatStyle.Flat;
            btnXuat.ForeColor = Color.Green;
            btnXuat.Location = new Point(779, 6);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(115, 39);
            btnXuat.TabIndex = 23;
            btnXuat.Text = "Xuất excel...";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Location = new Point(658, 6);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(115, 39);
            btnTimKiem.TabIndex = 23;
            btnTimKiem.Text = "Tìm kiếm...";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Location = new Point(537, 6);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(115, 39);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Location = new Point(295, 6);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(115, 39);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa...";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(416, 6);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(115, 39);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.FlatStyle = FlatStyle.Flat;
            btnInHoaDon.Location = new Point(174, 6);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(115, 39);
            btnInHoaDon.TabIndex = 22;
            btnInHoaDon.Text = "In hoá đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnLapHoaDonMoi
            // 
            btnLapHoaDonMoi.FlatAppearance.BorderColor = Color.Blue;
            btnLapHoaDonMoi.FlatStyle = FlatStyle.Flat;
            btnLapHoaDonMoi.ForeColor = Color.Blue;
            btnLapHoaDonMoi.Location = new Point(50, 6);
            btnLapHoaDonMoi.Name = "btnLapHoaDonMoi";
            btnLapHoaDonMoi.Size = new Size(118, 39);
            btnLapHoaDonMoi.TabIndex = 21;
            btnLapHoaDonMoi.Text = "Lập hoá đơn mới...";
            btnLapHoaDonMoi.UseVisualStyleBackColor = true;
            btnLapHoaDonMoi.Click += btnLapHoaDonMoi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(946, 396);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hoá đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, NhanVien, KhachHang, NgayLap, TongTien, GhiChuHoaDon, ChiTiet });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.Size = new Size(940, 368);
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
            NhanVien.ReadOnly = true;
            // 
            // KhachHang
            // 
            KhachHang.DataPropertyName = "TenKhachHang";
            KhachHang.HeaderText = "Khách hàng";
            KhachHang.Name = "KhachHang";
            KhachHang.ReadOnly = true;
            // 
            // NgayLap
            // 
            NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            NgayLap.DefaultCellStyle = dataGridViewCellStyle1;
            NgayLap.HeaderText = "Ngày lập";
            NgayLap.Name = "NgayLap";
            NgayLap.ReadOnly = true;
            // 
            // TongTien
            // 
            TongTien.DataPropertyName = "TongTienHoaDon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            TongTien.DefaultCellStyle = dataGridViewCellStyle2;
            TongTien.HeaderText = "Tổng tiền";
            TongTien.Name = "TongTien";
            TongTien.ReadOnly = true;
            // 
            // GhiChuHoaDon
            // 
            GhiChuHoaDon.DataPropertyName = "GhiChuHoaDon";
            GhiChuHoaDon.HeaderText = "Ghi chú";
            GhiChuHoaDon.Name = "GhiChuHoaDon";
            GhiChuHoaDon.ReadOnly = true;
            // 
            // ChiTiet
            // 
            ChiTiet.DataPropertyName = "XemChiTiet";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ChiTiet.DefaultCellStyle = dataGridViewCellStyle3;
            ChiTiet.HeaderText = "Chi tiểt";
            ChiTiet.Name = "ChiTiet";
            ChiTiet.ReadOnly = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 452);
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
        private Button btnXuat;
        private Button btnTimKiem;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnInHoaDon;
        private Button btnLapHoaDonMoi;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NhanVien;
        private DataGridViewTextBoxColumn KhachHang;
        private DataGridViewTextBoxColumn NgayLap;
        private DataGridViewTextBoxColumn TongTien;
        private DataGridViewTextBoxColumn GhiChuHoaDon;
        private DataGridViewLinkColumn ChiTiet;
    }
}