using System;
using System.Collections.Generic;
using System.Threading;

namespace Task43
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArray = new[] { 5.5, -5.6, 18.9, 0, 5.6 };
            CustomSort(myArray, (t1, t2) => t1 > t2);
            Console.WriteLine("Main thread:");
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SortAsync(myArray, (t1, t2) => t1 > t2);
            SortingFinished += Message;
        }

        public static event Action<string> SortingFinished;
        public static void Message(string mes)
        {
            Console.WriteLine(mes);
        }

        public static void CustomSort<T>(T[] arr, Func<T, T, bool> compare)
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

        public static void SortAsync<T>(T[] arr, Func<T, T, bool> compare)
        {
            Thread[] threads = new Thread[4];
            for (int i = 0; i < 4; i++)
            {
                threads[i] = new Thread(() =>
                    {

                        Thread.Sleep(5000);
                        Console.WriteLine($"Starting Thread #{Thread.CurrentThread.ManagedThreadId}.\n Asynchronous array sorting: ");
                        CustomSort<T>(arr, compare);
                        PrintArray<T>(arr);
                        SortingFinished?.Invoke("Sorting Finished!");
                    });
            }
            foreach (Thread t in threads)
                t.Start();            
        }

        public static void PrintArray<T>(T[] sortArr)
        {
            for (int i = 0; i < sortArr.Length; i++)
            {
                Console.Write(sortArr[i] + " ");                
            }
            Console.WriteLine();
        }
    }

}
