using System;

namespace Calculatrice
{
    partial class Inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNaiss = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.btnValide = new System.Windows.Forms.Button();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbMDP = new System.Windows.Forms.TextBox();
            this.checkBoxMdp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(51, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(68, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(51, 85);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(98, 25);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblNaiss
            // 
            this.lblNaiss.AutoSize = true;
            this.lblNaiss.Location = new System.Drawing.Point(51, 141);
            this.lblNaiss.Name = "lblNaiss";
            this.lblNaiss.Size = new System.Drawing.Size(170, 25);
            this.lblNaiss.TabIndex = 2;
            this.lblNaiss.Text = "DateNaissance :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(51, 203);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(64, 25);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail :";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(270, 25);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(338, 31);
            this.txbNom.TabIndex = 4;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(270, 82);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(338, 31);
            this.txbPrenom.TabIndex = 5;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(270, 203);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(338, 31);
            this.txbMail.TabIndex = 7;
            // 
            // btnValide
            // 
            this.btnValide.Location = new System.Drawing.Point(340, 364);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(200, 54);
            this.btnValide.TabIndex = 8;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = true;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click_1);
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Location = new System.Drawing.Point(270, 141);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(338, 31);
            this.dtpNaissance.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 262);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // txbMDP
            // 
            this.txbMDP.Location = new System.Drawing.Point(270, 259);
            this.txbMDP.Name = "txbMDP";
            this.txbMDP.ShortcutsEnabled = false;
            this.txbMDP.Size = new System.Drawing.Size(338, 31);
            this.txbMDP.TabIndex = 11;
            this.txbMDP.UseSystemPasswordChar = true;
            // 
            // checkBoxMdp
            // 
            this.checkBoxMdp.AutoSize = true;
            this.checkBoxMdp.Location = new System.Drawing.Point(308, 310);
            this.checkBoxMdp.Name = "checkBoxMdp";
            this.checkBoxMdp.Size = new System.Drawing.Size(252, 29);
            this.checkBoxMdp.TabIndex = 12;
            this.checkBoxMdp.Text = "Afficher mot de passe";
            this.checkBoxMdp.UseVisualStyleBackColor = true;
            this.checkBoxMdp.CheckedChanged += new System.EventHandler(this.checkBoxMdp_CheckedChanged);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxMdp);
            this.Controls.Add(this.txbMDP);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(this.btnValide);
            this.Controls.Add(this.txbMail);
            this.Controls.Add(this.txbPrenom);
            this.Controls.Add(this.txbNom);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNaiss);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Name = "Inscription";
            this.Text = "Inscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNaiss;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbMDP;
        private System.Windows.Forms.CheckBox checkBoxMdp;
    }
}