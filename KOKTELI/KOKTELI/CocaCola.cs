using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    class CocaCola : Sastojak
    {
        private double kolicina;
        private string nazivCole;
        public CocaCola(double kolicina, string _nazivCole)
        {
            this.kolicina = this.kolicina + kolicina;
            dcl = 2.5 * kolicina;
            nazivCole = _nazivCole;
        }
        
        public override string Prikazi()
        {
            return kolicina + " Coca-cole " + nazivCole;
        }
    }
}
