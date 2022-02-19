using LoggerBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassLibrary
{
    [TrackingEntity]
    public class Person
    {
        [TrackingProperty]
        public string Name { get; set; }
        [TrackingProperty]
        public string Gender { get; set; }
        public int Age { get; set; }
        public Person(string name, int age, string gender)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(gender))
            {
                Name = name;
                Gender = gender;
            }
            else if (age < 0 && age > 150)
            {
                throw new ArgumentException();
            }
            else
            {
                throw new NullReferenceException();
            }
            Age = age;
        }
    }
}
