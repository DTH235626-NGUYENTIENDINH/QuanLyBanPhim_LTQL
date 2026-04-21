namespace QLBP.FORM
{
    partial class frmBaoHanh
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            gbBaoHanh = new GroupBox();
            chkDaTra = new CheckBox();
            dtpNgayTra = new DateTimePicker();
            dtpNgayTiepNhan = new DateTimePicker();
            cboTrangThai = new QLBP.Controls.CustomCombobox();
            cboNhanVien = new QLBP.Controls.CustomCombobox();
            cboKhachHang = new QLBP.Controls.CustomCombobox();
            cboHoaDon = new QLBP.Controls.CustomCombobox();
            cboBanPhim = new QLBP.Controls.CustomCombobox();
            txtMoTaLoi = new QLBP.Controls.CustomTextbox();
            txtNoiDung = new QLBP.Controls.CustomTextbox();
            txtChiPhi = new QLBP.Controls.CustomTextbox();
            txtGhiChu = new QLBP.Controls.CustomTextbox();
            btnThem = new QLBP.Controls.CustomButon();
            btnSua = new QLBP.Controls.CustomButon();
            btnXoa = new QLBP.Controls.CustomButon();
            btnTimKiem = new QLBP.Controls.CustomButon();
            btnLuu = new QLBP.Controls.CustomButon();
            btnHuyBo = new QLBP.Controls.CustomButon();
            lblBaoHanhStatus = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            gbBaoHanh.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // gbBaoHanh
            // 
            gbBaoHanh.Controls.Add(chkDaTra);
            gbBaoHanh.Controls.Add(dtpNgayTra);
            gbBaoHanh.Controls.Add(dtpNgayTiepNhan);
            gbBaoHanh.Controls.Add(cboTrangThai);
            gbBaoHanh.Controls.Add(cboNhanVien);
            gbBaoHanh.Controls.Add(cboKhachHang);
            gbBaoHanh.Controls.Add(cboHoaDon);
            gbBaoHanh.Controls.Add(cboBanPhim);
            gbBaoHanh.Controls.Add(txtMoTaLoi);
            gbBaoHanh.Controls.Add(txtNoiDung);
            gbBaoHanh.Controls.Add(txtChiPhi);
            gbBaoHanh.Controls.Add(txtGhiChu);
            gbBaoHanh.Controls.Add(btnThem);
            gbBaoHanh.Controls.Add(btnSua);
            gbBaoHanh.Controls.Add(btnXoa);
            gbBaoHanh.Controls.Add(btnTimKiem);
            gbBaoHanh.Controls.Add(btnLuu);
            gbBaoHanh.Controls.Add(btnHuyBo);
            gbBaoHanh.Controls.Add(lblBaoHanhStatus);
            gbBaoHanh.Controls.Add(label1);
            gbBaoHanh.Controls.Add(label2);
            gbBaoHanh.Controls.Add(label3);
            gbBaoHanh.Controls.Add(label4);
            gbBaoHanh.Controls.Add(label5);
            gbBaoHanh.Controls.Add(label6);
            gbBaoHanh.Controls.Add(label7);
            gbBaoHanh.Controls.Add(label8);
            gbBaoHanh.Controls.Add(label9);
            gbBaoHanh.Controls.Add(label10);
            gbBaoHanh.Controls.Add(label11);
            gbBaoHanh.Dock = DockStyle.Top;
            gbBaoHanh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbBaoHanh.ForeColor = Color.FromArgb(255, 128, 255);
            gbBaoHanh.Location = new Point(0, 0);
            gbBaoHanh.Name = "gbBaoHanh";
            gbBaoHanh.Size = new Size(988, 280);
            gbBaoHanh.TabIndex = 0;
            gbBaoHanh.TabStop = false;
            gbBaoHanh.Text = "Thông tin bảo hành sửa chữa";
            // 
            // chkDaTra
            // 
            chkDaTra.Location = new Point(610, 133);
            chkDaTra.Name = "chkDaTra";
            chkDaTra.Size = new Size(20, 23);
            chkDaTra.TabIndex = 0;
            chkDaTra.Text = "";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Enabled = false;
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(705, 130);
            dtpNgayTra.Size = new Size(115, 29);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.TabIndex = 1;
            // 
            // dtpNgayTiepNhan
            // 
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Short;
            dtpNgayTiepNhan.Location = new Point(450, 175);
            dtpNgayTiepNhan.Size = new Size(200, 29);
            dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            dtpNgayTiepNhan.TabIndex = 2;
            // 
            // cboTrangThai
            // 
            SetupCombo(cboTrangThai, 130, 220, 180);
            cboTrangThai.Items.AddRange(new object[] { "Tiếp nhận", "Đang sửa chữa", "Hoàn thành", "Đã trả khách" });
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.TabIndex = 3;
            // 
            // cboNhanVien
            // 
            SetupCombo(cboNhanVien, 130, 175, 180);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.TabIndex = 4;
            // 
            // cboKhachHang
            // 
            SetupCombo(cboKhachHang, 130, 40, 180);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.TabIndex = 5;
            cboKhachHang.OnSelectedIndexChanged += cboKhachHang_SelectedIndexChanged;
            // 
            // cboHoaDon
            // 
            SetupCombo(cboHoaDon, 130, 85, 180);
            cboHoaDon.Name = "cboHoaDon";
            cboHoaDon.TabIndex = 6;
            cboHoaDon.OnSelectedIndexChanged += cboHoaDon_SelectedIndexChanged;
            // 
            // cboBanPhim
            // 
            SetupCombo(cboBanPhim, 130, 130, 180);
            cboBanPhim.Name = "cboBanPhim";
            cboBanPhim.TabIndex = 7;
            cboBanPhim.OnSelectedIndexChanged += cboBanPhim_SelectedIndexChanged;
            // 
            // txtMoTaLoi
            // 
            SetupTextbox(txtMoTaLoi, 450, 40, 200);
            txtMoTaLoi.Name = "txtMoTaLoi";
            txtMoTaLoi.TabIndex = 8;
            // 
            // txtNoiDung
            // 
            SetupTextbox(txtNoiDung, 450, 85, 200);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.TabIndex = 9;
            // 
            // txtChiPhi
            // 
            SetupTextbox(txtChiPhi, 450, 130, 150);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.TabIndex = 10;
            // 
            // txtGhiChu
            // 
            SetupTextbox(txtGhiChu, 450, 220, 380);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.TabIndex = 11;
            // 
            // btnThem
            // 
            SetupButton(btnThem, "Thêm mới", Color.Cyan, 740, 35);
            btnThem.Name = "btnThem";
            btnThem.TabIndex = 12;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            SetupButton(btnSua, "Sửa chữa", Color.Yellow, 860, 35);
            btnSua.Name = "btnSua";
            btnSua.TabIndex = 13;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            SetupButton(btnXoa, "Xoá", Color.Red, 740, 80);
            btnXoa.Name = "btnXoa";
            btnXoa.TabIndex = 14;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTimKiem
            // 
            SetupButton(btnTimKiem, "Tìm kiếm", Color.White, 860, 80);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.TabIndex = 15;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLuu
            // 
            SetupButton(btnLuu, "Lưu lại", Color.Lime, 860, 125);
            btnLuu.Name = "btnLuu";
            btnLuu.TabIndex = 16;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            SetupButton(btnHuyBo, "Huỷ bỏ", Color.Orange, 860, 170);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.TabIndex = 17;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // lblBaoHanhStatus
            // 
            lblBaoHanhStatus.AutoSize = true;
            lblBaoHanhStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblBaoHanhStatus.ForeColor = Color.Yellow;
            lblBaoHanhStatus.Location = new Point(130, 255);
            lblBaoHanhStatus.Name = "lblBaoHanhStatus";
            lblBaoHanhStatus.Size = new Size(132, 15);
            lblBaoHanhStatus.TabIndex = 18;
            lblBaoHanhStatus.Text = "Tình trạng bảo hành: --";
            // 
            // label1
            // 
            SetupLabel(label1, "Trạng thái:", 20, 225);
            // 
            // label2
            // 
            SetupLabel(label2, "Nhân viên:", 20, 180);
            // 
            // label3
            // 
            SetupLabel(label3, "Khách hàng (*):", 20, 45);
            // 
            // label4
            // 
            SetupLabel(label4, "Số hoá đơn:", 20, 90);
            // 
            // label5
            // 
            SetupLabel(label5, "Sản phẩm (*):", 20, 135);
            // 
            // label6
            // 
            SetupLabel(label6, "Ngày nhận:", 330, 180);
            // 
            // label7
            // 
            SetupLabel(label7, "Mô tả lỗi (*):", 330, 45);
            // 
            // label8
            // 
            SetupLabel(label8, "Nội dung sửa:", 330, 90);
            // 
            // label9
            // 
            SetupLabel(label9, "Chi phí:", 330, 135);
            // 
            // label10
            // 
            SetupLabel(label10, "Ghi chú:", 330, 225);
            // 
            // label11
            // 
            SetupLabel(label11, "Ngày trả:", 635, 133);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox2.Location = new Point(0, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu bảo hành";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(73, 72, 82);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle5.BackColor = Color.FromArgb(116, 41, 145);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(56, 52, 79);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
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
            dataGridView.Size = new Size(982, 152);
            dataGridView.TabIndex = 0;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // frmBaoHanh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(988, 460);
            Controls.Add(groupBox2);
            Controls.Add(gbBaoHanh);
            Name = "frmBaoHanh";
            Text = "Quản lý bảo hành sửa chữa";
            Load += frmBaoHanh_Load;
            gbBaoHanh.ResumeLayout(false);
            gbBaoHanh.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private void SetupLabel(Label lbl, string text, int x, int y)
        {
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 10F);
            lbl.ForeColor = Color.White;
            lbl.Location = new Point(x, y);
            lbl.Text = text;
        }

        private void SetupCombo(Controls.CustomCombobox cbo, int x, int y, int w)
        {
            cbo.BackColor = Color.FromArgb(32, 30, 45);
            cbo.BorderColor = Color.MediumSlateBlue;
            cbo.BorderSize = 2;
            cbo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cbo.ForeColor = Color.White;
            cbo.IconColor = Color.Fuchsia;
            cbo.ListBackColor = Color.FromArgb(128, 128, 255);
            cbo.ListTextColor = Color.White;
            cbo.Location = new Point(x, y);
            cbo.MinimumSize = new Size(200, 30);
            cbo.Size = new Size(w, 30);
            cbo.Padding = new Padding(2);
        }

        private void SetupTextbox(Controls.CustomTextbox txt, int x, int y, int w)
        {
            txt.BackColor = Color.FromArgb(32, 30, 45);
            txt.BorderColor = Color.MediumSlateBlue;
            txt.BorderSize = 2;
            txt.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txt.ForeColor = Color.White;
            txt.Location = new Point(x, y);
            txt.Multiline = false;
            txt.Padding = new Padding(7);
            txt.PassWordChar = false;
            txt.Size = new Size(w, 32);
            txt.UnderlinedStyle = false;
        }

        private void SetupButton(Controls.CustomButon btn, string text, Color color, int x, int y)
        {
            btn.BackColor = Color.Transparent;
            btn.BackgroundColor = Color.Transparent;
            btn.BorderColor = color;
            btn.BorderRadius = 20;
            btn.BorderSize = 2;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = color;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.Location = new Point(x, y);
            btn.Size = new Size(115, 39);
            btn.Text = text;
            btn.TextColor = color;
        }
        #endregion

        private GroupBox gbBaoHanh;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Controls.CustomCombobox cboBanPhim;
        private Controls.CustomCombobox cboKhachHang;
        private Controls.CustomCombobox cboHoaDon;
        private Controls.CustomCombobox cboNhanVien;
        private Controls.CustomCombobox cboTrangThai;
        private Controls.CustomTextbox txtMoTaLoi;
        private Controls.CustomTextbox txtNoiDung;
        private Controls.CustomTextbox txtChiPhi;
        private Controls.CustomTextbox txtGhiChu;
        private DateTimePicker dtpNgayTiepNhan;
        private DateTimePicker dtpNgayTra;
        private CheckBox chkDaTra;
        private Controls.CustomButon btnThem;
        private Controls.CustomButon btnSua;
        private Controls.CustomButon btnXoa;
        private Controls.CustomButon btnTimKiem;
        private Controls.CustomButon btnLuu;
        private Controls.CustomButon btnHuyBo;
        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10, label11;
        private Label lblBaoHanhStatus;
    }
}
