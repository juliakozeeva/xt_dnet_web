using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Task27
{
    public class Ring : Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        Round outerR;

        public Round OuterR
        {
            get => outerR;
            set => outerR = value ?? throw new ArgumentNullException();
        }

        Round innerR;

        public Round InnerR
        {
            get => innerR;
            set => innerR = value ?? throw new ArgumentNullException();
        }

        public Ring(int x, int y, double outerR, double innerR)
        {
            if (outerR < innerR)
                throw new ArgumentException("Внешний радиус должен быть больше внутреннего.");
            X = x;
            Y = y;
            OuterR = new Round(x, y, outerR);
            InnerR = new Round(x, y, innerR);
        }


        public double GetArea()
        {
            return OuterR.GetArea() - InnerR.GetArea();
        }

        public double GetLength()
        {
            return OuterR.GetArea() + InnerR.GetArea();
        }

        public override void Draw(string figureType)
        {
            base.Draw(figureType);
            Console.WriteLine("Точка х = {0} , у = {1}, внешний радиус = {2}, внутрениий радиус = {3}," +
                " площадь = {4}, длина = {5} ", X, Y, OuterR.Radius, InnerR.Radius, Round(GetArea(), 2), Round(GetLength(), 2));
            Console.WriteLine();
        }
    }
}
