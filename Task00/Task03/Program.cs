using System;

namespace Task00
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое положительное нечетное число больше 2:");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                isSquare(N);
            }
            else
            {
                Console.WriteLine("Вы ввели не число. Повторите ввод.");
            }

            Console.ReadLine();
        }
        static void isSquare(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Число меньше либо равно 1. Повторите ввод.");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine("Число четное, повторите ввод.");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (i == n / 2)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (j == n / 2)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("*");
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write("*");
                        }
                    }

                    Console.WriteLine(" ");
                }

            }

        }
    }
}
