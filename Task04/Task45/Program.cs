using System;

namespace Task45
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = "546568";
            var test = myString.IsNum();
            Console.WriteLine(test);
        }
    }
    public static class Extensions
    {
        public static bool IsNum(this string s)
        {
            if(!String.IsNullOrEmpty(s))
            {
                foreach (char ch in s)
                {
                    if (!char.IsDigit(ch) || ch == '.' || ch == ',')
                        return false;
                }
                return true;
            }
            return false;
        }
    }
}
