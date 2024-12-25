using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_Interface_Abstract
{
    public class Rectangle : IsShape
    {
        public double Width {get; set;}
        public double Height {get; set;}

        public double CalculateArae() {
            return Width * Height;
        }
    }
}