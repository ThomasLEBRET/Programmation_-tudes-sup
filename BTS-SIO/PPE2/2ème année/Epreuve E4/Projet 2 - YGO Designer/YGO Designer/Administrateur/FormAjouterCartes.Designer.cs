
namespace YGO_Designer
{
    partial class FormAjouterCartes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeCarte = new System.Windows.Forms.ComboBox();
            this.tbNomCarte = new System.Windows.Forms.TextBox();
            this.rtbDescriptCarte = new System.Windows.Forms.RichTextBox();
            this.tbContainCarte = new System.Windows.Forms.TabControl();
            this.tbMonstre = new System.Windows.Forms.TabPage();
            this.clbEffets = new System.Windows.Forms.CheckedListBox();
            this.tbDefMo = new System.Windows.Forms.TextBox();
            this.tbAtkMo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbNbrEtoiles = new System.Windows.Forms.ComboBox();
            this.cbAttribMon = new System.Windows.Forms.ComboBox();
            this.cbTypeMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddMonstre = new System.Windows.Forms.Button();
            this.tbMagie = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPiege = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNoCarte = new System.Windows.Forms.TextBox();
            this.tbContainCarte.SuspendLayout();
            this.tbMonstre.SuspendLayout();
            this.tbMagie.SuspendLayout();
            this.tbPiege.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(305, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type de carte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(638, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(18, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // cbTypeCarte
            // 
            this.cbTypeCarte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeCarte.FormattingEnabled = true;
            this.cbTypeCarte.Location = new System.Drawing.Point(459, 25);
            this.cbTypeCarte.Name = "cbTypeCarte";
            this.cbTypeCarte.Size = new System.Drawing.Size(121, 23);
            this.cbTypeCarte.TabIndex = 3;
            // 
            // tbNomCarte
            // 
            this.tbNomCarte.Location = new System.Drawing.Point(694, 28);
            this.tbNomCarte.Name = "tbNomCarte";
            this.tbNomCarte.PlaceholderText = "Illusionniste d\'effet";
            this.tbNomCarte.Size = new System.Drawing.Size(278, 23);
            this.tbNomCarte.TabIndex = 4;
            // 
            // rtbDescriptCarte
            // 
            this.rtbDescriptCarte.Location = new System.Drawing.Point(143, 93);
            this.rtbDescriptCarte.Name = "rtbDescriptCarte";
            this.rtbDescriptCarte.Size = new System.Drawing.Size(437, 96);
            this.rtbDescriptCarte.TabIndex = 5;
            this.rtbDescriptCarte.Text = "";
            // 
            // tbContainCarte
            // 
            this.tbContainCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContainCarte.Controls.Add(this.tbMonstre);
            this.tbContainCarte.Controls.Add(this.tbMagie);
            this.tbContainCarte.Controls.Add(this.tbPiege);
            this.tbContainCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbContainCarte.Location = new System.Drawing.Point(143, 208);
            this.tbContainCarte.Name = "tbContainCarte";
            this.tbContainCarte.SelectedIndex = 0;
            this.tbContainCarte.Size = new System.Drawing.Size(802, 341);
            this.tbContainCarte.TabIndex = 6;
            // 
            // tbMonstre
            // 
            this.tbMonstre.Controls.Add(this.clbEffets);
            this.tbMonstre.Controls.Add(this.tbDefMo);
            this.tbMonstre.Controls.Add(this.tbAtkMo);
            this.tbMonstre.Controls.Add(this.label9);
            this.tbMonstre.Controls.Add(this.label8);
            this.tbMonstre.Controls.Add(this.cbNbrEtoiles);
            this.tbMonstre.Controls.Add(this.cbAttribMon);
            this.tbMonstre.Controls.Add(this.cbTypeMon);
            this.tbMonstre.Controls.Add(this.label6);
            this.tbMonstre.Controls.Add(this.label5);
            this.tbMonstre.Controls.Add(this.label4);
            this.tbMonstre.Controls.Add(this.btAddMonstre);
            this.tbMonstre.Location = new System.Drawing.Point(4, 32);
            this.tbMonstre.Name = "tbMonstre";
            this.tbMonstre.Padding = new System.Windows.Forms.Padding(3);
            this.tbMonstre.Size = new System.Drawing.Size(794, 305);
            this.tbMonstre.TabIndex = 0;
            this.tbMonstre.Text = "Monstre";
            this.tbMonstre.UseVisualStyleBackColor = true;
            // 
            // clbEffets
            // 
            this.clbEffets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEffets.CheckOnClick = true;
            this.clbEffets.ColumnWidth = 2;
            this.clbEffets.FormattingEnabled = true;
            this.clbEffets.Location = new System.Drawing.Point(67, 105);
            this.clbEffets.Name = "clbEffets";
            this.clbEffets.Size = new System.Drawing.Size(641, 108);
            this.clbEffets.TabIndex = 16;
            // 
            // tbDefMo
            // 
            this.tbDefMo.Location = new System.Drawing.Point(376, 54);
            this.tbDefMo.Name = "tbDefMo";
            this.tbDefMo.Size = new System.Drawing.Size(122, 31);
            this.tbDefMo.TabIndex = 15;
            // 
            // tbAtkMo
            // 
            this.tbAtkMo.Location = new System.Drawing.Point(376, 6);
            this.tbAtkMo.Name = "tbAtkMo";
            this.tbAtkMo.Size = new System.Drawing.Size(122, 31);
            this.tbAtkMo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(290, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Défense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(290, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "Attaque ";
            // 
            // cbNbrEtoiles
            // 
            this.cbNbrEtoiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNbrEtoiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNbrEtoiles.FormattingEnabled = true;
            this.cbNbrEtoiles.Location = new System.Drawing.Point(734, 30);
            this.cbNbrEtoiles.Name = "cbNbrEtoiles";
            this.cbNbrEtoiles.Size = new System.Drawing.Size(57, 31);
            this.cbNbrEtoiles.TabIndex = 11;
            // 
            // cbAttribMon
            // 
            this.cbAttribMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttribMon.FormattingEnabled = true;
            this.cbAttribMon.Location = new System.Drawing.Point(152, 46);
            this.cbAttribMon.Name = "cbAttribMon";
            this.cbAttribMon.Size = new System.Drawing.Size(121, 31);
            this.cbAttribMon.TabIndex = 10;
            // 
            // cbTypeMon
            // 
            this.cbTypeMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeMon.FormattingEnabled = true;
            this.cbTypeMon.Location = new System.Drawing.Point(152, 3);
            this.cbTypeMon.Name = "cbTypeMon";
            this.cbTypeMon.Size = new System.Drawing.Size(121, 31);
            this.cbTypeMon.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(67, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Attribut ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(640, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre d\'étoiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type de monstre";
            // 
            // btAddMonstre
            // 
            this.btAddMonstre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddMonstre.AutoSize = true;
            this.btAddMonstre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAddMonstre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddMonstre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAddMonstre.FlatAppearance.BorderSize = 0;
            this.btAddMonstre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAddMonstre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btAddMonstre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddMonstre.Location = new System.Drawing.Point(145, 238);
            this.btAddMonstre.Name = "btAddMonstre";
            this.btAddMonstre.Size = new System.Drawing.Size(490, 53);
            this.btAddMonstre.TabIndex = 0;
            this.btAddMonstre.Text = "Ajouter";
            this.btAddMonstre.UseVisualStyleBackColor = false;
            this.btAddMonstre.Click += new System.EventHandler(this.btAddMonstre_Click);
            // 
            // tbMagie
            // 
            this.tbMagie.Controls.Add(this.button1);
            this.tbMagie.Location = new System.Drawing.Point(4, 32);
            this.tbMagie.Name = "tbMagie";
            this.tbMagie.Padding = new System.Windows.Forms.Padding(3);
            this.tbMagie.Size = new System.Drawing.Size(794, 305);
            this.tbMagie.TabIndex = 1;
            this.tbMagie.Text = "Magie";
            this.tbMagie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(266, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbPiege
            // 
            this.tbPiege.Controls.Add(this.button2);
            this.tbPiege.Location = new System.Drawing.Point(4, 32);
            this.tbPiege.Name = "tbPiege";
            this.tbPiege.Size = new System.Drawing.Size(794, 305);
            this.tbPiege.TabIndex = 2;
            this.tbPiege.Text = "Piège";
            this.tbPiege.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(266, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "N°";
            // 
            // tbNoCarte
            // 
            this.tbNoCarte.Location = new System.Drawing.Point(65, 27);
            this.tbNoCarte.MaxLength = 8;
            this.tbNoCarte.Name = "tbNoCarte";
            this.tbNoCarte.PlaceholderText = "12345678";
            this.tbNoCarte.Size = new System.Drawing.Size(212, 23);
            this.tbNoCarte.TabIndex = 8;
            // 
            // FormAjouterCartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tbNoCarte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbContainCarte);
            this.Controls.Add(this.rtbDescriptCarte);
            this.Controls.Add(this.tbNomCarte);
            this.Controls.Add(this.cbTypeCarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormAjouterCartes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGO Designer - Ajouter cartes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbContainCarte.ResumeLayout(false);
            this.tbMonstre.ResumeLayout(false);
            this.tbMonstre.PerformLayout();
            this.tbMagie.ResumeLayout(false);
            this.tbPiege.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTypeCarte;
        private System.Windows.Forms.TextBox tbNomCarte;
        private System.Windows.Forms.RichTextBox rtbDescriptCarte;
        private System.Windows.Forms.TabControl tbContainCarte;
        private System.Windows.Forms.TabPage tbMonstre;
        private System.Windows.Forms.TabPage tbMagie;
        private System.Windows.Forms.TabPage tbPiege;
        private System.Windows.Forms.Button btAddMonstre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbAttribMon;
        private System.Windows.Forms.ComboBox cbTypeMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNbrEtoiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNoCarte;
        private System.Windows.Forms.TextBox tbDefMo;
        private System.Windows.Forms.TextBox tbAtkMo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbEffets;
    }
}

