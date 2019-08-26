using System;
using System.Text.RegularExpressions;

namespace Task7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text:");
            string inputText = Console.ReadLine();
            string outputText =TextReplacement(inputText);
            Console.WriteLine($"Result of replacement: {outputText}");
        }
        public static string TextReplacement (string input) => Regex.Replace(input, @"<(\/?[^>]+)>", "_");
    }
}
