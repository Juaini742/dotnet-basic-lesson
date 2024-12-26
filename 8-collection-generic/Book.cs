using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _8_collection_generic.Model.B
{
    public class Book
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Author: {Author}";
        }
    }
}
