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
            base.Draw(figureType);
            Console.WriteLine($"площадь = {Round(GetArea(), 2)}");
            Console.WriteLine();
        }
    }
}
