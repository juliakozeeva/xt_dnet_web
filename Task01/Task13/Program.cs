using System;

namespace Task13
{
    class anotherTriangle
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
                    isAnotherTriangle(N);
                }
                else
                {
                    Console.WriteLine("Ввод некорректный. Повторите ввод.");
                    Console.WriteLine();
                }
            }

        }
        static void isAnotherTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < n + i; j++)
                {
                    if (j <= n - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
