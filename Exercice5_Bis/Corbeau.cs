using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices5_Bis
{
    public class Corbeau : Oiseau
    {
        private static readonly int _vit =10;

        public static int Vit
        {
            get { return _vit; }
        }
        public Corbeau(int Age,int AgeMaximum, string Cri ):base( Age, AgeMaximum, Cri )
        {
            
        }
        public new void seDeplace(int nbMetre)
        {
            Console.WriteLine($"le corbeau vole de {nbMetre}");
        }
    }
}
