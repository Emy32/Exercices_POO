using Exercices5_bis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices5_Bis
{
    public class Oiseau : Animal
    {

        
        private static readonly int _ageMaximum = 20; // readonly pour dire securiser un peu plus

        public static int AgeMaximum
        {
            get { return _ageMaximum; }
        }
        public Oiseau(int age, string cri) : base(age, AgeMaximum)// si on enleve base ici on doit le mettre en bas comme suit
        {
            //base.AgeMaximum= AgeMaximum;
        }

        public Oiseau(int Age, int AgeMaximunm, string Cri) : base(Age, AgeMaximunm, Cri)
        {
        }

        public new void seDeplace(int nbMetre) //methode
        {

            Console.WriteLine($"l'oiseau vole de {nbMetre} metres");

        }
    }
}
