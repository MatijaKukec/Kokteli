using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    public class Sastojak
    {
        protected double dcl;

        public double VratiDecilitre()
        {
            return dcl;
        }

        public void PostaviDecilitre(double dcl)
        {
            this.dcl = dcl;
        }

        public virtual string Prikazi()
        {
            return "Volumen čaše: " + dcl + "dcl";
        }
    }
}
