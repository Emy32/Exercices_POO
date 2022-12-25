using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //creation de la classe etudiant
               Etudiant etudiant1 = new Etudiant();
           
            etudiant1.setNom("DUPONT");
            etudiant1.Prenom = "Pierre";
            etudiant1.genre = "Monsieur";
            etudiant1.age = 35;
            etudiant1.sePresenter();

            Etudiant etudiant2 = new Etudiant();
           etudiant2.setNom("DURANT");
           etudiant2.Prenom = "Nicolas";
           etudiant2.genre = "Monsieur";
           etudiant2.age = 27;
           etudiant2.sePresenter();
          
            Etudiant etudiant3 = new Etudiant();
         etudiant3.setNom("DUMARCHER");
         etudiant3.Prenom = "Elise";
         etudiant3.genre = "Madame";
         etudiant3.age = 25;
         etudiant3.sePresenter();

            Etudiant etudiant4 = new Etudiant();
           etudiant4.setNom("LAPORTE");
           etudiant4.Prenom = "Celine";
           etudiant4.genre = "Madame";
           etudiant4.age = 28;
           etudiant4.sePresenter(); 

           

            


        }
    }
}
