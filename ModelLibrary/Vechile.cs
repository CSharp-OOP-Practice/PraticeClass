using System;

namespace ModelLibrary
{
    public class Vechile
    {
        private readonly string _registrationNumber;
        public Vechile()
        {
            Console.WriteLine("Vehcile is being initialized.");
        }

        public Vechile(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine("Vechile registration number is {0}", this._registrationNumber);
        }

        public virtual int Speed()
        {
            return 100;
        }
    }
}
