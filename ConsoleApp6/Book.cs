using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Book:Base
    {
        private static int _id = 0;
        public string Author { get; set; }  
        public Category Category { get; set; }

        public Book(string name,string author, Category category)
        {
            Name=name;
            Id = ++_id;
            Author = author;
            Category = category;
        }

        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Author:{Author} Category:{Category}";
        }
    }
}
