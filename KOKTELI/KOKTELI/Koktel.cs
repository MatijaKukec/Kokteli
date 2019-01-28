using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    class Koktel
    {
        private List<Sastojak> sastojci = new List<Sastojak>();
        private string nazivKoktela;
        private double dcl;
        public Koktel(string _nazivKoktela)
        {
            nazivKoktela = _nazivKoktela;
        }

        public void Dodaj(Sastojak s)
        {
            sastojci.Add(s);
        }

        public string Posluzi()
        {
            string posluzi;

            posluzi = ("Posluzujem koktel " + nazivKoktela
                       + "\nSastojci (" + sastojci.Count() + "):\n");

            foreach(Sastojak s in sastojci)
            {
                posluzi += s.Prikazi() +"\n";
                dcl = dcl + s.VratiDecilitre();
            }

            posluzi += "Potrebna čaša minimalno dcl: "+ dcl;
            return posluzi;
        }
    }
}
