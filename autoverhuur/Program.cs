using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoverhuur
{
    class Program
    {
        List<Auto> autos = new List<Auto>();
        List<Klant> klanten = new List<Klant>();

        static void Main(string[] args)
        {
        }

        static void invoer()
        {

        }

        static void PlaatsAuto()
        {

        }

        static void PlaatsKlant()
        {

        }

        static void ToonAutos()
        {

        }

        static void ToonKlanten()
        {

        }

        static void ToonVerhuurdeAutos()
        {

        }

        static void VerhuurAuto()
        {

        }

        static List<Auto> GeefAutoOpVoorkeuren(double vermogen, string merk)
        {
            //Lijst clonen
            List<Auto> autosopvoorkeuren = new List<Auto>();

            foreach (Auto item in autos)
            {
                autosopvoorkeuren.Add(item);
            }

            for (int i = autosopvoorkeuren.Count-1; i>=0; i--)
            {
                if (!/*Voorkeur*/)
                {
                    autosopvoorkeuren.RemoveAt(i); //Verwijder dingen die niet aan voorkeur voldoen
                }
            }


            return autosopvoorkeuren;
        }

        static void ToonAutosOpVoorkeuren()
        {

        }
    }
}
