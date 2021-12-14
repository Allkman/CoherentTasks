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
            var trainingType = new Training();   
            var trainings = new List<Training>();
            Console.WriteLine($"Training has material: {trainingType.IsPractical()}");

            //creating practicall lesson to test IsPractical()
            var practicalLesson = new PracticalLesson("Working with variables", "In-progress", null);
            Console.WriteLine("Adding a Practical Lesson");
            trainingType.Add(practicalLesson);
            Console.WriteLine($"Training contains only a Practical Lesson: {trainingType.IsPractical()}");
            Console.WriteLine();
            Console.WriteLine("Adding a lecture to the training.");

            var lecture1 = new Lecture("C#", "Variables", practicalLesson);
            trainingType.Add(lecture1);
            Console.WriteLine("After adding a Lecture to the Training:");
            Console.WriteLine($"The answer to if \"Training contains only Practical Lesson\" is: {trainingType.IsPractical()}");
            Console.WriteLine("[------------------]");
            trainings.Add(trainingType);

                Console.WriteLine($"The number of current trainings: {trainings.Count}");
            
            Console.WriteLine($"Training Description: {trainingType.Desctription = "Programming basics in .NET"}");
           
            Console.WriteLine();
            var trainingClone = trainingType.Clone();
            trainings.Add(trainingClone);
            Console.WriteLine($"The number of trainings after cloninig: {trainings.Count}");

            Console.WriteLine($"Training Clone Description: {trainingClone.Desctription = "Clonned training."}");

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
