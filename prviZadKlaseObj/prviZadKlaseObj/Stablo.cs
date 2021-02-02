using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prviZadKlaseObj
{
    class Stablo:Biljka
    {
       public bool opadajuListovi;

        public bool OpadajuListovi()
        {

            return opadajuListovi;

        }
        public void stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
}
