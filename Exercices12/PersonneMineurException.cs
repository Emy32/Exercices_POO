using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices12
{
    public class PersonneMineurException : Exception
    {

        public PersonneMineurException(string? message) : base(message)
        {

        }
    }
}
