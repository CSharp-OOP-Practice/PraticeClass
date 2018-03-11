using System;

namespace ModelLibrary
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic");
        }

        public Customer(string message)
        {
            Console.WriteLine(message);
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

        public void GeneralService()
        {
            Console.WriteLine("Nothing");
        }
    }
}
