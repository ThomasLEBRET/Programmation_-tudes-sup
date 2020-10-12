namespace tricount
{
    partial class FormMaDepense
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
            this.lbPayeur = new System.Windows.Forms.ListBox();
            this.lbParticipants = new System.Windows.Forms.ListBox();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbSomme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.lbFinanceur = new System.Windows.Forms.Label();
            this.lbConcerne = new System.Windows.Forms.ListBox();
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
            // lbPayeur
            // 
            this.lbPayeur.FormattingEnabled = true;
            this.lbPayeur.Location = new System.Drawing.Point(227, 126);
            this.lbPayeur.Name = "lbPayeur";
            this.lbPayeur.Size = new System.Drawing.Size(330, 69);
            this.lbPayeur.TabIndex = 10;
            // 
            // lbParticipants
            // 
            this.lbParticipants.FormattingEnabled = true;
            this.lbParticipants.Location = new System.Drawing.Point(227, 201);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(330, 69);
            this.lbParticipants.TabIndex = 11;
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(353, 37);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 20);
            this.tbTitre.TabIndex = 12;
            // 
            // tbSomme
            // 
            this.tbSomme.Location = new System.Drawing.Point(353, 78);
            this.tbSomme.Name = "tbSomme";
            this.tbSomme.Size = new System.Drawing.Size(100, 20);
            this.tbSomme.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Intitulé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Somme";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(686, 328);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(43, 18);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "Date";
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(339, 276);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(114, 51);
            this.btValider.TabIndex = 17;
            this.btValider.Text = "Valider la modification";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // lbFinanceur
            // 
            this.lbFinanceur.AutoSize = true;
            this.lbFinanceur.Location = new System.Drawing.Point(12, 28);
            this.lbFinanceur.Name = "lbFinanceur";
            this.lbFinanceur.Size = new System.Drawing.Size(49, 13);
            this.lbFinanceur.TabIndex = 18;
            this.lbFinanceur.Text = "Payeur : ";
            // 
            // lbConcerne
            // 
            this.lbConcerne.FormattingEnabled = true;
            this.lbConcerne.Location = new System.Drawing.Point(584, 126);
            this.lbConcerne.Name = "lbConcerne";
            this.lbConcerne.Size = new System.Drawing.Size(188, 147);
            this.lbConcerne.TabIndex = 19;
            // 
            // FormMaDepense
            // 
            this.AcceptButton = this.btValider;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btRetour;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.lbConcerne);
            this.Controls.Add(this.lbFinanceur);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSomme);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.lbParticipants);
            this.Controls.Add(this.lbPayeur);
            this.Controls.Add(this.btRetour);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMaDepense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMaDepense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.ListBox lbPayeur;
        private System.Windows.Forms.ListBox lbParticipants;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbSomme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label lbFinanceur;
        private System.Windows.Forms.ListBox lbConcerne;
    }
}