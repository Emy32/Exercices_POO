using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices7
{
    public class Galaxie          
    {
        private string _nom;
        private List<Planete> _lstPlanetes;
       
        


        public string Noms
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public List<Planete> lstPlanetes
        {
            get { return _lstPlanetes; }
            set { _lstPlanetes = value; }

        }
      
       public string Description()
        {
            return $"je suis la galaxie {Noms} et je possede {lstPlanetes.Count} planetes";
        }

    }
    
   
}
