using System;
using System.Collections.Generic;
using System.Text;

namespace _38.Uzdevums
{
    class KaskoPolicy : PolicyBase
    {
        public int Accidents { get; set; }
        public int CarYear { get; set; }

        public override double CalculatePremium()
        {
            var sum = 0;

            //if (Accidents > 5 && CarYear > 2005)
            //{
            //    return sum += 95;
            //}
            if (Accidents > 5)
            {
               sum += 40; 
            }
            if (CarYear > 2005)
            {
               sum += 55;
            }
            return sum;
        }
    }
}
