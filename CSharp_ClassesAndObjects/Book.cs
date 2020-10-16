using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace CSharp_ClassesAndObjects
{
    public class Book
    {
        
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {

            var result = 0.0;
            var highgrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                lowGrade = Math.Min(number, lowGrade);
                highgrade = Math.Max(number, highgrade);
                result += number;
            }


            result /= grades.Count;
            Console.WriteLine($"The lowest grade is {lowGrade}");
            Console.WriteLine($"The Highest grade is {highgrade}");
            Console.WriteLine($"The average grade is {result:N1}");
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }


            result.Average /= grades.Count;
            return result;
           
        }

        private List<double> grades;
        public string name;

    }
}
