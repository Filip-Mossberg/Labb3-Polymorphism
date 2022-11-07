using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    internal class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangle(double _Length = 7, double _Height = 3)
        {
            this.Length = _Length;
            this.Height = _Height;
        }
        public override double Area()
        {
            return Length * Height;
        }

    }
}
