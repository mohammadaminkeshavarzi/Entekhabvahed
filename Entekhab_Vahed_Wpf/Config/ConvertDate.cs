using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entekhab_Vahed_Wpf.Config
{
    public static class ConvertDate
    {
        public static string GetPdate(this DateTime EnDate)
        {
            PersianCalendar pcalendar = new PersianCalendar();
            string Pdate = pcalendar.GetYear(EnDate).ToString("0000") + "/" +
               pcalendar.GetMonth(EnDate).ToString("00") + "/" +
               pcalendar.GetDayOfMonth(EnDate).ToString("00");

            return Pdate;
        }
        public static DateTime ConvertToGregorian(this string persianDateString)//1399/03/05
        {
            string[] persianDateParts = persianDateString.Split('/');
            int persianYear = int.Parse(persianDateParts[0]);
            int persianMonth = int.Parse(persianDateParts[1]);
            int persianDay = int.Parse(persianDateParts[2]);
            PersianCalendar pc = new PersianCalendar();
            DateTime date = new DateTime(persianYear, persianMonth, persianDay, pc);
            return date;

        }
    }
}
