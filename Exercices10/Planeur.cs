using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices10
{
    public class Planeur : Avion
    {
        private int _poids;

        public int Poids
        {
            get { return _poids; }
            set { _poids = value; }
        }

        public Planeur(string immatriculation, string modele, DateTime dateConstruction, int poids) : base(immatriculation, modele, dateConstruction)
        {
            _poids = poids;
        }
        public override string Description()
        {

            return base.Description() + $"::Poids: {Poids}";
        }

        public override void Demarrer()
        {
            Console.WriteLine($"le Planeur immatricu:{Immatriculation} modele:{Modele} dateConst:{DateConstruction} poids:{Poids} est tracté et prend de la vitesse!");
        }
        public override void Atterir()
        {
            Console.WriteLine($"le Planeur immatricu: {Immatriculation}  modele:{Modele}  dateConst:{DateConstruction}  poids:{Poids} perd de l'altitude!");
        }
    }
}
