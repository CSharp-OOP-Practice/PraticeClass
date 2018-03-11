using System;

namespace ModelLibrary
{
    public class GoldCustomer : Customer
    {
        public GoldCustomer(string message)
            : base(message)
        {
            Console.WriteLine("Hi, this is VIP.");
        }

        public void OfferVouchar()
        {
            this.CalculateRating(excludeOrders: true);
        }

        public void SpecialService()
        {
            Console.WriteLine("Special");
        }
    }
}
