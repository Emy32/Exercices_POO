using Exercices6;
using Exercices7;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exrcices6
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Personne> Personnes = new List<Personne>();

            Personnes.Add(new Employe("Pierre", "DUPONT", new DateTime(1984, 12, 15), 1685.95f));
            Personnes.Add(new Employe("Paul", "DURANT", new DateTime(1978, 5, 11), 1885.95f));
            Personnes.Add(new Employe("Alain", "DUMARCHER", new DateTime(1981, 10, 5), 1750.95f));
            Personnes.Add(new Employe("Elyne", "MARCHANT", new DateTime(1990, 11, 15), 1325.95f));
            Personnes.Add(new Employe("Céline", "LAPORTE", new DateTime(1980, 9, 22), 2675.35f));
            Personnes.Add(new Chef("Maxime", "LAPIERRE", new DateTime(1978, 8, 10), 2800.25f, "Finance"));
            Personnes.Add(new Chef("Fabien", "LAMARCHE", new DateTime(1975, 5, 20), 2800.25f, "DRH"));
            Personnes.Add(new Directeur("Sébastien", "LEGRAND", new DateTime(1973, 2, 25), 3500.45f, "Siege", "Auchan"));


            foreach (Personne personne in Personnes) //1ere methode d iteration
            {
                personne.Afficher();
                Console.WriteLine();
            }

            Console.WriteLine("\n**************************************************************\n");


            for (int i = 0; i < Personnes.Count; i++)//2 eme methode d iteration

            {

                Personnes[i].Afficher();
                Console.WriteLine();
            }






        }
        
    }

}
