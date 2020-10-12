namespace tricount
{
    partial class FormAddParticipant
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
            this.tbNomParticipant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRetour
            // 
            this.btRetour.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btRetour.Location = new System.Drawing.Point(12, 327);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 23);
            this.btRetour.TabIndex = 0;
            this.btRetour.Text = "Retour ";
            this.btRetour.UseVisualStyleBackColor = true;
            this.btRetour.Click += new System.EventHandler(this.btRetour_Click);
            // 
            // tbNomParticipant
            // 
            this.tbNomParticipant.Location = new System.Drawing.Point(299, 152);
            this.tbNomParticipant.Name = "tbNomParticipant";
            this.tbNomParticipant.Size = new System.Drawing.Size(194, 20);
            this.tbNomParticipant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du participant";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(360, 192);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 3;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FormAddParticipant
            // 
            this.AcceptButton = this.btValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRetour;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNomParticipant);
            this.Controls.Add(this.btRetour);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddParticipant";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un participant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.TextBox tbNomParticipant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btValider;
    }
}