using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.BookISBN.Entities;

namespace Task2.Entities.BookISBN
{
    internal class Book
    {
        public string Title { get => _title; set => _title= value; }
        private string _title;
        public DateTime? PublicationDate { get; set; }
        public List<Author> Authors { get; set; }

        public Book(string title)
        {
            _title = title;
        }
    }
}
