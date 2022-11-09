using System;

namespace Labb3_Polymorphism
{
    internal class Square : Geometry 
    {
        public double Length { get; set; }
        public Square()
        {
            this.Length = 4;
        }
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }
}
