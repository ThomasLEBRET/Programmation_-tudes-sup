namespace testPassageFenetre
{
    partial class Form2
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
            this.lbF2 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbF2
            // 
            this.lbF2.AutoSize = true;
            this.lbF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF2.Location = new System.Drawing.Point(146, 78);
            this.lbF2.Name = "lbF2";
            this.lbF2.Size = new System.Drawing.Size(206, 25);
            this.lbF2.TabIndex = 0;
            this.lbF2.Text = "Je suis la fenêtre 2 !";
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(443, 226);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 1;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(12, 226);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 2;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 261);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.lbF2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbF2;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btRetour;
    }
}