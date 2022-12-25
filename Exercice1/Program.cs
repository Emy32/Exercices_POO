using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice1
{
    public class Program
    {
        class Rectangle
        {
            #region attributs (permet de stocker les attributs)

            private float _longueur;// de facto les proprietes sont private pour respecter le principe d encapsulaton
           private float _largeur;// le enderscores est une questions de nomenclatures(nom)
          // private float _surface;

            #endregion getters & setters
            public float getLongeur()
            { 
                return _longueur; 
            }

            public void setLongeur(float l)
            {
                _longueur = l;
            }

            //public float surface
            //{
                //get { return _surface; }
                //set { _surface = value; } //ecriture equivalent a plus haut
            //}
            public float surface { get; set; } // dans ce cas on supprime le public surface d en haut
            public float longueur
            {
                get { return _longueur; }
                set { _longueur = value; } //ecriture equivalent a plus haut
            }

           
            public float calculerSurface()
            {
                return _longueur * _largeur;
            }

            //le constructeur
            public float calculerPerimetre()
            {
                return 2 * _longueur + 2 * _largeur;
            }
            
            //le constructeur
            public Rectangle(float l, float L)
            {
                _longueur = l;
                _largeur = L;
                //_surface = l * L;
            }
        }
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5,8);
            Console.WriteLine(rect.getLongeur());
            rect.setLongeur(12);
            Console.WriteLine(rect.getLongeur());
            Console.ReadKey();
        }
    }
}
