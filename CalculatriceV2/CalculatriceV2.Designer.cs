namespace CalculatriceV2
{
    partial class CalculatriceV2
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.NbreA = new System.Windows.Forms.Label();
            this.NbreB = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.radioSom = new System.Windows.Forms.RadioButton();
            this.radioDiff = new System.Windows.Forms.RadioButton();
            this.radioProd = new System.Windows.Forms.RadioButton();
            this.radioQuot = new System.Windows.Forms.RadioButton();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NbreA
            // 
            this.NbreA.AutoSize = true;
            this.NbreA.Location = new System.Drawing.Point(85, 48);
            this.NbreA.Name = "NbreA";
            this.NbreA.Size = new System.Drawing.Size(113, 25);
            this.NbreA.TabIndex = 0;
            this.NbreA.Text = "Nombre A:";
            // 
            // NbreB
            // 
            this.NbreB.AutoSize = true;
            this.NbreB.Location = new System.Drawing.Point(85, 106);
            this.NbreB.Name = "NbreB";
            this.NbreB.Size = new System.Drawing.Size(113, 25);
            this.NbreB.TabIndex = 1;
            this.NbreB.Text = "Nombre B:\r\n";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(260, 34);
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(420, 42);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(260, 100);
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(420, 40);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // radioSom
            // 
            this.radioSom.AutoSize = true;
            this.radioSom.Location = new System.Drawing.Point(61, 180);
            this.radioSom.Name = "radioSom";
            this.radioSom.Size = new System.Drawing.Size(115, 29);
            this.radioSom.TabIndex = 4;
            this.radioSom.TabStop = true;
            this.radioSom.Text = "Somme";
            this.radioSom.UseVisualStyleBackColor = true;
            this.radioSom.CheckedChanged += new System.EventHandler(this.radioSom_CheckedChanged);
            // 
            // radioDiff
            // 
            this.radioDiff.AutoSize = true;
            this.radioDiff.Location = new System.Drawing.Point(61, 241);
            this.radioDiff.Name = "radioDiff";
            this.radioDiff.Size = new System.Drawing.Size(141, 29);
            this.radioDiff.TabIndex = 5;
            this.radioDiff.TabStop = true;
            this.radioDiff.Text = "Difference";
            this.radioDiff.UseVisualStyleBackColor = true;
            this.radioDiff.CheckedChanged += new System.EventHandler(this.radioDiff_CheckedChanged);
            // 
            // radioProd
            // 
            this.radioProd.AutoSize = true;
            this.radioProd.Location = new System.Drawing.Point(61, 298);
            this.radioProd.Name = "radioProd";
            this.radioProd.Size = new System.Drawing.Size(111, 29);
            this.radioProd.TabIndex = 6;
            this.radioProd.TabStop = true;
            this.radioProd.Text = "Produit";
            this.radioProd.UseVisualStyleBackColor = true;
            this.radioProd.CheckedChanged += new System.EventHandler(this.radioProd_CheckedChanged);
            // 
            // radioQuot
            // 
            this.radioQuot.AutoSize = true;
            this.radioQuot.Location = new System.Drawing.Point(61, 356);
            this.radioQuot.Name = "radioQuot";
            this.radioQuot.Size = new System.Drawing.Size(124, 29);
            this.radioQuot.TabIndex = 7;
            this.radioQuot.TabStop = true;
            this.radioQuot.Text = "Quotient";
            this.radioQuot.UseVisualStyleBackColor = true;
            this.radioQuot.CheckedChanged += new System.EventHandler(this.radioQuot_CheckedChanged);
            // 
            // LblResult
            // 
            this.LblResult.Location = new System.Drawing.Point(12, 435);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(964, 168);
            this.LblResult.TabIndex = 8;
            this.LblResult.Text = "Information";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 612);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.radioQuot);
            this.Controls.Add(this.radioProd);
            this.Controls.Add(this.radioDiff);
            this.Controls.Add(this.radioSom);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.NbreB);
            this.Controls.Add(this.NbreA);
            this.Name = "Form1";
            this.Text = "Calculatricev2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NbreA;
        private System.Windows.Forms.Label NbreB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.RadioButton radioSom;
        private System.Windows.Forms.RadioButton radioDiff;
        private System.Windows.Forms.RadioButton radioProd;
        private System.Windows.Forms.RadioButton radioQuot;
        private System.Windows.Forms.Label LblResult;
    }
}

