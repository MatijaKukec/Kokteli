using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    class Rum : Sastojak
    {
        private string nazivRuma;

        public Rum(double dcl, string nazivRuma)
        {
            this.dcl = dcl;
            this.nazivRuma = nazivRuma;
        }

        public override string Prikazi()
        {
            return dcl + " dcl ruma " + nazivRuma;
        }
    }
}
