using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_InterfaceSegregationPrinciple
{
    public interface IDVD : ILibraryItem
    {   
        List<string> Actors { get; set; }
        int RunTimeInMinutes { get; set; }
        
    }
}
