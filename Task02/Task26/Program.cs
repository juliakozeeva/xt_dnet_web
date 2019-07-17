using System;
using static System.Math;

namespace Task26
{
    class Program
    {
        static void Main(string[] args)
        {
            Round myRound = new Round(-2, 6, 10);
            Console.WriteLine("Площадь круга = {0}", Round(myRound.GetArea(), 2));
            Console.WriteLine("Периметр круга = {0}", Round(myRound.GetLength(), 2));
            Console.WriteLine();
            Ring myRing = new Ring(-2, 2, 14, 5);
            Console.WriteLine("Площадь кольца = {0}", Round(myRing.GetArea(), 2));
            Console.WriteLine("Периметр кольца = {0}", Round(myRing.GetLength(), 2));

            Console.ReadKey();
        }
    }  
}
