using System;

namespace Labb_3___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Teckning cirkel = new Cirkel();
            Teckning rektangel = new Rektangel();
            Teckning kvadrat = new Kvadrat();
            Console.WriteLine("Rektangel area: " + rektangel.Area());
            Console.WriteLine("Cirkel area: " + cirkel.Area());
            Console.WriteLine("Kvadrat area: " + kvadrat.Area());
            Console.ReadLine();
        }
    }
}
