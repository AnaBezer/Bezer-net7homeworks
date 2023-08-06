using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ.Ex._1
{
    public class InvalidDateException : Exception
    {
        public InvalidDateException(string? message) : base(message)
        {

        }

        public static void InvalidDateExceptionMethod()
        {
            try
            {
                Console.Write("Enter a date (yyyy-MM-dd): ");

                if (DateTime.TryParse(Console.ReadLine(), out DateTime inputDate))
                {
                    if (inputDate < DateTime.Now)
                    {
                        throw new InvalidDateException("Invalid date. Date cannot be in the past.");
                    }
                    else
                    {
                        Console.WriteLine("Valid date.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format.");
                }
            }
            catch (InvalidDateException ex)
            {
                Console.WriteLine("InvalidDateException: " + ex.Message);
            }

        }


    }
}




