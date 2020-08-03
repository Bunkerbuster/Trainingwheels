using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_DependencyInversionPrincipleLibrary
{
    public class Chore : IChore
    {
        ILogger _Logger;
        IMessageSender _MessageSender;

        public string ChoreName { get; set; }

        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }
       
        // constrocter level
        public Chore(ILogger Logger, IMessageSender MessageSender)
        {
            _Logger = Logger;
            _MessageSender = MessageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;

            
            //Logger log = new Logger();


            _Logger.Log($"Performed work on { ChoreName } ");

        }


        public void CompleteChore()
        {
            IsComplete = true;

            //Logger log = new Logger();

            _Logger.Log($"Completed { ChoreName } ");

            //Emailer emailer = new Emailer();
            _MessageSender.SendMessage(Owner, $"The chore { ChoreName } is complete ");

        }
    }
}
