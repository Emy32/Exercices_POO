using Exercices6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices7
{
    public class Directeur : Chef
    {
        private string _societe;
        public string Societe
        {
            get { return _societe; }
            set { _societe = value; }
        }
        public Directeur(string nom, string prenom, DateTime date, float salaire, string service, string societe) : base(nom, prenom, date, salaire, service)
        {
            Societe = societe;
        }
        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" *** Societe: " + Societe);
        }
    }
}
