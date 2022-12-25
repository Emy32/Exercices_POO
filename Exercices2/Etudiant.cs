using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices2
{
   public class Etudiant
    {
        private string _Nom;
        private string _prenom;
        private int _age;
        private string _genre;

        public string getNom()
        {
            return _Nom;
        }
        public void setNom(string nom)
            { 
            _Nom = nom;
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }
            
            set
            {
                _prenom = value;
            }
                }
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string genre { get;set; }

        public void sePresenter()
        {
            Console.WriteLine($"Bonjour, je m appelle {genre} {_Nom} {_prenom} et j ai {_age} ans");
        }
    }
}
