using System;
using System.Collections.Generic;
using System.Text;

namespace _37.Uzdevums
{
    public class KitchenTabel : Tabel
    {
        public int PeopleCount { get; private set; } // 4 or 8

        public int PeopleExtend(int people)
        {
            if (people==8)
            {  
                return Wight += 90;
            }
            return Wight;
            
        }

    }
}
