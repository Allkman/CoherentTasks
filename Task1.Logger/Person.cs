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
        [TrackingProperty]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
