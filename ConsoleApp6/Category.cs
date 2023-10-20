using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Category : Base
    {
        private static int _id;
        public Category(string name)
        {
            Id=++_id;
            Name= name;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
