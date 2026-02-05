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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new QLBP.FORM.frmLoaiBanPhim());
            //Application.Run(new QLBP.FORM.frmHangSanXuat());
            //Application.Run(new QLBP.FORM.frmKhachHang());
            //Application.Run(new QLBP.FORM.frmNhanVien());
            Application.Run(new QLBP.FORM.frmBanPhim());

        }
    }
}