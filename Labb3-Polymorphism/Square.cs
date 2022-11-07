using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    internal class Square : Geometry 
    {
        public double Length { get; set; }
        public Square(double _Length = 4)
        {
            this.Length = _Length;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
