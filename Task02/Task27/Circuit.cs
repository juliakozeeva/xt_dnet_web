using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Task27
{
    public class Circuit : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        private double r;

        public double Radius
        {
            get => r;

            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else throw new ArgumentException("Недопустимое значение радиуса.");
            }
        }
        private const double PI = Math.PI;
        public Circuit(int x, int y, double r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public double GetLength() => 2 * PI * Radius;
        public override void Draw(string figureType)
        {
            base.Draw(figureType);
            Console.WriteLine("Точка х = {0} , у = {1}, радиус = {2}, длина = {3} ",
                X, Y, r, Round(GetLength(), 2));
            Console.WriteLine();
        }
    }
}
