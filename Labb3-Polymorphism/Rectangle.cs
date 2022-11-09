using System;

namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangle()
        {
            this.Length = 7;
            this.Height = 3;
        }
        public override double Area()
        {
            return Length * Height;
        }

    }
}
