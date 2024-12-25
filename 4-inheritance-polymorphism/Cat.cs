using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_inheritance_polymorphism
{
    public class Cat : Animal
    {
        public virtual void Meow() {
            System.Console.WriteLine($"The {Name} meows");
        }

        public override void Eat() {
            base.Eat(); // Memanggil method Eat() yang ada di base class Animal
            System.Console.WriteLine($"The {Name} is eating mice");
        }
    }
}