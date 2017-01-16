using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_01_16_2017
{
    class LastMinute:Podroz
    {
        public override double KosztPoRabacie()
        {
            return koszt * 0.75; // -25
        }
        public override string ToString()
        {
            return ToString() + "LastMinute";
        }
    }
}
