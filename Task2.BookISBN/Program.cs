using Task2.BookISBN.Entities;
using Task2.BookISBN.Models;
using Task2.Entities.BookISBN;

try
{
    var catalog = new CatalogService();
    var author1 = new Author("Sam", "Burt");
    var author2 = new Author("Timothy", "Wilt");
    var bookValid = new Book("978-1-56619-909-4", "First Book", new DateTime(1999, 10, 15), new HashSet<Author>() { author1, author2 });

    var author3 = new Author("Anthony", "Soulman");
    var author4 = new Author("Rita", "Smith");
    var book2 = new Book("978-1-56619-909-3", "Second Book", new DateTime(2008, 02, 10), new HashSet<Author>() { author3, author4 });

    var author5 = new Author("Tim", "Roth");
    var author6 = new Author("Sarah", "Wright");
    //My Book() class has IsValidISBN method that will check if ISBN is valid before creating a new Book()
    //string isbnInvalid = "123";
    //will throw ArgumentExeption "Incorrect ISBN format."
    //var bookInvalid = new Book(isbnInvalid, "BAD Book", new DateTime(2011, 07, 19), new HashSet<Author>() { author5, author6});

    catalog["978-1-56619-909-4"] = bookValid;
    catalog["978-1-56619-909-3"] = book2;

    var bookReceived = bookValid;
    Console.WriteLine(bookValid == bookReceived);

    Console.WriteLine(catalog["9781566199094"]);
    Console.WriteLine(catalog["9781566199093"]); 
    Console.WriteLine(catalog["9781566199092"]); //The book with specified ISBN was not found.
}
catch (KeyNotFoundException)
{
    Console.WriteLine("The book with specified ISBN was not found.");
}
catch (InvalidOperationException)
{
    Console.WriteLine("You have attempted to assign null");
}
catch (NullReferenceException)
{
    Console.WriteLine("ISBN key does not exist.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Catalog is empty.");
}
catch (ArgumentNullException)
{
    Console.WriteLine("The title of the book is mandatory.");
}
catch (ArgumentException)
{
    Console.WriteLine("Incorrect ISBN format.");
}
Console.ReadLine();