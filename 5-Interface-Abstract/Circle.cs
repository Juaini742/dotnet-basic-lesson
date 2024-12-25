using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_Interface_Abstract
{
    public class Circle : IsShape
    {
        public double Radius {get; set;}

        public double CalculateArae() {
            return 3.14 * Radius * Radius;
        }
    }
}