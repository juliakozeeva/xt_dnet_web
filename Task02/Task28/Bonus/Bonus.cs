using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public abstract class Bonus : Point
    {
        public abstract void Affect(Player player);

        public Bonus(int x, int y) : base(x, y)
        {
        }
    }
}
