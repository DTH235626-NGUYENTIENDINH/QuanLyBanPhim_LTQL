namespace QLBP.FORM
{
    partial class DangNhap
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
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(113, 143, 191);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(280, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 548);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(139, 75);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // button1
            // 
            button1.Location = new Point(158, 417);
            button1.Name = "button1";
            button1.Size = new Size(133, 62);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(75, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 72);
            panel2.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(75, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 72);
            panel4.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên đăng nhập";
            textBox1.Size = new Size(268, 26);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(15, 23);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mật khẩu";
            textBox2.Size = new Size(268, 26);
            textBox2.TabIndex = 9;
            textBox2.UseSystemPasswordChar = true;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 572);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap";
            Text = "DangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel4;
        private TextBox textBox2;
    }
}