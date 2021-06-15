using DP_Strategy.Business.Models;
using System;

namespace DP_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {


            var order = new Order
            {
                ShippingsDetails = new ShippingsDetails
                {
                    OrigenCountry = "Sweden",
                    DestinationCountry = "Sweden"
                }
            };

            order.LineItems.Add(
                new Item("CSHARP_SMORGASBORD",
                    "C# Smorgasbord", 
                    100m,
                    ItemType.Literature),
                1
                );

            order.LineItems.Add(
                new Item("CONSULTING",
                    "Building a website",
                    100m,
                    ItemType.Service),
                1
                );

            Console.WriteLine(order.GetTax());

        }
    }
}
