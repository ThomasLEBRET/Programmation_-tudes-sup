namespace inscription_serialisation
{
    partial class Info
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
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.gbMemory = new System.Windows.Forms.GroupBox();
            this.paMemory = new System.Windows.Forms.Panel();
            this.lbMemory = new System.Windows.Forms.Label();
            this.gbDevine = new System.Windows.Forms.GroupBox();
            this.paDevine = new System.Windows.Forms.Panel();
            this.lbDevine = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            this.gbMemory.SuspendLayout();
            this.paMemory.SuspendLayout();
            this.gbDevine.SuspendLayout();
            this.paDevine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbQuitter
            // 
            this.pbQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pbQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuitter.Image = global::inscription_serialisation.Properties.Resources.btQuitter;
            this.pbQuitter.Location = new System.Drawing.Point(12, 274);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(75, 75);
            this.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuitter.TabIndex = 0;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // gbMemory
            // 
            this.gbMemory.BackColor = System.Drawing.Color.Transparent;
            this.gbMemory.Controls.Add(this.paMemory);
            this.gbMemory.Location = new System.Drawing.Point(12, 12);
            this.gbMemory.Name = "gbMemory";
            this.gbMemory.Size = new System.Drawing.Size(350, 250);
            this.gbMemory.TabIndex = 1;
            this.gbMemory.TabStop = false;
            this.gbMemory.Text = "Memory";
            // 
            // paMemory
            // 
            this.paMemory.Controls.Add(this.lbMemory);
            this.paMemory.Location = new System.Drawing.Point(6, 19);
            this.paMemory.Name = "paMemory";
            this.paMemory.Size = new System.Drawing.Size(338, 225);
            this.paMemory.TabIndex = 0;
            // 
            // lbMemory
            // 
            this.lbMemory.AutoSize = true;
            this.lbMemory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMemory.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemory.ForeColor = System.Drawing.Color.Black;
            this.lbMemory.Location = new System.Drawing.Point(0, 32);
            this.lbMemory.Name = "lbMemory";
            this.lbMemory.Size = new System.Drawing.Size(603, 134);
            this.lbMemory.TabIndex = 0;
            this.lbMemory.Text = "Bienvenu dans le jeu du mémory.\r\nVous devez trouver les paires d\'images correspon" +
                "dantes \r\nAttention vous avez un temps limité !\r\nHeureusement, vous pouvez mettre" +
                " le jeu sur pause au cas o";
            this.lbMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDevine
            // 
            this.gbDevine.BackColor = System.Drawing.Color.Transparent;
            this.gbDevine.Controls.Add(this.paDevine);
            this.gbDevine.Location = new System.Drawing.Point(422, 12);
            this.gbDevine.Name = "gbDevine";
            this.gbDevine.Size = new System.Drawing.Size(350, 250);
            this.gbDevine.TabIndex = 2;
            this.gbDevine.TabStop = false;
            this.gbDevine.Text = "Devine";
            // 
            // paDevine
            // 
            this.paDevine.Controls.Add(this.lbDevine);
            this.paDevine.Location = new System.Drawing.Point(6, 19);
            this.paDevine.Name = "paDevine";
            this.paDevine.Size = new System.Drawing.Size(338, 225);
            this.paDevine.TabIndex = 1;
            // 
            // lbDevine
            // 
            this.lbDevine.AutoSize = true;
            this.lbDevine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDevine.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevine.ForeColor = System.Drawing.Color.Black;
            this.lbDevine.Location = new System.Drawing.Point(0, 32);
            this.lbDevine.Name = "lbDevine";
            this.lbDevine.Size = new System.Drawing.Size(638, 101);
            this.lbDevine.TabIndex = 0;
            this.lbDevine.Text = "Bienvenu dans le jeu Devine.\r\nVous devez trouver la lettre maquante au début de c" +
                "haque mot\r\nVous pouvez réessayer plusieurs fois.";
            this.lbDevine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.gbDevine);
            this.Controls.Add(this.gbMemory);
            this.Controls.Add(this.pbQuitter);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Info";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            this.gbMemory.ResumeLayout(false);
            this.paMemory.ResumeLayout(false);
            this.paMemory.PerformLayout();
            this.gbDevine.ResumeLayout(false);
            this.paDevine.ResumeLayout(false);
            this.paDevine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.GroupBox gbMemory;
        private System.Windows.Forms.GroupBox gbDevine;
        private System.Windows.Forms.Label lbMemory;
        private System.Windows.Forms.Panel paMemory;
        private System.Windows.Forms.Panel paDevine;
        private System.Windows.Forms.Label lbDevine;
    }
}