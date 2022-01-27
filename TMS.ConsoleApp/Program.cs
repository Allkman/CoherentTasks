using System;
using System.Collections.Generic;
using TMS.ConsoleApp.Entities;

namespace TMS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[------------------]");
            var springTraining = new Training();
            springTraining.Description = "Spring C# Training";

            Console.WriteLine($"Training has material: {springTraining.IsPractical()}"); // false

            var practicalLesson = new PracticalLesson("Working with variables", "In-progress", null);
            Console.WriteLine("Adding a Practical Lesson");
            springTraining.Add(practicalLesson);

            Console.WriteLine($"Training contains only a Practical Lesson: {springTraining.IsPractical()}"); // true
            Console.WriteLine();
            Console.WriteLine("Adding a lecture to the training.");

            var lecture1 = new Lecture("C#", "Variables");
            springTraining.Add(lecture1);

            Console.WriteLine("After adding a Lecture to the Training:");
            Console.WriteLine($"The answer to if \"Training contains only Practical Lesson\" is: {springTraining.IsPractical()}"); // false
            Console.WriteLine("[------------------]");

            var springTrainingClone = springTraining.Clone();
            Console.WriteLine($"Clonned Spring Training Description: {springTrainingClone.Description}");
            Console.WriteLine();
        }
    }
}
