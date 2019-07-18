using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Wolf : Monster
    {
        Random r = new Random();
        public Wolf(int x, int y) : base(x, y, atack: 2, speed: 4, health: 5)
        {
        }
    }
}
