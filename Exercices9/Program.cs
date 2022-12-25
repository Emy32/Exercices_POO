using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Camion camion1 = new("1-BZC-003", "IVECO", "EUROCARGO", new DateTime(2017, 03, 21), 6);
            Camion camion2 = new("25-RWB-493", "Renault Truc", "Gamme D", new DateTime(2016, 12, 15), 12);

            Voiture Voiture1 = new Voiture("1-ABC-003", "Peugeot", "208", new DateTime(2018, 11, 01), "Thermique");
            Voiture Voiture2 = new Voiture("5-GTF-103", "Peugeot", "3008", new DateTime(2020, 12, 15), "Hybride");
            Voiture Voiture3 = new Voiture("4-BCZ-452", "Citroen", "C3", new DateTime(2019, 02, 25), "Thermique");
            Voiture Voiture4 = new Voiture("2-HYD-546", "Renault", "Zoe", new DateTime(2020, 07, 12), "Thermique");

            List<Vehicule> vehiculeList = new List<Vehicule>{ camion1,camion2, Voiture1, Voiture2, Voiture3, Voiture4 };
            vehiculeList.Add(camion1);
            vehiculeList.Add(camion2);
           

            foreach (Vehicule vehicule in vehiculeList)
            {
                Console.WriteLine(vehicule.Description());
            }

            Console.WriteLine(camion1.Description());
            Console.WriteLine(camion2.Description());

            Voiture3.Demarrer();
            camion1.Accelerer();

            // selectionne toutes les plaques qui possedent 3
            foreach (var v in vehiculeList)
            {

                if (v.Immatriculation[v.Immatriculation.Length - 1].ToString() == "3")
                {
                    Console.WriteLine(v.Description());

                }

            }

        }
    }
}
