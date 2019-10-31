using System;
using System.Collections.Generic;
using System.Text;

namespace _38.Uzdevums
{
    class TravelPolicy : PolicyBase
    {
        public int Day { get; set; }
        public string Country { get; set; }

        public override double CalculatePremium()
        {
            if (Country.ToLower() == "russia"
                || Country.ToLower() == "ukrain" 
                || Country.ToLower() == "america")
            {
                return Day * 1.50;
            }
            else
            {
                return Day * 1.25;
            }
        }
    }
}
