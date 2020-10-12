namespace test {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            this.tbInsee = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.lbInsee = new System.Windows.Forms.Label();
            this.btVerify = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInsee
            // 
            this.tbInsee.Location = new System.Drawing.Point(46, 95);
            this.tbInsee.Name = "tbInsee";
            this.tbInsee.Size = new System.Drawing.Size(190, 20);
            this.tbInsee.TabIndex = 0;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(197, 226);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 1;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbInsee
            // 
            this.lbInsee.AutoSize = true;
            this.lbInsee.Location = new System.Drawing.Point(74, 57);
            this.lbInsee.Name = "lbInsee";
            this.lbInsee.Size = new System.Drawing.Size(137, 13);
            this.lbInsee.TabIndex = 2;
            this.lbInsee.Text = "Entrez votre numéro INSEE";
            this.lbInsee.Click += new System.EventHandler(this.lbInsee_Click);
            // 
            // btVerify
            // 
            this.btVerify.Location = new System.Drawing.Point(103, 121);
            this.btVerify.Name = "btVerify";
            this.btVerify.Size = new System.Drawing.Size(75, 23);
            this.btVerify.TabIndex = 3;
            this.btVerify.Text = "Vérifier";
            this.btVerify.UseVisualStyleBackColor = true;
            this.btVerify.Click += new System.EventHandler(this.btVerify_Click);
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(12, 214);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 13);
            this.lbMessage.TabIndex = 4;
            this.lbMessage.Click += new System.EventHandler(this.lbMessage_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(103, 150);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copier";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btVerify);
            this.Controls.Add(this.lbInsee);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.tbInsee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInsee;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lbInsee;
        private System.Windows.Forms.Button btVerify;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnCopy;
    }
}

