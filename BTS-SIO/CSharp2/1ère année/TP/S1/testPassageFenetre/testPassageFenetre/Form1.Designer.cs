namespace testPassageFenetre
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
            this.lbF1 = new System.Windows.Forms.Label();
            this.btF2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(347, 247);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbF1
            // 
            this.lbF1.AutoSize = true;
            this.lbF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbF1.Location = new System.Drawing.Point(106, 112);
            this.lbF1.Name = "lbF1";
            this.lbF1.Size = new System.Drawing.Size(206, 25);
            this.lbF1.TabIndex = 1;
            this.lbF1.Text = "Je suis la fenêtre 1 !";
            // 
            // btF2
            // 
            this.btF2.Location = new System.Drawing.Point(130, 161);
            this.btF2.Name = "btF2";
            this.btF2.Size = new System.Drawing.Size(151, 54);
            this.btF2.TabIndex = 2;
            this.btF2.Text = "Aller à la fenêtre 2";
            this.btF2.UseVisualStyleBackColor = true;
            this.btF2.Click += new System.EventHandler(this.btF2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 282);
            this.Controls.Add(this.btF2);
            this.Controls.Add(this.lbF1);
            this.Controls.Add(this.btQuitter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lbF1;
        private System.Windows.Forms.Button btF2;
    }
}

