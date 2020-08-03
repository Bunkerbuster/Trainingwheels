﻿namespace DesignPatterns_DependencyInversionPrincipleLibrary
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}