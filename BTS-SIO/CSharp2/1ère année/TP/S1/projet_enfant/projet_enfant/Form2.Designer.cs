namespace projet_enfant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btRetour = new System.Windows.Forms.Button();
            this.pbTomate = new System.Windows.Forms.PictureBox();
            this.btValider = new System.Windows.Forms.Button();
            this.tbTomate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomate)).BeginInit();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.Location = new System.Drawing.Point(12, 343);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 0;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // pbTomate
            // 
            this.pbTomate.Image = ((System.Drawing.Image)(resources.GetObject("pbTomate.Image")));
            this.pbTomate.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbTomate.InitialImage")));
            this.pbTomate.Location = new System.Drawing.Point(241, 65);
            this.pbTomate.Name = "pbTomate";
            this.pbTomate.Size = new System.Drawing.Size(216, 200);
            this.pbTomate.TabIndex = 1;
            this.pbTomate.TabStop = false;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(309, 303);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // tbTomate
            // 
            this.tbTomate.Location = new System.Drawing.Point(267, 271);
            this.tbTomate.Name = "tbTomate";
            this.tbTomate.Size = new System.Drawing.Size(168, 20);
            this.tbTomate.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 378);
            this.Controls.Add(this.tbTomate);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.pbTomate);
            this.Controls.Add(this.btRetour);
            this.Name = "Form2";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTomate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.PictureBox pbTomate;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox tbTomate;
    }
}