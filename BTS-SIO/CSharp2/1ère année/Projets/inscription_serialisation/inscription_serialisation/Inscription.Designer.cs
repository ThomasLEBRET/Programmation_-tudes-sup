namespace inscription_serialisation
{
    partial class Inscription
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
            this.btInscription = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMotDePasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btPasserAConnexion = new System.Windows.Forms.Button();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // btInscription
            // 
            this.btInscription.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInscription.Location = new System.Drawing.Point(325, 250);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(150, 50);
            this.btInscription.TabIndex = 1;
            this.btInscription.Text = "Inscription";
            this.btInscription.UseVisualStyleBackColor = true;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(325, 100);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(150, 24);
            this.tbLogin.TabIndex = 2;
            // 
            // tbMotDePasse
            // 
            this.tbMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMotDePasse.Location = new System.Drawing.Point(325, 180);
            this.tbMotDePasse.Name = "tbMotDePasse";
            this.tbMotDePasse.Size = new System.Drawing.Size(150, 24);
            this.tbMotDePasse.TabIndex = 3;
            this.tbMotDePasse.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom d\'utilisateur ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mot de passe";
            // 
            // btPasserAConnexion
            // 
            this.btPasserAConnexion.BackColor = System.Drawing.Color.Transparent;
            this.btPasserAConnexion.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPasserAConnexion.Location = new System.Drawing.Point(660, 320);
            this.btPasserAConnexion.Name = "btPasserAConnexion";
            this.btPasserAConnexion.Size = new System.Drawing.Size(120, 40);
            this.btPasserAConnexion.TabIndex = 6;
            this.btPasserAConnexion.Text = "Connexion";
            this.btPasserAConnexion.UseVisualStyleBackColor = false;
            this.btPasserAConnexion.Click += new System.EventHandler(this.btPasserAConnexion_Click);
            // 
            // pbQuitter
            // 
            this.pbQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pbQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuitter.Image = global::inscription_serialisation.Properties.Resources.btQuitter;
            this.pbQuitter.Location = new System.Drawing.Point(10, 280);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(75, 75);
            this.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuitter.TabIndex = 7;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::inscription_serialisation.Properties.Resources.bgg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 363);
            this.ControlBox = false;
            this.Controls.Add(this.pbQuitter);
            this.Controls.Add(this.btPasserAConnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMotDePasse);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.btInscription);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inscription";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.Inscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInscription;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMotDePasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPasserAConnexion;
        private System.Windows.Forms.PictureBox pbQuitter;
    }
}

