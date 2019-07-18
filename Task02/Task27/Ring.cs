using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace Task27
{
    public class Ring : Circuit
    {
        //public int X { get; set; }
        //public int Y { get; set; }

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

        public Ring(int x, int y, double r, double innerR) : base(x, y, r)
        {
            if (r < innerR)
                throw new ArgumentException("Внешний радиус должен быть больше внутреннего.");
            X = x;
            Y = y;
            OuterR = new Round(x, y, r);
            InnerR = new Round(x, y, innerR);
        }


        public double GetArea()
        {
            return OuterR.GetArea() - InnerR.GetArea();
        }

        public override double GetLength()
        {
            return OuterR.GetArea() + InnerR.GetArea();
        }

        public override void Draw(string figureType)
        {
            Console.WriteLine("Тип фигуры \"{0}\". Точка х = {1} , у = {2}, внешний радиус = {3}, внутрениий радиус = {4}," +
             " площадь = {5}, длина = {6} ", figureType, X, Y, OuterR.Radius, InnerR.Radius, Round(GetArea(), 2), Round(GetLength(), 2));
            Console.WriteLine();
        }
    }
}
