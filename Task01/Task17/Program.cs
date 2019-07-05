using System;

namespace Task17
{
    class ArrayProcessing
    {
        static void Main(string[] args)
        {
            CreateArray();            
            Console.ReadLine();
        }

        static void CreateArray()
        {
            int[] array = new int[10];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
            }
            Console.Write("Массив до сортировки: ");
            PrintArray(array);
            Console.WriteLine();
            MaxMinValue(array);
            Console.Write("Массив после сортировки: ");
            ArraySort(array);            
        }

        static void MaxMinValue (int[] arr)
        {
            int max = 0;
            int min = 100;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Максимальное значение в массиве: {max} \nМинимальное значение в массиве: {min}");
                                
        }

        static void ArraySort(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }                   

                }
            }
            
            PrintArray(arr);
        }

        static void PrintArray (int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}

