using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices10
{
    public class Avion
    {
        private  static int _identifiant;
        private string _immatriculation;
        private string _modele;
        private DateTime _dateConstruction;
        private int _nbreId;

        
        public static int Identifiant
        {
            get { return _identifiant; }
            set { _identifiant = value; }
        }
        public string Immatriculation
        {
            get { return _immatriculation; }
            set { _immatriculation = value; }
        }
        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }
       

        public DateTime DateConstruction
        {
            get { return _dateConstruction; }
            set { _dateConstruction = value; }
        }
       

        public int NbreId
        {
            get { return _nbreId; }
            set { _nbreId = value; }
        }
        public Avion(string immatriculation,string modele,DateTime dateConstruction)
        {
                _immatriculation = immatriculation;
                _modele = modele;
                _dateConstruction = dateConstruction;
                _nbreId = Identifiant++;

        }

        public  virtual string Description()
        {
            return $"Identifiant {NbreId} ; Immatriculation {Immatriculation}; Modele  {Modele}; DateConstruction {DateConstruction}";
        }

        public virtual void Demarrer()
        {

        }
        public virtual void Atterir()
        {

        }






    }
}
