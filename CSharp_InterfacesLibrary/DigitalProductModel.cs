using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_InterfacesLibrary
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        public int TotalDownLoadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel Customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title }  to { Customer.EmailAddress } ");

                TotalDownLoadsLeft -= 1;

                if (TotalDownLoadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownLoadsLeft = 0;
                }
            }
        }
    }


}
