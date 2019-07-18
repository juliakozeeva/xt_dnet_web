using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Apple : Bonus
    {
        public Apple(int x, int y) : base(x, y)
        {
        }
        public override void Affect(Player player)
        {
            player.Speed++;
        }
    }
}
