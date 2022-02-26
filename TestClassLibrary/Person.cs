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
        public string Gender { get; }
        public int Age { get; set; }
        [TrackingProperty("Street")]
        public string Street;
        [TrackingProperty("Number")]
        public int Number;
        [TrackingProperty("City")]
        public string City;

        public Person(string name, int age, string gender, string street, int number, string city)
        {
            if (!string.IsNullOrEmpty(name) &&
                !string.IsNullOrEmpty(gender) &&
                !string.IsNullOrEmpty(street) &&
                !string.IsNullOrEmpty(city))
            {
                Name = name;
                Gender = gender;
                Street = street;
                City = city;
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
            Number = number;
        }
    }
}
