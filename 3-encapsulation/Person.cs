using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_encapsulation
{
    public class Person
    {

        private string? _name;

        public string? Name {
            get { return _name; }
            set {_name = value; }
        }
    }
}