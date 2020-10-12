namespace tricount
{
    partial class FormTricount
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
            this.btQuitter = new System.Windows.Forms.Button();
            this.lbDepense = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbSomme = new System.Windows.Forms.TextBox();
            this.lbParticipants = new System.Windows.Forms.ListBox();
            this.lbPayeur = new System.Windows.Forms.ListBox();
            this.btPayer = new System.Windows.Forms.Button();
            this.btSupprimerTricount = new System.Windows.Forms.Button();
            this.btAddParticipant = new System.Windows.Forms.Button();
            this.btSupprimerParticipant = new System.Windows.Forms.Button();
            this.btBalances = new System.Windows.Forms.Button();
            this.lbRemboursement = new System.Windows.Forms.ListBox();
            this.lbRembourse = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btQuitter.Location = new System.Drawing.Point(12, 327);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Retour";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbDepense
            // 
            this.lbDepense.FormattingEnabled = true;
            this.lbDepense.Location = new System.Drawing.Point(394, 12);
            this.lbDepense.Name = "lbDepense";
            this.lbDepense.ScrollAlwaysVisible = true;
            this.lbDepense.Size = new System.Drawing.Size(364, 121);
            this.lbDepense.TabIndex = 1;
            this.lbDepense.SelectedIndexChanged += new System.EventHandler(this.lbDepense_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter une dépense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intitulé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Somme";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(71, 53);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(100, 20);
            this.tbTitre.TabIndex = 6;
            // 
            // tbSomme
            // 
            this.tbSomme.Location = new System.Drawing.Point(71, 93);
            this.tbSomme.Name = "tbSomme";
            this.tbSomme.Size = new System.Drawing.Size(100, 20);
            this.tbSomme.TabIndex = 7;
            // 
            // lbParticipants
            // 
            this.lbParticipants.FormattingEnabled = true;
            this.lbParticipants.Location = new System.Drawing.Point(15, 224);
            this.lbParticipants.Name = "lbParticipants";
            this.lbParticipants.Size = new System.Drawing.Size(330, 69);
            this.lbParticipants.TabIndex = 8;
            this.lbParticipants.SelectedIndexChanged += new System.EventHandler(this.lbParticipants_SelectedIndexChanged);
            // 
            // lbPayeur
            // 
            this.lbPayeur.FormattingEnabled = true;
            this.lbPayeur.Location = new System.Drawing.Point(15, 123);
            this.lbPayeur.Name = "lbPayeur";
            this.lbPayeur.Size = new System.Drawing.Size(330, 69);
            this.lbPayeur.TabIndex = 9;
            this.lbPayeur.SelectedIndexChanged += new System.EventHandler(this.lbPayeur_SelectedIndexChanged);
            // 
            // btPayer
            // 
            this.btPayer.Location = new System.Drawing.Point(127, 327);
            this.btPayer.Name = "btPayer";
            this.btPayer.Size = new System.Drawing.Size(75, 23);
            this.btPayer.TabIndex = 10;
            this.btPayer.Text = "Ajouter";
            this.btPayer.UseVisualStyleBackColor = true;
            this.btPayer.Click += new System.EventHandler(this.btPayer_Click);
            // 
            // btSupprimerTricount
            // 
            this.btSupprimerTricount.Location = new System.Drawing.Point(229, 327);
            this.btSupprimerTricount.Name = "btSupprimerTricount";
            this.btSupprimerTricount.Size = new System.Drawing.Size(145, 23);
            this.btSupprimerTricount.TabIndex = 11;
            this.btSupprimerTricount.Text = "Supprimer le Tricount";
            this.btSupprimerTricount.UseVisualStyleBackColor = true;
            this.btSupprimerTricount.Click += new System.EventHandler(this.btSupprimerTricount_Click);
            // 
            // btAddParticipant
            // 
            this.btAddParticipant.Location = new System.Drawing.Point(12, 3);
            this.btAddParticipant.Name = "btAddParticipant";
            this.btAddParticipant.Size = new System.Drawing.Size(96, 44);
            this.btAddParticipant.TabIndex = 12;
            this.btAddParticipant.Text = "Ajouter un participant";
            this.btAddParticipant.UseVisualStyleBackColor = true;
            this.btAddParticipant.Click += new System.EventHandler(this.btAddParticipant_Click);
            // 
            // btSupprimerParticipant
            // 
            this.btSupprimerParticipant.Location = new System.Drawing.Point(147, 3);
            this.btSupprimerParticipant.Name = "btSupprimerParticipant";
            this.btSupprimerParticipant.Size = new System.Drawing.Size(102, 44);
            this.btSupprimerParticipant.TabIndex = 13;
            this.btSupprimerParticipant.Text = "Supprimer un participant";
            this.btSupprimerParticipant.UseVisualStyleBackColor = true;
            this.btSupprimerParticipant.Click += new System.EventHandler(this.btSupprimerParticipant_Click);
            // 
            // btBalances
            // 
            this.btBalances.Location = new System.Drawing.Point(764, 270);
            this.btBalances.Name = "btBalances";
            this.btBalances.Size = new System.Drawing.Size(75, 23);
            this.btBalances.TabIndex = 14;
            this.btBalances.Text = "Balances";
            this.btBalances.UseVisualStyleBackColor = true;
            this.btBalances.Click += new System.EventHandler(this.btBalances_Click);
            // 
            // lbRemboursement
            // 
            this.lbRemboursement.FormattingEnabled = true;
            this.lbRemboursement.Location = new System.Drawing.Point(394, 148);
            this.lbRemboursement.Name = "lbRemboursement";
            this.lbRemboursement.ScrollAlwaysVisible = true;
            this.lbRemboursement.Size = new System.Drawing.Size(364, 121);
            this.lbRemboursement.TabIndex = 15;
            this.lbRemboursement.SelectedIndexChanged += new System.EventHandler(this.lbRemboursement_SelectedIndexChanged);
            // 
            // lbRembourse
            // 
            this.lbRembourse.FormattingEnabled = true;
            this.lbRembourse.Location = new System.Drawing.Point(394, 275);
            this.lbRembourse.Name = "lbRembourse";
            this.lbRembourse.ScrollAlwaysVisible = true;
            this.lbRembourse.Size = new System.Drawing.Size(364, 95);
            this.lbRembourse.TabIndex = 16;
            // 
            // FormTricount
            // 
            this.AcceptButton = this.btPayer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btQuitter;
            this.ClientSize = new System.Drawing.Size(854, 368);
            this.Controls.Add(this.lbRembourse);
            this.Controls.Add(this.lbRemboursement);
            this.Controls.Add(this.btBalances);
            this.Controls.Add(this.btSupprimerParticipant);
            this.Controls.Add(this.btAddParticipant);
            this.Controls.Add(this.btSupprimerTricount);
            this.Controls.Add(this.btPayer);
            this.Controls.Add(this.lbPayeur);
            this.Controls.Add(this.lbParticipants);
            this.Controls.Add(this.tbSomme);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDepense);
            this.Controls.Add(this.btQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTricount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTricount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.ListBox lbDepense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbSomme;
        private System.Windows.Forms.ListBox lbParticipants;
        private System.Windows.Forms.ListBox lbPayeur;
        private System.Windows.Forms.Button btPayer;
        private System.Windows.Forms.Button btSupprimerTricount;
        private System.Windows.Forms.Button btAddParticipant;
        private System.Windows.Forms.Button btSupprimerParticipant;
        private System.Windows.Forms.Button btBalances;
        private System.Windows.Forms.ListBox lbRemboursement;
        private System.Windows.Forms.ListBox lbRembourse;
    }
}