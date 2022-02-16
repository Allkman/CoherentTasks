using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task1.Logger
{
    internal class Logger
    {
        Person Person { get; set; } = new Person();
        public Logger(Person person)
        {
            Person = person;
        }

        public string Track(Person person)
        {
            string json = JsonSerializer.Serialize<Person>(person);
            Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson.Name);
            return restoredPerson.Name;
        }
    }
}
