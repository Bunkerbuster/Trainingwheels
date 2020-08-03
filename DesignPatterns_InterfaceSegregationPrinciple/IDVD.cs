using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_InterfaceSegregationPrinciple
{
    public interface IDVD : ILibraryItem
    {
        int RunTimeInMinutes { get; set; }
        List<string> Actors { get; set; }
    }
}
