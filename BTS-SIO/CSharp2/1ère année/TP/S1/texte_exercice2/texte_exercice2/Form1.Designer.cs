namespace texte_exercice2
{
    partial class Form1
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
            this.lbTexte = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.cbISouligne = new System.Windows.Forms.CheckBox();
            this.cbGras = new System.Windows.Forms.CheckBox();
            this.cbItalique = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbTexte
            // 
            this.lbTexte.AutoSize = true;
            this.lbTexte.Location = new System.Drawing.Point(35, 74);
            this.lbTexte.Name = "lbTexte";
            this.lbTexte.Size = new System.Drawing.Size(94, 65);
            this.lbTexte.TabIndex = 0;
            this.lbTexte.Text = "Cette phrase doit \r\nchanger \r\nd\'apparence selon\r\nles cases qui sotn \r\ncochées";
            this.lbTexte.Click += new System.EventHandler(this.lbTexte_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(126, 203);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 1;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // cbISouligne
            // 
            this.cbISouligne.AutoSize = true;
            this.cbISouligne.Location = new System.Drawing.Point(234, 73);
            this.cbISouligne.Name = "cbISouligne";
            this.cbISouligne.Size = new System.Drawing.Size(67, 17);
            this.cbISouligne.TabIndex = 2;
            this.cbISouligne.Text = "Souligné";
            this.cbISouligne.UseVisualStyleBackColor = true;
            this.cbISouligne.CheckedChanged += new System.EventHandler(this.cbISouligne_CheckedChanged);
            // 
            // cbGras
            // 
            this.cbGras.AutoSize = true;
            this.cbGras.Location = new System.Drawing.Point(234, 109);
            this.cbGras.Name = "cbGras";
            this.cbGras.Size = new System.Drawing.Size(48, 17);
            this.cbGras.TabIndex = 3;
            this.cbGras.Text = "Gras";
            this.cbGras.UseVisualStyleBackColor = true;
            this.cbGras.CheckedChanged += new System.EventHandler(this.cbGras_CheckedChanged);
            // 
            // cbItalique
            // 
            this.cbItalique.AutoSize = true;
            this.cbItalique.Location = new System.Drawing.Point(234, 143);
            this.cbItalique.Name = "cbItalique";
            this.cbItalique.Size = new System.Drawing.Size(60, 17);
            this.cbItalique.TabIndex = 4;
            this.cbItalique.Text = "Italique";
            this.cbItalique.UseVisualStyleBackColor = true;
            this.cbItalique.CheckedChanged += new System.EventHandler(this.cbItalique_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.cbItalique);
            this.Controls.Add(this.cbGras);
            this.Controls.Add(this.cbISouligne);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.lbTexte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTexte;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.CheckBox cbISouligne;
        private System.Windows.Forms.CheckBox cbGras;
        private System.Windows.Forms.CheckBox cbItalique;
    }
}

