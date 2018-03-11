using ModelLibrary;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PraticeClass
{
    

    class Program
    {
        static void Main(string[] args)
        {
            //var car = new Car("20170727");
            //var goldCustomer = new GoldCustomer("hahaha");
            //Casting(goldCustomer);

            //var customer = new Customer();
            //var goldCustomer = new GoldCustomer();

            //var calculator = new RateCalculator();
            //var person = new Person(new DateTime(1983, 02, 27));
            //Console.WriteLine(person.GetAge());

            //var cookie = new HttpCookie();
            //cookie["key"] = "Ray";
            //Console.WriteLine(cookie["key"]);

            //var migrator = new DbMigrator(new Logger());
            //migrator.Migrate();

            //var installer = new Installer(new Logger());
            //installer.Log();
        }

        /// <summary>
        /// Boxing/Unboxing 要避免使用
        /// </summary>
        private static void Boxing()
        {
            var list = new ArrayList();
            //Boxing
            list.Add(1);
            //unboxing
            var i = (int)list[0];
            Console.WriteLine(list[0]);
        }

        private static void Casting(GoldCustomer goldCustomer)
        {
            // Upcasting
            Customer customer = goldCustomer;
            object upCasting = goldCustomer;
            var downCasting = upCasting as GoldCustomer;
            if (downCasting == null)
                Console.WriteLine("There's no such thing like this.");
            else
                Console.WriteLine("You're right!");
        }
    }
}
