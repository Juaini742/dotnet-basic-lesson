using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _12.entity_framework.entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
