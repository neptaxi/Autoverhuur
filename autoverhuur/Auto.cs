using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
    public class Auto
    {
        public enum Brandstoffen
        {
            Benzine,
            Diesel,
            Gas
        }

        public enum Soorten
        {
            Personenauto,
            Vrachtwagen,
            Truck,
            Tractor
        }

        public string Kenteken { get; private set; }
        public Soorten Soort { get; private set; }
        public string Merk { get; private set; }
        public double PrijsPerUur { get; set; }
        public double PrijsKlasse { get; set; }
        public bool Verzekerd { get; set; }
        public Brandstoffen Brandstof { get; private set; }
        public int AantalStoelen { get; private set; }
        public int KlantenNummer { get; set; }
        public DateTime StartHuur { get; set; }
        public DateTime EindHuur { get; set; }
        public double Vermogen { get; private set; }

        public Auto(string kenteken, Soorten soort, string merk, double prijsPerUur, double prijsKlasse, 
                    bool verzekerd, Brandstoffen brandstof, int aantalStoelen, int klantNummer, DateTime startHuur, 
                    DateTime eindHuur, double vermogen)
        {
            Kenteken = kenteken;
            Soort = soort;
            Merk = merk;
            PrijsPerUur = prijsPerUur;
            PrijsKlasse = prijsKlasse;
            Verzekerd = verzekerd;
            Brandstof = brandstof;
            AantalStoelen = aantalStoelen;
            KlantenNummer = klantNummer;
            StartHuur = startHuur;
            EindHuur = eindHuur;
            Vermogen = vermogen;
        }
        
        public void ToonAutoGegevens()
        {
            Console.WriteLine("Kenteken: {0}", Kenteken);
            Console.WriteLine("Soort: {0}", Soort.ToString());
            Console.WriteLine("Merk: {0}", Merk);
            Console.WriteLine("Prijs per uur: {0}", PrijsPerUur.ToString());
            Console.WriteLine("Prijs Klasse: {0}", PrijsKlasse.ToString());
            Console.WriteLine("Verzekerd: {0}", Verzekerd.ToString());
            Console.WriteLine("Brandstof: {0}", Brandstof.ToString());
            Console.WriteLine("Aantal Stoelen: {0}", AantalStoelen.ToString());
            Console.WriteLine("Klanten nummer: {0}", KlantenNummer.ToString());
            Console.WriteLine("StartHuur: {0}", StartHuur.ToString());
            Console.WriteLine("EindHuur: {0}", EindHuur.ToString());
            Console.WriteLine("Vermogen: {0}", Vermogen.ToString());
        }      
    }
}
/*
    - Auto
    Kenteken
    Soort
    Merk
    prijs per uur
    prijs klasse
    Verzekerd
    brandstof
    Aantal stoelen
    Klantnummer (gelinkt)
    Starthuur
    eindhuur
*/
