namespace Exemple_WinForm1
{
    partial class MaFenetreWindows
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
            this.Lbl_A = new System.Windows.Forms.Label();
            this.Lbl_Cc = new System.Windows.Forms.Label();
            this.Lbl_Objet = new System.Windows.Forms.Label();
            this.txb_A = new System.Windows.Forms.TextBox();
            this.txb_B = new System.Windows.Forms.TextBox();
            this.txb_C = new System.Windows.Forms.TextBox();
            this.btn_Envoyer = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Lbl_A
            // 
            this.Lbl_A.AutoSize = true;
            this.Lbl_A.Location = new System.Drawing.Point(27, 53);
            this.Lbl_A.Name = "Lbl_A";
            this.Lbl_A.Size = new System.Drawing.Size(26, 25);
            this.Lbl_A.TabIndex = 0;
            this.Lbl_A.Text = "A\r\n";
            // 
            // Lbl_Cc
            // 
            this.Lbl_Cc.AutoSize = true;
            this.Lbl_Cc.Location = new System.Drawing.Point(27, 151);
            this.Lbl_Cc.Name = "Lbl_Cc";
            this.Lbl_Cc.Size = new System.Drawing.Size(38, 25);
            this.Lbl_Cc.TabIndex = 2;
            this.Lbl_Cc.Text = "Cc\r\n";
            // 
            // Lbl_Objet
            // 
            this.Lbl_Objet.AutoSize = true;
            this.Lbl_Objet.Location = new System.Drawing.Point(27, 256);
            this.Lbl_Objet.Name = "Lbl_Objet";
            this.Lbl_Objet.Size = new System.Drawing.Size(63, 25);
            this.Lbl_Objet.TabIndex = 3;
            this.Lbl_Objet.Text = "Objet\r\n";
            // 
            // txb_A
            // 
            this.txb_A.Location = new System.Drawing.Point(148, 26);
            this.txb_A.Multiline = true;
            this.txb_A.Name = "txb_A";
            this.txb_A.Size = new System.Drawing.Size(695, 52);
            this.txb_A.TabIndex = 4;
            this.txb_A.TextChanged += new System.EventHandler(this.txb_A_TextChanged);
            // 
            // txb_B
            // 
            this.txb_B.Location = new System.Drawing.Point(148, 121);
            this.txb_B.Multiline = true;
            this.txb_B.Name = "txb_B";
            this.txb_B.Size = new System.Drawing.Size(695, 55);
            this.txb_B.TabIndex = 5;
            // 
            // txb_C
            // 
            this.txb_C.Location = new System.Drawing.Point(148, 225);
            this.txb_C.Multiline = true;
            this.txb_C.Name = "txb_C";
            this.txb_C.Size = new System.Drawing.Size(695, 56);
            this.txb_C.TabIndex = 6;
            // 
            // btn_Envoyer
            // 
            this.btn_Envoyer.Location = new System.Drawing.Point(425, 579);
            this.btn_Envoyer.Name = "btn_Envoyer";
            this.btn_Envoyer.Size = new System.Drawing.Size(150, 47);
            this.btn_Envoyer.TabIndex = 8;
            this.btn_Envoyer.Text = "Envoyer";
            this.btn_Envoyer.UseVisualStyleBackColor = true;
            this.btn_Envoyer.Click += new System.EventHandler(this.btn_Envoyer_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(32, 336);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(811, 198);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // MaFenetreWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 655);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Envoyer);
            this.Controls.Add(this.txb_C);
            this.Controls.Add(this.txb_B);
            this.Controls.Add(this.txb_A);
            this.Controls.Add(this.Lbl_Objet);
            this.Controls.Add(this.Lbl_Cc);
            this.Controls.Add(this.Lbl_A);
            this.Name = "MaFenetreWindows";
            this.Text = "MaFenetreWindows";
            this.Load += new System.EventHandler(this.MaFenetreWindows_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_A;
        private System.Windows.Forms.Label Lbl_Cc;
        private System.Windows.Forms.Label Lbl_Objet;
        private System.Windows.Forms.TextBox txb_A;
        private System.Windows.Forms.TextBox txb_B;
        private System.Windows.Forms.TextBox txb_C;
        private System.Windows.Forms.Button btn_Envoyer;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}