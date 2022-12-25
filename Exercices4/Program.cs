using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Exercices4
{
    public class Program
    {
        public static void Main(string[] args)
        {
           List<Salaire> employes = new List<Salaire>();  

           Salaire employe = new Salaire("Caron", "Martial", 76900, 2450, 0.2f);
           Salaire employe1 = new Salaire("Dubois", "Sylvain", 60200, 2680, 0.4f);
           Salaire employe2 = new Salaire("Moreau", "Nadine", 30450, 2520, 0.3f);
           Salaire employe3 = new Salaire("Leroy", "Valerie", 28100, 2310, 0.2f);
           Salaire employe4 = new Salaire("Fournier", "Michel", 20480, 2620, 0.3f);

            //employe.Nom = "Caron";
            //employe.Prenom = "Martial";
            //employe.Matricule = 76900;
            //employe.Salarie = 2450;
            //employe.TauxCs = 0.2f;
            

            //employe1.Nom = "Dubois";
            //employe1.Prenom = "Sylvain";
            //employe1.Matricule = 60200;
            //employe1.Salarie = 2680;
            //employe1.TauxCs = 0.4f;
          

            //employe2.Nom = "Moreau";
            //employe2.Prenom = "Nadine";
            //employe2.Matricule = 30450;
            //employe2.Salarie = 2520;
            //employe2.TauxCs = 0.3f;
           

            //employe3.Nom = "Leroy";
            //employe3.Prenom = "Valerie";
            //employe3.Matricule = 28100;
            //employe3.Salarie = 2310;
            //employe3.TauxCs = 0.2f;
          

            //employe4.Nom = "Fournier";
            //employe4.Prenom = "Michel";
            //employe4.Matricule = 20480;
            //employe4.Salarie = 2620;
            //employe4.TauxCs = 0.3f;
           
            employes.Add(employe);
            employes.Add(employe1);
            employes.Add(employe2);
            employes.Add(employe3);
            employes.Add(employe4);

            foreach( Salaire travailleurs in employes)
            {
               Console.WriteLine(travailleurs.CalculerSalaireNet());
            }
        















        }     


    }
        
      
          
}  
