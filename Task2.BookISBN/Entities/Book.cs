using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task2.BookISBN.Entities;

namespace Task2.Entities.BookISBN
{
    internal class Book
    {
        private string _title;
        private string _publicationDate;
        private List<Author> Authors;
        private static readonly Regex isbnWithHyphens = new Regex(@"^[0-9]*[-][0-9]*[-][0-9]*[-][0-9]*[-][0-9]*");
        private static readonly Regex isbnDigitsOnly = new Regex(@"^[0-9]{13}$");
        private string _isbn;
        public string ISBN
        {
            get
            {
                return _isbn;
            }
            set 
            {
                if (IsValideISBN(value))
                    _isbn = value;
                {
                    if (isbnWithHyphens.IsMatch(_isbn))
                    {
                        string normalizedISBN = Regex.Replace(_isbn, @"[^0-9]", "");
                        _isbn = normalizedISBN;
                    }
                }
            }
        }
        public Book(string isbn, string title, string date)
        {
            ISBN = isbn;
            _title = title;
            Authors = new List<Author>();
            _publicationDate = date;
        }
        public Book()
        {

        }
        private bool IsValideISBN(string isbn)
        {

            if (isbn == null)
            {
                throw new NullReferenceException();
            }
            else if (isbnWithHyphens.Match(isbn).Success)
            {
                return true;
            }
            else if (isbnDigitsOnly.Match(isbn).Success)
            {
                return true;
            }
            else
            {
                throw new ArgumentException();
            }
                
        }
        public void AddAuthors(Author author)
        {
            Authors.Add(author);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            var author = new Author();
            sb.AppendLine(_title);
            sb.AppendLine(_publicationDate.ToString());
            sb.AppendLine("Author (-s):");
            for (int i = 0; i < Authors.Count; i++)
            {
                sb.AppendLine(Authors[i].ToString());
            }
            return sb.ToString();
        }
    }
}