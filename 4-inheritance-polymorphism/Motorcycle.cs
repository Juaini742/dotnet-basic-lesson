using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_inheritance_polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Drive() {
            System.Console.WriteLine($"{Brand} motorcycle is zooming by!");
        }
    }
}