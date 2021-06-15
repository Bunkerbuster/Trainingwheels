using System;
using System.Collections.Generic;
using DesignPatterns_2_OCPLibrary;

namespace DesignPatterns_2_OCPUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel {FirstName = "Tim", LastName = "Corey"},
                new PersonModel {FirstName = "Sue", LastName = "Storm"},
                new PersonModel {FirstName = "Nancy", LastName = "Roman"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            Accounts accountprocessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountprocessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAdress} ");

            }

            Console.ReadLine();
        }
    }
}
