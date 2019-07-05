using System;

namespace Task112
{
    class CharDoubler
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string secondInput = Console.ReadLine();
            string outputString = isCharDoubler(firstInput, secondInput);
            Console.WriteLine($"Результирующая строка: {outputString}");;

            Console.ReadLine();
        }

        static string isCharDoubler(string first, string second)
        {
            string result = "";
            foreach (char ch in first)
                if (second.Contains(ch))
                {
                    for (int i = 0; i < 2; i++)
                    {
                        result += ch;
                    }
                }
                else
                {
                    result += ch;
                }
            return result;
        }
    }
}
