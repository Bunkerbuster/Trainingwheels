using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_SingleResponsibilityPrincipleUI
{
    public class StandardMessages
    {
        public static void WelcomeMessages() 
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string FieldName)
        {
            Console.WriteLine($"You did not give us a valid { FieldName }! ");
        }
    }
}
