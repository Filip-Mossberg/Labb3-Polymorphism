using System;

namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geometry = new Geometry();

            geometry = new Circle();
            Console.WriteLine($"Area Cicle: {geometry.Area()}");

            geometry = new Rectangle();
            Console.WriteLine($"Area Rectangle: {geometry.Area()}");

            geometry = new Square();
            Console.WriteLine($"Area Square: {geometry.Area()}");

            Console.ReadKey();
        }
    }
}
