using System;

namespace Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle myTriangle = new Triangle(8, 7, 6);
            Console.WriteLine($"Площадь треугольника = {Math.Round(myTriangle.TriangleArea(), 2)}");
            Console.WriteLine($"Периметр треугольника = {myTriangle.TrianglePerimeter()}");

            Console.ReadKey();
        }
    }    
}
