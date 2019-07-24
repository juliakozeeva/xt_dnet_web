using System;
using System.Collections;
using System.Collections.Generic;

namespace Task33
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dynamicArray = new DynamicArray<int>() { 1, 2, 3 };
            Console.WriteLine("Первоначальная инициализация массива: ");
            foreach (int item in dynamicArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Length = {dynamicArray.Length}");
            Console.WriteLine($"Capacity = {dynamicArray.Capacity}");
            Console.WriteLine();
            dynamicArray.Add(4);
            dynamicArray[0] = 5;
            List<int> newCollection = new List<int> { 5, 6, 7 };
            dynamicArray.AddRange(newCollection);
            Console.WriteLine("Использование индексатора [0] = 5, метода Add(4) и AddRange({ 5, 6, 7 }): ");
            foreach (int item in dynamicArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Length = {dynamicArray.Length}");
            Console.WriteLine($"Capacity = {dynamicArray.Capacity}");
            Console.WriteLine();
            dynamicArray.Remove(4);
            dynamicArray.Remove(6);
            Console.WriteLine("Использование метода Remove(4), Remove(6): ");
            foreach (int item in dynamicArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Length = {dynamicArray.Length}");
            Console.WriteLine($"Capacity = {dynamicArray.Capacity}");
            Console.WriteLine();
            Console.WriteLine();
            dynamicArray.Insert(10, 3);
            Console.WriteLine("Использование метода Insert(10, 3): ");
            foreach (int item in dynamicArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Length = {dynamicArray.Length}");
            Console.WriteLine($"Capacity = {dynamicArray.Capacity}");
            Console.ReadKey();
        }
    }    
}

