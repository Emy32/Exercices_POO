using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercices9
{
       public class Camion : Vehicule
       {
        private int _poids;

        public int Poids
        {
            get { return _poids; }
            set { _poids = value; }
        }

        public Camion( string immatriculation, string fabricant, string modele, DateTime dateFabrication,int poids) :base(immatriculation, fabricant,  modele, dateFabrication)
        {
            Poids = poids;
        }

        public override string Description()
        {
            return base.Description() + " Poids (en tonnes): " + Poids;

        }
        public override void Demarrer()
        {
            Console.WriteLine($"Le camion {Fabricant} {Modele} démarre");
        }
        public override void Accelerer()
        { 
            Console.WriteLine($"Le camion {Fabricant} {Modele} accélère");
        }




    }
}
