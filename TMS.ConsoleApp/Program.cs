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
            var springTraining = new Training("Spring C# Training");

            var practicalLesson = new PracticalLesson("Working with variables", "In-progress", null);
            Console.WriteLine("Adding a Practical Lesson");
            springTraining.Add(practicalLesson);

            Console.WriteLine($"Training contains only a Practical Lesson: {springTraining.IsPractical()}"); // true
            Console.WriteLine();
            Console.WriteLine("Adding a lecture to the training.");

            var lecture = new Lecture("C#", "Variables");
            springTraining.Add(lecture);

            Console.WriteLine("After adding a Lecture to the Training:");
            Console.WriteLine($"The answer to if \"Training contains only Practical Lesson\" is: {springTraining.IsPractical()}"); // false
            Console.WriteLine("[------------------]");

            // cloning
            var trainingClone = springTraining.Clone();
            //creating clone training types:
            var practicalLessonClone = (PracticalLesson)trainingClone.TrainingTypes[0];
            var lectureClone = (Lecture)trainingClone.TrainingTypes[1];
            Console.WriteLine($"Clonned Training Description: {trainingClone.Description = "Summer JS Training"}");
            Console.WriteLine($"Original Training Description: {springTraining.Description}");
            Console.WriteLine();
        }
    }
}
