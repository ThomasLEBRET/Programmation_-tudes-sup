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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbTomate = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValdier = new System.Windows.Forms.Button();
            this.pbTomate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTomate)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTomate
            // 
            this.tbTomate.Location = new System.Drawing.Point(226, 283);
            this.tbTomate.Name = "tbTomate";
            this.tbTomate.Size = new System.Drawing.Size(196, 20);
            this.tbTomate.TabIndex = 1;
            this.tbTomate.TextChanged += new System.EventHandler(this.tbTomate_TextChanged);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(543, 359);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValdier
            // 
            this.btValdier.Location = new System.Drawing.Point(285, 326);
            this.btValdier.Name = "btValdier";
            this.btValdier.Size = new System.Drawing.Size(75, 23);
            this.btValdier.TabIndex = 3;
            this.btValdier.Text = "Valider";
            this.btValdier.UseVisualStyleBackColor = true;
            this.btValdier.Click += new System.EventHandler(this.btValdier_Click);
            // 
            // pbTomate
            // 
            this.pbTomate.Image = ((System.Drawing.Image)(resources.GetObject("pbTomate.Image")));
            this.pbTomate.Location = new System.Drawing.Point(212, 27);
            this.pbTomate.Name = "pbTomate";
            this.pbTomate.Size = new System.Drawing.Size(223, 223);
            this.pbTomate.TabIndex = 0;
            this.pbTomate.TabStop = false;
            this.pbTomate.Click += new System.EventHandler(this.pbTomate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 394);
            this.Controls.Add(this.btValdier);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.tbTomate);
            this.Controls.Add(this.pbTomate);
            this.Name = "Form1";
            this.Text = "Tomate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTomate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTomate;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValdier;
        private System.Windows.Forms.PictureBox pbTomate;
    }
}

