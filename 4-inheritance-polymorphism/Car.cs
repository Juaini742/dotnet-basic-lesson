using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_inheritance_polymorphism
{
    public class Car : Vehicle
    {

        public int NumberOfDoors {get; set;}

        public override void Drive() {
            System.Console.WriteLine($"{Brand} car is driving with {NumberOfDoors} doors.");
        }
        
    }
}