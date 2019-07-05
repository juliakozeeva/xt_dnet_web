using System;

namespace Task111
{
    class AverageStringLength
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фразу: ");
            string inputPhrase = Console.ReadLine();
            int averageLength = isAverageStringLength(inputPhrase);
            Console.WriteLine($"Средняя длина слов в строке = {averageLength}");
        }

        static int isAverageStringLength(string str)
        {
            char[] delimiterChars = { ',', '.', ':', '\t', '!', '?', ':', ';', '"', '-', ' '};
            string[] wordsArray = str.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < wordsArray.Length; i++)
            {
                count += wordsArray[i].Length;
            }
            int result = count / wordsArray.Length;
            return result;
        }
    }
}

