using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public class User
    {
        private string _password;

        private class UserInvalidPasswordException : Exception
        {
            public UserInvalidPasswordException(string message) : base(message)
            {
            }
        }
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        
        public string Mail { get; set; }
        public string Password 
        {
            get { return _password; }
            set
            {

                if (!IsValidPassword(value))
                {
                    throw new UserInvalidPasswordException("Le Mot de passe est invalide !!!");
                }
                else
                {
                    _password = value;
                }
            }
        }
        public string Identifiant { get; set; }

        

        public User(string nom, string prenom, DateTime dateNaissance, string mail, string password)
        {
            
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Mail = mail;
            Password = password;
           
        }

        
        public bool IsValidUser()
        {
            if (!IsNotEmptyOnlyLetters(Nom))
            {
               
                return false;
            }

            if (!IsNotEmptyOnlyLetters(Prenom))
            {
                
                return false;
            }

            if (!IsValidEmail(Mail))
            {
                return false;
            }

            if (DateNaissance > DateTime.Today.AddYears(-18))
            {
               
                return false;
            }

            if (!IsValidPassword(Password))
            {
                return false;
            }
            return true;
        }

        private bool IsValidPassword(string pass)
        {
            if (pass == null)
                return false;

            if (pass.Length < 8)
                return false;

            bool ExistUpper = false;
            bool ExistDigit = false;

            foreach (char caractere in pass)
            {
                if (char.IsUpper(caractere))
                    ExistUpper = true;

                if (char.IsDigit(caractere))
                    ExistDigit = true;
            }

            return ExistUpper && ExistDigit;

        }

        private bool IsNotEmptyOnlyLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            foreach (char caractere in s)
            {
                if (!char.IsLetter(caractere))
                    return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            //Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9-])([a-zA-Z0-9_-.]*)@([((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]).){3}|((([a-zA-Z0-9-]+).)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])])$");

            //return !mRegxExpression.IsMatch(email);

            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                MailAddress address = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }

        }
    }
}
