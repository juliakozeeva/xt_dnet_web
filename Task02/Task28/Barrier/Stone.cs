using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Stone : Barrier
    {
        public Stone(int x, int y) : base(x, y)
        {
            obstruction = false;
        }
    }
}
