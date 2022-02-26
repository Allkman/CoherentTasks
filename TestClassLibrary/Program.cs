using LoggerBL;
using TestClassLibrary;

try
{
    var person = new Person("Tom", 25, "Male", "Highroad", 12, "London");
    var logger = new Logger("test");

    logger.Track(person);
}
catch (ArgumentException)
{
    throw new ArgumentException("Age must be from 0 to 150");
}
catch (NullReferenceException)
{
    throw new NullReferenceException("Cannot be empty or null");
}