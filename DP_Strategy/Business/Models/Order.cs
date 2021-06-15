using System;
using System.Collections.Generic;
using System.Text;

namespace DP_Strategy.Business.Models
{
    public class Order
    {


        public decimal TotalPrice => LineItems.Sum(Item => Item.Key.Price * Item.Value);

        public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;

        public ShippingDetails ShippingDetails { get; set; }

        public decimal GetTax()
        {
            var destination = ShippingDetails.DestinationCountry.ToLowerInvariant();

            if(destination == "sweden")
            {
                var origin = ShippingDetails.OriginCountry.ToLowerInvariant();

                if (destination == origin)
                {
                    return TotalPrice * 0.25m;
                }

                // Tax per item

                return 0;
            }

            if (destination == "us")
            { 
                switch (ShippingDetails.DestinationState.ToLowerInvariant())
                {
                    case "la": return TotalPrice * 0.095m;
                    case "ny": return TotalPrice * 0.04m;
                    case "nyc": return TotalPrice * 0.045m;
                    default: return 0m;
                }


            }


            }


    }
}
