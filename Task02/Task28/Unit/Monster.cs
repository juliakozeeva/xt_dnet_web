using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public abstract class Monster : Unit
    {
        Random r = new Random();

        public Monster(int x, int y, int atack, int speed, int health) : base(x, y)
        {
            Atack = atack;
            Speed = speed;
            Health = health;
        }
    }
}
