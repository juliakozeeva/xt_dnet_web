using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Task21
{
    public class Round
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
        public Round(int x, int y, double r)
        {
            X = x;
            Y = y;
            Radius = r;
        }

        public double AreaRound() => PI * Pow(Radius, 2);
        public double LengthRound() => 2 * PI * Radius;
    }
}
