using System;

namespace Labb3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle();
            Console.WriteLine($"Area Circle: {circle.Area()}");

            Geometry rectangle = new Rectangle();
            Console.WriteLine($"Area Rectangle: {rectangle.Area()}");

            Geometry square = new Square();
            Console.WriteLine($"Area Square: {square.Area()}");

            Console.ReadKey();
        }
    }
}
