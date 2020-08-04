using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_SingleResponsibilityPrincipleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person Output = new Person();

            Console.Write("What is your first name: ");

            Output.FirstName = Console.ReadLine();

            Console.Write("What is your  last name: ");

            Output.LastName = Console.ReadLine();

            return Output;
        }

    }
}
