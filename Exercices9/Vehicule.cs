using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices9
{
    public class Vehicule
    {
        private static int _identifiant;
        private string _immatriculation;
        private string _fabricant;
        private string _modele;
        private DateTime _dateFabrication;
        private int _id;
       

        public static int Identifiant
        {
            get { return _identifiant; }
             set { _identifiant = value ; }
        }
        public string Immatriculation
        {
            get { return _immatriculation; }
            set { _immatriculation = value; }
        }
       
        public string Fabricant
        {
            get { return _fabricant; }
            set { _fabricant = value; }
        }
        public string Modele
        {
            get { return _modele; }
            set { _modele = value; }
        }
        public DateTime DateFabrication
        {
            get { return _dateFabrication; }
            set { _dateFabrication = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
       
        public Vehicule(string immatriculation,string fabricant,string modele,DateTime dateFabrication)
        {
             Immatriculation = immatriculation;
            Fabricant = fabricant;
            Modele = modele;
            DateFabrication = dateFabrication;
            Id = Identifiant++;



        }

       

        public  virtual string Description()
        {
            return $"Identifiant::{Id} Immatri ::{Immatriculation} Fabricant::{Fabricant} Modele::{Modele} DateFabri::{DateFabrication}";


        }
        public virtual void Demarrer()
        {
            Console.WriteLine("le vehicule demarre");
        }
        public virtual void Accelerer()
        {
            Console.WriteLine("le vehicule accelere");
        }



    }
}
