namespace QLBP.FORM
{
    partial class BanPhim
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
            cbHSX = new ComboBox();
            cbLoaiSW = new ComboBox();
            cbLoaiPhim = new ComboBox();
            txtSoLuong = new TextBox();
            txtGia = new TextBox();
            txtTen = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbHSX);
            groupBox1.Controls.Add(cbLoaiSW);
            groupBox1.Controls.Add(cbLoaiPhim);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 186);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bàn phím";
            // 
            // cbHSX
            // 
            cbHSX.FormattingEnabled = true;
            cbHSX.Location = new Point(525, 26);
            cbHSX.Name = "cbHSX";
            cbHSX.Size = new Size(213, 29);
            cbHSX.TabIndex = 2;
            // 
            // cbLoaiSW
            // 
            cbLoaiSW.FormattingEnabled = true;
            cbLoaiSW.Location = new Point(170, 146);
            cbLoaiSW.Name = "cbLoaiSW";
            cbLoaiSW.Size = new Size(213, 29);
            cbLoaiSW.TabIndex = 2;
            // 
            // cbLoaiPhim
            // 
            cbLoaiPhim.FormattingEnabled = true;
            cbLoaiPhim.Location = new Point(170, 106);
            cbLoaiPhim.Name = "cbLoaiPhim";
            cbLoaiPhim.Size = new Size(213, 29);
            cbLoaiPhim.TabIndex = 2;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 12F);
            txtSoLuong.Location = new Point(525, 112);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(213, 29);
            txtSoLuong.TabIndex = 1;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI", 12F);
            txtGia.Location = new Point(525, 72);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(213, 29);
            txtGia.TabIndex = 1;
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F);
            txtTen.Location = new Point(170, 66);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(213, 29);
            txtTen.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(170, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(213, 29);
            txtID.TabIndex = 1;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(21, 32);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 2);
            label5.Size = new Size(75, 23);
            label5.TabIndex = 0;
            label5.Text = "Mã phím:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 152);
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
            label3.Location = new Point(21, 112);
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
            label1.Location = new Point(21, 72);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 2);
            label1.Size = new Size(127, 23);
            label1.TabIndex = 0;
            label1.Text = "Tên bàn phím (*):";
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(773, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 141);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(121, 3);
            button4.Name = "button4";
            button4.Size = new Size(115, 39);
            button4.TabIndex = 0;
            button4.Text = "Lưu";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(3, 93);
            button3.Name = "button3";
            button3.Size = new Size(115, 39);
            button3.TabIndex = 0;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(124, 93);
            button6.Name = "button6";
            button6.Size = new Size(112, 39);
            button6.TabIndex = 0;
            button6.Text = "Huỷ bỏ";
            button6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(3, 48);
            button2.Name = "button2";
            button2.Size = new Size(115, 39);
            button2.TabIndex = 0;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(124, 48);
            button5.Name = "button5";
            button5.Size = new Size(112, 39);
            button5.TabIndex = 0;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(115, 39);
            button1.TabIndex = 0;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 395);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách bàn phím";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 25);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(994, 367);
            dataGridView.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // BanPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 611);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BanPhim";
            Text = "BanPhim";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
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
        private Panel panel1;
        private TextBox txtID;
        private Label label5;
        private TextBox txtSoLuong;
        private TextBox txtGia;
        private TextBox txtTen;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private ComboBox cbHSX;
        private ComboBox cbLoaiSW;
        private ComboBox cbLoaiPhim;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button2;
        private Button button5;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}