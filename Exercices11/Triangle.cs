using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices11
{
    public class Triangle : FormeGeometrique
    {
        private float _a;
        private float _b;
        private float _c;

        public float A
        {
            get { return _a; }
            set { _a = value; }
        }

        public float B
        {
            get { return _b; }
            set { _b = value; }
        }
        public float C
        {
            get { return _c; }
            set { _c = value; }
        }
        public Triangle()
        {
                _a = A;
                _b = B;
                _c = C;
        }
        public override float CalculerPerimetre()
        {
           return A + B + C;    
        }

        public override float CalculerSurface()
        {
            return B + C;
        }

        public override float CalculerVolume()
        {
            throw new NotImplementedException();
        }
    }
}
