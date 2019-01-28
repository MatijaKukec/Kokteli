using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    class Led : Sastojak
    {
        private string opis;

        public Led(string opis)
        {
            dcl = dcl+1;
            this.opis=opis;
        }

        public override string Prikazi()
        {
            return "Led " + opis;
        }
    }
}
