using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercices4
{
    public class Salaire
    {
        private int _matricule;  //attributs
        private string _nom;
        private string _prenom;
        private float _salarie;
        private float _tauxCs;
        static float SalaryNet;
        private  int _id = 1;
        private  static int _GlobalId = 1;

        public int Matricule   // profull pour creer les attributs directements et les accesseurs                   
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public string Nom
        { get { return _nom; }
            set { _nom = value; }
        }
        public int Id 
        { 
            get{return _id;}
           
        }

            
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public float Salarie
        {
            get { return _salarie; }
            set { _salarie = value; }
        }

        public float TauxCs
        {
            get { return _tauxCs; }
            set { _tauxCs = value; }
        }

       
        public Salaire()     //constructeur par defaut
        {
            _GlobalId++;
            _id = _GlobalId;
        }

        public Salaire(int matricule) :this()  // constructeur qui permet de renseigner le matricule this() fait allusion a GlobalId++
        {
            Matricule =matricule;
        }

        public Salaire(int matricule, string nom) :this() //constructeur qui instancie l attribut matricule et le nom
        {
            Matricule = matricule;
            Nom = nom;


        }

        public Salaire( string _nom,string _prenom, int _matricule,float _salarie,float _tauxCs) :this() // constructeur qui instancie tous les attributs
        {
            
            Matricule = _matricule;
            Nom = _nom;
            Prenom = _prenom;
            Salarie = _salarie;
            TauxCs = _tauxCs;

            
        }

        public float CalculerSalaireNet()  // methode
        {
           
          Console.WriteLine($"Le salaire net de l'employé {Nom} {Prenom} Matricule-->{Matricule} salaire -->{Salarie} a pour salaire net: ");
            SalaryNet = Salarie - (Salarie * TauxCs);

            return  SalaryNet ;  
           
        }

    }

} 


   

