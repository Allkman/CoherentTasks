using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.EmployeeVacation
{
    internal class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person() { }
        public Guid? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
