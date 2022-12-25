namespace Calculatrice
{
    partial class LoginForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.checkAffiche = new System.Windows.Forms.CheckBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(70, 126);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(105, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Identifiant";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(79, 207);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(106, 25);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Password";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(240, 116);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(456, 35);
            this.txtId.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(130, 352);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(195, 52);
            this.btnValider.TabIndex = 4;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // checkAffiche
            // 
            this.checkAffiche.AutoSize = true;
            this.checkAffiche.Location = new System.Drawing.Point(280, 272);
            this.checkAffiche.Name = "checkAffiche";
            this.checkAffiche.Size = new System.Drawing.Size(275, 29);
            this.checkAffiche.TabIndex = 5;
            this.checkAffiche.Text = "Afficher le mot de passe";
            this.checkAffiche.UseVisualStyleBackColor = true;
            this.checkAffiche.CheckedChanged += new System.EventHandler(this.checkAffiche_CheckedChanged);
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(240, 201);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(456, 31);
            this.txtMdp.TabIndex = 6;
            this.txtMdp.UseSystemPasswordChar = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(488, 352);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(167, 52);
            this.btnCreer.TabIndex = 7;
            this.btnCreer.Text = "Creer compte";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.checkAffiche);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblId);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.CheckBox checkAffiche;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnCreer;
    }
}