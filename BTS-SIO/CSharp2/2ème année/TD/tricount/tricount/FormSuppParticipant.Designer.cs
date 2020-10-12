namespace tricount
{
    partial class FormSuppParticipant
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
            this.btRetour = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.lbParticipant = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRetour.Location = new System.Drawing.Point(12, 327);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 0;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(360, 307);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lbParticipant
            // 
            this.lbParticipant.FormattingEnabled = true;
            this.lbParticipant.Location = new System.Drawing.Point(168, 30);
            this.lbParticipant.Name = "lbParticipant";
            this.lbParticipant.Size = new System.Drawing.Size(444, 238);
            this.lbParticipant.TabIndex = 3;
            // 
            // FormSuppParticipant
            // 
            this.AcceptButton = this.btValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRetour;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.lbParticipant);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btRetour);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuppParticipant";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supprimer un participant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.ListBox lbParticipant;
    }
}