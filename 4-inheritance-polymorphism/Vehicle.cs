using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_inheritance_polymorphism
{
    public class Vehicle
    {
        public string? Brand {get; set;}

        public virtual void Drive() {
            System.Console.WriteLine("Vehicle is driving");
        }
    }
}