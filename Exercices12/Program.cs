using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try      //gerer l exception
            {
                Personne p_mineur = new Personne(16);
                Personne p_adulte = new Personne(25);

            }
            catch (PersonneMineurException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
