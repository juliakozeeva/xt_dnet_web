using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Task27
{
    public class Round : Circuit
    {
        private const double PI = Math.PI;
        public Round(int x, int y, double r) : base(x, y, r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public double GetArea() => PI * Pow(Radius, 2);
        public override void Draw(string figureType)
        {
            Console.WriteLine("Тип фигуры \"{0}\". Точка х = {1} , у = {2}, радиус = {3}, длина = {4}, площадь {5}", figureType,
               X, Y, r, Round(GetLength(), 2), Round(GetArea(), 2));
            Console.WriteLine();
        }
    }
}
