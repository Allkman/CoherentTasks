using System.Text;
using System.Text.RegularExpressions;
using Task2.BookISBN.Entities;

namespace Task2.Entities.BookISBN
{
    internal class Book
    {
        private string _title;
        private DateTime? _publicationDate;
        private HashSet<Author> _authors;
        private static readonly Regex _isbnWithHyphens = new Regex(@"^[0-9]*[-][0-9]*[-][0-9]*[-][0-9]*[-][0-9]*");
        private static readonly Regex _isbnDigitsOnly = new Regex(@"^[0-9]{13}$");
        private string _isbn;
        public string ISBN
        {
            get
            {
                if (!IsValidISBN(_isbn))
                {
                    _isbn = null;
                    throw new ArgumentException();
                }
                return _isbn;
            }
            set 
            {
                if (IsValidISBN(value))
                {
                    _isbn = value;
                    if (_isbnWithHyphens.IsMatch(_isbn))
                    {
                        string normalizedISBN = Regex.Replace(_isbn, @"[^0-9]", "");
                        _isbn = normalizedISBN;
                    }
                }
            }
        }
        public Book(string isbn, string title, DateTime date, HashSet<Author> authors)
        {

                ISBN = isbn;
            if (!string.IsNullOrEmpty(title))
            {
                _title = title;
            }
            else
            {
                throw new ArgumentNullException();
            }
            _authors = authors;
            _publicationDate = date;
        }
        private bool IsValidISBN(string isbn)
        {
            if (isbn == null)
            {
                throw new NullReferenceException();
            }
            else if (_isbnWithHyphens.Match(isbn).Success)
            {
                return true;
            }
            else if (_isbnDigitsOnly.Match(isbn).Success)
            {
                return true;
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(_title);
            sb.AppendLine(_publicationDate.ToString());
            sb.AppendLine("Author (-s):");
            foreach (var author in _authors)
            {
                sb.Append($"{author} \n");
            }
            return sb.ToString();
        }

    }
}