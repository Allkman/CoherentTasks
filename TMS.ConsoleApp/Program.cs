using System;
using TMS.ConsoleApp.Entities;

namespace TMS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var training = new Training("");           

            var practicalLesson = new PracticalLesson("Working with variables", "In-progress", null);
            Console.WriteLine(training.IsPractical());
            var lecture1 = new Lecture("C# basics", "Variables", practicalLesson);
            training.Add(lecture1);
            Console.WriteLine(training.IsPractical());
        }
    }
}
