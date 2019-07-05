using System;

namespace Task12
{
    class Triangle
    {
        static void Main(string[] args)
        {
            inputCheck();
            Console.ReadLine();
        }

        static void inputCheck()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Введите положительное целое число: ");
                bool input = int.TryParse(Console.ReadLine(), out int N);
                if (N > 0)
                {
                    repeat = false;
                    isTriangle(N);
                }
                else
                {
                    Console.WriteLine("Ввод некорректный. Повторите ввод.");
                    Console.WriteLine();
                }
            }

        }
        
        static void isTriangle (int n)
        {
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
