using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Cherry : Bonus
    {
        public override void Affect(Player player)
        {
            player.Health++;
        }

        public Cherry(int x, int y) : base(x, y)
        {
        }
    }
}
