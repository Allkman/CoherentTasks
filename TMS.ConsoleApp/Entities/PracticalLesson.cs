using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class PracticalLesson : EntityBase
    {
        public string? TaskCondition { get; set; }
        public string? Solution { get; set; }
        public PracticalLesson(string description, string taskCondition, string solution)
        {
            Description = description;
            TaskCondition = taskCondition;
            Solution = solution;
        }

        public override object Clone()
        {
            return new PracticalLesson(Description, TaskCondition, Solution);
        }
    }
}
