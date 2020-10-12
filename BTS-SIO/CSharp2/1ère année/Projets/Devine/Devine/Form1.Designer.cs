namespace Devine
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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lbMot = new System.Windows.Forms.Label();
            this.tbReponse = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(131, 32);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(189, 183);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // lbMot
            // 
            this.lbMot.AutoSize = true;
            this.lbMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMot.Location = new System.Drawing.Point(200, 235);
            this.lbMot.Name = "lbMot";
            this.lbMot.Size = new System.Drawing.Size(56, 29);
            this.lbMot.TabIndex = 1;
            this.lbMot.Text = "mot";
            // 
            // tbReponse
            // 
            this.tbReponse.Location = new System.Drawing.Point(181, 267);
            this.tbReponse.Name = "tbReponse";
            this.tbReponse.Size = new System.Drawing.Size(100, 22);
            this.tbReponse.TabIndex = 2;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(377, 324);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 3;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(191, 318);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(79, 35);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 402);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.tbReponse);
            this.Controls.Add(this.lbMot);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lbMot;
        private System.Windows.Forms.TextBox tbReponse;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
    }
}

