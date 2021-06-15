using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_2_OCPLibrary
{
    public class Accounts : IAccounts
    {

        public EmployeeModel Create(PersonModel person)
        {

            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAdress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";

            return output;
        }

    }
}
