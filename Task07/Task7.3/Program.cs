using System;
using System.Text.RegularExpressions;

namespace Task7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            PrintEmail(Console.ReadLine());
            Console.ReadLine();
        }
        public static void PrintEmail (string input)
        {
            Regex regex = new Regex(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9-]+[\.a-zA-Z]+[\.a-zA-Z]{2,6})");
            MatchCollection matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                Console.WriteLine("Email addresses found:");
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
        }
    }
}
