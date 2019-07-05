using System;

namespace Task19
{
    class NonNegativeSum
    {
        static void Main(string[] args)
        {
            CreateArray();
            Console.ReadLine();
        }

        static void CreateArray()
        {
            double[] array = new double[15];
            Random r = new Random();
            Console.Write("Инициализация массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-15, 15) / 10.0;
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            isNonNegativeSum(array);            
        }

        static void isNonNegativeSum (double[] massiv)
        {
            double sum = 0;
            for (int i = 0; i < massiv.Length; i++)
            {
                if (massiv[i] > 0)
                {
                    sum += massiv[i];
                }
            }
            Console.WriteLine($"Сумма всех положительных чисел массива = {sum}");
        }
    }
}
