using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercices5
{
    public class Animal
    {
        private string _cri;
        private int _age;
        private int _ageMaximun;
        

        public int Age
        {
            get { return _age; } 
            set { _age = value; }    
        }
        public int AgeMaximun
        {
            get { return _ageMaximun; }
             private set { _ageMaximun = value; }
        }
        public string cri
        {
             get{return _cri; }
             set{ _cri = value;   }
        }

        public Animal(int Age, int AgeMaximunm)  //constructeur
        {
            Age = _age;
            AgeMaximunm = _ageMaximun;
        }
       

        public Animal( int Age, int AgeMaximunm, string Cri) //constructeur
        {
            _age = Age;
            _ageMaximun = AgeMaximunm;
        }

        public void Crie()   //methode
        {
            Console.WriteLine("crie");
        }
        public void seDeplace(int nbMetre) //methode
        {
          
            Console.WriteLine($"l'animal se dplace de {nbMetre} ");

        }

        public void vieillit()  //methode
        {
            vieillit(1);
        }
        public void vieillit(int age)   // on ajoute void quand ça ne retourn rien (donc on ne doit pas ajouter return
        {
              Age += age;
            if(Age > _ageMaximun)
            {
                Console.WriteLine(" l animal est mort,il a depasse son esperance de vie");
            }
            else
            {
                Console.WriteLine($" l animal a {Age} ans il est toujours vivant");
            }
        }

        public void mange() //methode
        {
            Console.WriteLine("mange");
            Crie();
        }

        public void description() //methode
        {
                Console.WriteLine();
        }

      
        public class Oiseau:Animal  //classe enfant
        {
            
            public Oiseau(int Age, int AgeMaximunm, string Cri) : base(Age, AgeMaximunm,Cri) //constructeur
            {
             
                AgeMaximun = 20;
            }

            public void Vole()  //methode
            {

            }


            public class Aigle : Oiseau   //classe enfant
            {
                public Aigle(int Age, int AgeMaximunm,string Cri) : base(Age, AgeMaximunm,Cri)
                {
                    AgeMaximun = 10;
                }
            }
        }

        public class Chien : Animal  //classe enfant
        {
            private string _nom;

           

            public string Nom
            {
                get { return _nom; }
                set { _nom = value; }
            }

            public Chien(string Nom,int Age, int AgeMaximunm,string Cri) : base(Age, AgeMaximunm,Cri)
            {
                _nom = Nom;
                AgeMaximun = 15;
                

            }

            private void Marche()
            {
              
            }
        }
            

    }
}
