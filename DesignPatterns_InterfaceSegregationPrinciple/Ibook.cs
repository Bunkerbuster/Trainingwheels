﻿namespace DesignPatterns_InterfaceSegregationPrinciple
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
