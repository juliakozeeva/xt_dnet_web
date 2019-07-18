using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Bear : Monster
    {
        Random r = new Random();
        public Bear(int x, int y) : base(x, y, atack: 4, speed: 2, health: 6)
        {
        }
    }
}
