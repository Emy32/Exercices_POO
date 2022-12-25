using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercices11
{
    public class Cercle : FormeGeometrique
    {
      
        private float _rayon;

        
        public float Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }
        public Cercle()
        {
          
            _rayon = Rayon;
        }

        public override float CalculerPerimetre()
        {
            return (float)(Math.PI * 2 * Rayon);
        }

        public override float CalculerSurface()
        {
            return (float)(Math.PI * Rayon * Rayon);
        }

        public override float CalculerVolume()
        {
            throw new NotImplementedException();
        }
    }
}
