using Task2.BookISBN.Entities;
using Task2.BookISBN.Models;
using Task2.Entities.BookISBN;

try
{
    var date = new DateTime(1999, 10, 15).ToShortDateString();
    var book1 = new Book("978-1-56619-909-4", "Good Book", date);
    var author1 = new Author("Sam", "Burt");
    var author2 = new Author("Timothy", "Wilt");

    //var book2 = new Book("979-1-07819-209-3", "Good People", new DateTime(1983));
    //var author3 = new Author("Anthony", "Soulman");
    //var author4 = new Author("Rita", "Smith");

    book1.AddAuthors(author1);
    book1.AddAuthors(author2);

    //book2.AddAuthors(author3);
    //book2.AddAuthors(author4);

    var catalog = new CatalogService();
    catalog.PostBook(book1);
    //catalog.PostBook(book2);



    Console.WriteLine(catalog.GetBookByIsbn("9781566199094"));
    //Console.WriteLine(catalog.GetBookByIsbn("979-1-07819-209-3"));

}
catch (NullReferenceException)
{

    Console.WriteLine("ISBN key does not exist");
}
catch (ArgumentException)
{

    Console.WriteLine("Incorrect ISBN format.");
}
//Console.WriteLine();

Console.ReadLine();