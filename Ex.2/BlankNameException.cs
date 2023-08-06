using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ.Ex._2
{
    public class BlankNameException : Exception
    {
        public BlankNameException(string message) : base(message)
        {

        }

        public static void BlankNameExceptionMethod()
        {
            List<string> names = new List<string>();
            Console.WriteLine("Enter names (type 'done' to finish) : ");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "done")
                {
                    break;
                }

                names.Add(input);
            }

            foreach (string name in names)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new BlankNameException("Blank name found. Please provide a valid name.");
                }
                else
                {
                    Console.WriteLine($"Valid name: '{name}'");
                }

            }

        }
    }
}

