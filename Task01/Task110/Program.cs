using System;

namespace Task110
{
    class Array2D
    {
        static void Main(string[] args)
        {
            CreateArray();

            Console.ReadLine();
        }

        static void CreateArray()
        {
            int[,] array = new int[5, 6];
            Random r = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(30);
                }
            }

            ShowArray(array);
            isSumOfElements(array);
        }
        static void ShowArray(int[,] arr)
        {
            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }            
        }

        static void isSumOfElements(int[,] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            Console.WriteLine($"Сумма элементов массива, стоящих на чётных позициях {sum}");
        }
    }
}
