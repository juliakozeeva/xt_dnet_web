using System;
using System.Collections.Generic;
using System.Linq;

namespace Task44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 5, 6, 8, 10};
            var sum = numArray.ArraySum((t1, t2) => t1 + t2);
            Console.WriteLine(sum);
        }

  }
    public static class Extensions
    {
        public static T ArraySum<T>(this T[] collection, Func<T, T, T> Sum) where T:IComparable<T> 
        {
            T sum = collection.First();
            foreach (T item in collection.Skip(1))
            {
                sum = Sum(sum, item);             
            }
            return sum;
        }
    }
}
