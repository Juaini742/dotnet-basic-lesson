using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_inheritance_polymorphism
{
    public class Animal
    {
        public string? Name {get; set;}

        public virtual void Eat()  { // virtual: Digunakan di base class untuk menandai method yang bisa di-override.
            System.Console.WriteLine($"The {Name} is eating");
        }
    }
}