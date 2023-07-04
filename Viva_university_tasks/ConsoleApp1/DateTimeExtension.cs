using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class DateTimeExension
    {
        public static string ToFriendlyDate(this DateTime date)
        {
            string month = date.ToString("MMMM") + ' ' + date.Day + ", " + date.Year;
            return month;
        }
    }
}
