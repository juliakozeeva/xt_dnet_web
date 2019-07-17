using System;
using static System.Math;

namespace Task27
{
    class Program
    {
        static void Main(string[] args)
        {
            ChooseFigure();

            Console.ReadKey();
        }

        static void ChooseFigure()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Создать новую фигуру:");
                string[] figureArr = new string[5] { "1: линия", "2: окружность", "3: прямоугольник", "4: круг", "5: кольцо" };
                foreach (var item in figureArr)
                {
                    Console.WriteLine($"\t{item}");
                }
                Console.Write("Выберите фигуру: ");
                bool input = int.TryParse(Console.ReadLine(), out int n);
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите значение координаты \"x1\" ");
                            int x1 = CheckInput();
                            Console.WriteLine("Введите значение координаты \"x2\" ");
                            int x2 = CheckInput();
                            Console.WriteLine("Введите значение координаты \"y1\" ");
                            int y1 = CheckInput();
                            Console.WriteLine("Введите значение координаты \"y2\" ");
                            int y2 = CheckInput();
                            Line line = new Line(x1, x2, y1, y2);
                            line.Draw("линия");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите значение координаты \"x\" ");
                            int x = CheckInput();
                            Console.WriteLine("Введите значение координаты \"y\" ");
                            int y = CheckInput();
                            Console.WriteLine("Введите значение радиуса \"r\" ");
                            int r = CheckInput();
                            Circuit circuit = new Circuit(x, y, r);
                            circuit.Draw("окружность");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите значение длины \"a\" ");
                            int a = CheckInput();
                            Console.WriteLine("Введите значение ширины \"b\" ");
                            int b = CheckInput();
                            Rectangle rectangle = new Rectangle(a, b);
                            rectangle.Draw("прямоугольник");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите значение координаты \"x\" ");
                            int x = CheckInput();
                            Console.WriteLine("Введите значение координаты \"y\" ");
                            int y = CheckInput();
                            Console.WriteLine("Введите значение радиуса \"r\" ");
                            int r = CheckInput();
                            Round round = new Round(x, y, r);
                            round.Draw("круг");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Введите значение координаты \"x\" ");
                            int x = CheckInput();
                            Console.WriteLine("Введите значение координаты \"y\" ");
                            int y = CheckInput();
                            Console.WriteLine("Введите значение внешнего радиуса \"rO\" ");
                            int rO = CheckInput();
                            Console.WriteLine("Введите значение внутреннего радиуса \"rI\" ");
                            int rI = CheckInput();
                            Ring ring = new Ring(x, y, rO, rI);
                            ring.Draw("кольцо");
                            break;
                        }
                    default:
                        Console.WriteLine("Введите число от 1 до 5.");
                        Console.WriteLine();
                        break;
                }                
            }

        }

        static int CheckInput ()
        {
            if (!int.TryParse(Console.ReadLine(), out int value))
                throw new ArgumentException("Введено неверное значение, повторите ввод.");
            else
                return value;
        }
    }
}
