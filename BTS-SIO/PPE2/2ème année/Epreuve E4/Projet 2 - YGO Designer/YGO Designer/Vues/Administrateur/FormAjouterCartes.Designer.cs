
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjouterCartes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTypeCarte = new System.Windows.Forms.ComboBox();
            this.tbNomCarte = new System.Windows.Forms.TextBox();
            this.rtbDescriptCarte = new System.Windows.Forms.RichTextBox();
            this.tbContainCarte = new System.Windows.Forms.TabControl();
            this.tbMonstre = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clbTypeCarteMonstre = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.gbTypeMagie = new System.Windows.Forms.GroupBox();
            this.rbTerrain = new System.Windows.Forms.RadioButton();
            this.rbEquipement = new System.Windows.Forms.RadioButton();
            this.rbRituelle = new System.Windows.Forms.RadioButton();
            this.rbContinue = new System.Windows.Forms.RadioButton();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.btAddMagie = new System.Windows.Forms.Button();
            this.tbPiege = new System.Windows.Forms.TabPage();
            this.gbTypePiege = new System.Windows.Forms.GroupBox();
            this.rbContrePiege = new System.Windows.Forms.RadioButton();
            this.rbContinu = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.btAddPiege = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.clbEffets = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNoCarte = new System.Windows.Forms.TextBox();
            this.tbContainCarte.SuspendLayout();
            this.tbMonstre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbMagie.SuspendLayout();
            this.gbTypeMagie.SuspendLayout();
            this.tbPiege.SuspendLayout();
            this.gbTypePiege.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
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
            this.label2.ForeColor = System.Drawing.Color.White;
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
            this.label3.ForeColor = System.Drawing.Color.White;
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
            this.tbMonstre.BackColor = System.Drawing.Color.White;
            this.tbMonstre.Controls.Add(this.pictureBox1);
            this.tbMonstre.Controls.Add(this.clbTypeCarteMonstre);
            this.tbMonstre.Controls.Add(this.label10);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // clbTypeCarteMonstre
            // 
            this.clbTypeCarteMonstre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTypeCarteMonstre.CheckOnClick = true;
            this.clbTypeCarteMonstre.FormattingEnabled = true;
            this.clbTypeCarteMonstre.Location = new System.Drawing.Point(253, 125);
            this.clbTypeCarteMonstre.MultiColumn = true;
            this.clbTypeCarteMonstre.Name = "clbTypeCarteMonstre";
            this.clbTypeCarteMonstre.Size = new System.Drawing.Size(245, 82);
            this.clbTypeCarteMonstre.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(128, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Type de carte";
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
            this.cbNbrEtoiles.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNbrEtoiles.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNbrEtoiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNbrEtoiles.FormattingEnabled = true;
            this.cbNbrEtoiles.Location = new System.Drawing.Point(734, 30);
            this.cbNbrEtoiles.Name = "cbNbrEtoiles";
            this.cbNbrEtoiles.Size = new System.Drawing.Size(57, 31);
            this.cbNbrEtoiles.TabIndex = 11;
            // 
            // cbAttribMon
            // 
            this.cbAttribMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAttribMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAttribMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttribMon.FormattingEnabled = true;
            this.cbAttribMon.Location = new System.Drawing.Point(152, 46);
            this.cbAttribMon.Name = "cbAttribMon";
            this.cbAttribMon.Size = new System.Drawing.Size(121, 31);
            this.cbAttribMon.TabIndex = 10;
            // 
            // cbTypeMon
            // 
            this.cbTypeMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.label4.Location = new System.Drawing.Point(0, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type de monstre";
            // 
            // btAddMonstre
            // 
            this.btAddMonstre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddMonstre.AutoSize = true;
            this.btAddMonstre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(119)))), ((int)(((byte)(67)))));
            this.btAddMonstre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddMonstre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAddMonstre.FlatAppearance.BorderSize = 0;
            this.btAddMonstre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAddMonstre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btAddMonstre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddMonstre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddMonstre.Location = new System.Drawing.Point(145, 238);
            this.btAddMonstre.Name = "btAddMonstre";
            this.btAddMonstre.Size = new System.Drawing.Size(522, 53);
            this.btAddMonstre.TabIndex = 0;
            this.btAddMonstre.Text = "Ajouter";
            this.btAddMonstre.UseVisualStyleBackColor = false;
            this.btAddMonstre.Click += new System.EventHandler(this.btAddMonstre_Click);
            // 
            // tbMagie
            // 
            this.tbMagie.Controls.Add(this.gbTypeMagie);
            this.tbMagie.Controls.Add(this.btAddMagie);
            this.tbMagie.Location = new System.Drawing.Point(4, 32);
            this.tbMagie.Name = "tbMagie";
            this.tbMagie.Padding = new System.Windows.Forms.Padding(3);
            this.tbMagie.Size = new System.Drawing.Size(794, 305);
            this.tbMagie.TabIndex = 1;
            this.tbMagie.Text = "Magie";
            this.tbMagie.UseVisualStyleBackColor = true;
            // 
            // gbTypeMagie
            // 
            this.gbTypeMagie.Controls.Add(this.rbTerrain);
            this.gbTypeMagie.Controls.Add(this.rbEquipement);
            this.gbTypeMagie.Controls.Add(this.rbRituelle);
            this.gbTypeMagie.Controls.Add(this.rbContinue);
            this.gbTypeMagie.Controls.Add(this.rbQuick);
            this.gbTypeMagie.Controls.Add(this.rbNone);
            this.gbTypeMagie.Location = new System.Drawing.Point(143, 51);
            this.gbTypeMagie.Name = "gbTypeMagie";
            this.gbTypeMagie.Size = new System.Drawing.Size(604, 159);
            this.gbTypeMagie.TabIndex = 2;
            this.gbTypeMagie.TabStop = false;
            this.gbTypeMagie.Text = "Type de magie";
            // 
            // rbTerrain
            // 
            this.rbTerrain.AutoSize = true;
            this.rbTerrain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTerrain.Location = new System.Drawing.Point(454, 111);
            this.rbTerrain.Name = "rbTerrain";
            this.rbTerrain.Size = new System.Drawing.Size(85, 27);
            this.rbTerrain.TabIndex = 5;
            this.rbTerrain.Text = "Terrain";
            this.rbTerrain.UseVisualStyleBackColor = true;
            // 
            // rbEquipement
            // 
            this.rbEquipement.AutoSize = true;
            this.rbEquipement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbEquipement.Location = new System.Drawing.Point(235, 111);
            this.rbEquipement.Name = "rbEquipement";
            this.rbEquipement.Size = new System.Drawing.Size(128, 27);
            this.rbEquipement.TabIndex = 4;
            this.rbEquipement.Text = "Equipement";
            this.rbEquipement.UseVisualStyleBackColor = true;
            // 
            // rbRituelle
            // 
            this.rbRituelle.AutoSize = true;
            this.rbRituelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbRituelle.Location = new System.Drawing.Point(15, 111);
            this.rbRituelle.Name = "rbRituelle";
            this.rbRituelle.Size = new System.Drawing.Size(91, 27);
            this.rbRituelle.TabIndex = 3;
            this.rbRituelle.Text = "Rituelle";
            this.rbRituelle.UseVisualStyleBackColor = true;
            // 
            // rbContinue
            // 
            this.rbContinue.AutoSize = true;
            this.rbContinue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbContinue.Location = new System.Drawing.Point(454, 47);
            this.rbContinue.Name = "rbContinue";
            this.rbContinue.Size = new System.Drawing.Size(102, 27);
            this.rbContinue.TabIndex = 2;
            this.rbContinue.Text = "Continue";
            this.rbContinue.UseVisualStyleBackColor = true;
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbQuick.Location = new System.Drawing.Point(230, 47);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(117, 27);
            this.rbQuick.TabIndex = 1;
            this.rbQuick.Text = "Jeu-Rapide";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNone.Location = new System.Drawing.Point(15, 47);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(89, 27);
            this.rbNone.TabIndex = 0;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "Normal";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // btAddMagie
            // 
            this.btAddMagie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddMagie.BackColor = System.Drawing.Color.Green;
            this.btAddMagie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddMagie.FlatAppearance.BorderSize = 0;
            this.btAddMagie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btAddMagie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btAddMagie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddMagie.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddMagie.Location = new System.Drawing.Point(145, 238);
            this.btAddMagie.Name = "btAddMagie";
            this.btAddMagie.Size = new System.Drawing.Size(522, 53);
            this.btAddMagie.TabIndex = 1;
            this.btAddMagie.Text = "Ajouter";
            this.btAddMagie.UseVisualStyleBackColor = false;
            this.btAddMagie.Click += new System.EventHandler(this.btAddMagie_Click);
            // 
            // tbPiege
            // 
            this.tbPiege.Controls.Add(this.gbTypePiege);
            this.tbPiege.Controls.Add(this.btAddPiege);
            this.tbPiege.Location = new System.Drawing.Point(4, 32);
            this.tbPiege.Name = "tbPiege";
            this.tbPiege.Size = new System.Drawing.Size(794, 305);
            this.tbPiege.TabIndex = 2;
            this.tbPiege.Text = "Piège";
            this.tbPiege.UseVisualStyleBackColor = true;
            // 
            // gbTypePiege
            // 
            this.gbTypePiege.Controls.Add(this.rbContrePiege);
            this.gbTypePiege.Controls.Add(this.rbContinu);
            this.gbTypePiege.Controls.Add(this.rbNormal);
            this.gbTypePiege.Location = new System.Drawing.Point(143, 51);
            this.gbTypePiege.Name = "gbTypePiege";
            this.gbTypePiege.Size = new System.Drawing.Size(600, 164);
            this.gbTypePiege.TabIndex = 3;
            this.gbTypePiege.TabStop = false;
            this.gbTypePiege.Text = "Type de piège";
            // 
            // rbContrePiege
            // 
            this.rbContrePiege.AutoSize = true;
            this.rbContrePiege.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbContrePiege.Location = new System.Drawing.Point(454, 47);
            this.rbContrePiege.Name = "rbContrePiege";
            this.rbContrePiege.Size = new System.Drawing.Size(135, 27);
            this.rbContrePiege.TabIndex = 2;
            this.rbContrePiege.Text = "Contre-Piège";
            this.rbContrePiege.UseVisualStyleBackColor = true;
            // 
            // rbContinu
            // 
            this.rbContinu.AutoSize = true;
            this.rbContinu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbContinu.Location = new System.Drawing.Point(230, 47);
            this.rbContinu.Name = "rbContinu";
            this.rbContinu.Size = new System.Drawing.Size(92, 27);
            this.rbContinu.TabIndex = 1;
            this.rbContinu.Text = "Continu";
            this.rbContinu.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNormal.Location = new System.Drawing.Point(15, 47);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(89, 27);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // btAddPiege
            // 
            this.btAddPiege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddPiege.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(27)))), ((int)(((byte)(17)))));
            this.btAddPiege.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddPiege.FlatAppearance.BorderSize = 0;
            this.btAddPiege.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btAddPiege.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAddPiege.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPiege.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddPiege.Location = new System.Drawing.Point(145, 238);
            this.btAddPiege.Name = "btAddPiege";
            this.btAddPiege.Size = new System.Drawing.Size(522, 53);
            this.btAddPiege.TabIndex = 1;
            this.btAddPiege.Text = "Ajouter";
            this.btAddPiege.UseVisualStyleBackColor = false;
            this.btAddPiege.Click += new System.EventHandler(this.btAddPiege_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(598, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Effets";
            // 
            // clbEffets
            // 
            this.clbEffets.CheckOnClick = true;
            this.clbEffets.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clbEffets.FormattingEnabled = true;
            this.clbEffets.Location = new System.Drawing.Point(598, 107);
            this.clbEffets.Name = "clbEffets";
            this.clbEffets.Size = new System.Drawing.Size(443, 82);
            this.clbEffets.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 7;
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
            this.tbNoCarte.TabIndex = 8;
            // 
            // FormAjouterCartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNoCarte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbContainCarte);
            this.Controls.Add(this.clbEffets);
            this.Controls.Add(this.rtbDescriptCarte);
            this.Controls.Add(this.tbNomCarte);
            this.Controls.Add(this.cbTypeCarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAjouterCartes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter cartes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tbContainCarte.ResumeLayout(false);
            this.tbMonstre.ResumeLayout(false);
            this.tbMonstre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbMagie.ResumeLayout(false);
            this.gbTypeMagie.ResumeLayout(false);
            this.gbTypeMagie.PerformLayout();
            this.tbPiege.ResumeLayout(false);
            this.gbTypePiege.ResumeLayout(false);
            this.gbTypePiege.PerformLayout();
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
        private System.Windows.Forms.Button btAddMagie;
        private System.Windows.Forms.Button btAddPiege;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox clbTypeCarteMonstre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbTypeMagie;
        private System.Windows.Forms.RadioButton rbTerrain;
        private System.Windows.Forms.RadioButton rbEquipement;
        private System.Windows.Forms.RadioButton rbRituelle;
        private System.Windows.Forms.RadioButton rbContinue;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.GroupBox gbTypePiege;
        private System.Windows.Forms.RadioButton rbContrePiege;
        private System.Windows.Forms.RadioButton rbContinu;
        private System.Windows.Forms.RadioButton rbNormal;
    }
}

