namespace heritage_rectangle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numLongueur = new System.Windows.Forms.NumericUpDown();
            this.numLargeur = new System.Windows.Forms.NumericUpDown();
            this.btValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargeur)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(12, 278);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez une longueur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrez une largeur :";
            // 
            // numLongueur
            // 
            this.numLongueur.Location = new System.Drawing.Point(175, 31);
            this.numLongueur.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numLongueur.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLongueur.Name = "numLongueur";
            this.numLongueur.Size = new System.Drawing.Size(77, 20);
            this.numLongueur.TabIndex = 3;
            this.numLongueur.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numLargeur
            // 
            this.numLargeur.Location = new System.Drawing.Point(175, 92);
            this.numLargeur.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numLargeur.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLargeur.Name = "numLargeur";
            this.numLargeur.Size = new System.Drawing.Size(77, 20);
            this.numLargeur.TabIndex = 4;
            this.numLargeur.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(25, 140);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(227, 23);
            this.btValider.TabIndex = 5;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 313);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.numLargeur);
            this.Controls.Add(this.numLongueur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Héritage de la classe Rectangle";
            ((System.ComponentModel.ISupportInitialize)(this.numLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLargeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLongueur;
        private System.Windows.Forms.NumericUpDown numLargeur;
        private System.Windows.Forms.Button btValider;
    }
}

