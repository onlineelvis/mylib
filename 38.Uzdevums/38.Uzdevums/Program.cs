using System;
using System.Collections.Generic;

namespace _38.Uzdevums
{
    class Program
    {
        static void Main(string[] args)
        {
            var kp1 = new KaskoPolicy()
            {
                Accidents = 6,
                CarYear = 2007,
            };
            var kp2 = new KaskoPolicy()
            {
                Accidents = 3,
                CarYear = 2009,
            };

            var tp1 = new TravelPolicy()
            {
                Country = "Russia",
                Day = 15
            };
            var tp2 = new TravelPolicy()
            {
                Country = "Arabia",
                Day = 11
            };

            var policyBasesList = new List<PolicyBase>();
            policyBasesList.Add(kp1);
            policyBasesList.Add(kp2);
            policyBasesList.Add(tp1);
            policyBasesList.Add(tp2);

            foreach (var item in policyBasesList)
            {
                Console.WriteLine($"Premium sum: {item.CalculatePremium()}");
            }
        }
    }
}
