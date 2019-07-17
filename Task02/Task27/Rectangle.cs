using System;
using System.Collections.Generic;
using System.Text;

namespace Task27
{
    public class Rectangle : Shape
    {
        private int a;

        public int A
        {
            get => a;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше либо равно 0.");
                a = value;
            }
        }

        private int b;

        public int B
        {
            get => b;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона прямоугольника не может быть меньше либо равно 0.");
                b = value;
            }
        }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public int GetArea()
        {
            return a * b;
        }
        public int GetPerimeter()
        {
            return 2 * (a + b);
        }

        public override void Draw(string figureType)
        {
            base.Draw(figureType);
            Console.WriteLine("Сторона a = {0} , b = {1}, площадь = {2}, периметр = {3} ", a, b, GetArea(), GetPerimeter());
            Console.WriteLine();
        }
    }
}
