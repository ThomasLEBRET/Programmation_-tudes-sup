namespace tp_musique
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
            this.pbGuitare = new System.Windows.Forms.PictureBox();
            this.btGuitare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuitare)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(12, 264);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pbGuitare
            // 
            this.pbGuitare.Image = global::tp_musique.Properties.Resources.guitare;
            this.pbGuitare.Location = new System.Drawing.Point(53, 12);
            this.pbGuitare.Name = "pbGuitare";
            this.pbGuitare.Size = new System.Drawing.Size(143, 167);
            this.pbGuitare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuitare.TabIndex = 1;
            this.pbGuitare.TabStop = false;
            // 
            // btGuitare
            // 
            this.btGuitare.Location = new System.Drawing.Point(53, 200);
            this.btGuitare.Name = "btGuitare";
            this.btGuitare.Size = new System.Drawing.Size(143, 44);
            this.btGuitare.TabIndex = 2;
            this.btGuitare.Text = "Ecouter ";
            this.btGuitare.UseVisualStyleBackColor = true;
            this.btGuitare.Click += new System.EventHandler(this.btGuitare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 299);
            this.Controls.Add(this.btGuitare);
            this.Controls.Add(this.pbGuitare);
            this.Controls.Add(this.btQuitter);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGuitare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.PictureBox pbGuitare;
        private System.Windows.Forms.Button btGuitare;
    }
}

