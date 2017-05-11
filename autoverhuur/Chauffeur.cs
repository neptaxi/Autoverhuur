using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
   public class Chauffeur
    {
        public string Naam { get; set; }
        public double Uurloon { get; set; }
        public int Id { get; private set; }

        public Chauffeur(string naam, int id, double uurloon)
        {
            naam = Naam;
            id = Id;
            uurloon = Uurloon;
        }
    }
}
