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
            var trainingTypes = new Training();   
            Console.WriteLine($"Training has material: {trainingTypes.IsPractical()}");

            var practicalLesson = new PracticalLesson("Working with variables", "In-progress", null);
            Console.WriteLine("Adding a Practical Lesson");
            trainingTypes.Add(practicalLesson);
            Console.WriteLine($"Training contains only a Practical Lesson: {trainingTypes.IsPractical()}");
            Console.WriteLine();
            Console.WriteLine("Adding a lecture to the training.");

            var lecture1 = new Lecture("C#", "Variables");
            trainingTypes.Add(lecture1);
            Console.WriteLine("After adding a Lecture to the Training:");
            Console.WriteLine($"The answer to if \"Training contains only Practical Lesson\" is: {trainingTypes.IsPractical()}");
            Console.WriteLine("[------------------]");
           
            var trainingClone = trainingTypes.Clone();

            foreach (var item in trainingClone.trainingTypes)
            {
            Console.WriteLine($"Cloned object in Training: {item}");

            }
            Console.WriteLine();
        }
    }
}
