namespace QLBP.FORM
{
    partial class HangSanXuat
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button6 = new Button();
            button2 = new Button();
            button5 = new Button();
            button1 = new Button();
            txtTen = new TextBox();
            txtID = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 203);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hãng sản xuất";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(754, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 141);
            panel1.TabIndex = 2;
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
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 12F);
            txtTen.Location = new Point(169, 67);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(514, 29);
            txtTen.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.Location = new Point(169, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(514, 29);
            txtID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 0, 0, 2);
            label5.Size = new Size(135, 23);
            label5.TabIndex = 2;
            label5.Text = "Mã hãng sản xuất:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 73);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 2);
            label1.Size = new Size(157, 23);
            label1.TabIndex = 3;
            label1.Text = "Tên hãng sản xuất (*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(6, 113);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 2);
            label2.Size = new Size(96, 23);
            label2.TabIndex = 3;
            label2.Text = "Quốc gia (*):";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(169, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 29);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 0, 0, 2);
            label3.Size = new Size(68, 23);
            label3.TabIndex = 3;
            label3.Text = "Website:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(169, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(514, 29);
            textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 378);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            groupBox2.Enter += groupBox1_Enter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(994, 350);
            dataGridView1.TabIndex = 0;
            // 
            // HangSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 611);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HangSanXuat";
            Text = "HangSanXuat";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button6;
        private Button button2;
        private Button button5;
        private Button button1;
        private TextBox txtTen;
        private TextBox txtID;
        private Label label5;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}