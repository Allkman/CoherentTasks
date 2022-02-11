using Task2.Entities.BookISBN;

namespace Task2.BookISBN.Models
{
    internal class CatalogService
    {
        private List<Book> _books;
        private Book _book;
        //an indexer for GET Book
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
        }
        public CatalogService()
        {
            _books = new List<Book>();
            _book = new Book();
        }
        public void PostBook(Book book)
        {
            var books = _books.Where(b => b.ISBN == book.ISBN).Select(book => book).ToList();

            _book = books.FirstOrDefault();
            if (_book != null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                _books.Add(book);
            }
        }
    }
}
