using Task1.Logger;

var person = new Person("Tom", 25);
var logger = new Logger(person);
Console.WriteLine(logger);