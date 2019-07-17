using System;
using System.Collections.Generic;
using System.Text;

namespace Task22
{
    public class Triangle
    {
        private int a;

        public int A
        {
            get => a;
            set => a = value;
        }

        private int b;

        public int B
        {
            get => b;
            set => b = value;
        }

        private int c;

        public int C
        {
            get => c;
            set => c = value;
        }


        public double TriangleArea()
        {
            int p = a + b + c;
            double semiP = p / 2;
            return Math.Sqrt(semiP * (semiP - a) * (semiP - b) * (semiP - c));
        }

        public int TrianglePerimeter()
        {
            return a + b + c;
        }

        public Triangle(int x, int y, int z)
        {
            if ((x < y + z) & (y < x + z) & (z < x + y))
            {
                if (x > 0)
                {
                    A = x;
                }

                if (y > 0)
                {
                    B = y;
                }

                if (z > 0)
                {
                    C = z;
                }
            }
            else
            {
                A = B = C = 0;
                throw new ArgumentException("Треугольник с такими сторонами не существует!");
            }
        }
    }
}
