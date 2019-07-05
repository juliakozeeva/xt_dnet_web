using System;

namespace Task11
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            inputCheck();
            Console.ReadLine();
        }

        static void inputCheck()
        {
            bool repeat = true;

            while (repeat)
            {
                Console.WriteLine("Введите два целых положительных числа, для определения площади прямоугольника.");
                Console.Write("A: ");
                string inputA = Console.ReadLine();
                if (!int.TryParse(inputA, out int a))
                {
                    isNotInt();
                }
                else
                {
                    if (a <= 0)
                    {
                        Break();
                    }
                    else
                    {
                        Console.Write("B: ");
                        string inputB = Console.ReadLine();
                        if (!int.TryParse(inputB, out int b))
                        {
                            isNotInt();
                        }
                        else
                        {
                            if (b <= 0)
                            {
                                Break();

                            }
                            else
                            {
                                repeat = false;
                                Console.WriteLine(isRectangleArea(a, b));
                            }
                                
                        }
                    }
                }
            }

        }

        static void Break ()
        {
            Console.WriteLine("Вы ввели отрицательное число или 0. Повторите ввод.");
            Console.WriteLine();
        }

        static void isNotInt ()
        {
            Console.Clear();
            Console.WriteLine("Вы ввели строку или нецелое число. Повторите ввод.");
            Console.WriteLine();
        }

        static string isRectangleArea(int x, int y)
        {
            var result = "Площадь прямоугольника = " + x * y;

            return result; 
        }
    }
}
