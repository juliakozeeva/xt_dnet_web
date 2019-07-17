using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Task27
{
    public class Line : Shape
    {
        private int x1;

        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        private int x2;

        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        private int y1;

        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        private int y2;

        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        public Line(int x1, int x2, int y1, int y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }

        public double Length()
        {
            return Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));
        }

        public override void Draw(string figureType)
        {
            base.Draw(figureType);
            Console.WriteLine("Точка х1 = {0} , x2 = {1}, y1 = {2}, y2 = {3}, длина = {4} ", x1, x2, y1, y2, Round(Length(), 2));
            Console.WriteLine();
        }
    }
}
