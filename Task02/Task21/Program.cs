using System;
using static System.Math;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Round myRound = new Round(2, 6, 10);
            Console.WriteLine("Площадь круга = {0}", Round(myRound.AreaRound(), 2));
            Console.WriteLine("Периметр круга = {0}", Round(myRound.LengthRound(), 2));

            Console.ReadKey();
        }
    }
}
