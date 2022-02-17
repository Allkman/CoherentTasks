using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1.Logger
{
    [TrackingEntity]
    internal class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }
        [TrackingProperty]
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
