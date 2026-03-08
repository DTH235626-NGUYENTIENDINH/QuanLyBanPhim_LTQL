using QLBP.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace QLBP.FORM
{
    public partial class frmLoaiBanPhim : Form
    {
        public frmLoaiBanPhim()
        {
            InitializeComponent();
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;
        private void batTatChucNang(bool gt)
        {
            btnLuu.Enabled = gt;
            btnHuyBo.Enabled = gt;
            txtTen.Enabled = gt;

            btnThem.Enabled = !gt;
            btnSua.Enabled = !gt;
            btnXoa.Enabled = !gt;
            btnTimKiem.Enabled = !gt;
            btnNhap.Enabled = !gt;
            btnXuat.Enabled = !gt;
        }
        private void frmLoaiBanPhim_Load(object sender, EventArgs e)
        {
            batTatChucNang(false);

            List<LoaiBanPhim> lbp = new List<LoaiBanPhim>();
            lbp = context.LoaiBanPhims.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lbp;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            xuLySua = false;
            batTatChucNang(true);
            txtTen.Clear();
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
            batTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xác nhận xoá loại bàn phím này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                LoaiBanPhim lbp = context.LoaiBanPhims.Find(id);
                if (lbp != null)
                {
                    context.LoaiBanPhims.Remove(lbp);
                }
                context.SaveChanges();
                frmLoaiBanPhim_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    LoaiBanPhim lbp = new LoaiBanPhim();
                    lbp.TenLoai = txtTen.Text;
                    context.LoaiBanPhims.Add(lbp);

                    context.SaveChanges();
                }
                else if (xuLySua)
                {
                    LoaiBanPhim lbp = context.LoaiBanPhims.Find(id);
                    if (lbp != null)
                    {
                        lbp.TenLoai = txtTen.Text;
                        context.LoaiBanPhims.Update(lbp);

                        context.SaveChanges();
                    }
                }
                else
                {
                    string search = txtTen.Text.Trim().ToLower();
                    List<LoaiBanPhim> lbp = context.LoaiBanPhims.Where(x => x.TenLoai.ToLower().Contains(search)).ToList();
                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = lbp;

                    txtTen.DataBindings.Clear();
                    txtTen.DataBindings.Add("Text", bindingSource, "TenLoai", false, DataSourceUpdateMode.Never);
                    dataGridView.DataSource = bindingSource;
                    if (lbp.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return;

                }
                frmLoaiBanPhim_Load(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            xuLySua = false;
            xuLyThem = false;
            batTatChucNang(true);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiBanPhim_Load(sender, e);
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
                                LoaiBanPhim lbp = new LoaiBanPhim();
                                lbp.TenLoai = r["TenLoai"].ToString();
                                context.LoaiBanPhims.Add(lbp);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmLoaiBanPhim_Load(sender, e);
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
            saveFileDialog.FileName = "LoaiBanPhim_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[2]
                    {
                        new DataColumn("ID", typeof(int)),new DataColumn("Loại bàn phím", typeof(string))
                    });
                    var LoaiBanPhim = context.LoaiBanPhims.ToList();
                    if (LoaiBanPhim != null)
                    {
                        foreach (var p in LoaiBanPhim)
                            table.Rows.Add(p.ID, p.TenLoai);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "LoaiBanPhim");
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
