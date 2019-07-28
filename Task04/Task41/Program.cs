using System;
using System.Collections.Generic;

namespace Task41
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new [] { 5.5, -5.6, 18.9, 0, 5.6 };
            CustomSort(myArray, (t1, t2) => t1 > t2);
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
        }

        public static void CustomSort<T> (T[] arr, Func<T, T, bool> compare)
        {
            if (compare == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare(arr[i], arr[j]))
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }

}
