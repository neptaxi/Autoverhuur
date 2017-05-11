using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
    class Klant
    {
        public string Naam { get; protected set; }
        public string Adres { get; set; }
        public int KlantNummer { get; private set; }

        public Klant(string naam, string adres, int klantNummer)
        {
            Naam = naam;
            Adres = adres;
            KlantNummer = klantNummer;
        }

        public void ToonKlantGegevens()
        {
            Console.WriteLine("Naam {0}", Naam);
            Console.WriteLine("Adres {0}", Adres);
            Console.WriteLine("KlantNummer {0}", KlantNummer.ToString());
        }
    }
}