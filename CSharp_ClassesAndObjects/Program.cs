using System;
using System.Collections.Generic;

namespace CSharp_ClassesAndObjects
{
    class Program
    {
        // Plurasight C# fundamentals
        // working with classes and Objects


        static void Main(string[] args)
        {

            // om bovenstaande main method te kunnen aanroepen kun je niet door 
            // var p = new Program() en dan p.Mian(args) dit komt omdat de method 
            // static is
            // de compiler laat dit niet toe
            // je kunt deze wel direct aanroepen, (maar je zt in dit geval 
            // wel in een infinity loop)
            // Program.Main(args)


            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            book.ShowStatistics();

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;

            foreach(var number in grades) 
            {
                result += number;
            }



            // a -= b is equivalent to a = a - b
            // a *= b is equivalent to a = a * b
            // a /= b is equivalent to a = a / b


            result /= grades.Count;
            Console.WriteLine($"the average grade is {result:N1}");




            var stats = book.GetStatistics();

            Console.Write($"The Lowest grade is {stats.Average}");
            Console.Write($"The highest grade is {stats.High}");
            Console.Write($"The average grade is {stats.Average:N1}");


            Console.ReadKey();
        }
    }
}
