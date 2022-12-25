using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices12
{
   
    public class Personne
    {
        private int _age;

        public int Age
        {

            get { return _age; }
            set
            {
                if (value < 18)
                {
                    throw new PersonneMineurException("la personne doit avoir plus de 18 ans");
                }
                else
                {
                    _age = value;
                }

            }
        }

        public Personne(int age)
        {
            _age = Age;
        }

                        

    }
}
