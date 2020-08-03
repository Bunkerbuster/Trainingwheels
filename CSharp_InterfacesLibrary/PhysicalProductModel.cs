using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_InterfacesLibrary
{
    public class PhysicalProductModel : IProductModel
    {

        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(CustomerModel Customer)
        { 
            if(HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping { Title }  to { Customer.FirstName } in { Customer.City } ");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
