using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemple_WinForm1
{
    public partial class MaFenetreWindows : Form
    {
        //private int _compteur =0;
        //private int _decompter;
        public MaFenetreWindows()
        {
            InitializeComponent();
        }

      

        private void btn_Envoyer_Click(object sender, EventArgs e)
        {
            //_compteur++;
            // MessageBox.Show(_compteur.ToString());   incrementer +1

            if (IsFormsMail())
            {
                using (MailMessage emailMessage = new MailMessage())
                {
                    emailMessage.From = new MailAddress("testmailiepsmpoo@gmail.com");
                    emailMessage.To.Add(new MailAddress(txb_A.Text, "POO"));
                    emailMessage.Subject = txb_C.Text;
                    emailMessage.Body = richTextBox1.Text;
                    emailMessage.Priority = MailPriority.Normal;
                    using (SmtpClient MailClient = new SmtpClient("smtp.gmail.com", 587))
                    {
                        MailClient.EnableSsl = true;

                        MailClient.Credentials = new System.Net.NetworkCredential("testmailiepsmpoo@gmail.com", "qceeibbssspszbbx");
                        MailClient.Send(emailMessage);
                    }
                }
            }
            else
            {

            }


        }

        private bool isMailValid(string mail)
        {
            return true; // => Si le mail est valid
        }
        private bool IsFormsMail()
        {
            if (!isMailValid(txb_A.Text))
                return false;

            if (txb_B.Text != "")
                if (!isMailValid(txb_B.Text))
                    return false;

            return true;
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            if (txb_A.Text == "")
            {
                MessageBox.Show("Merci de saisir un destinataire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Mail envoyé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MaFenetreWindows_Load(object sender, EventArgs e)
        {

        }

        private void txb_A_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
