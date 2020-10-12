namespace rectangle_classe
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
            this.btQuitter = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.numLongueur = new System.Windows.Forms.NumericUpDown();
            this.numLargeur = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargeur)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(564, 208);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(69, 13);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(105, 13);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Entrez une longueur ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(69, 45);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(93, 13);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "Entrez une largeur";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(72, 82);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 7;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // numLongueur
            // 
            this.numLongueur.Location = new System.Drawing.Point(199, 13);
            this.numLongueur.Name = "numLongueur";
            this.numLongueur.Size = new System.Drawing.Size(59, 20);
            this.numLongueur.TabIndex = 8;
            this.numLongueur.ValueChanged += new System.EventHandler(this.numLongueur_ValueChanged);
            // 
            // numLargeur
            // 
            this.numLargeur.Location = new System.Drawing.Point(199, 38);
            this.numLargeur.Name = "numLargeur";
            this.numLargeur.Size = new System.Drawing.Size(59, 20);
            this.numLargeur.TabIndex = 9;
            this.numLargeur.ValueChanged += new System.EventHandler(this.numLargeur_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 243);
            this.Controls.Add(this.numLargeur);
            this.Controls.Add(this.numLongueur);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btQuitter);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Rectangle";
            ((System.ComponentModel.ISupportInitialize)(this.numLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.NumericUpDown numLongueur;
        private System.Windows.Forms.NumericUpDown numLargeur;
    }
}

