using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class LoginForm : Form
    {
        public bool isValidLogin { get; private set; } = false;
        private UserBDD UserBDD = new UserBDD();

        public LoginForm()
        {
        
               
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(UserBDD.ExistUser(txtId.Text,txtMdp.Text))
            {
               
                isValidLogin = true;
                Close();
                    
            }
            else
            {
                MessageBox.Show(" Vous n etes pas autorisé!!!", "Identifiant", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void checkAffiche_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAffiche.Checked == true)
            {
                txtMdp.UseSystemPasswordChar= false;
            }else
            {
                txtMdp.UseSystemPasswordChar= true;
            }

        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
           
           Inscription inscriptionTip = new Inscription();

            Hide();    // pour cacher la fenetre precedente
            inscriptionTip.ShowDialog();

            Show();
            

        }
    }
}
