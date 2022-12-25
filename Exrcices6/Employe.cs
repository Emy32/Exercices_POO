using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrcices6
{
    public class Employe : Personne
    {
        private float _salaire;

        public float Salaire
        {
            get { return _salaire; }
            set { _salaire = value; }
        }

        public Employe(string nom, string prenom, DateTime date, float salaire) : base(nom, prenom, date)
        {
            Salaire = salaire;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" *** Salaire : " + Salaire);
        }

    }
}
