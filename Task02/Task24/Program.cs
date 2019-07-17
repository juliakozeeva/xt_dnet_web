using System;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString str1 = new MyString("Инкапсуляция");
            MyString str2 = new MyString("Наследование");
            
            Console.WriteLine($"str1: {str1.StringProperty}");
            Console.WriteLine($"str2: {str2.StringProperty}");
            Console.WriteLine();
            Console.WriteLine("str1.IndexOf('н') = {0}", str1.IndexOf('н'));
            Console.WriteLine("str2.Contains('а') = {0}", str2.Contains('а'));
            Console.WriteLine("str2.StartsWith('Н') = {0}", str2.StartsWith('Н'));
            Console.WriteLine("str.Concat = {0}", str1.Concat(str2.StringProperty));
            Console.WriteLine("str.Equals = {0}", MyString.Equals(str1.StringProperty, str2.StringProperty));
            Console.WriteLine("str1.ToCharArray = {0}", str1.ToCharArray());
            Console.WriteLine("str2.Remove = {0}", str2.Remove(3));
            Console.ReadKey();
        }
    }    
}
