using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3___Polymorphism
{
    class Rektangel : Teckning
    {
        public double Height { get; set; }
        public double Width {get; set;}

        public Rektangel()
        {
            Height = 4;
            Width = 5;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
