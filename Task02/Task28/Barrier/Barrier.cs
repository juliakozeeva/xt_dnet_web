using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public abstract class Barrier : Point
    {
        protected bool obstruction;

        public Barrier(int x, int y) : base(x, y)
        {
        }
    }
}
