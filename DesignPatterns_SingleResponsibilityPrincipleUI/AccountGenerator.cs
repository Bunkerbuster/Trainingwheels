using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_SingleResponsibilityPrincipleUI
{
    public class AccountGenerator
    {

        public static void CreateAccount(Person User)
        {

             Console.WriteLine($"Your username is {User.FirstName.Substring(0, 1)}{User.LastName}");
        }

    }
}
