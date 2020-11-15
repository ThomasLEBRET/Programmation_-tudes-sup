
namespace YGO_Designer
{
    partial class FormChercherCarte
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.tbNoCarte = new System.Windows.Forms.TextBox();
            this.tbNomCarte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChercherParNum = new System.Windows.Forms.Button();
            this.btChercheParNom = new System.Windows.Forms.Button();
            this.lbCartes = new System.Windows.Forms.ListBox();
            this.paCarte = new System.Windows.Forms.Panel();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.paCarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "N°";
            // 
            // tbNoCarte
            // 
            this.tbNoCarte.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbNoCarte.Location = new System.Drawing.Point(65, 27);
            this.tbNoCarte.MaxLength = 8;
            this.tbNoCarte.Name = "tbNoCarte";
            this.tbNoCarte.PlaceholderText = "12345678";
            this.tbNoCarte.Size = new System.Drawing.Size(212, 23);
            this.tbNoCarte.TabIndex = 9;
            // 
            // tbNomCarte
            // 
            this.tbNomCarte.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbNomCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomCarte.Location = new System.Drawing.Point(760, 25);
            this.tbNomCarte.MaxLength = 8;
            this.tbNomCarte.Name = "tbNomCarte";
            this.tbNomCarte.PlaceholderText = "12345678";
            this.tbNomCarte.Size = new System.Drawing.Size(212, 23);
            this.tbNomCarte.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Correspondance partielle par nom";
            // 
            // btChercherParNum
            // 
            this.btChercherParNum.BackColor = System.Drawing.Color.Black;
            this.btChercherParNum.FlatAppearance.BorderSize = 0;
            this.btChercherParNum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btChercherParNum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btChercherParNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChercherParNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChercherParNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChercherParNum.Location = new System.Drawing.Point(38, 85);
            this.btChercherParNum.Name = "btChercherParNum";
            this.btChercherParNum.Size = new System.Drawing.Size(238, 45);
            this.btChercherParNum.TabIndex = 12;
            this.btChercherParNum.Text = "Chercher par numéro";
            this.btChercherParNum.UseVisualStyleBackColor = false;
            this.btChercherParNum.Click += new System.EventHandler(this.btChercherParNum_Click);
            // 
            // btChercheParNom
            // 
            this.btChercheParNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChercheParNom.BackColor = System.Drawing.Color.Black;
            this.btChercheParNom.FlatAppearance.BorderSize = 0;
            this.btChercheParNom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btChercheParNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btChercheParNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChercheParNom.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChercheParNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChercheParNom.Location = new System.Drawing.Point(681, 85);
            this.btChercheParNom.Name = "btChercheParNom";
            this.btChercheParNom.Size = new System.Drawing.Size(238, 45);
            this.btChercheParNom.TabIndex = 13;
            this.btChercheParNom.Text = "Chercher par nom partiel";
            this.btChercheParNom.UseVisualStyleBackColor = false;
            // 
            // lbCartes
            // 
            this.lbCartes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCartes.FormattingEnabled = true;
            this.lbCartes.ItemHeight = 15;
            this.lbCartes.Location = new System.Drawing.Point(38, 179);
            this.lbCartes.Name = "lbCartes";
            this.lbCartes.Size = new System.Drawing.Size(457, 349);
            this.lbCartes.TabIndex = 14;
            this.lbCartes.SelectedIndexChanged += new System.EventHandler(this.lbCartes_SelectedIndexChanged);
            // 
            // paCarte
            // 
            this.paCarte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paCarte.BackColor = System.Drawing.Color.DarkGray;
            this.paCarte.Controls.Add(this.lbDescription);
            this.paCarte.Controls.Add(this.lbNom);
            this.paCarte.Location = new System.Drawing.Point(630, 179);
            this.paCarte.Name = "paCarte";
            this.paCarte.Size = new System.Drawing.Size(308, 349);
            this.paCarte.TabIndex = 15;
            // 
            // lbNom
            // 
            this.lbNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNom.ForeColor = System.Drawing.Color.White;
            this.lbNom.Location = new System.Drawing.Point(10, 9);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(50, 23);
            this.lbNom.TabIndex = 16;
            this.lbNom.Text = "Nom";
            // 
            // lbDescription
            // 
            this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescription.ForeColor = System.Drawing.Color.White;
            this.lbDescription.Location = new System.Drawing.Point(10, 67);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(103, 23);
            this.lbDescription.TabIndex = 17;
            this.lbDescription.Text = "Description";
            // 
            // FormChercherCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.paCarte);
            this.Controls.Add(this.lbCartes);
            this.Controls.Add(this.btChercheParNom);
            this.Controls.Add(this.btChercherParNum);
            this.Controls.Add(this.tbNomCarte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNoCarte);
            this.Controls.Add(this.label7);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormChercherCarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGO Designer - Ajouter cartes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.paCarte.ResumeLayout(false);
            this.paCarte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNoCarte;
        private System.Windows.Forms.TextBox tbNomCarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChercherParNum;
        private System.Windows.Forms.Button btChercheParNom;
        private System.Windows.Forms.ListBox lbCartes;
        private System.Windows.Forms.Panel paCarte;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.Label lbDescription;
    }
}

