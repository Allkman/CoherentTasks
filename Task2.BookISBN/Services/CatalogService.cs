using Task2.Entities.BookISBN;

namespace Task2.BookISBN.Models
{
    internal class CatalogService
    {
        private List<Book> _books;
        private Book _book;
        //an indexer for GET and POST(ADD-Assign) Book
        public Book this[string isbn]
        {
            get
            {
                var books = _books.Where(book => book.ISBN == isbn).Select(book => book).ToList();
                _book = books.FirstOrDefault();
                if (_book != null)
                {
                    return _book;
                }
                throw new KeyNotFoundException();
            }
            set
            {
                if (value != null)
                {
                    _books.Add(value);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public CatalogService()
        {
            _books = new List<Book>();
            _book = new Book();
        }
    }
}
