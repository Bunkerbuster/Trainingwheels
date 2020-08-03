using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_InterfacesLibrary
{

    /// <summary>
    /// Everything in a Interface is a contract, and all are public
    /// </summary>
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get;  }
        void ShipItem(CustomerModel Customer);
    }
}
