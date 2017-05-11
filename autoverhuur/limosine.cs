using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
    class Limosine : Auto
    {

        public string BeginBestemming { get; set; }
        public string EindBestemming { get; set; }
        public string Route { get; set; }
        public string HuidigeLocatie { get; set; }

        public Limosine(string kenteken, Soorten soort, string merk, double prijsPerUur, double prijsKlasse, bool verzekerd, Brandstoffen brandstof, int aantalStoelen, int klantNummer, DateTime startHuur, DateTime eindHuur, double vermogen, string beginBestemming, string eindBestemming, string route, string huidigeLocatie) : base(kenteken, soort, merk, prijsPerUur, prijsKlasse, verzekerd, brandstof, aantalStoelen, klantNummer, startHuur, eindHuur, vermogen)
        {
            BeginBestemming = beginBestemming;
            EindBestemming = eindBestemming;
            Route = route;
            HuidigeLocatie = huidigeLocatie;  

        }
    }
}
