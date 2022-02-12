using Task2.BookISBN.Entities;
using Task2.BookISBN.Models;
using Task2.Entities.BookISBN;

try
{
    var book1 = new Book("978-1-56619-909-4", "Good Book", new DateTime(1999, 10, 15));
    var author1 = new Author("Sam", "Burt");
    var author2 = new Author("Timothy", "Wilt");

    var book2 = new Book("978-1-56619-909-3", "Good People", new DateTime(2008, 02, 10));
    var author3 = new Author("Anthony", "Soulman");
    var author4 = new Author("Rita", "Smith");

    book1.AddAuthors(author1);
    book1.AddAuthors(author2);

    book2.AddAuthors(author3);
    book2.AddAuthors(author4);

    var catalog = new CatalogService();

    catalog[null] = book1;
    catalog[null] = book2;
    //catalog[null] = null;

    Console.WriteLine(catalog["9781566199094"]);
    Console.WriteLine();
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