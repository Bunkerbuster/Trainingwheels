using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_SingleResponsibilityPrincipleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person Person)
        {
            // Check to be shure the first and the last names are valid
            if (string.IsNullOrWhiteSpace(Person.FirstName))
            {
                //Console.WriteLine("You did not give us a valid first nane! ");
                StandardMessages.DisplayValidationError("First name");
                //Console.ReadLine();
                //StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Person.LastName))
            {
                //Console.WriteLine("You did not give us a valid last nane! ");
                StandardMessages.DisplayValidationError("Last name");

                //Console.ReadLine();
                //StandardMessages.EndApplication();
                return false;
            }

            return true;
        }
    }
}
