using ClosedXML.Excel;
using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;
namespace QLBP.FORM
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            txtHoVaTen.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            cboVaiTro.IsReadOnly = !giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            List<NhanVien> nv = new List<NhanVien>(); nv = context.NhanVien.ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = nv;
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboVaiTro.DataBindings.Clear();
            cboVaiTro.DataBindings.Add("SelectedIndex", bindingSource, "VaiTro", true, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLySua = false;
            BatTatChucNang(true);

            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
            cboVaiTro.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            xuLyThem = false;
            xuLySua = true;
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xác nhận xoá người này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((xuLySua || xuLyThem) && (string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
                cboVaiTro.SelectedIndex == -1))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (xuLyThem)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtSDT.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        nv.VaiTro = cboVaiTro.SelectedIndex;
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }
                }
                else if (xuLySua)
                {
                    NhanVien nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtSDT.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.VaiTro = cboVaiTro.SelectedIndex;
                        context.NhanVien.Update(nv);
                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false;
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text);
                        context.SaveChanges();
                    }
                }
                else
                {
                    string ten = txtHoVaTen.Text.Trim().ToLower();
                    string sdt = txtSDT.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim().ToLower();
                    string tenDN = txtTenDangNhap.Text.Trim().ToLower();

                    var query = context.NhanVien.AsQueryable();

                    if (!string.IsNullOrEmpty(ten))
                        query = query.Where(x => x.HoVaTen.ToLower().Contains(ten));

                    if (!string.IsNullOrEmpty(sdt))
                        query = query.Where(x => x.DienThoai.Contains(sdt));

                    if (!string.IsNullOrEmpty(diaChi))
                        query = query.Where(x => x.DiaChi.ToLower().Contains(diaChi));

                    if (!string.IsNullOrEmpty(tenDN))
                        query = query.Where(x => x.TenDangNhap.ToLower().Contains(tenDN));

                    if (cboVaiTro.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(cboVaiTro.Text))
                    {
                        int vaiTro = cboVaiTro.SelectedIndex;
                        query = query.Where(x => x.VaiTro == vaiTro);
                    }

                    List<NhanVien> ketQua = query.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQua;
                    dataGridView.DataSource = bindingSource;

                    txtHoVaTen.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtSDT.DataBindings.Clear();
                    txtTenDangNhap.DataBindings.Clear();
                    txtMatKhau.DataBindings.Clear();
                    cboVaiTro.DataBindings.Clear();

                    if (ketQua.Count > 0)
                    {
                        txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
                        txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                        txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
                        txtTenDangNhap.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
                        cboVaiTro.DataBindings.Add("SelectedIndex", bindingSource, "VaiTro", true, DataSourceUpdateMode.Never);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHoVaTen.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                        txtTenDangNhap.Clear();
                        txtMatKhau.Clear();
                        cboVaiTro.Text = "";
                    }
                    return;
                }
                frmNhanVien_Load(sender, e);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLyThem = false;
            xuLySua = false;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
            cboVaiTro.Text = "";
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {

                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                NhanVien nv = new NhanVien();
                                nv.HoVaTen = r["Họ và tên"].ToString();
                                nv.DienThoai = r["SĐT"].ToString();
                                nv.DiaChi = r["Địa chỉ"].ToString();
                                nv.TenDangNhap = r["Tên đăng nhập"].ToString();
                                nv.MatKhau = r["Mật khẩu"].ToString();
                                string vt = r["Vai trò"].ToString().Trim().ToLower();
                                nv.VaiTro = vt == "nv bán hàng" ? 1 : vt == "nv bảo hành" ? 2 : 0;
                                context.NhanVien.Add(nv);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc tập tin Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[7] {
                    new DataColumn("ID", typeof(int)),
                        new DataColumn("Họ và tên", typeof(string)),
                        new DataColumn("SĐT", typeof(string)),
                        new DataColumn("Địa chỉ", typeof(string)),
                        new DataColumn("Tên đăng nhập", typeof(string)),
                        new DataColumn("Mật khẩu", typeof(string)),
                        new DataColumn("Vai trò", typeof(string))
                    });
                    var nv = context.NhanVien.ToList();
                    if (nv != null)
                    {
                        foreach (var p in nv)
                        {
                            string vt = p.VaiTro == 0 ? "Quản lý" : p.VaiTro == 1 ? "NV Bán hàng" : "NV Bảo hành";
                            table.Rows.Add(p.ID, p.HoVaTen, p.DienThoai, p.DiaChi, p.TenDangNhap, p.MatKhau, vt);
                        }
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Nhân viên");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
