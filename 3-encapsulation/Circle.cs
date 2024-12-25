using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_encapsulation
{
    public class Circle
    {
        public double Radius {get; set;}

        public double CaculateArea () {
            // return Math.PI * Radius * Radius;
            return 3.14 * Radius * Radius;
        }
    }
}