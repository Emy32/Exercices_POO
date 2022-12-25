using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculatrice
{
    public partial class CalculatriceForm: Form
    {
        

        public CalculatriceForm()
        {
            InitializeComponent();
        }
        private void TxtAB_KeyPress(object sender, KeyPressEventArgs e)
           
            /* lorsque le code se repete pour un meme Txt label, on peut ultiliser le sender
             comme ainsi et renommer les deux text label ou 3 avec le meme nom ex TxtAB
            Pour le label A et B*/
        {
            TextBox txb = (TextBox)sender;// sender c est l objet evenement

            bool IsPointPresent = (tbxA.Text.IndexOf('.') != -1);
            /*int i = tbxA.Text.Split('.').Length;pour afficher qu un point*/
            //TxtA.Text.indexOf('.',i) pour afficher qu un point aussi

            if(!txb.Text.Contains("."))
            { 
               if (txb.Text.IndexOf('.') == -1) //deja 1 point

               {
                                 

                    if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' ||e.KeyChar =='-'))
                    //IsControl permet de revenir ou d effacer
                    {
                        e.Handled = true;
                    }
                    else
                    { 
                            if(txb.Text != "")
                            {
                                if(e.KeyChar =='-')
                                    e.Handled = true;
                            }
                    }
                  

               }
            }
            else
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '-'))
                {
                    e.Handled = true;
                }
                else
                {
                    if (txb.Text != "")
                    {
                        if (e.KeyChar == '-')
                            e.Handled = true;
                    }
                }

            }

        } 
        // contrainte factorisé plus court 
       // bool test1 = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);  -> Autorisé
       // bool test2 = e.KeyChar == '.' && !txb.Text.Contains("."); -> autorisé
      //  bool test3 = e.keychar == '-' && txb.text == ""; ->autorise|| test3); -> autorisé

        //e.Handeld = !(tes1 || tes2 || test3); -> autorisé




        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                float A = float.Parse(tbxA.Text);
                float B = float.Parse(tbxB.Text);

                LblInformation.Text = (A + B).ToString();
                LblInformation.ForeColor = Color.Black;
                LblInformation.BackColor = Color.AliceBlue;
                LblInformation.Show();


            }
            catch 
            {
                LblInformation.Text = "Une erreur de saisie a été détectée !! ";
                LblInformation.ForeColor = Color.White;
                LblInformation.BackColor = Color.Red;
                LblInformation.Show();

            }


        }


        private void btn_diff_Click(object sender, EventArgs e)
        {
            try
            {
                float A = float.Parse(tbxA.Text);
                float B = float.Parse(tbxB.Text);

                LblInformation.Text = (A - B).ToString();
                LblInformation.ForeColor = Color.Black;
                LblInformation.BackColor = Color.AliceBlue;
                LblInformation.Show();


            }
            catch /*lorsqu on ne met rien l exception prend toute les erreurs mais
                   on ne sait pas exactement laquelle*/
            {

                LblInformation.Text = "Une erreur de saisie a été détectée !! ";
                LblInformation.ForeColor = Color.White;
                LblInformation.BackColor = Color.Red;
                LblInformation.Show();
            }

        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            try
            {
                float A = float.Parse(tbxA.Text);
                float B = float.Parse(tbxB.Text);

                LblInformation.Text = (A * B).ToString();
                LblInformation.ForeColor = Color.Black;
                LblInformation.BackColor = Color.AliceBlue;
                LblInformation.Show();

            }
            catch 
            {

                LblInformation.Text = "Une erreur de saisie a été détectée !! ";
                LblInformation.ForeColor = Color.White;
                LblInformation.BackColor = Color.Red;
                LblInformation.Show();
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
           

           
            try
            {
                float A = float.Parse(tbxA.Text);
                float B = float.Parse(tbxB.Text);

                LblInformation.Text = (A / B).ToString();
                LblInformation.ForeColor = Color.Black;
                LblInformation.BackColor = Color.AliceBlue;
                LblInformation.Show();

            }
            catch
            {

                LblInformation.Text = "Une erreur de saisie a été détectée !! ";
                LblInformation.ForeColor = Color.White;
                LblInformation.BackColor = Color.Red;
                LblInformation.Show();

            }
            
        }

        private void btn_gomme_Click(object sender, EventArgs e)
        {
            LblInformation.Text = tbxA.Text = tbxB.Text = String.Empty;
            LblInformation.Hide();
            //autre maniere de gommer les labels
            tbxA.Text = "";
            tbxB.Text = "";
            LblInformation.Text = "";

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous sûr(e) de vouloir quitter ?", "Demande de confirmation",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void LblInformation_TextChanged(object sender, EventArgs e)
        {/* label pour l agrandir mettre autoSize a false puis text aligne si on
          veut aligner le texte */

           
        }

        private void TextBox_B_Load(object sender, EventArgs e)
            /* cliquez sur la form meme de la fenetre allez dans les proprietes
             flamme, choisir load ( ca permet de charger en premier plan)*/
        {
            LblInformation.Hide();
        }

      
    }
        
}
