using System;
using System.Collections;
using System.Collections.Generic;

namespace Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое натуральное число: ");
            bool input = int.TryParse(Console.ReadLine(), out int num);
            if (input && num > 0)
                Lost(num);
            else
                Console.WriteLine("Повторите ввод.");
        }

        public static void Lost(int num)
        {
            ArrayList array = new ArrayList(num);
            for (int i = 1; i <= num; i++)
            {
                array.Add(i);
                Console.Write(array[i - 1] + " ");
            }
            Console.WriteLine();
            int index = 1;
            while (array.Count != 1)
            {
                array.RemoveAt(index);
                index++;

                if (index > array.Count)
                {
                    index = 1;
                }
                if (index == array.Count)
                {
                    index = 0;
                }
                for (int i = 0; i < array.Count; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();

            }
        }

    }

}
