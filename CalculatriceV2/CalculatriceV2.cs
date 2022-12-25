using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatriceV2
{
    public partial class CalculatriceV2 : Form
    {
        
        public CalculatriceV2()
        {
            InitializeComponent();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioSom_CheckedChanged(object sender, EventArgs e)
        {
            
            try
            {
                float nbreA = float.Parse(textBoxA.Text);
                float nbreB = float.Parse(textBoxB.Text);
                LblResult.Text = (nbreA + nbreB).ToString();
                LblResult.ForeColor = Color.Black;
                LblResult.BackColor = Color.Beige;
                LblResult.Show();
            }catch
            {

            }

        }

        private void radioDiff_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float nbreA = float.Parse(textBoxA.Text);
                float nbreB = float.Parse(textBoxB.Text);
                LblResult.Text = (nbreA - nbreB).ToString();
                LblResult.ForeColor = Color.Black;
                LblResult.BackColor = Color.Beige;
                LblResult.Show();
            }catch
            {

            }
            
        }

        private void radioProd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float nbreA = float.Parse(textBoxA.Text);
                float nbreB = float.Parse(textBoxB.Text);
                LblResult.Text = (nbreA * nbreB).ToString();
                LblResult.ForeColor = Color.Black;
                LblResult.BackColor = Color.Beige;
                LblResult.Show();

            }
            catch
            { 

            }
            

        }

        private void radioQuot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float nbreA = float.Parse(textBoxA.Text);
                float nbreB = float.Parse(textBoxB.Text);
                LblResult.Text = (nbreA / nbreB).ToString();
                LblResult.ForeColor = Color.Black;
                LblResult.BackColor = Color.Beige;
                LblResult.Show();
            }catch
            {


            }
            

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblResult.Hide();
        }

        //factorisation du code 

        //private class CalculeAB
        //{
        //    public float A { get; set; }
        //    public float B { get; set; }

        //    public CalculeAB(float a, float b)
        //    {
        //        A = a;
        //        B = b;
        //    }
        //    public CalculeAB(string a, string b)
        //    {
        //        try
        //        {
        //            A = float.Parse(a);
        //            B = float.Parse(b);
        //        }
        //        catch
        //        {
        //            throw;
        //        }
        //    }

        //    public float Add()
        //    {
        //        return A + B;
        //    }

        //    public float Diff()
        //    {
        //        return A - B;
        //    }

        //    public float Prod()
        //    {
        //        return A * B;
        //    }

        //    public float Div()
        //    {
        //        float result = A / B;
        //        if (float.IsInfinity(result))
        //            throw new DivideByZeroException();

        //        return result;

        //    }
        //}
        //public CalculatriceV2Form()
        //{
        //    InitializeComponent();
        //}
        //private void DisplayInfo(string information, bool IsError = false)
        //{
        //    lblInformation.Text = information;

        //    if (IsError)
        //    {
        //        lblInformation.ForeColor = Color.White;
        //        lblInformation.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        lblInformation.ForeColor = Color.Black;
        //        lblInformation.BackColor = Color.AliceBlue;
        //    }

        //    lblInformation.Show();

        //}
        //private void lblExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //private void lblGomme_Click(object sender, EventArgs e)
        //{
        //    lblInformation.Text = tbxA.Text = tbxB.Text = String.Empty;
        //    lblInformation.Hide();

        //}
        //private void btnOperation_Click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;

        //    try
        //    {
        //        CalculeAB opAB = new CalculeAB(tbxA.Text, tbxB.Text);

        //        if (btn == btnAdd)
        //            DisplayInfo(opAB.Add().ToString());

        //        if (btn == btnDiff)
        //            DisplayInfo(opAB.Diff().ToString());

        //        if (btn == btnProd)
        //            DisplayInfo(opAB.Prod().ToString());

        //        if (btn == btnDiv)
        //            DisplayInfo(opAB.Div().ToString());
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        DisplayInfo("Vous ne pouvez pas diviser par zéro !! ", true);
        //    }
        //    catch
        //    {
        //        DisplayInfo("Une erreur de saisie a été détectée !! ", true);
        //    }
        //}
        //private void CalculatriceForm_Load(object sender, EventArgs e)
        //{
        //    lblInformation.Hide();
        //    tbxA.Focus();
        //}
        //private void tbxAB_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    TextBox txb = (TextBox)sender;

        //    if (txb.Text.IndexOf('.') == -1)
        //    {
        //        if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.'))
        //        {
        //            e.Handled = true;
        //        }
        //    }
        //    else
        //    {
        //        if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
        //        {
        //            e.Handled = true;
        //        }
        //    }

        //}
        //private void tbxAB_TextChanged(object sender, EventArgs e)
        //{
        //    lblInformation.Hide();
        //}
    }
}
