using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices7
{
    public class Planete 
    {
        private string _name;
        private float _masse;
        private float _diametre;


        public string Nom
        {
            get { return _name; }
            set { _name = value; }
        }
        public float Masse
        {
            get { return _masse; }
            set { _masse = value; }
        }
        public float Diametre
        {
            get { return _diametre; }
            set { _diametre = value; }
        }
        public Planete(string Nom, float Masse, float Diametre)
        {

            _name = Nom;
            _masse = Masse;
            _diametre = Diametre;
        }
        public Planete() //constructeur par defaut
        {

        }
        public Planete(string Nom) //constructeur qui permet d instancier le nom
        {
            Nom = _name ;

        }
        public Planete( string Nom,float Diametre):this (Nom) //constructeur qui permet d instancier le nom et this fais reference au nom utiliser plus haut
        {
            
            _diametre = Diametre;

        }

       
         public string Description()
        {
           return $"je suis la planete {Nom} et de Masse :{Masse} relative par rapport a la terre"; 
        }
        
    }
}
