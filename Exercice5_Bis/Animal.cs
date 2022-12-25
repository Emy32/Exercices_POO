using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercices5_bis

{
    public class Animal
    {
        public static string _cri;
        private int _age;
        private  int _ageMaximun;
        

        public int Age

        {
            get { return _age; } 
            set { _age = value; }    
        }
        public int AgeMaximun
        {
            get { return _ageMaximun; }
            set { _ageMaximun = value; }
        }
       
       

        public Animal(int Age, int AgeMaximunm)  //constructeur
        {
            this.Age = Age;// changer de nom ou faire un this pour differencier
           
        }
       

        public Animal( int Age, int AgeMaximunm, string Cri) //constructeur
        {
            this.Age = Age;
           
            _cri = Cri;
           
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

      
      
            
          


    }
}
