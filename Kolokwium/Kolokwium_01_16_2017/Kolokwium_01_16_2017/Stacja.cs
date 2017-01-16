using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_01_16_2017
{
    class Stacja:ICloneable
    {
        private string nazwaStacji;
        private bool oplataKlimatyczna;

        public Stacja(string nazwaStacji, bool oplataKlimatyczna)
        {
            this.nazwaStacji = nazwaStacji;
            this.oplataKlimatyczna = oplataKlimatyczna;
        }
        public override string ToString()
        {
            return "Stacja:" + this.nazwaStacji + ", opłata klimatyczna:" + this.oplataKlimatyczna;
        }
        public bool JakaOplata()
        {
            return oplataKlimatyczna;
        }
        public Object Clone()
        {
            return MemberwiseClone();
        }
    }
}
