using System;
using System.Collections.Generic;
using System.Text;

namespace Task27
{
    public abstract class Shape
    {
        public virtual void Draw(string figureType)
        {
            Console.Write("Тип фигуры \"{0}\". ", figureType);
        }
    }
}
