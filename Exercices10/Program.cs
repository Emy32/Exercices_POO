using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Exercices10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BiMoteurs BiMoteur1 = new("1-BZC-003 ", "Beechcraft Baron", new DateTime(2017, 03, 21), 6);
            BiMoteurs BiMoteur2 = new("25-RWB-493", "Piper Seneca", new DateTime(2016, 12, 15), 7);

            Planeur planeur1 = new("1-ABC-003", "AS-33", new DateTime(2020, 01, 23), 285);
            Planeur planeur2 = new("5-GTF-103", "Lange Antares 21E", new DateTime(2018, 12, 15), 485);
            Planeur planeur3 = new("4-BCZ-452 ", "Nord 2000 ", new DateTime(1947, 02, 25), 176);
            Planeur planeur4 = new("2-HYD-546 ", "L-Spatz 55 ", new DateTime(1952, 07, 12), 152);

            List <Avion> lstAvion = new List<Avion>() {BiMoteur1,BiMoteur2,planeur1,planeur2,planeur3,planeur4 };
            lstAvion.Add(BiMoteur1);
            lstAvion.Add(BiMoteur2);

            foreach (Avion avions in lstAvion)
            {
                Console.WriteLine(avions.Description());
            }
           
            BiMoteur2.Demarrer();
            planeur2.Atterir();

        }
    }
}
