using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Kvadrat : Teckning
    {
        public double Side { get; set; }
        public Kvadrat()
        {
            Side = 3;
        }
        public override double Area()
        {
            return Side * Side;
        }
    }
}
