using System;
using System.Threading.Tasks;
using QLBP.DATA;

namespace QLBP.SERVICES
{
    public static class LogService
    {
        public static void Log(string nguoiDung, string hanhDong, string noiDung, string loaiLog = "Info")
        {
            Task.Run(() =>
            {
                try
                {
                    using (var context = new QLBPDbContext())
                    {
                        var log = new Log
                        {
                            ThoiGian = DateTime.Now,
                            NguoiDung = nguoiDung,
                            HanhDong = hanhDong,
                            NoiDung = noiDung,
                            LoaiLog = loaiLog
                        };
                        context.Logs.Add(log);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    // Fail silently or log to a file if DB fails
                }
            });
        }

        public static void LogInfo(string nguoiDung, string hanhDong, string noiDung)
        {
            Log(nguoiDung, hanhDong, noiDung, "Info");
        }

        public static void LogWarning(string nguoiDung, string hanhDong, string noiDung)
        {
            Log(nguoiDung, hanhDong, noiDung, "Warning");
        }

        public static void LogError(string nguoiDung, string hanhDong, string noiDung)
        {
            Log(nguoiDung, hanhDong, noiDung, "Error");
        }
    }
}
