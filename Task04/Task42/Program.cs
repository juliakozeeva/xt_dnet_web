using System;
using System.Collections.Generic;
using System.Linq;

namespace Task41
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            var myStringArray = new[] {  "b", "a", "two", "eleven", "four", "one", "chick", "check", "run", "ran", "a" };
            Func<string, string, bool> compare = CompareMethod;
            CustomSort<string>(myStringArray, CompareMethod);
            PrintArray(myStringArray);
        }

        public static bool CompareMethod(string firstStr, string secondStr)
        {
            if (firstStr.Length == secondStr.Length && firstStr.Length == 1)
                return true;
            if (firstStr.Length == secondStr.Length)
            {
                if (firstStr[0] > secondStr[0])
                    return false;
                for (int i = 1; i < firstStr.Length; i++)
                {
                    if (firstStr[i] > secondStr[i])
                        return true;
                }
            }
            if (firstStr.Length > secondStr.Length)
                return true;
            return false;
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

        public static void PrintArray<T>(T[] sortArr)
        {
            for (int i = 0; i < sortArr.Length; i++)
            {
                Console.Write(sortArr[i] + " ");
            }
        }
    }

}
