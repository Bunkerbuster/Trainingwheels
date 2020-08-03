using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_DependencyInversionPrincipleLibrary
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson Person, string Message)
        {
            Console.WriteLine($"I am texting { Person.FirstName } to say { Message }");
        }

    }
}
