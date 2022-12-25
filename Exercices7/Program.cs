using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercices7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Planete Mercure = new Planete("Mercure", 0.06f, 0.382f);
            Planete Venus = new Planete("Venus", 0.82f, 0.949f);
            Planete Terre = new Planete("Terre", 1.00f, 1.00f);
            Planete Mars = new Planete("Mars", 0.11f, 0.532f);
            Planete Jupiter = new Planete("Jupiter", 317.8f, 11.209f);

            Galaxie Galaxie = new Galaxie();
            Galaxie.Noms = "Voie_lactée";

            Galaxie.lstPlanetes = new List<Planete>() { Mercure, Venus, Terre, Mars };
            Galaxie.lstPlanetes.Add(Jupiter);

            Console.WriteLine(Galaxie.Description());

            foreach (Planete p in Galaxie.lstPlanetes)
            {
                Console.WriteLine(p.Description());
            }



        }

    }
}
