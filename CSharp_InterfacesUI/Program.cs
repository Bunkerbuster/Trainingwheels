using CSharp_InterfacesLibrary;
using System;
using System.Collections.Generic;

namespace CSharp_InterfacesUI
{
    class Program
    {
        /// <summary>
        /// CREATEIN INTERFACE [CTRL] + [.]
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {

            List<IProductModel> Cart = AddSampleData();
            CustomerModel Customer = GetCustomer();

            foreach(IProductModel Prod in Cart)
            {
                Prod.ShipItem(Customer);
                // is => from C# 7.0
                if(Prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the {digital.Title} you have { digital.TotalDownLoadsLeft } downloads left");
                }
            }

            Console.ReadLine();
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                City = "Scranton",
                EmailAddress = "tim@iamtimcorey.com",
                PhoneNumber = "555-1212"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> Output = new List<IProductModel>
            {
                new PhysicalProductModel { Title = "Nerf Football" },
                new PhysicalProductModel { Title = "IAmTimCorey T-Shirt" },
                new PhysicalProductModel { Title = "Hard Drive" },
                new DigitalProductModel {Title = "Lesson Source Code"}
            };

            return Output;
        }
    }
}
