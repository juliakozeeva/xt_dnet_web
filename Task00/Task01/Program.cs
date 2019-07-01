using System;

namespace Task01
{
    class Simple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число больше 0:");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                isSequence(N);
            }
            else
            {
                Console.WriteLine("Ввод некорректный. Повторите ввод.");
            }

            Console.ReadLine();
        }

        static void isSequence(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Ввод некорректный. Повторите ввод.");
            }
            else
            {
                string result = "";
                for (int i = 1; i <= n; i++)
                {
                    result += i + ", ";
                }
                Console.WriteLine(result.Remove(result.Length - 2, 1));
            }
        }
    }
}
