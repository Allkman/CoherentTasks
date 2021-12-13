using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class Lecture : Training
    {
        public string Topic { get; set; } = string.Empty;
        public PracticalLesson PracticalLesson { get; set; }
        public Lecture(string description, string topic, PracticalLesson practicalLesson):base(description)
        {
            Topic = topic;
            PracticalLesson = practicalLesson;
        }
    }
}
