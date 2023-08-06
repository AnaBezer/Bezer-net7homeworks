using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ.Ex._5
{
    public static class DateTimeExtensions
    {

        public static string ToFullDateString(this DateTime dateTime)
        {
            return dateTime.ToString("M/d/yyyy H:mm:ss");
        }
    }

    public static class DateTimeUse
    {
        public static void DateTimeMethod()
        {
            DateTime now = DateTime.Now;
            string fullDateString = now.ToFullDateString();

            Console.WriteLine("Full Date String: " + fullDateString);
        }
    }
}



