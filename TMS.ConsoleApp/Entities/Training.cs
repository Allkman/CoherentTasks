using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class Training
    {
        public List<Lecture> Lectures { get; set; } = new List<Lecture>();
        public List<PracticalLesson> PracticalLessons { get; set; }
        void Add()
        {

        }
        bool IsPractical()
        {
            return true;
        }
        void Clone()
        {

        }
    }
}
