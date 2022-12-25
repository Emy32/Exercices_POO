using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Inscription : Form
    {
        private UserBDD UserBDD= new UserBDD();
       
        public Inscription()
        {
            InitializeComponent();
           
        }

        private void checkBoxMdp_CheckedChanged(object sender, EventArgs e)
        {
            txbMDP.UseSystemPasswordChar = !checkBoxMdp.Checked;

        }




        private void btnValide_Click_1(object sender, EventArgs e)
        {
            try
            {
                User user = new User(txbNom.Text,txbPrenom.Text,dtpNaissance.Value,txbMail.Text,txbMDP.Text);
                UserBDD.AddUser(user);
                   
            }catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        

        
    }




        
    
}
