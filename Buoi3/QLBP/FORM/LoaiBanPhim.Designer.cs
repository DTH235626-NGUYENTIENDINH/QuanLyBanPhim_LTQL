namespace QLBP.FORM
{
    partial class frmLoaiBanPhim
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
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnTimKiem = new Button();
            txtTen = new TextBox();
            btnXoa = new Button();
            label1 = new Label();
            btnSua = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1463, 232);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại phím";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(1269, 138);
            btnHuyBo.Margin = new Padding(4, 5, 4, 5);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(160, 65);
            btnHuyBo.TabIndex = 0;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(929, 138);
            btnLuu.Margin = new Padding(4, 5, 4, 5);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(164, 65);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(1101, 138);
            btnTimKiem.Margin = new Padding(4, 5, 4, 5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(160, 65);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F);
            txtTen.Location = new Point(189, 73);
            txtTen.Margin = new Padding(4, 5, 4, 5);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(1240, 39);
            txtTen.TabIndex = 8;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(757, 138);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(164, 65);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(46, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 3);
            label1.Size = new Size(133, 35);
            label1.TabIndex = 7;
            label1.Text = "Tên loại (*):";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(585, 138);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(164, 65);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(413, 138);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(164, 65);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.Location = new Point(0, 232);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(1463, 408);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách loại phím";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenLoai });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(4, 37);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1455, 366);
            dataGridView.TabIndex = 0;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Loại bàn phím";
            TenLoai.MinimumWidth = 8;
            TenLoai.Name = "TenLoai";
            // 
            // frmLoaiBanPhim
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 640);
            Controls.Add(groupBox4);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLoaiBanPhim";
            Text = "Loại bàn phím";
            Load += LoaiBanPhim_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnHuyBo;
        private Button btnSua;
        private Button btnTimKiem;
        private Button btnThem;
        private TextBox txtTen;
        private Label label1;
        private GroupBox groupBox4;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenLoai;
    }
}