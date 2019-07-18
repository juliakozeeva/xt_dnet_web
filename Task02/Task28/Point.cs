using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public abstract class Point
    {
        protected int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        protected int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
