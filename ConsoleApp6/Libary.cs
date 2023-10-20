using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Libary:Base
    {
        private static int _id=0;

        public List<Book> _books=new();

        public Libary(string name)
        {
            Id=++_id;
            Name= name;
        }

        public void AddBook(Book book) 
        {
            _books.Add(book);

        }
        public void ListAllBooks()
        {
            foreach(Book book in _books)
            {
                Console.WriteLine(book);
            }
        }


    }
}
