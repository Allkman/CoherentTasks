using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task2.Entities.BookISBN;

namespace Task2.BookISBN.Models
{
    internal class CatalogService
    {
        private List<Book> Books { get; set; }
        public CatalogService()
        {
            Books = new List<Book>();
        }
        public void PostBook(Book book, string isbn)
        {
            if (book[isbn].Contains(isbn))
            {
                Books.Add(book);
            }
        }
        public Book GetBookByIsbn(string isbn)
        {
           return Books.Where(b => b[isbn] == isbn).FirstOrDefault();
        }
    }
}
