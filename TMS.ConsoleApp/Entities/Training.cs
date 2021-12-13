using Matrix.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class Training
    {
        private List<Training> trainings = new List<Training>();
        private List<Lecture> lectures = new List<Lecture>();
        private List<PracticalLesson> PracticalLessons = new List<PracticalLesson>();
        public string Desctription { get; set; }

        public void Add()
        {

        }
        public Training( string description)
        {
            Desctription = description;
        }
        public bool IsPractical()
        {
           
        }
        void Clone()
        {

        }
    }
}
