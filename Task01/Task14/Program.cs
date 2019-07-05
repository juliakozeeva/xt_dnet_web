using System;

namespace Task14
{
    class XMasTree
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
                    isXMasTree(N);
                }
                else
                {
                    Console.WriteLine("Ввод некорректный. Повторите ввод.");
                    Console.WriteLine();
                }
            }
        }
        static void isXMasTree(int n)
        {
            for (int i = 0; i <= n + 2; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    for (int k = 0; k < n + j; k++)
                    {
                        if (k <= n - j)
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
}

