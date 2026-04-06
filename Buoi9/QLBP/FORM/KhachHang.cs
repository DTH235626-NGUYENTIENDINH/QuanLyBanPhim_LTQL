using ClosedXML.Excel;
using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBP.FORM
{
    public partial class frmKhachHang : Form
    {
        private NhanVien currentUser;

        public frmKhachHang(NhanVien user = null)
        {
            InitializeComponent();
            currentUser = user;
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;

        private void BatTatChucNang(bool giaTri)
        {
            // Quản lý (0) và Bán hàng (1) được phép sửa/thêm khách hàng. Bảo hành (2) chỉ xem.
            bool canEdit = (currentUser == null || currentUser.VaiTro == 0 || currentUser.VaiTro == 1);

            btnLuu.Enabled = giaTri && canEdit;
            btnHuyBo.Enabled = giaTri && canEdit;

            txtHoVaTen.Enabled = giaTri && canEdit;
            txtSDT.Enabled = giaTri && canEdit;
            txtDiaChi.Enabled = giaTri && canEdit;

            btnThem.Enabled = !giaTri && canEdit;
            btnSua.Enabled = !giaTri && canEdit;
            btnXoa.Enabled = !giaTri && canEdit;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri && canEdit;
            btnXuat.Enabled = !giaTri && canEdit;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);

            List<KhachHang> kh = new List<KhachHang>();
            kh = context.KhachHang.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);

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

            if (MessageBox.Show("Xác nhận xóa khách hàng này?" + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    string tenKH = kh.HoVaTen;
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Xoá khách hàng", $"Đã xoá khách hàng: {tenKH}");
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((xuLyThem || xuLySua) && (string.IsNullOrWhiteSpace(txtHoVaTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text)))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    kh.DienThoai = txtSDT.Text;
                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                    QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Thêm khách hàng", $"Đã thêm khách hàng mới: {kh.HoVaTen}");
                }
                else if (xuLySua)
                {
                    KhachHang kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.DienThoai = txtSDT.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                        QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Cập nhật khách hàng", $"Đã cập nhật thông tin khách hàng: {kh.HoVaTen}");
                    }

                }
                else
                {
                    string tenCanTim = txtHoVaTen.Text.Trim().ToLower();
                    string sdtCanTim = txtSDT.Text.Trim();
                    string diaChiCanTim = txtDiaChi.Text.Trim().ToLower();
                    var query = context.KhachHang.AsQueryable();
                    //Lọc theo Tên
                    if (!string.IsNullOrEmpty(tenCanTim))
                    {
                        query = query.Where(k => k.HoVaTen.ToLower().Contains(tenCanTim));
                    }

                    //Lọc theo SĐT
                    if (!string.IsNullOrEmpty(sdtCanTim))
                    {
                        query = query.Where(k => k.DienThoai.Contains(sdtCanTim));
                    }

                    //Lọc theo Địa chỉ
                    if (!string.IsNullOrEmpty(diaChiCanTim))
                    {
                        query = query.Where(k => k.DiaChi.ToLower().Contains(diaChiCanTim));
                    }

                    List<KhachHang> ketQuaTimKiem = query.ToList();

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = ketQuaTimKiem;
                    dataGridView.DataSource = bindingSource;


                    txtHoVaTen.DataBindings.Clear();
                    txtDiaChi.DataBindings.Clear();
                    txtSDT.DataBindings.Clear();

                    if (ketQuaTimKiem.Count > 0)
                    {
                        txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
                        txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                        txtSDT.DataBindings.Add("Text", bindingSource, "DienThoai", false, DataSourceUpdateMode.Never);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtHoVaTen.Clear();
                        txtDiaChi.Clear();
                        txtSDT.Clear();
                    }
                    return;
                }
                frmKhachHang_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLySua = false;
            xuLyThem = false;
            BatTatChucNang(true);
            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
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
                                KhachHang kh = new KhachHang();
                                kh.HoVaTen = r["Họ và tên"].ToString();
                                kh.DienThoai = r["SĐT"].ToString();
                                kh.DiaChi = r["Địa chỉ"].ToString();
                                context.KhachHang.Add(kh);
                                
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhachHang_Load(sender, e);
                        }
                        if (firstRow)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[4] {
                    new DataColumn("ID", typeof(int)),
                        new DataColumn("Họ và tên", typeof(string)),
                        new DataColumn("SĐT", typeof(string)),
                        new DataColumn("Địa chỉ", typeof(string))
                    });
                    var kh = context.KhachHang.ToList();
                    if (kh != null)
                    {
                        foreach (var p in kh)
                            table.Rows.Add(p.ID, p.HoVaTen, p.DienThoai,p.DiaChi);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

