using System;

namespace Task02
{
    class Sequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое положительное целое число:");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                isSimple(N);
            }
            else
            {
                Console.WriteLine("Вы не ввели число. Повторите ввод.");
            }
            Console.ReadLine();
        }
        static void isSimple(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine("Числа меньше 1 простыми не являются. Повторите ввод.");
            }
            else if (n == 2)
            {
                Console.WriteLine($"Число {n} является простым.");
            }
            else if (n > 2)
            {
                for (int a = 2; a < n; a++)
                {
                    if (n % a == 0)
                    {
                        Console.WriteLine($"Число {n} является составным.");
                        return;
                    }

                }
                Console.WriteLine($"Число {n} является простым.");

            }
        }
    }
}
