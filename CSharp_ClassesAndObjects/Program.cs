using System;

namespace CSharp_ClassesAndObjects
{
    class Program
    {
        // Plurasight C# fundamentals
        // working with classes and Objects


        static void Main(string[] args)
        {

            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();

            var stats = book.GetStatistics();

            Console.Write($"The Lowest grade is {stats.Average}");
            Console.Write($"The highest grade is {stats.High}");
            Console.Write($"The average grade is {stats.Average:N1}");


            Console.ReadKey();
        }
    }
}
