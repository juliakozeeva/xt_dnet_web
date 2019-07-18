using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public abstract class Unit : Point
    {
        protected int speed;

        public int Speed
        {
            get => speed;
            set { speed = value; }
        }

        protected int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        protected int atack;

        public int Atack
        {
            get { return atack; }
            set { atack = value; }
        }

        public Unit(int x, int y) : base(x, y)
        {

        }

        public Unit(int x, int y, int speed, int health, int atack) : base(x, y)
        {
            Speed = speed;
            Health = health;
            Atack = atack;
        }

    }
}
