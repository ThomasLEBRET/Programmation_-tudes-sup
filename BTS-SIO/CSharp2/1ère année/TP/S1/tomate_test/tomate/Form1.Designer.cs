namespace tomate
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
            this.tbFruit = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValdier = new System.Windows.Forms.Button();
            this.pbFruit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFruit
            // 
            this.tbFruit.Location = new System.Drawing.Point(549, 106);
            this.tbFruit.Name = "tbFruit";
            this.tbFruit.Size = new System.Drawing.Size(196, 20);
            this.tbFruit.TabIndex = 1;
            this.tbFruit.TextChanged += new System.EventHandler(this.tbFruit_TextChanged);
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(635, 385);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(124, 54);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValdier
            // 
            this.btValdier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValdier.Location = new System.Drawing.Point(601, 151);
            this.btValdier.Name = "btValdier";
            this.btValdier.Size = new System.Drawing.Size(110, 60);
            this.btValdier.TabIndex = 3;
            this.btValdier.Text = "Valider";
            this.btValdier.UseVisualStyleBackColor = true;
            this.btValdier.Click += new System.EventHandler(this.btValdier_Click);
            // 
            // pbFruit
            // 
            this.pbFruit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFruit.Image = global::tomate.Properties.Resources.tomate;
            this.pbFruit.Location = new System.Drawing.Point(12, 12);
            this.pbFruit.Name = "pbFruit";
            this.pbFruit.Size = new System.Drawing.Size(487, 427);
            this.pbFruit.TabIndex = 0;
            this.pbFruit.TabStop = false;
            this.pbFruit.Click += new System.EventHandler(this.pbTomate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 451);
            this.Controls.Add(this.btValdier);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.tbFruit);
            this.Controls.Add(this.pbFruit);
            this.Name = "Form1";
            this.Text = "Quizz - Fruits et Légume";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFruit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFruit;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValdier;
        private System.Windows.Forms.PictureBox pbFruit;
    }
}

