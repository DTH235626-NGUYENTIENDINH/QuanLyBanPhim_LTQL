namespace QLBP.Reports
{
    partial class frmThongKeSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.chkSapHetHang = new System.Windows.Forms.CheckBox();
            this.numGiaDen = new System.Windows.Forms.NumericUpDown();
            this.lblGiaDen = new System.Windows.Forms.Label();
            this.numGiaTu = new System.Windows.Forms.NumericUpDown();
            this.lblGiaTu = new System.Windows.Forms.Label();
            this.btnLocKetQua = new System.Windows.Forms.Button();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.cboHangSanXuat = new System.Windows.Forms.ComboBox();
            this.lblHangSanXuat = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.chkSapHetHang);
            this.panelTop.Controls.Add(this.numGiaDen);
            this.panelTop.Controls.Add(this.lblGiaDen);
            this.panelTop.Controls.Add(this.numGiaTu);
            this.panelTop.Controls.Add(this.lblGiaTu);
            this.panelTop.Controls.Add(this.btnLocKetQua);
            this.panelTop.Controls.Add(this.cboLoaiSanPham);
            this.panelTop.Controls.Add(this.lblLoaiSanPham);
            this.panelTop.Controls.Add(this.cboHangSanXuat);
            this.panelTop.Controls.Add(this.lblHangSanXuat);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(900, 100);
            this.panelTop.TabIndex = 0;
            // 
            // chkSapHetHang
            // 
            this.chkSapHetHang.AutoSize = true;
            this.chkSapHetHang.Location = new System.Drawing.Point(544, 60);
            this.chkSapHetHang.Name = "chkSapHetHang";
            this.chkSapHetHang.Size = new System.Drawing.Size(165, 19);
            this.chkSapHetHang.TabIndex = 9;
            this.chkSapHetHang.Text = "Chỉ hiện SP sắp hết hàng";
            this.chkSapHetHang.UseVisualStyleBackColor = true;
            // 
            // numGiaDen
            // 
            this.numGiaDen.Location = new System.Drawing.Point(359, 58);
            this.numGiaDen.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGiaDen.Name = "numGiaDen";
            this.numGiaDen.Size = new System.Drawing.Size(161, 23);
            this.numGiaDen.TabIndex = 8;
            this.numGiaDen.ThousandsSeparator = true;
            // 
            // lblGiaDen
            // 
            this.lblGiaDen.AutoSize = true;
            this.lblGiaDen.Location = new System.Drawing.Point(267, 61);
            this.lblGiaDen.Name = "lblGiaDen";
            this.lblGiaDen.Size = new System.Drawing.Size(50, 15);
            this.lblGiaDen.TabIndex = 7;
            this.lblGiaDen.Text = "Giá đến:";
            // 
            // numGiaTu
            // 
            this.numGiaTu.Location = new System.Drawing.Point(100, 58);
            this.numGiaTu.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.numGiaTu.Name = "numGiaTu";
            this.numGiaTu.Size = new System.Drawing.Size(147, 23);
            this.numGiaTu.TabIndex = 6;
            this.numGiaTu.ThousandsSeparator = true;
            // 
            // lblGiaTu
            // 
            this.lblGiaTu.AutoSize = true;
            this.lblGiaTu.Location = new System.Drawing.Point(12, 61);
            this.lblGiaTu.Name = "lblGiaTu";
            this.lblGiaTu.Size = new System.Drawing.Size(43, 15);
            this.lblGiaTu.TabIndex = 5;
            this.lblGiaTu.Text = "Giá từ:";
            // 
            // btnLocKetQua
            // 
            this.btnLocKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLocKetQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocKetQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLocKetQua.ForeColor = System.Drawing.Color.White;
            this.btnLocKetQua.Location = new System.Drawing.Point(750, 30);
            this.btnLocKetQua.Name = "btnLocKetQua";
            this.btnLocKetQua.Size = new System.Drawing.Size(120, 40);
            this.btnLocKetQua.TabIndex = 4;
            this.btnLocKetQua.Text = "LỌC DỮ LIỆU";
            this.btnLocKetQua.UseVisualStyleBackColor = false;
            this.btnLocKetQua.Click += new System.EventHandler(this.btnLocKetQua_Click);
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(359, 19);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(161, 23);
            this.cboLoaiSanPham.TabIndex = 3;
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.Location = new System.Drawing.Point(267, 22);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(86, 15);
            this.lblLoaiSanPham.TabIndex = 2;
            this.lblLoaiSanPham.Text = "Loại sản phẩm:";
            // 
            // cboHangSanXuat
            // 
            this.cboHangSanXuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHangSanXuat.FormattingEnabled = true;
            this.cboHangSanXuat.Location = new System.Drawing.Point(100, 19);
            this.cboHangSanXuat.Name = "cboHangSanXuat";
            this.cboHangSanXuat.Size = new System.Drawing.Size(147, 23);
            this.cboHangSanXuat.TabIndex = 1;
            // 
            // lblHangSanXuat
            // 
            this.lblHangSanXuat.AutoSize = true;
            this.lblHangSanXuat.Location = new System.Drawing.Point(12, 22);
            this.lblHangSanXuat.Name = "lblHangSanXuat";
            this.lblHangSanXuat.Size = new System.Drawing.Size(85, 15);
            this.lblHangSanXuat.TabIndex = 0;
            this.lblHangSanXuat.Text = "Hãng sản xuất:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(900, 350);
            this.reportViewer1.TabIndex = 1;
            // 
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panelTop);
            this.Name = "frmThongKeSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân tích sản phẩm chuyên sâu";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTu)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnLocKetQua;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.ComboBox cboHangSanXuat;
        private System.Windows.Forms.Label lblHangSanXuat;
        private System.Windows.Forms.NumericUpDown numGiaDen;
        private System.Windows.Forms.Label lblGiaDen;
        private System.Windows.Forms.NumericUpDown numGiaTu;
        private System.Windows.Forms.Label lblGiaTu;
        private System.Windows.Forms.CheckBox chkSapHetHang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
