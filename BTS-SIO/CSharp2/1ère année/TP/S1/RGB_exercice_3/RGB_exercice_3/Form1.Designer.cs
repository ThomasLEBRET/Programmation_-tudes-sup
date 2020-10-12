namespace RGB_exercice_3
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
            this.panelCouleur = new System.Windows.Forms.Panel();
            this.hsbarreVert = new System.Windows.Forms.HScrollBar();
            this.hsbarreBleu = new System.Windows.Forms.HScrollBar();
            this.hsbarreRouge = new System.Windows.Forms.HScrollBar();
            this.lbRouge = new System.Windows.Forms.Label();
            this.lbBleu = new System.Windows.Forms.Label();
            this.lbVert = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCouleur
            // 
            this.panelCouleur.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelCouleur.Location = new System.Drawing.Point(38, 149);
            this.panelCouleur.Name = "panelCouleur";
            this.panelCouleur.Size = new System.Drawing.Size(200, 100);
            this.panelCouleur.TabIndex = 0;
            this.panelCouleur.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCouleur_Paint);
            // 
            // hsbarreVert
            // 
            this.hsbarreVert.LargeChange = 1;
            this.hsbarreVert.Location = new System.Drawing.Point(102, 66);
            this.hsbarreVert.Maximum = 255;
            this.hsbarreVert.Name = "hsbarreVert";
            this.hsbarreVert.Size = new System.Drawing.Size(162, 17);
            this.hsbarreVert.TabIndex = 2;
            this.hsbarreVert.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbarreVert_Scroll);
            // 
            // hsbarreBleu
            // 
            this.hsbarreBleu.LargeChange = 1;
            this.hsbarreBleu.Location = new System.Drawing.Point(102, 112);
            this.hsbarreBleu.Maximum = 255;
            this.hsbarreBleu.Name = "hsbarreBleu";
            this.hsbarreBleu.Size = new System.Drawing.Size(162, 17);
            this.hsbarreBleu.TabIndex = 3;
            this.hsbarreBleu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbarreBleu_Scroll);
            // 
            // hsbarreRouge
            // 
            this.hsbarreRouge.LargeChange = 1;
            this.hsbarreRouge.Location = new System.Drawing.Point(102, 20);
            this.hsbarreRouge.Maximum = 255;
            this.hsbarreRouge.Name = "hsbarreRouge";
            this.hsbarreRouge.Size = new System.Drawing.Size(162, 17);
            this.hsbarreRouge.TabIndex = 1;
            this.hsbarreRouge.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbarreRouge_Scroll);
            // 
            // lbRouge
            // 
            this.lbRouge.AutoSize = true;
            this.lbRouge.Location = new System.Drawing.Point(38, 20);
            this.lbRouge.Name = "lbRouge";
            this.lbRouge.Size = new System.Drawing.Size(39, 13);
            this.lbRouge.TabIndex = 4;
            this.lbRouge.Text = "Rouge";
            this.lbRouge.Click += new System.EventHandler(this.lbRouge_Click);
            // 
            // lbBleu
            // 
            this.lbBleu.AutoSize = true;
            this.lbBleu.Location = new System.Drawing.Point(38, 112);
            this.lbBleu.Name = "lbBleu";
            this.lbBleu.Size = new System.Drawing.Size(28, 13);
            this.lbBleu.TabIndex = 5;
            this.lbBleu.Text = "Bleu";
            this.lbBleu.Click += new System.EventHandler(this.lbBleu_Click);
            // 
            // lbVert
            // 
            this.lbVert.AutoSize = true;
            this.lbVert.Location = new System.Drawing.Point(38, 70);
            this.lbVert.Name = "lbVert";
            this.lbVert.Size = new System.Drawing.Size(26, 13);
            this.lbVert.TabIndex = 6;
            this.lbVert.Text = "Vert";
            this.lbVert.Click += new System.EventHandler(this.lbVert_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(302, 226);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 7;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.lbVert);
            this.Controls.Add(this.lbBleu);
            this.Controls.Add(this.lbRouge);
            this.Controls.Add(this.hsbarreRouge);
            this.Controls.Add(this.hsbarreBleu);
            this.Controls.Add(this.hsbarreVert);
            this.Controls.Add(this.panelCouleur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCouleur;
        private System.Windows.Forms.HScrollBar hsbarreVert;
        private System.Windows.Forms.HScrollBar hsbarreBleu;
        private System.Windows.Forms.HScrollBar hsbarreRouge;
        private System.Windows.Forms.Label lbRouge;
        private System.Windows.Forms.Label lbBleu;
        private System.Windows.Forms.Label lbVert;
        private System.Windows.Forms.Button btQuitter;
    }
}

