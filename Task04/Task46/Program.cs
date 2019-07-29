using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task46
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ShowMethods();
        }

        public static void ShowMethods ()
        {
            Console.WriteLine("Methods for finding the maximum element in the array.");

            int[] myArray =  { -5, 6, 8, -19, -100};
            foreach (var item in myArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var max1 = Maximum(myArray);
            Console.WriteLine($"The method that directly implements the search. Max = {max1}");

            Func<int, int, bool> func = IsMaxNumber;
            var max2 = MaximumDelegateMethod(myArray, func);
            Console.WriteLine($"The method to which the search condition is passed through a delegate instance. Max = {max2}");

            var max3 = MaximumDelegateMethod(myArray, delegate (int max, int item)
            {
                return max.CompareTo(item) < 0;
            });
            Console.WriteLine($"The method to which the search condition is passed through the delegate as an anonymous method. Max = {max3}");

            var max4 = MaximumDelegateMethod(myArray, ( max,  item ) => max.CompareTo(item) < 0);
            Console.WriteLine($"The method to which the search condition is passed through the delegate in the form of a lambda expression. Max = {max4}");

            var max5 = myArray.Max();
            Console.WriteLine($"LINQ expression. Max = {max5}");

        }
        public static T Maximum<T>(IEnumerable<T> collection) where T : IComparable<T>
        {
            T max = collection.First();
            foreach (T item in collection.Skip(1))
            {
                if (max.CompareTo(item) < 0)
                    max = item;
            }
            return max;
        }
        public static bool IsMaxNumber<T>(T max, T item) where T : IComparable<T>
        {
            if (max.CompareTo(item) < 0)
                return true;
            return false;
        }
        public static T MaximumDelegateMethod<T>(IEnumerable<T> collection, Func<T, T, bool> myDelegate) where T : IComparable<T>
        {
            if (myDelegate == null)
            {
                throw new ArgumentNullException("Empty condition delegate.");
            }
            T max = collection.First();
            foreach (T item in collection.Skip(1))
            {
                if (myDelegate.Invoke(max, item))
                    max = item;
            }
            return max;
        }
    }
}
