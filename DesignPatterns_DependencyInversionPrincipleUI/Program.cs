using DesignPatterns_DependencyInversionPrincipleLibrary;
using System;

namespace DesignPatterns_DependencyInversionPrincipleUI
{
    class Program
    {

        /// Source : https://www.youtube.com/watch?v=NnZZMkwI6KI
        /// <summary>
        /// Dependency inversion
        /// 
        /// In software engineering, dependency injection is a technique in which an object receives other objects that it depends on. 
        /// These other objects are called dependencies. In the typical "using" relationship[1] the receiving object is called a 
        /// client and the passed (that is, "injected") object is called a service. The code that passes the service to the client 
        /// can be many kinds of things and is called the injector. Instead of the client specifying which service it will use, the
        /// injector tells the client what service to use. The "injection" refers to the passing of a dependency (a service) into the
        /// object (a client) that would use it. 
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IPerson Owner = Factory.CreatePerson();
            Owner.FirstName = "Tim";
            Owner.LastName = "Corey";
            Owner.EmailAddress = "tim@iamtimcorey.com";
            Owner.PhoneNumber = "555-1212";


            //Person _Owner = new Person
            //{
            //    FirstName = "Tim",
            //    LastName = "Corey",
            //    EmailAddress = "tim@iamtimcorey.com",
            //    PhoneNumber = "555-1212"
            //};


            IChore Chore = Factory.CreateChore();
            Chore.ChoreName = "Take out the trash";
            Chore.Owner = Owner;
            
            //Chore Chore = new Chore
            //{
            //    ChoreName = "Take out the trash",
            //    Owner = _Owner
            //};

            Chore.PerformedWork(3);
            Chore.PerformedWork(1.5);
            Chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
