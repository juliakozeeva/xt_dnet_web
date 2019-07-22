using System;
using System.Collections.Generic;
using System.Linq;

namespace Task32
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите текст ");

            string text = Console.ReadLine();

            WordFrequency(text);

            Console.ReadKey();
        }

        public static void WordFrequency(string text)
        {

            List<string> list = new List<string>();

            String[] words = text.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                list.Add(words[i].ToLower());
            }


            List<string> set = new List<string>(list.Distinct());

            for (int i = 0; i < set.Count; i++)
            {
                int count = 0;

                for (int j = 0; j < list.Count; j++)
                {
                    if (set[i].Equals(list[j]))
                    {
                        count++;
                    }
                }
               Console.WriteLine("Слово {0} \tвстречается {1} раз(а)", set[i], count);
            }
        }
    }
}