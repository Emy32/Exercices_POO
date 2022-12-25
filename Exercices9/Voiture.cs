using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices9
{
    public class Voiture : Vehicule
    {
        private string _natureTermique;

        public string NatureTermique
        {
            get { return _natureTermique; }
            set { _natureTermique = value; }
        }

        public Voiture(string immatriculation, string fabricant, string modele, DateTime dateFabrication, string natureTermique) : base(immatriculation,fabricant, modele, dateFabrication)
        {
            
            NatureTermique = natureTermique;
        }
        public override string Description()
        {
            return base.Description() + " :: " + NatureTermique;
            // return $"Identifiant::{identifiant} Immatriculation ::{immatri} Fabricant::{Fabricant} Modele::{Modele} Nature::{NatureThermique}; 2eme maniere
        }

        public override void Accelerer()
        {
            Console.WriteLine($"la voiture {Fabricant} {Modele} accelere");
        }
        public override void Demarrer()
        {
            Console.WriteLine($"la voiture {Fabricant}  {Modele} demarre");
        }

    }
}
