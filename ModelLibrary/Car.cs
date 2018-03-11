using System;

namespace ModelLibrary
{
    public class Car : Vechile
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized.");
        }

        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car registration number is {0}", registrationNumber);
        }

        public override int Speed()
        {
            return 300;
        }
    }
}
