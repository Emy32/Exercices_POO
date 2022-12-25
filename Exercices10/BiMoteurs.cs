using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices10
{
     public class BiMoteurs : Avion
     {
        private int _nbrePlace;

        public int NbrePlace
        {
            get { return _nbrePlace; }
            set { _nbrePlace = value; }
        }

        public BiMoteurs(string immatriculation, string modele, DateTime dateConstruction, int nbrePlace) : base(immatriculation, modele, dateConstruction)
        {
            _nbrePlace = nbrePlace;
        }

        public override string Description()
        {
           
            return base.Description()+ $"::NbrePlace: {NbrePlace}";
        }

        public override void Demarrer()
        {
            
            Console.WriteLine($"le BiMoteur immatri:{Immatriculation}  modele:{Modele} dateConst:{DateConstruction} place:{NbrePlace} demarre et allume ses moteurs");
        }
        public override void Atterir()
        {
           
            Console.WriteLine($"le BiMoteur immatri:{Immatriculation}  modele:{Modele} dateConst:{DateConstruction} place:{NbrePlace} coupe ses moteurs et ouvre son train d'atterissage");
        }
     }
}
