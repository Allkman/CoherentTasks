using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class Lecture
    {
        public string Topic { get; set; }
        public PracticalLesson PracticalLesson { get; set; }
    }
}
