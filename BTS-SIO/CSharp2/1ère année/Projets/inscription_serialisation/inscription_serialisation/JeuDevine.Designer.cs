namespace inscription_serialisation
{
    partial class JeuDevine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JeuDevine));
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tbReponse = new System.Windows.Forms.TextBox();
            this.lbMot = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQuitter
            // 
            resources.ApplyResources(this.pbQuitter, "pbQuitter");
            this.pbQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pbQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuitter.Image = global::inscription_serialisation.Properties.Resources.btQuitter;
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // tbReponse
            // 
            resources.ApplyResources(this.tbReponse, "tbReponse");
            this.tbReponse.Name = "tbReponse";
            // 
            // lbMot
            // 
            resources.ApplyResources(this.lbMot, "lbMot");
            this.lbMot.Name = "lbMot";
            // 
            // btValider
            // 
            resources.ApplyResources(this.btValider, "btValider");
            this.btValider.Name = "btValider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // JeuDevine
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::inscription_serialisation.Properties.Resources.devine;
            this.ControlBox = false;
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lbMot);
            this.Controls.Add(this.tbReponse);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JeuDevine";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.JeuDevine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbReponse;
        private System.Windows.Forms.Label lbMot;
        private System.Windows.Forms.Button btValider;
    }
}