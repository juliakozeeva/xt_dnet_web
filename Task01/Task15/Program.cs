using System;

namespace Task15
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            isSum();
            Console.ReadLine();
        }

        static void isSum()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    result += i;
            }
            Console.WriteLine($"Cумма всех чисел меньше 1000, кратных 3 или 5 = {result}");
        }
    }
}
