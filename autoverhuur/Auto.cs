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

<<<<<<< HEAD
        public string Kenteken { get; private set; }
=======
        public enum Soorten
        {
            Personenauto,
            Vrachtwagen,
            Truck,
            Tractor
        }

        public string Kenteken { get; private set; }
        public Soorten Soort { get; private set; }
>>>>>>> 3574c61a7ec3bdb2f089e3dbd8a7d02c523589fc
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

<<<<<<< HEAD
        public Auto(string kenteken, string merk, double prijsPerUur, double prijsKlasse, 
=======
        public Auto(string kenteken, Soorten soort, string merk, double prijsPerUur, double prijsKlasse, 
>>>>>>> 3574c61a7ec3bdb2f089e3dbd8a7d02c523589fc
                    bool verzekerd, Brandstoffen brandstof, int aantalStoelen, int klantNummer, DateTime startHuur, 
                    DateTime eindHuur, double vermogen)
        {
            Kenteken = kenteken;
<<<<<<< HEAD
=======
            Soort = soort;
>>>>>>> 3574c61a7ec3bdb2f089e3dbd8a7d02c523589fc
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
<<<<<<< HEAD
=======
            Console.WriteLine("Soort: {0}", Soort.ToString());
>>>>>>> 3574c61a7ec3bdb2f089e3dbd8a7d02c523589fc
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
