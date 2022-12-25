using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();
            login.ShowDialog();

            if(login.isValidLogin == true)
            {
                CalculatriceForm calculate = new CalculatriceForm();
                calculate.ShowDialog();
            }
           // Application.Run(new LoginForm());
            
        }
    }
}
