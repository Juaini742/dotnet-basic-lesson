using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_Interface_Abstract
{
    public abstract class Animal
    {
        public string? Name {get; set;}

        public abstract void sleep();

        public void eat() {
            System.Console.WriteLine($"The {Name} is Eating");
        }
        
    }
}