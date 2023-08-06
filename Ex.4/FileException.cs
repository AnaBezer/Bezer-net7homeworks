using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ.Ex._4
{
    public class FileException : Exception
    {
        public FileException(string message) : base(message)
        {

        }

        public static void FileExceptionMethod()
        {
            //string fileAddress = "C:\\Users\\anell\\Desktop\\wantsome\\Homework\\Exceptions_LINQ_Homework\\5txt.txt";

            //try
            //{
            //    string fileText = File.ReadAllText(fileAddress);

            //    if (fileText == null)
            //    {
            //        Console.WriteLine("Enter some text: ");
            //        string userText = Console.ReadLine();
            //        File.WriteAllText(fileAddress, userText);
            //    }

            //    Console.WriteLine("File Content: " + fileText);


            //}
            //catch (FileNotFoundException)
            //{
            //    File.CreateText(fileAddress);
            //    Console.WriteLine("Enter some text: ");
            //    string userText = Console.ReadLine();
            //    File.WriteAllText(fileAddress, userText);

            try
            {
                Console.Write("Enter the name of a file: ");
                string fileName = Console.ReadLine();

                if (File.Exists(fileName))
                {
                    string fileContents = File.ReadAllText(fileName);
                    if (string.IsNullOrWhiteSpace(fileContents))
                    {
                        Console.WriteLine("File is empty.");
                        Console.Write("Enter some text to write to the file: ");
                        string newText = Console.ReadLine();
                        File.WriteAllText(fileName, newText);
                    }
                    else
                    {
                        Console.WriteLine("File contents:");
                        Console.WriteLine(fileContents);
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                    Console.Write("Enter some text to write to the file: ");
                    string newText = Console.ReadLine();
                    File.WriteAllText(fileName, newText);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException: " + ex.Message);
            }
        }
    }
}



