using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3_Polymorphism
{
    internal class Circle : Geometry
    {
        public int Radie { get; set; }
        public double Pi = 3.14;
        public Circle(int _Radie = 5)
        {
            this.Radie = _Radie;
        }
        public override double Area()
        {
            return Pi * Math.Pow(Radie, 2);
        }
    }
}
