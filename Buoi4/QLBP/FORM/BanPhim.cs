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
using System.IO;
using SlugGenerator;
namespace QLBP.FORM
{
    public partial class frmBanPhim : Form
    {
        public frmBanPhim()
        {
            InitializeComponent();
        }
        QLBPDbContext context = new QLBPDbContext();
        bool xuLyThem = false;
        bool xuLySua = false;
        int id;
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");

        private void batTatChucNang(bool giatri)
        {
            btnThem.Enabled = !giatri;
            btnSua.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
            btnTimKiem.Enabled = !giatri;

            btnLuu.Enabled = giatri;
            btnHuyBo.Enabled = giatri;
            btnDoiAnh.Enabled = !giatri;

            txtTen.Enabled = giatri;
            cboLoaiPhim.Enabled = giatri;
            txtLoaiSwitch.Enabled = giatri;
            cboHSX.Enabled = giatri;
            numGiaBan.Enabled = giatri;
            numSoLuong.Enabled = giatri;
            picHinhAnh.Enabled = giatri;
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
                    context.BanPhim.Remove(hsx);
                }
                context.SaveChanges();
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
    }
}
