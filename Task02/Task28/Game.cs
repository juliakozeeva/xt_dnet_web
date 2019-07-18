using System;
using System.Collections.Generic;
using System.Text;

namespace Task28
{
    class Game
    {
        public static void initGame()
        {
            Random r = new Random();
            Field field = new Field(10, 10);

            Player myPlayer = new Player(r.Next(0, field.Width), r.Next(0, field.Height), "Nik");
            Monster myWolf = new Wolf(r.Next(0, field.Width), r.Next(0, field.Height));
            Monster myBear = new Bear(r.Next(0, field.Width), r.Next(0, field.Height));
            Bonus myApple = new Apple(r.Next(0, field.Width), r.Next(0, field.Height));
            Bonus myCherry = new Cherry(r.Next(0, field.Width), r.Next(0, field.Height));
            Barrier myTree = new Tree(r.Next(0, field.Width), r.Next(0, field.Height));
            Barrier myStone = new Stone(r.Next(0, field.Width), r.Next(0, field.Height));
        }

        public static void StartGame ()
        {
            string[] gameOptions = new string[3] { "1: начать игру", "2: настройки", "3: выйти из игры" };
            foreach (var options in gameOptions)
            {
                Console.WriteLine(options);
            }
            bool repeat = true;
            while (repeat)
            {
                bool input = int.TryParse(Console.ReadLine(), out int number);
                if (number == 1)
                    Console.WriteLine("Ведется разработка игры :)");
                else if (number == 2)
                {
                    initGame();
                }
                else if (number == 3)
                    repeat = false;
                else
                    Console.WriteLine("Неверный ввод!");
            }
        }
    }
}
