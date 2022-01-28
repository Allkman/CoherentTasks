using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Entities.BookISBN;

namespace Task2.BookISBN.Models
{
    internal class Catalog
    {
        public Dictionary<string, Book> Books { get; set; }
        public Book GetBookByISBN()
        {
            string title="";
            return new Book(title);
        }
    }
}
