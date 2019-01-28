using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOKTELI
{
    class Program
    {
        static void Main(string[] args)
        {
            Koktel CubaLibre = new Koktel("Cuba Libre");
            CubaLibre.Dodaj(new Limeta(0.5)); //jedna limeta ima 0.4dcl
            CubaLibre.Dodaj(new Rum(0.4, "Bacardi Gold"));

            CubaLibre.Dodaj(new CocaCola(1, "zero"));

            CubaLibre.Dodaj(new Led("zdrobljeni"));

            Console.WriteLine(CubaLibre.Posluzi());
            Console.ReadKey();

        }
    }
}
