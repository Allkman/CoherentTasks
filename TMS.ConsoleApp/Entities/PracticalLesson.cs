using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.ConsoleApp.Entities
{
    internal class PracticalLesson : Training
    {
        public string? TaskCondition { get; set; }
        public string? Solution { get; set; }
        public PracticalLesson(string description, string taskCondition, string solution) :base(description)
        {
            TaskCondition = taskCondition;
            Solution = solution;
        }
    }
}
