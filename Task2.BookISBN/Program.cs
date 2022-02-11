using Task2.BookISBN.Entities;
using Task2.BookISBN.Models;
using Task2.Entities.BookISBN;

try
{
    var date1 = new DateTime(1999, 10, 15).ToShortDateString();
    var date2 = new DateTime(2008, 02, 10).ToShortDateString();

    var book1 = new Book("978-1-56619-909-4", "Good Book", date1);
    var author1 = new Author("Sam", "Burt");
    var author2 = new Author("Timothy", "Wilt");

    var book2 = new Book("978-1-56619-909-3", "Good People", date2);
    var author3 = new Author("Anthony", "Soulman");
    var author4 = new Author("Rita", "Smith");

    book1.AddAuthors(author1);
    book1.AddAuthors(author2);

    book2.AddAuthors(author3);
    book2.AddAuthors(author4);

    var catalog = new CatalogService();
    catalog.PostBook(book1);
    catalog.PostBook(book2);

    Console.WriteLine(catalog["9781566199094"]);
    Console.WriteLine();
    Console.WriteLine(catalog["9781566199093"]); 
    Console.WriteLine(catalog["9781566199092"]); 
}
catch (KeyNotFoundException)
{
    Console.WriteLine("The book with specified ISBN was not found.");
}
catch (InvalidOperationException)
{
    Console.WriteLine("ISBN key already exist.");
}
catch (NullReferenceException)
{
    Console.WriteLine("ISBN key does not exist.");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Catalog is empty.");
}
catch (ArgumentException)
{

    Console.WriteLine("Incorrect ISBN format.");
}
Console.ReadLine();