using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    internal class Voiture
    {
        private string _marque;
        private string _couleur;
        private int _matricule;
        private int _nombre_de_chevaux;

        public Voiture()
        {

        }

        public Voiture(string _marque, string _couleur, int _matricule, int _nombre_de_chevaux)
        {
            Marque = _marque;
            Couleur = _couleur;
            Matricule = _matricule;
            Nombre_de_chevaux = _nombre_de_chevaux;
        }

        public Voiture(int matricule)
        {
            Matricule = _matricule;
        }




        public string Marque { get; set; }
        public string Couleur { get; set; }

        public int Matricule { get; set; }


        public int Nombre_de_chevaux { get; set; }
        public string Presentation()
        {
            return $"Marque -->{Marque} :: Couleur-->{Couleur} :: Matricule-->{Matricule}:: Nombre_de_chevaux-->{Nombre_de_chevaux}";
        }
    }


}



   




