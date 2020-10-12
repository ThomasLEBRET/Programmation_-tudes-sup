namespace tricount
{
    partial class FormConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbUser = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btValiderUser = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(300, 150);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(200, 20);
            this.tbUser.TabIndex = 0;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(279, 105);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(252, 20);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Rentrer votre nom d\'utilisateur";
            // 
            // btValiderUser
            // 
            this.btValiderUser.Location = new System.Drawing.Point(368, 196);
            this.btValiderUser.Name = "btValiderUser";
            this.btValiderUser.Size = new System.Drawing.Size(75, 23);
            this.btValiderUser.TabIndex = 2;
            this.btValiderUser.Text = "Valider";
            this.btValiderUser.UseVisualStyleBackColor = true;
            this.btValiderUser.Click += new System.EventHandler(this.btValiderUser_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btQuitter.Location = new System.Drawing.Point(12, 327);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 3;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // FormConnexion
            // 
            this.AcceptButton = this.btValiderUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btQuitter;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValiderUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnexion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btValiderUser;
        private System.Windows.Forms.Button btQuitter;
    }
}

