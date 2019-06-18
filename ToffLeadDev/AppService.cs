using System;
using System.IO;
using System.Reflection;

namespace ToffLeadDev
{
    /*
     * Служебные методы для приложения в целом.
     */
    public class AppService
    {
        /*
         * Версия сборки.
         */
        public static string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /*
         * Дата сборки.
         */
        public static DateTime GetBuildDate()
        {
            string filePath = Assembly.GetCallingAssembly().Location;
            const int peHeaderOffset = 60;
            const int linkerTimestampOffset = 8;
            byte[] b = new byte[2048];

            using (Stream s = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                s.Read(b, 0, 2048);
            }

            int secondsSince1970 = BitConverter.ToInt32(b, BitConverter.ToInt32(b, peHeaderOffset) + linkerTimestampOffset);
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
            dt = dt.AddSeconds(secondsSince1970);
            dt = dt.AddHours(TimeZone.CurrentTimeZone.GetUtcOffset(dt).Hours);

            return dt;
        }

        private AppService() { }
    }
}
