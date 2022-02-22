using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation
{
    internal abstract class Person //abstract: to not allow to create an instance of this class
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person() { }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
