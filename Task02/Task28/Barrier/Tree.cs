using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Tree : Barrier
    {
        public Tree(int x, int y) : base(x, y)
        {
            obstruction = true;
        }
    }
}
