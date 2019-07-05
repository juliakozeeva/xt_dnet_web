using System;

namespace Task16
{
    class FontAdjustment
    {
        static void Main(string[] args)
        {
            Show();
            Console.ReadLine();
        }

        static void Show()
        {
            bool bold = false;
            bool italic = false;
            bool underline = false;

            while (true)
            {
                string res = "";
                if (bold)
                {
                    res += "Bold, ";
                }
                if (italic)
                {
                    res += "Italic, ";
                }
                if (underline)
                {
                    res += "Underline, ";
                }
                if (bold || italic || underline)
                {
                    selectFont(res.Remove(res.Length - 2));
                }
                else
                {
                    res = "None";
                    selectFont(res);
                }
                
                bool input = int.TryParse(Console.ReadLine(), out int n);
                if (n == 1)
                {
                    if (bold)
                    {
                        bold = false;
                    }
                    else
                    {
                        bold = true;
                    }
                }
                if (n == 2)
                {
                    if (italic)
                    {
                        italic = false;
                    }
                    else
                    {
                        italic = true;
                    }
                }
                if (n == 3)
                {
                    if (underline)
                    {
                        underline = false;
                    }
                    else
                    {
                        underline = true;
                    }
                }
                else if (n <= 0 || n > 4)
                {
                    Console.WriteLine("Некорректный ввод. Введите номер шрифта.");
                    Console.WriteLine();
                }
            }
        }

        static void selectFont (string res)
        {
            Console.WriteLine($"Параметры надписи: {res}");
            Console.WriteLine("Введите:");
            string[] fonts = { "1 : Bold", "2 : Italic", "3 : Underline" };
            foreach (string i in fonts)
            {
                Console.WriteLine($"\t{i}");
            }
        }
    }
}

