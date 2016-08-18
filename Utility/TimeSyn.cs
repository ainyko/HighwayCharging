using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;//DLL IMPORT

namespace Utility
{
    public class TimeSyn
    {
        [DllImport("kernel32.dll")]
        //[DllImport("coredll.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Auto)]
        public static extern bool SetLocalTime(ref SYSTEMTIME time);

        /// <summary>
        /// 设置系统时间类
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;

            public void FromDateTime(DateTime dateTime)
            {
                wYear = (ushort)dateTime.Year;
                wMonth = (ushort)dateTime.Month;
                wDayOfWeek = (ushort)dateTime.DayOfWeek;
                wDay = (ushort)dateTime.Day;
                wHour = (ushort)dateTime.Hour;
                wMinute = (ushort)dateTime.Minute;
                wSecond = (ushort)dateTime.Second;
                wMilliseconds = (ushort)dateTime.Millisecond;
            }

            public DateTime ToDateTime()
            {
                return new DateTime(wYear, wMonth, wDay, wHour, wMinute, wSecond);
            }
        }
        /// <summary>
        /// 设置系统时间
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public bool SetDate(DateTime time)
        {
            bool bRet;
            SYSTEMTIME st = new SYSTEMTIME();
            st.FromDateTime(time);
            bRet = SetLocalTime(ref st);
            return bRet;
        }
    }
}
