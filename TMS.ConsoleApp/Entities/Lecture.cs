using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class Lecture : EntityBase
    {
        public string Topic { get; set; } = string.Empty;
        public string PracticalLesson { get; set; } = string.Empty;
        public string Solution { get; set; } = string.Empty;

        public Lecture(string description, string topic)
        {
            Description = description;
            Topic = topic;

        }

        public override object Clone()
        {
            return new Lecture(Description, Topic);
        }
    }
}
