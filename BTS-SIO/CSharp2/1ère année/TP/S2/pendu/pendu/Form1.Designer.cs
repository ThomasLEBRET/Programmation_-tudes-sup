namespace pendu
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
            this.btLettre = new System.Windows.Forms.Button();
            this.tbLettre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(338, 269);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btLettre
            // 
            this.btLettre.Location = new System.Drawing.Point(139, 165);
            this.btLettre.Name = "btLettre";
            this.btLettre.Size = new System.Drawing.Size(130, 23);
            this.btLettre.TabIndex = 1;
            this.btLettre.Text = "Essayer";
            this.btLettre.UseVisualStyleBackColor = true;
            this.btLettre.Click += new System.EventHandler(this.btLettre_Click);
            // 
            // tbLettre
            // 
            this.tbLettre.Location = new System.Drawing.Point(180, 139);
            this.tbLettre.Name = "tbLettre";
            this.tbLettre.Size = new System.Drawing.Size(49, 20);
            this.tbLettre.TabIndex = 2;
            this.tbLettre.TextChanged += new System.EventHandler(this.tbLettre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrez une lettre ";
            // 
            // lbMot
            // 
            this.lbMot.AutoSize = true;
            this.lbMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMot.Location = new System.Drawing.Point(139, 217);
            this.lbMot.Name = "lbMot";
            this.lbMot.Size = new System.Drawing.Size(157, 25);
            this.lbMot.TabIndex = 4;
            this.lbMot.Text = "motUtilisateur";
            this.lbMot.Click += new System.EventHandler(this.lbMot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 304);
            this.Controls.Add(this.lbMot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLettre);
            this.Controls.Add(this.btLettre);
            this.Controls.Add(this.btQuitter);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btLettre;
        private System.Windows.Forms.TextBox tbLettre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMot;
    }
}

