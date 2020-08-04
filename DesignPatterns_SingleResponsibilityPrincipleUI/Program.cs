using System;

namespace DesignPatterns_SingleResponsibilityPrincipleUI
{
    class Program
    {
        /// SRP = Single Responsibility Principle
        /// Source https://www.youtube.com/watch?v=5RwhyZnVRS8
        /// <summary>
        /// The single-responsibility principle (SRP) is a computer-programming principle that states that every module or class[1]
        /// should have responsibility over a single part of the functionality provided by the software, and that responsibility 
        /// should be entirely encapsulated by the class, module or function. All its services should be narrowly aligned with that
        /// responsibility. Robert C. Martin expresses the principle as, "A class should have only one reason to change,"[1] 
        /// although, because of confusion around the word "reason" he more recently stated "This principle is about people."[2]
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
                        //Console.WriteLine("Welcome to my application");
            StandardMessages.WelcomeMessages();

            // Ask for user information
                    //Person User = new Person();
                    //Console.Write("What is your first name: ");
                    //User.FirstName = Console.ReadLine();
                    //Console.Write("What is your  last name: ");
                    //User.LastName = Console.ReadLine();

            Person User = PersonDataCapture.Capture();

            // Check to be shure the first and the last names are valid
                    //if (string.IsNullOrWhiteSpace(User.FirstName))
                    //{
                    //    Console.WriteLine("You did not give us a valid first nane! ");
                    //    //Console.ReadLine();
                    //    StandardMessages.EndApplication();
                    //    return;
                    //}

                    //if (string.IsNullOrWhiteSpace(User.LastName))
                    //{
                    //    Console.WriteLine("You did not give us a valid last nane! ");
                    //    //Console.ReadLine();
                    //    StandardMessages.EndApplication();
                    //    return;
                    //}

            bool IsUservalid = PersonValidator.Validate(User);

            if (IsUservalid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // create a username for the person
                    //Console.WriteLine($"Your username is {User.FirstName.Substring(0, 1)}{User.LastName}");
            AccountGenerator.CreateAccount(User);

                    //Console.ReadLine();
            StandardMessages.EndApplication();
        }
    }
}
