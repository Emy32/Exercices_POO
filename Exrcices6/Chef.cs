using Exrcices6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices6
{
    public class Chef : Employe
    {
        private string _service;

        public Chef(string nom, string prenom, DateTime date, float salaire,string Service) : base(nom, prenom, date, salaire)// toujours reprendre les attributs du constructeurs parents
        {
            _service = nom;

        }

        public string Service
        {
            get { return _service; }
            set { _service = value; }
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("*** service :" + Service);
        }


    }
}
