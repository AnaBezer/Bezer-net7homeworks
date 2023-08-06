using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ.Ex._3
{
    public class ExceptionsEx3 : Exception
    {
        public ExceptionsEx3(string message) : base(message)
        {

        }

        public static void ExceptionsMethod()
        {
            Console.WriteLine("Enter a list of numbers (separated by spaces): ");
            string input = Console.ReadLine();

            List<int> convertedList = new List<int>();

            try
            {
                char[] separators = { ' ' };
                string[] splittedInput = input.Split(separators);


                foreach (string s in splittedInput)
                {
                    int converted = Convert.ToInt32(s);
                    convertedList.Add(converted);
                }

                int sum = convertedList.Sum();
                double averageNumber = convertedList.Average();

                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("Average Number: " + averageNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Unable to convert to an integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too large or too small.");
            }
            catch (DivideByZeroException)
            {
                //will never handle this exception because FormatException will override it. 
            }

        }
    }
}
