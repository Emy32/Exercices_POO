namespace Calculatrice
{
    partial class CalculatriceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatriceForm));
            this.Lbl_A = new System.Windows.Forms.Label();
            this.Lbl_B = new System.Windows.Forms.Label();
            this.GpeCalcul = new System.Windows.Forms.GroupBox();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_prod = new System.Windows.Forms.Button();
            this.btn_diff = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_gomme = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxA = new System.Windows.Forms.TextBox();
            this.tbxB = new System.Windows.Forms.TextBox();
            this.LblInformation = new System.Windows.Forms.Label();
            this.GpeCalcul.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_A
            // 
            this.Lbl_A.AutoSize = true;
            this.Lbl_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_A.Location = new System.Drawing.Point(28, 88);
            this.Lbl_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_A.Name = "Lbl_A";
            this.Lbl_A.Size = new System.Drawing.Size(302, 62);
            this.Lbl_A.TabIndex = 0;
            this.Lbl_A.Text = "Entrez la valeur de A :\r\n\r\n";
            // 
            // Lbl_B
            // 
            this.Lbl_B.AutoSize = true;
            this.Lbl_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_B.Location = new System.Drawing.Point(28, 139);
            this.Lbl_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_B.Name = "Lbl_B";
            this.Lbl_B.Size = new System.Drawing.Size(302, 31);
            this.Lbl_B.TabIndex = 1;
            this.Lbl_B.Text = "Entrez la valeur de B :\r\n";
            // 
            // GpeCalcul
            // 
            this.GpeCalcul.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GpeCalcul.Controls.Add(this.btn_div);
            this.GpeCalcul.Controls.Add(this.btn_prod);
            this.GpeCalcul.Controls.Add(this.btn_diff);
            this.GpeCalcul.Controls.Add(this.btn_add);
            this.GpeCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpeCalcul.Location = new System.Drawing.Point(34, 224);
            this.GpeCalcul.Margin = new System.Windows.Forms.Padding(4);
            this.GpeCalcul.Name = "GpeCalcul";
            this.GpeCalcul.Padding = new System.Windows.Forms.Padding(4);
            this.GpeCalcul.Size = new System.Drawing.Size(277, 189);
            this.GpeCalcul.TabIndex = 4;
            this.GpeCalcul.TabStop = false;
            this.GpeCalcul.Text = "calculette";
            // 
            // btn_div
            // 
            this.btn_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(163, 105);
            this.btn_div.Margin = new System.Windows.Forms.Padding(4);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(88, 60);
            this.btn_div.TabIndex = 5;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.Location = new System.Drawing.Point(24, 105);
            this.btn_prod.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Size = new System.Drawing.Size(88, 60);
            this.btn_prod.TabIndex = 5;
            this.btn_prod.Text = "x";
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_diff
            // 
            this.btn_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diff.Location = new System.Drawing.Point(163, 34);
            this.btn_diff.Margin = new System.Windows.Forms.Padding(4);
            this.btn_diff.Name = "btn_diff";
            this.btn_diff.Size = new System.Drawing.Size(88, 63);
            this.btn_diff.TabIndex = 5;
            this.btn_diff.Text = "-";
            this.btn_diff.UseVisualStyleBackColor = true;
            this.btn_diff.Click += new System.EventHandler(this.btn_diff_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(24, 35);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(88, 63);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_gomme
            // 
            this.btn_gomme.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_gomme.Image = ((System.Drawing.Image)(resources.GetObject("btn_gomme.Image")));
            this.btn_gomme.Location = new System.Drawing.Point(363, 238);
            this.btn_gomme.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gomme.Name = "btn_gomme";
            this.btn_gomme.Size = new System.Drawing.Size(210, 174);
            this.btn_gomme.TabIndex = 5;
            this.btn_gomme.UseVisualStyleBackColor = true;
            this.btn_gomme.Click += new System.EventHandler(this.btn_gomme_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(598, 239);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 174);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // tbxA
            // 
            this.tbxA.Location = new System.Drawing.Point(363, 75);
            this.tbxA.Multiline = true;
            this.tbxA.Name = "tbxA";
            this.tbxA.Size = new System.Drawing.Size(386, 40);
            this.tbxA.TabIndex = 8;
            this.tbxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAB_KeyPress);
            // 
            // tbxB
            // 
            this.tbxB.Location = new System.Drawing.Point(363, 139);
            this.tbxB.Multiline = true;
            this.tbxB.Name = "tbxB";
            this.tbxB.Size = new System.Drawing.Size(386, 40);
            this.tbxB.TabIndex = 9;
            this.tbxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAB_KeyPress);
            // 
            // LblInformation
            // 
            this.LblInformation.Location = new System.Drawing.Point(-1, 446);
            this.LblInformation.Name = "LblInformation";
            this.LblInformation.Size = new System.Drawing.Size(935, 170);
            this.LblInformation.TabIndex = 7;
            this.LblInformation.Text = "Informations";
            this.LblInformation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CalculatriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 619);
            this.Controls.Add(this.LblInformation);
            this.Controls.Add(this.tbxB);
            this.Controls.Add(this.tbxA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_gomme);
            this.Controls.Add(this.GpeCalcul);
            this.Controls.Add(this.Lbl_B);
            this.Controls.Add(this.Lbl_A);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculatriceForm";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.TextBox_B_Load);
            this.GpeCalcul.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_A;
        private System.Windows.Forms.Label Lbl_B;
       
        private System.Windows.Forms.GroupBox GpeCalcul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_prod;
        private System.Windows.Forms.Button btn_diff;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_gomme;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxA;
        private System.Windows.Forms.TextBox tbxB;
        private System.Windows.Forms.Label LblInformation;
    }
}

