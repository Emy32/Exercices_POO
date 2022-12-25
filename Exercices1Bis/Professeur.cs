using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1Bis
{
    internal class Professeur
    {
       
        
            #region attributs ou champs
            private string _nom;
            private string _prenom;
            private string _genre;
            private int _age;
            private Classe classe;
            #endregion

            #region Accesseurs
            public Classe Maclasse
            {
                get { return classe; } // getter et setter classique et la il faut defenir les proprietes:"private int _age;"
            set { classe = value; }
            }
            public int Age { get; set; } // get set sont ici des proprietes c# aux accesseurs classiques et il faut supprimer les attributs : "private int _age;"

        public string Genre
            {
                get
                {
                    string str = string.Empty;
                    if (_genre == "Masculin")
                    {
                        str = "M.";

                    }
                    else
                    {
                        str = "Mme";
                    }

                    return str;
                }
                set { _genre = value; }
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
            #endregion

            public void SePresenter() // prevoir toujours en programmation donc la methode ici normalement c est de definir void  en sting et faire un return
            {
                Console.WriteLine($"Bonjour, je m’appelle {Genre} {Nom} {Prenom} et je suis votre professeur de {Maclasse.Matiere}");

            }
        
}   }
