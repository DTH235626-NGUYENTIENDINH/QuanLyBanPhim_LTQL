using QLBP.DATA;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Vòng lặp đăng nhập - đăng xuất
            while (true)
            {
                using (var frmDangNhap = new QLBP.FORM.DangNhap())
                {
                    if (frmDangNhap.ShowDialog() == DialogResult.OK)
                    {
                        // Đăng nhập thành công → mở Main form
                        var frmMain = new QLBP.FORM.frmMain(frmDangNhap.NhanVienDangNhap);
                        Application.Run(frmMain);

                        // Nếu Main form đóng do đăng xuất → lặp lại
                        if (!frmMain.DaDangXuat)
                            break; // Thoát hẳn ứng dụng
                        // else: quay lại vòng lặp → hiện form đăng nhập
                    }
                    else
                    {
                        // Nhấn Thoát ở form đăng nhập → thoát ứng dụng
                        break;
                    }
                }
            }
        }
    }
}