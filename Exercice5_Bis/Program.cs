using Exercices5_Bis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice5_Bis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Oiseau oiseau = new Oiseau(2,20,"cui cui");
            oiseau.seDeplace(3);
            oiseau.Crie();

            Corbeau corbeau = new Corbeau(2, 10, "croi croi");
            corbeau.seDeplace(5);
            corbeau.Crie();
           

            Chien chien = new Chien(3, 15, "waf waf", "Felix");
            chien.seDeplace(6);
            chien.Crie();
        }
      
    }
}
