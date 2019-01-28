using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    class Limeta : Sastojak
    {
        private double kolicina;

        public Limeta(double _kolicina)
        {
            kolicina = _kolicina;
            dcl = 0.4 * kolicina;
        }

        public override string Prikazi()
        {
            return kolicina + " limete";
        }
    }
}
