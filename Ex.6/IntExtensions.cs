using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ.Ex._6
{
    public static class IntExtensions
    {
        public static string ToBinary(this int value)
        {
            return Convert.ToString(value, 2);
        }
    }

    public static class IntUse
    {

        public static void IntMethod()
        {
            int number = 5;
            string binaryString = number.ToBinary();

            Console.WriteLine("Binary representation: " + binaryString);
        }

    }
}
