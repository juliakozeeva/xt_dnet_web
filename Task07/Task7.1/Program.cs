using System;
using System.Text.RegularExpressions;

namespace Task7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text containing a date in the format dd-mm-yyyy:");
            string inputText = Console.ReadLine();
            if (CheckInputDateValue(inputText))
            {
                Console.WriteLine($"The text '{inputText}' contains the date.");
            }
            else
            {
                Console.WriteLine($"There is no date in text: '{inputText}'");
            }

            Console.ReadLine();
        }

        public static bool CheckInputDateValue(string input)
        {
            Regex regex = new Regex(@"((0[1-9]|[1-2]\d|3[0-1])-(0[1-9]|1[0-2])-[1-2]\d{3})");
            if (regex.IsMatch(input))
                return true;
            return false;
        }
    }
}
