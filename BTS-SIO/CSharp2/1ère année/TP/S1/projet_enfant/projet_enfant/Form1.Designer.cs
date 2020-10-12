namespace projet_enfant
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
            this.btCommencer = new System.Windows.Forms.Button();
            this.lbEnfant = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCommencer
            // 
            this.btCommencer.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCommencer.Location = new System.Drawing.Point(72, 171);
            this.btCommencer.Name = "btCommencer";
            this.btCommencer.Size = new System.Drawing.Size(295, 107);
            this.btCommencer.TabIndex = 0;
            this.btCommencer.Text = "Commencer";
            this.btCommencer.UseVisualStyleBackColor = true;
            this.btCommencer.Click += new System.EventHandler(this.btCommencer_Click);
            // 
            // lbEnfant
            // 
            this.lbEnfant.AutoSize = true;
            this.lbEnfant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnfant.Location = new System.Drawing.Point(12, 83);
            this.lbEnfant.Name = "lbEnfant";
            this.lbEnfant.Size = new System.Drawing.Size(607, 48);
            this.lbEnfant.TabIndex = 1;
            this.lbEnfant.Text = "Bienvenu dans le jeu des fruits et légumes.\r\nConnais-tu le nom des 10 fruits et l" +
                "égumes que je compte te proposer ?\r\n";
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(544, 312);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 347);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.lbEnfant);
            this.Controls.Add(this.btCommencer);
            this.Name = "Form1";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCommencer;
        private System.Windows.Forms.Label lbEnfant;
        private System.Windows.Forms.Button btQuitter;
    }
}

