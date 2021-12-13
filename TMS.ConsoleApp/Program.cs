using System;
using TMS.ConsoleApp.Entities;

namespace TMS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var training = new Training();
            foreach (var item in training.PracticalLessons)
            {
                Console.WriteLine(item.Description);
            }
            Console.WriteLine(training.IsPractical());
            //int input = int.Parse(Console.ReadLine());
            var practicalLesson = new PracticalLesson("HomeWork1", "Ready", "Sum(a, b)");
            var lecture1 = new Lecture("C# basics", "Variables", practicalLesson);
            training.Add(lecture1, practicalLesson);
            Console.WriteLine(training.Lectures);
        }
    }
}
