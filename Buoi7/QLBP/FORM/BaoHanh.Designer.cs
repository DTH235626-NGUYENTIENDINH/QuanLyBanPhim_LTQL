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
            DataGridViewCellStyle cs1 = new DataGridViewCellStyle();
            DataGridViewCellStyle cs2 = new DataGridViewCellStyle();
            DataGridViewCellStyle cs3 = new DataGridViewCellStyle();

            gbBaoHanh = new GroupBox();
            cboBanPhim = new QLBP.Controls.CustomCombobox();
            cboKhachHang = new QLBP.Controls.CustomCombobox();
            cboHoaDon = new QLBP.Controls.CustomCombobox();
            cboNhanVien = new QLBP.Controls.CustomCombobox();
            cboTrangThai = new QLBP.Controls.CustomCombobox();
            txtMoTaLoi = new QLBP.Controls.CustomTextbox();
            txtNoiDung = new QLBP.Controls.CustomTextbox();
            txtChiPhi = new QLBP.Controls.CustomTextbox();
            txtGhiChu = new QLBP.Controls.CustomTextbox();
            dtpNgayTiepNhan = new DateTimePicker();
            dtpNgayTra = new DateTimePicker();
            chkDaTra = new CheckBox();

            btnThem = new QLBP.Controls.CustomButon();
            btnSua = new QLBP.Controls.CustomButon();
            btnXoa = new QLBP.Controls.CustomButon();
            btnTimKiem = new QLBP.Controls.CustomButon();
            btnLuu = new QLBP.Controls.CustomButon();
            btnHuyBo = new QLBP.Controls.CustomButon();

            label1 = new Label(); label2 = new Label(); label3 = new Label();
            label4 = new Label(); label5 = new Label(); label6 = new Label();
            label7 = new Label(); label8 = new Label(); label9 = new Label();
            label10 = new Label();

            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();

            gbBaoHanh.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();

            // === GroupBox Thông tin ===
            gbBaoHanh.Controls.Add(chkDaTra); gbBaoHanh.Controls.Add(dtpNgayTra);
            gbBaoHanh.Controls.Add(dtpNgayTiepNhan);
            gbBaoHanh.Controls.Add(cboTrangThai); gbBaoHanh.Controls.Add(cboNhanVien);
            gbBaoHanh.Controls.Add(cboKhachHang); gbBaoHanh.Controls.Add(cboHoaDon); 
            gbBaoHanh.Controls.Add(cboBanPhim);
            gbBaoHanh.Controls.Add(txtMoTaLoi); gbBaoHanh.Controls.Add(txtNoiDung);
            gbBaoHanh.Controls.Add(txtChiPhi); gbBaoHanh.Controls.Add(txtGhiChu);
            gbBaoHanh.Controls.Add(btnThem); gbBaoHanh.Controls.Add(btnSua);
            gbBaoHanh.Controls.Add(btnXoa); gbBaoHanh.Controls.Add(btnTimKiem);
            gbBaoHanh.Controls.Add(btnLuu); gbBaoHanh.Controls.Add(btnHuyBo);
            gbBaoHanh.Controls.Add(label1); gbBaoHanh.Controls.Add(label2);
            gbBaoHanh.Controls.Add(label3); gbBaoHanh.Controls.Add(label4);
            gbBaoHanh.Controls.Add(label5); gbBaoHanh.Controls.Add(label6);
            gbBaoHanh.Controls.Add(label7); gbBaoHanh.Controls.Add(label8);
            gbBaoHanh.Controls.Add(label9); gbBaoHanh.Controls.Add(label10);
            gbBaoHanh.Dock = DockStyle.Top;
            gbBaoHanh.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbBaoHanh.ForeColor = Color.FromArgb(255, 128, 255);
            gbBaoHanh.Location = new Point(0, 0);
            gbBaoHanh.Name = "gbBaoHanh";
            gbBaoHanh.Size = new Size(988, 280);
            gbBaoHanh.TabIndex = 0;
            gbBaoHanh.TabStop = false;
            gbBaoHanh.Text = "Thông tin bảo hành sửa chữa";

            // Labels
            SetupLabel(label2, "Khách hàng (*):", 7, 35);
            SetupLabel(label10, "Hoá đơn (*):", 7, 75);
            SetupLabel(label1, "Sản phẩm (*):", 7, 115);
            SetupLabel(label3, "NV phụ trách:", 7, 155);
            SetupLabel(label7, "Trạng thái:", 7, 195);
            SetupLabel(label9, "Ghi chú:", 7, 235);
            
            SetupLabel(label4, "Mô tả lỗi (*):", 350, 35);
            SetupLabel(label5, "Nội dung sửa:", 350, 75);
            SetupLabel(label6, "Chi phí (VNĐ):", 350, 115);
            SetupLabel(label8, "Ngày tiếp nhận:", 350, 195);

            // ComboBoxes
            SetupCombo(cboKhachHang, 130, 32, 210); cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.OnSelectedIndexChanged += cboKhachHang_SelectedIndexChanged;
            
            SetupCombo(cboHoaDon, 130, 72, 210); cboHoaDon.Name = "cboHoaDon";
            cboHoaDon.OnSelectedIndexChanged += cboHoaDon_SelectedIndexChanged;

            SetupCombo(cboBanPhim, 130, 112, 210); cboBanPhim.Name = "cboBanPhim";
            cboBanPhim.OnSelectedIndexChanged += cboBanPhim_SelectedIndexChanged;

            SetupCombo(cboNhanVien, 130, 152, 210); cboNhanVien.Name = "cboNhanVien";
            SetupCombo(cboTrangThai, 130, 192, 210); cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Items.AddRange(new object[] { "Tiếp nhận", "Đang sửa chữa", "Hoàn thành", "Đã trả khách" });

            // TextBoxes
            SetupTextbox(txtMoTaLoi, 460, 32, 250); txtMoTaLoi.Name = "txtMoTaLoi";
            SetupTextbox(txtNoiDung, 460, 72, 250); txtNoiDung.Name = "txtNoiDung";
            SetupTextbox(txtChiPhi, 460, 112, 150); txtChiPhi.Name = "txtChiPhi";
            SetupTextbox(txtGhiChu, 130, 232, 580); txtGhiChu.Name = "txtGhiChu";

            // DateTimePickers
            dtpNgayTiepNhan.Location = new Point(480, 195);
            dtpNgayTiepNhan.Size = new Size(230, 25);
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Short;
            dtpNgayTiepNhan.CalendarForeColor = Color.White;
            dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";

            chkDaTra.Text = "Ngày trả:";
            chkDaTra.ForeColor = Color.White;
            chkDaTra.Font = new Font("Segoe UI", 10F);
            chkDaTra.Location = new Point(620, 113);
            chkDaTra.Size = new Size(90, 25);
            chkDaTra.Name = "chkDaTra";

            dtpNgayTra.Location = new Point(715, 113);
            dtpNgayTra.Size = new Size(145, 25);
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Enabled = false;
            dtpNgayTra.Name = "dtpNgayTra";

            // Buttons
            SetupButton(btnThem, "Thêm", Color.FromArgb(0, 192, 0), 735, 25);
            btnThem.Click += btnThem_Click;
            SetupButton(btnSua, "Sửa", Color.FromArgb(192, 192, 0), 855, 25);
            btnSua.Click += btnSua_Click;
            SetupButton(btnXoa, "Xoá", Color.Red, 735, 65);
            btnXoa.Click += btnXoa_Click;
            SetupButton(btnTimKiem, "Tìm kiếm", Color.FromArgb(255, 128, 0), 855, 65);
            btnTimKiem.Click += btnTimKiem_Click;
            SetupButton(btnLuu, "Lưu", Color.DodgerBlue, 735, 150);
            btnLuu.Click += btnLuu_Click;
            SetupButton(btnHuyBo, "Huỷ bỏ", Color.FromArgb(192, 192, 0), 855, 150);
            btnHuyBo.Click += btnHuyBo_Click;

            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = Color.FromArgb(255, 128, 255);
            groupBox2.Location = new Point(0, 280);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(988, 200);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phiếu bảo hành";

            // DataGridView
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
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
            cs3.BackColor = Color.FromArgb(56, 52, 79);
            cs3.ForeColor = Color.White;
            cs3.SelectionBackColor = SystemColors.Highlight;
            dataGridView.DefaultCellStyle = cs3;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = Color.White;
            dataGridView.MultiSelect = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Name = "dataGridView";
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;

            // Form
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
        private Label label1, label2, label3, label4, label5, label6, label7, label8, label9, label10;
    }
}
