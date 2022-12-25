using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices11
{
    public abstract class FormeGeometrique
    {
        public abstract float CalculerPerimetre();//quand on met la methode abstract, la classe doit etre obligatoirement abstract

        public abstract float CalculerSurface();


        public abstract float CalculerVolume();
        
    }
}
