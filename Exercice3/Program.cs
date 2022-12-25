using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercice3
{
    public class Program
    {
        static int model;
        
        public static void Main(string[] args)
        {
            List<Voiture> voitures = new List<Voiture>();

            Voiture voitures1 = new Voiture();
            Voiture voitures2 = new Voiture();
            Voiture voitures3 = new Voiture();
            Voiture voitures4 = new Voiture();
            Voiture voitures5 = new Voiture();

            voitures.Add(voitures1); //  ajouter des voitures a la liste
            voitures.Add (voitures2);
            voitures.Add (voitures3);
            voitures.Add (voitures4);
            voitures.Add (voitures5);

            voitures1.Marque = "Peugeot";
            voitures1.Couleur = "Rouge";
            voitures1.Matricule = 1234;
            voitures1.Nombre_de_chevaux = 3;

            voitures2.Marque = "Toyota";
            voitures2.Couleur = "vert";
            voitures2.Matricule = 5678;
            voitures2.Nombre_de_chevaux = 4;

            voitures3.Marque = "Volvo";
            voitures3.Couleur = "noire";
            voitures3.Matricule = 9147;
            voitures3.Nombre_de_chevaux = 5;

            voitures4.Marque = "Mercedes";
            voitures4.Couleur = "Violet";
            voitures4.Matricule = 7256;
            voitures4.Nombre_de_chevaux = 6;

            voitures5.Marque = "Bmw";
            voitures5.Couleur = "Bleu";
            voitures5.Matricule = 2519;
            voitures5.Nombre_de_chevaux = 7;

            Console.WriteLine(voitures1.Presentation()); 


            foreach (Voiture auto in voitures)
            {
                Console.WriteLine(voitures1.Presentation());
            }

            foreach (Voiture auto in voitures)
            {
                voitures1.Nombre_de_chevaux++;

            }
            foreach (Voiture auto in voitures)
            {
                Console.WriteLine(auto.Presentation());
            }

           
            Console.WriteLine("Entrez le numero de matricule de la voiture:");
              model= int.Parse(Console.ReadLine());

            bool isExist = false;
            foreach(Voiture auto in voitures)
            {
                if(!isExist)
                isExist=(auto.Matricule == model);
                if(isExist)
                {
                    Console.WriteLine(auto.Presentation());
                    break;
                }

            }
            if(isExist == false)
            {
                Console.WriteLine("matricule inexistant");
            }

        }   
            
    }
}
