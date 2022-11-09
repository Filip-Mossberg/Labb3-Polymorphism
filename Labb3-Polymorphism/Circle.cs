using System;

namespace Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public int Radie { get; set; }
        public double Pi = 3.14;
        public Circle()
        {
            this.Radie = 5;
        }
        public override double Area()
        {
            return Pi * Math.Pow(Radie, 2);
        }
    }
}
