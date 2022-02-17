using Task2.BookISBN.Entities;
using Task2.BookISBN.Models;
using Task2.Entities.BookISBN;

try
{
    var catalog = new CatalogService();
    var bookValid = new Book("978-1-56619-909-4", "First Book", new DateTime(1999, 10, 15));
    var author1 = new Author("Sam", "Burt");
    var author2 = new Author("Timothy", "Wilt");

    var book2 = new Book("978-1-56619-909-3", "Second Book", new DateTime(2008, 02, 10));
    var author3 = new Author("Anthony", "Soulman");
    var author4 = new Author("Rita", "Smith");

    string isbnInvalid = "123";
    var bookInvalid = new Book(isbnInvalid, "BAD Book", new DateTime(2011, 07, 19));
    var author5 = new Author("Tim", "Roth");
    var author6 = new Author("Sarah", "Wright");

    bookValid.AddAuthors(author1);
    bookValid.AddAuthors(author2);

    book2.AddAuthors(author3);
    book2.AddAuthors(author4);

    //bookInvalid.AddAuthors(author5);
    //bookInvalid.AddAuthors(author6);


    catalog["978-1-56619-909-4"] = bookValid;
    catalog["978-1-56619-909-3"] = book2;


    var bookReceived = catalog["978-1-56619-909-4"];
    //var bookReceived = bookValid;
    Console.WriteLine(bookValid == bookReceived);

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