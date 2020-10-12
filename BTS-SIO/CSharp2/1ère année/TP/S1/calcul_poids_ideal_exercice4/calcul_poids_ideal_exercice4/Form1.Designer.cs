namespace calcul_poids_ideal_exercice4
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
            this.gbSexe = new System.Windows.Forms.GroupBox();
            this.gbTaille = new System.Windows.Forms.GroupBox();
            this.gbAge = new System.Windows.Forms.GroupBox();
            this.rbHomme = new System.Windows.Forms.RadioButton();
            this.rbFemme = new System.Windows.Forms.RadioButton();
            this.tbTaille = new System.Windows.Forms.TextBox();
            this.lbTaille = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.btCalculer = new System.Windows.Forms.Button();
            this.lbPoidsIdeal = new System.Windows.Forms.Label();
            this.tbPoids = new System.Windows.Forms.TextBox();
            this.gbSexe.SuspendLayout();
            this.gbTaille.SuspendLayout();
            this.gbAge.SuspendLayout();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(172, 284);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // gbSexe
            // 
            this.gbSexe.Controls.Add(this.rbFemme);
            this.gbSexe.Controls.Add(this.rbHomme);
            this.gbSexe.Location = new System.Drawing.Point(12, 12);
            this.gbSexe.Name = "gbSexe";
            this.gbSexe.Size = new System.Drawing.Size(123, 88);
            this.gbSexe.TabIndex = 1;
            this.gbSexe.TabStop = false;
            this.gbSexe.Text = "Sexe";
            // 
            // gbTaille
            // 
            this.gbTaille.Controls.Add(this.lbTaille);
            this.gbTaille.Controls.Add(this.tbTaille);
            this.gbTaille.Location = new System.Drawing.Point(141, 12);
            this.gbTaille.Name = "gbTaille";
            this.gbTaille.Size = new System.Drawing.Size(141, 52);
            this.gbTaille.TabIndex = 2;
            this.gbTaille.TabStop = false;
            this.gbTaille.Text = "Taille";
            // 
            // gbAge
            // 
            this.gbAge.Controls.Add(this.lbAge);
            this.gbAge.Controls.Add(this.tbAge);
            this.gbAge.Location = new System.Drawing.Point(310, 12);
            this.gbAge.Name = "gbAge";
            this.gbAge.Size = new System.Drawing.Size(91, 52);
            this.gbAge.TabIndex = 3;
            this.gbAge.TabStop = false;
            this.gbAge.Text = "Age";
            // 
            // rbHomme
            // 
            this.rbHomme.AutoSize = true;
            this.rbHomme.Location = new System.Drawing.Point(7, 20);
            this.rbHomme.Name = "rbHomme";
            this.rbHomme.Size = new System.Drawing.Size(61, 17);
            this.rbHomme.TabIndex = 0;
            this.rbHomme.TabStop = true;
            this.rbHomme.Text = "Homme";
            this.rbHomme.UseVisualStyleBackColor = true;
            this.rbHomme.CheckedChanged += new System.EventHandler(this.rbHomme_CheckedChanged);
            // 
            // rbFemme
            // 
            this.rbFemme.AutoSize = true;
            this.rbFemme.Location = new System.Drawing.Point(7, 47);
            this.rbFemme.Name = "rbFemme";
            this.rbFemme.Size = new System.Drawing.Size(59, 17);
            this.rbFemme.TabIndex = 1;
            this.rbFemme.TabStop = true;
            this.rbFemme.Text = "Femme";
            this.rbFemme.UseVisualStyleBackColor = true;
            this.rbFemme.CheckedChanged += new System.EventHandler(this.rbFemme_CheckedChanged);
            // 
            // tbTaille
            // 
            this.tbTaille.Location = new System.Drawing.Point(6, 19);
            this.tbTaille.Name = "tbTaille";
            this.tbTaille.Size = new System.Drawing.Size(100, 20);
            this.tbTaille.TabIndex = 0;
            this.tbTaille.TextChanged += new System.EventHandler(this.tbTaille_TextChanged);
            // 
            // lbTaille
            // 
            this.lbTaille.AutoSize = true;
            this.lbTaille.Location = new System.Drawing.Point(113, 25);
            this.lbTaille.Name = "lbTaille";
            this.lbTaille.Size = new System.Drawing.Size(21, 13);
            this.lbTaille.TabIndex = 1;
            this.lbTaille.Text = "cm";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(7, 19);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(43, 20);
            this.tbAge.TabIndex = 0;
            this.tbAge.TextChanged += new System.EventHandler(this.tbAge_TextChanged);
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(56, 19);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(24, 13);
            this.lbAge.TabIndex = 1;
            this.lbAge.Text = "ans";
            // 
            // btCalculer
            // 
            this.btCalculer.Location = new System.Drawing.Point(141, 167);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(151, 23);
            this.btCalculer.TabIndex = 4;
            this.btCalculer.Text = "Calculer";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // lbPoidsIdeal
            // 
            this.lbPoidsIdeal.AutoSize = true;
            this.lbPoidsIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoidsIdeal.Location = new System.Drawing.Point(53, 230);
            this.lbPoidsIdeal.Name = "lbPoidsIdeal";
            this.lbPoidsIdeal.Size = new System.Drawing.Size(141, 17);
            this.lbPoidsIdeal.TabIndex = 5;
            this.lbPoidsIdeal.Text = "Votre poids idéal :";
            // 
            // tbPoids
            // 
            this.tbPoids.Location = new System.Drawing.Point(200, 230);
            this.tbPoids.Name = "tbPoids";
            this.tbPoids.Size = new System.Drawing.Size(82, 20);
            this.tbPoids.TabIndex = 6;
            this.tbPoids.TextChanged += new System.EventHandler(this.tbPoids_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 319);
            this.Controls.Add(this.tbPoids);
            this.Controls.Add(this.lbPoidsIdeal);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.gbAge);
            this.Controls.Add(this.gbTaille);
            this.Controls.Add(this.gbSexe);
            this.Controls.Add(this.btQuitter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSexe.ResumeLayout(false);
            this.gbSexe.PerformLayout();
            this.gbTaille.ResumeLayout(false);
            this.gbTaille.PerformLayout();
            this.gbAge.ResumeLayout(false);
            this.gbAge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.GroupBox gbSexe;
        private System.Windows.Forms.RadioButton rbFemme;
        private System.Windows.Forms.RadioButton rbHomme;
        private System.Windows.Forms.GroupBox gbTaille;
        private System.Windows.Forms.Label lbTaille;
        private System.Windows.Forms.TextBox tbTaille;
        private System.Windows.Forms.GroupBox gbAge;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Label lbPoidsIdeal;
        private System.Windows.Forms.TextBox tbPoids;
    }
}

