using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    public class Player : Unit
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        Random r = new Random();
        public Player(int x, int y, string name) : base(x, y)
        {
            Name = name;
            Speed = r.Next(2, 5);
            Health = r.Next(5, 10);
            Atack = r.Next(5, 8);
        }

        /// <summary>
        /// w - to move up
        /// a - to move left
        /// s - to move down
        /// d - to move right
        /// </summary>
        public void Move(Field field, char s)
        {
            if (s == 'w')
            {
                if (Y + speed > field.Height - 1)
                    Y = field.Height - 1;
                else
                    Y += speed;
            }
            else if (s == 'a')
            {
                if (X - speed > 0)
                    X = 0;
                else
                    X -= - speed;
            }
            else if (s == 's')
            {
                if (Y - speed < 0)
                    Y = 0;
                else
                    Y -= speed;
            }
            else if (s == 'd')
            {
                if (X + speed > field.Width - 1)
                    X = field.Width - 1;
                else
                    X += speed;
            }
        }
    }
}
