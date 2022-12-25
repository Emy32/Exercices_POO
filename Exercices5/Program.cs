using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal chat = new Animal(2, 15, "miaou miaou");

            chat.mange();
            chat.Crie();
            chat.seDeplace(5);
            chat.vieillit(2);
            chat.vieillit(15);  

        }
    }
}
