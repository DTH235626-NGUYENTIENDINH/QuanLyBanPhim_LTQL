using ClosedXML.Excel;
using QLBP.DATA;
using SlugGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLBP.FORM
{
    public partial class frmBanPhim : Form
    {
        private NhanVien currentUser;

        public frmBanPhim(NhanVien user = null)
        {
            InitializeComponent();
            currentUser = user;
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        private void batTatChucNang(bool giatri)
        {
            bool isAdmin = (currentUser == null || currentUser.VaiTro == 0);

            btnThem.Enabled = !giatri && isAdmin;
            btnSua.Enabled = !giatri && isAdmin;
            btnXoa.Enabled = !giatri && isAdmin;
            btnTimKiem.Enabled = !giatri;

            btnLuu.Enabled = giatri;
            btnHuyBo.Enabled = giatri;
            btnDoiAnh.Enabled = !giatri && isAdmin;

            txtTen.Enabled = giatri && isAdmin;
            cboLoaiPhim.IsReadOnly = !giatri || !isAdmin;
            txtLoaiSwitch.Enabled = giatri && isAdmin;
            cboHSX.IsReadOnly = !giatri || !isAdmin;
            numGiaBan.Enabled = giatri && isAdmin;
            numSoLuong.Enabled = giatri && isAdmin;
            picHinhAnh.Enabled = giatri && isAdmin;
        }

        private void layHangSanXuatCBO()
        {
            cboHSX.DataSource = context.HangSanXuat.ToList();
            cboHSX.ValueMember = "ID";
            cboHSX.DisplayMember = "TenHangSanXuat";
        }
        private void layLoaiBanPhimCBO()
        {
            cboLoaiPhim.DataSource = context.LoaiBanPhims.ToList();
            cboLoaiPhim.ValueMember = "ID";
            cboLoaiPhim.DisplayMember = "TenLoai";
        }
        private Image LoadImageNoLock(string path)
        {
            if (!File.Exists(path)) return null;
            byte[] bytes = File.ReadAllBytes(path);
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void frmBanPhim_Load(object sender, EventArgs e)
        {
            // Cấp quyền Admin mới được chỉnh sửa sản phẩm
            bool isAdmin = (currentUser == null || currentUser.VaiTro == 0);
            if (!isAdmin)
            {
                btnNhap.Enabled = false;
            }

            batTatChucNang(false);
            layHangSanXuatCBO();
            layLoaiBanPhimCBO();
            dataGridView.AutoGenerateColumns = false;

            List<DanhSachBanPhim> bp = new List<DanhSachBanPhim>();
            bp = context.BanPhim.Select(r => new DanhSachBanPhim
            {
                ID = r.ID,
                LoaiBanPhimID = r.LoaiBanPhimID,
                TenLoaiBanPhim = r.LoaiBanPhim.TenLoai,
                LoaiSwitch = r.LoaiSwitch,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenBP = r.TenBP,
                SoLuong = r.SoLuong,
                GiaBan = r.GiaBan,
                HinhAnh = r.HinhAnh
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = bp;

            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("Text", bindingSource, "TenBP", false, DataSourceUpdateMode.Never);
            cboLoaiPhim.DataBindings.Clear();
            cboLoaiPhim.DataBindings.Add("SelectedValue", bindingSource, "LoaiBanPhimID", false, DataSourceUpdateMode.Never);
            txtLoaiSwitch.DataBindings.Clear();
            txtLoaiSwitch.DataBindings.Add("Text", bindingSource, "LoaiSwitch", false, DataSourceUpdateMode.Never);
            cboHSX.DataBindings.Clear();
            cboHSX.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numGiaBan.DataBindings.Clear();
            numGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", false, DataSourceUpdateMode.Never);
            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imagesFolder, e.Value.ToString());
            };
            picHinhAnh.DataBindings.Add(hinhAnh);
            dataGridView.DataSource = bindingSource;

        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                string fileName = dataGridView.CurrentRow.Cells["HinhAnh"].Value?.ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    picHinhAnh.Image = LoadImageNoLock(Path.Combine(imagesFolder, fileName));
                }
            }
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh" && e.Value != null)
            {
                string path = Path.Combine(imagesFolder, e.Value.ToString());
                if (File.Exists(path))
                {
                    // Dùng hàm LoadImageNoLock ở đây để không khóa file
                    using (Image img = LoadImageNoLock(path))
                    {
                        e.Value = new Bitmap(img, 24, 24);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            batTatChucNang(true);
            xuLyThem = true;
            xuLySua = false;
            txtTen.Clear();
            txtLoaiSwitch.Clear();
            cboHSX.Text = string.Empty;
            cboLoaiPhim.Text = string.Empty;
            numGiaBan.Value = 0;
            numSoLuong.Value = 0;
            picHinhAnh.Image = null;
            picHinhAnh.ImageLocation = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            batTatChucNang(true);
            xuLyThem = false;
            xuLySua = true;
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Không có dữ liệu để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xác nhận xoá bàn phím này?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                BanPhim hsx = context.BanPhim.Find(id);
                if (hsx != null)
                {
                    string tenBP = hsx.TenBP;
                    context.BanPhim.Remove(hsx);
                    context.SaveChanges();
                    QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Xoá sản phẩm", $"Đã xoá bàn phím: {tenBP}");
                }
                frmBanPhim_Load(sender, e);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            batTatChucNang(true);
            xuLyThem = false;
            xuLySua = false;
            txtTen.Clear();
            txtLoaiSwitch.Clear();
            cboHSX.SelectedIndex = -1;
            cboLoaiPhim.SelectedIndex = -1;
            numGiaBan.Value = 0;
            numSoLuong.Value = 0;
            picHinhAnh.Image = null;
            picHinhAnh.ImageLocation = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((xuLySua || xuLyThem) && (string.IsNullOrWhiteSpace(txtTen.Text) ||
                string.IsNullOrWhiteSpace(txtLoaiSwitch.Text) ||
                string.IsNullOrWhiteSpace(cboHSX.Text) ||
                string.IsNullOrWhiteSpace(cboLoaiPhim.Text) ||
                numGiaBan.Value <= 0 || numSoLuong.Value <= 0
                ))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (xuLyThem)
                {
                    BanPhim bp = new BanPhim();
                    bp.TenBP = txtTen.Text.Trim();
                    bp.LoaiSwitch = txtLoaiSwitch.Text.Trim();
                    bp.HangSanXuatID = (int)cboHSX.SelectedValue;
                    bp.LoaiBanPhimID = (int)cboLoaiPhim.SelectedValue;
                    bp.GiaBan = (int)numGiaBan.Value;
                    bp.SoLuong = (int)numSoLuong.Value;
                    // Xử lý tên file ảnh (chỉ lấy tên file để lưu vào DB)
                    if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                    {
                        bp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                    }
                    else
                    {
                        bp.HinhAnh = "no_image.png"; // Ảnh mặc định nếu không chọn
                    }
                    context.BanPhim.Add(bp);
                    context.SaveChanges();
                    QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Thêm sản phẩm", $"Đã thêm bàn phím mới: {bp.TenBP}");
                }
                else if (xuLySua)
                {
                    BanPhim bp = context.BanPhim.Find(id);
                    if (bp != null)
                    {
                        bp.TenBP = txtTen.Text.Trim();
                        bp.LoaiSwitch = txtLoaiSwitch.Text.Trim();
                        bp.HangSanXuatID = (int)cboHSX.SelectedValue;
                        bp.LoaiBanPhimID = (int)cboLoaiPhim.SelectedValue;
                        bp.GiaBan = (int)numGiaBan.Value;
                        bp.SoLuong = (int)numSoLuong.Value;

                        // Cập nhật ảnh nếu có thay đổi ImageLocation
                        if (!string.IsNullOrEmpty(picHinhAnh.ImageLocation))
                        {
                            bp.HinhAnh = Path.GetFileName(picHinhAnh.ImageLocation);
                        }

                        context.BanPhim.Update(bp);
                        context.SaveChanges();
                        QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Cập nhật sản phẩm", $"Đã cập nhật thông tin bàn phím: {bp.TenBP}");
                    }
                }
                else
                {
                    string ten = txtTen.Text.Trim().ToLower();
                    string sw = txtLoaiSwitch.Text.Trim().ToLower();
                    int? hsxId = cboHSX.SelectedValue as int?;
                    int? loaiId = cboLoaiPhim.SelectedValue as int?;

                    // 1. Khởi tạo truy vấn
                    var query = context.BanPhim.AsQueryable();

                    // 2. Lọc theo các ô nhập liệu (ô nào có chữ/có chọn mới lọc)
                    if (!string.IsNullOrEmpty(ten))
                        query = query.Where(x => x.TenBP.ToLower().Contains(ten));

                    if (!string.IsNullOrEmpty(sw))
                        query = query.Where(x => x.LoaiSwitch.ToLower().Contains(sw));

                    if (cboHSX.SelectedIndex != -1)
                        query = query.Where(x => x.HangSanXuatID == hsxId);

                    if (cboLoaiPhim.SelectedIndex != -1)
                        query = query.Where(x => x.LoaiBanPhimID == loaiId);

                    // 3. Đổ dữ liệu vào class vàng DanhSachBanPhim
                    var ketQua = query.Select(r => new DanhSachBanPhim
                    {
                        ID = r.ID,
                        TenBP = r.TenBP,
                        LoaiSwitch = r.LoaiSwitch,
                        LoaiBanPhimID = r.LoaiBanPhimID,
                        TenLoaiBanPhim = r.LoaiBanPhim.TenLoai,
                        HangSanXuatID = r.HangSanXuatID,
                        TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                        SoLuong = r.SoLuong,
                        GiaBan = r.GiaBan,
                        HinhAnh = r.HinhAnh ?? "no_image.png"
                    }).ToList();

                    // 4. Làm mới BindingSource để Grid và các ô nhập liệu cập nhật theo kết quả
                    BindingSource bs = new BindingSource();
                    bs.DataSource = ketQua;
                    dataGridView.DataSource = bs;

                    // Reset lại Binding cho các control (để click dòng nào hiện dòng đó)
                    txtTen.DataBindings.Clear();
                    txtTen.DataBindings.Add("Text", bs, "TenBP", true, DataSourceUpdateMode.Never);

                    txtLoaiSwitch.DataBindings.Clear();
                    txtLoaiSwitch.DataBindings.Add("Text", bs, "LoaiSwitch", true, DataSourceUpdateMode.Never);

                    cboLoaiPhim.DataBindings.Clear();
                    cboLoaiPhim.DataBindings.Add("SelectedValue", bs, "LoaiBanPhimID", true, DataSourceUpdateMode.Never);

                    cboHSX.DataBindings.Clear();
                    cboHSX.DataBindings.Add("SelectedValue", bs, "HangSanXuatID", true, DataSourceUpdateMode.Never);

                    numSoLuong.DataBindings.Clear();
                    numSoLuong.DataBindings.Add("Value", bs, "SoLuong", true, DataSourceUpdateMode.Never);

                    numGiaBan.DataBindings.Clear();
                    numGiaBan.DataBindings.Add("Value", bs, "GiaBan", true, DataSourceUpdateMode.Never);

                    // 5. Thông báo kết quả
                    if (ketQua.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy bàn phím nào!", "Thông báo");
                        picHinhAnh.Image = null;
                    }
                    return;
                }
                frmBanPhim_Load(sender, e);
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmBanPhim_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Cập nhật hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.JFIF";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                string safeName = fileName.GenerateSlug() + ext;
                string fileSavePath = Path.Combine(imagesFolder, safeName);

                // QUAN TRỌNG: Bắt PictureBox nhả ảnh ra để không bị khóa
                if (picHinhAnh.Image != null)
                {
                    picHinhAnh.Image.Dispose();
                    picHinhAnh.Image = null;
                }

                try
                {
                    // Bây giờ Copy thoải mái, kể cả trùng tên
                    File.Copy(openFileDialog.FileName, fileSavePath, true);

                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                    BanPhim bp = context.BanPhim.Find(id);
                    bp.HinhAnh = safeName;
                    context.BanPhim.Update(bp);
                    context.SaveChanges();
                    frmBanPhim_Load(sender, e);
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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
                            int count = 0;
                            foreach (DataRow r in table.Rows)
                            {
                                // 1. Lấy dữ liệu thô từ Excel
                                string tenBP = r["Tên bàn phím"].ToString();
                                string tenLoai = r["Loại bàn phím"].ToString();
                                string tenHSX = r["Hãng sản xuất"].ToString();
                                string sw = r["Tên loại switch"].ToString();
                                int soLuong = int.TryParse(r["Số lượng"].ToString(), out int sl) ? sl : 0;
                                int giaBan = int.TryParse(r["Đơn giá"].ToString(), out int gb) ? gb : 0;
                                string hinhAnh = r["Hình ảnh"].ToString() ?? "no_image.png";

                                if (string.IsNullOrEmpty(tenBP)) continue; // Bỏ qua dòng trống tên

                                // 2. Xử lý Loại bàn phím (Tìm hoặc Tạo mới)
                                var loai = context.LoaiBanPhims.FirstOrDefault(x => x.TenLoai == tenLoai);
                                if (loai == null && !string.IsNullOrEmpty(tenLoai))
                                {
                                    loai = new LoaiBanPhim { TenLoai = tenLoai };
                                    context.LoaiBanPhims.Add(loai);
                                    context.SaveChanges(); // Lưu để lấy ID
                                }

                                // 3. Xử lý Hãng sản xuất (Tìm hoặc Tạo mới)
                                var hsx = context.HangSanXuat.FirstOrDefault(x => x.TenHangSanXuat == tenHSX);
                                if (hsx == null && !string.IsNullOrEmpty(tenHSX))
                                {
                                    hsx = new HangSanXuat { TenHangSanXuat = tenHSX };
                                    context.HangSanXuat.Add(hsx);
                                    context.SaveChanges(); // Lưu để lấy ID
                                }

                                // 4. Tạo đối tượng Bàn phím
                                BanPhim bp = new BanPhim
                                {
                                    TenBP = tenBP,
                                    LoaiSwitch = sw,
                                    SoLuong = soLuong,
                                    GiaBan = giaBan,
                                    HinhAnh = hinhAnh,
                                    LoaiBanPhimID = loai?.ID ?? 1, // Mặc định ID 1 nếu không có loại
                                    HangSanXuatID = hsx?.ID ?? 1  // Mặc định ID 1 nếu không có hãng
                                };

                                context.BanPhim.Add(bp);
                                count++;
                            }

                            context.SaveChanges();
                            QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Nhập Excel", $"Đã nhập thành công {count} sản phẩm từ file Excel.");
                            MessageBox.Show($"Đã nhập thành công {count} sản phẩm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmBanPhim_Load(sender, e);
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
            saveFileDialog.FileName = "Banphim_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[8] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("Tên bàn phím", typeof(string)),
                    new DataColumn("Loại bàn phím", typeof(string)),
                    new DataColumn("Tên loại switch", typeof(string)),
                    new DataColumn("Hãng sản xuất", typeof(string)),
                    new DataColumn("Số lượng", typeof(int)),
                    new DataColumn("Đơn giá", typeof(int)),
                    new DataColumn("Hình ảnh", typeof(string))
                    });
                    var bp = context.BanPhim.ToList();
                    if(bp != null)
                    {
                        foreach (var r in bp)
                        {
                            table.Rows.Add(r.ID, r.TenBP, r.LoaiBanPhim.TenLoai, r.LoaiSwitch, r.HangSanXuat.TenHangSanXuat, r.SoLuong, r.GiaBan, r.HinhAnh);
                        }
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "BanPhim");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        QLBP.SERVICES.LogService.LogInfo(currentUser?.HoVaTen ?? "Hệ thống", "Xuất Excel", $"Đã xuất danh sách bàn phím ra file Excel.");
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
