using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_Interface_Abstract
{
    public class Dog : Animal
    {
        public override void sleep() {
            System.Console.WriteLine($"The {Name} is sleeping from Dog Class");
        }
    }
}