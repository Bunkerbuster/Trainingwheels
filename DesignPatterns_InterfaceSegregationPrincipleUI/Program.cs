using DesignPatterns_InterfaceSegregationPrinciple;
using System;

namespace DesignPatterns_InterfaceSegregationPrincipleUI
{
    class Program
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=y1JiMGP51NE
        /// 
        /// When you are writing code, are you doing it right? That is a question that worries a lot of people, 
        /// and it should probably at least be something every developer thinks through. Design patterns are
        /// best-practice concepts that we can implement into our code to make it better in some way. Think of 
        /// them as guardrails that keep our code safe. In this video, we are going to look at the fourth entry 
        /// in the famous SOLID principle. The I stands for Interface Segregation Principle. We are going to 
        /// dive into what it means, how it should change our programming practices, and how far we should take
        /// it.
        /// 
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            IBorrowableBook Book = new Book
            {
                Author = "Demo"
            };

            Console.WriteLine(Book.Author);

            Console.ReadLine();
        }
    }
}
