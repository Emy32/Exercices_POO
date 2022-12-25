using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices1Bis
{
    internal class Classe
    {
        public  Classe()
        {


        }
            
            
        private string _matiere;
        private Professeur _prof;
        private List<Etudiant> etudiants;

        public List<Etudiant> Etudiants { get; set; }
       

        public Professeur Prof { get; set; }
       

        public string Matiere { get; set; }
       

        public void SePresenter()
        {
            Console.Write($"la classe de {Matiere} est enseigné par {Prof.Genre} {Prof.Nom} {Prof.Prenom} et les étudiants participant au cours sont ");
            foreach (Etudiant student in Etudiants)
            {
                Console.Write($"{student.Nom} {student.Prenom} ");
            }


        }
      
    }

}   

