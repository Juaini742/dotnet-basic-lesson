using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_encapsulation
{
    public class Student
    {
        public string? Name {get; set;}
        public int? Age {get; set;}

        public void DisplayInfo() {
            System.Console.WriteLine($"Hello, {Name} your age is {Age} years");
        }
    }
}