namespace tricount
{
    partial class FormListeTricount
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
            this.btAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomTricount = new System.Windows.Forms.TextBox();
            this.tbMesParticipants = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTricount = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(12, 327);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(269, 128);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 1;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du Tricount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Participants au Tricount\r\n";
            // 
            // tbNomTricount
            // 
            this.tbNomTricount.Location = new System.Drawing.Point(205, 10);
            this.tbNomTricount.Name = "tbNomTricount";
            this.tbNomTricount.Size = new System.Drawing.Size(139, 20);
            this.tbNomTricount.TabIndex = 4;
            // 
            // tbMesParticipants
            // 
            this.tbMesParticipants.Location = new System.Drawing.Point(205, 85);
            this.tbMesParticipants.Name = "tbMesParticipants";
            this.tbMesParticipants.Size = new System.Drawing.Size(139, 20);
            this.tbMesParticipants.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(386, 327);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 20);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // lbTricount
            // 
            this.lbTricount.FormattingEnabled = true;
            this.lbTricount.Location = new System.Drawing.Point(515, 38);
            this.lbTricount.Name = "lbTricount";
            this.lbTricount.Size = new System.Drawing.Size(257, 290);
            this.lbTricount.TabIndex = 7;
            this.lbTricount.SelectedIndexChanged += new System.EventHandler(this.lbTricount_SelectedIndexChanged);
            // 
            // FormListeTricount
            // 
            this.AcceptButton = this.btAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btQuitter;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.lbTricount);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbMesParticipants);
            this.Controls.Add(this.tbNomTricount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.btQuitter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListeTricount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes Tricount";
            this.Load += new System.EventHandler(this.FormListeTricount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomTricount;
        private System.Windows.Forms.TextBox tbMesParticipants;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox lbTricount;
    }
}