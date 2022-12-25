using Exercices5_bis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercices5_Bis
{
    public class Chien : Animal
    {
        private string _nom;
        private static int _age = 15;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public static int Age
        {
            get { return _age; }
        }
        public Chien(int Age, int AgeMaximum, string Cri,string Nom) : base(Age, AgeMaximum, Cri)
        {
           this.Nom = Nom; //toujours utliser le nom du setteur public string Nom
                
        }
        public new void seDeplace(int nbMetre) //methode on a ajouter new pour masquer la methode animal
        {

            Console.WriteLine($"le chien marche de {nbMetre} ");

        }
    }
}
