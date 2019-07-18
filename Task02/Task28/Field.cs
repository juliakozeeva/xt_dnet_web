using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Field
    {
        private int width;

        public int Width
        {
            get => width;
            set { width = value; }
        }
        private int height;

        public int Height
        {
            get => height;
            set { height = value; }
        }

        public Field(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
