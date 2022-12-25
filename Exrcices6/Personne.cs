using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrcices6
{
    public class Personne
    {
        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;
        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public Personne(string nom, string prenom, DateTime date)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = date;
        }

        public virtual void Afficher()
        {
            Console.Write("Nom : " + Nom + " *** Prenom : " + Prenom + " Date de naissance : " + DateNaissance);
        }

    }
}
