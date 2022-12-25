using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    
    public class UserBDD
    {
        private string _connexionString ="Data Source=EMILIE\\SQLEXPRESS;Database=Login;Trusted_Connection=True;MultipleActiveResultSets=true";

        public bool ExistUser(string Identifiant, string Password)
        {
            try
            {
                using (var conn = new SqlConnection(_connexionString))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand($"SELECT * FROM Connexions WHERE Identifiant = '{Identifiant}' AND Password = '{Password}'", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return true;
                            }

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Une erreur est survenue, veuillez contacter le responsable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        public void AddUser(string nom, string prenom, DateTime dateNaissance, string mail, string password)
        {
            using (SqlConnection conn = new SqlConnection(_connexionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Utilisateurs (Nom, Prenom, DateNaissance, Mail) VALUES ('{nom}','{prenom}','{dateNaissance}', '{mail}');SELECT SCOPE_IDENTITY()", conn))
                    {
                        int IdUtilisateur = Convert.ToInt32(cmd.ExecuteScalar());

                        cmd.CommandText = $"INSERT INTO Connexions (IdUtilisateur, Identifiant, Password) VALUES ({IdUtilisateur},'{mail}','{password}')";
                        cmd.ExecuteNonQuery();

                    }


                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue, veuillez contacter le responsable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }

        public void AddUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(_connexionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand($"INSERT INTO Utilisateurs (Nom, Prenom, DateNaissance, Mail) VALUES ('{user.Nom}','{user.Prenom}','{user.DateNaissance}', '{user.Mail}');SELECT SCOPE_IDENTITY()", conn))
                    {
                        int IdUtilisateur = Convert.ToInt32(cmd.ExecuteScalar());

                        cmd.CommandText = $"INSERT INTO Connexions (IdUtilisateur, Identifiant, Password) VALUES ({IdUtilisateur},'{user.Mail}','{user.Password}')";
                        cmd.ExecuteNonQuery();

                    }

                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue, veuillez contacter le responsable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}

