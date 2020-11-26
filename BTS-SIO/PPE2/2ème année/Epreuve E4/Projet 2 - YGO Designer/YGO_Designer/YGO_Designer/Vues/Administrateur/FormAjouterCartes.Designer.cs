
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(472, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // tbNomCarte
            // 
            this.tbNomCarte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNomCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomCarte.Location = new System.Drawing.Point(469, 46);
            this.tbNomCarte.Multiline = true;
            this.tbNomCarte.Name = "tbNomCarte";
            this.tbNomCarte.Size = new System.Drawing.Size(291, 25);
            this.tbNomCarte.TabIndex = 4;
            // 
            // rtbDescriptCarte
            // 
            this.rtbDescriptCarte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescriptCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescriptCarte.Location = new System.Drawing.Point(77, 144);
            this.rtbDescriptCarte.Name = "rtbDescriptCarte";
            this.rtbDescriptCarte.Size = new System.Drawing.Size(295, 78);
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
            this.tbContainCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbContainCarte.Location = new System.Drawing.Point(77, 246);
            this.tbContainCarte.Margin = new System.Windows.Forms.Padding(0);
            this.tbContainCarte.Name = "tbContainCarte";
            this.tbContainCarte.SelectedIndex = 0;
            this.tbContainCarte.Size = new System.Drawing.Size(687, 334);
            this.tbContainCarte.TabIndex = 6;
            this.tbContainCarte.SelectedIndexChanged += new System.EventHandler(this.tbContainCarte_SelectedIndexChanged);
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
            this.tbMonstre.Margin = new System.Windows.Forms.Padding(0);
            this.tbMonstre.Name = "tbMonstre";
            this.tbMonstre.Padding = new System.Windows.Forms.Padding(10);
            this.tbMonstre.Size = new System.Drawing.Size(679, 298);
            this.tbMonstre.TabIndex = 0;
            this.tbMonstre.Text = "Monstre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(641, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // clbTypeCarteMonstre
            // 
            this.clbTypeCarteMonstre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clbTypeCarteMonstre.CheckOnClick = true;
            this.clbTypeCarteMonstre.FormattingEnabled = true;
            this.clbTypeCarteMonstre.Location = new System.Drawing.Point(68, 127);
            this.clbTypeCarteMonstre.MultiColumn = true;
            this.clbTypeCarteMonstre.Name = "clbTypeCarteMonstre";
            this.clbTypeCarteMonstre.Size = new System.Drawing.Size(547, 82);
            this.clbTypeCarteMonstre.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(64, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Type de carte";
            // 
            // tbDefMo
            // 
            this.tbDefMo.Location = new System.Drawing.Point(388, 47);
            this.tbDefMo.Name = "tbDefMo";
            this.tbDefMo.Size = new System.Drawing.Size(105, 31);
            this.tbDefMo.TabIndex = 15;
            // 
            // tbAtkMo
            // 
            this.tbAtkMo.Location = new System.Drawing.Point(388, 6);
            this.tbAtkMo.Name = "tbAtkMo";
            this.tbAtkMo.Size = new System.Drawing.Size(105, 31);
            this.tbAtkMo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(304, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Défense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(304, 16);
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
            this.cbNbrEtoiles.BackColor = System.Drawing.SystemColors.Window;
            this.cbNbrEtoiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNbrEtoiles.FormattingEnabled = true;
            this.cbNbrEtoiles.Location = new System.Drawing.Point(617, 41);
            this.cbNbrEtoiles.Name = "cbNbrEtoiles";
            this.cbNbrEtoiles.Size = new System.Drawing.Size(49, 31);
            this.cbNbrEtoiles.TabIndex = 11;
            // 
            // cbAttribMon
            // 
            this.cbAttribMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAttribMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAttribMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAttribMon.FormattingEnabled = true;
            this.cbAttribMon.Location = new System.Drawing.Point(164, 40);
            this.cbAttribMon.Name = "cbAttribMon";
            this.cbAttribMon.Size = new System.Drawing.Size(104, 31);
            this.cbAttribMon.TabIndex = 10;
            // 
            // cbTypeMon
            // 
            this.cbTypeMon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeMon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeMon.FormattingEnabled = true;
            this.cbTypeMon.Location = new System.Drawing.Point(164, 3);
            this.cbTypeMon.Name = "cbTypeMon";
            this.cbTypeMon.Size = new System.Drawing.Size(104, 31);
            this.cbTypeMon.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(64, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Attribut ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(570, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Niveau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type de monstre";
            // 
            // btAddMonstre
            // 
            this.btAddMonstre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddMonstre.AutoSize = true;
            this.btAddMonstre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(232)))), ((int)(((byte)(85)))));
            this.btAddMonstre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddMonstre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAddMonstre.FlatAppearance.BorderSize = 0;
            this.btAddMonstre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAddMonstre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btAddMonstre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddMonstre.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btAddMonstre.Location = new System.Drawing.Point(134, 225);
            this.btAddMonstre.Name = "btAddMonstre";
            this.btAddMonstre.Size = new System.Drawing.Size(427, 46);
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
            this.tbMagie.Margin = new System.Windows.Forms.Padding(0);
            this.tbMagie.Name = "tbMagie";
            this.tbMagie.Padding = new System.Windows.Forms.Padding(10);
            this.tbMagie.Size = new System.Drawing.Size(679, 298);
            this.tbMagie.TabIndex = 1;
            this.tbMagie.Text = "Magie";
            this.tbMagie.UseVisualStyleBackColor = true;
            // 
            // gbTypeMagie
            // 
            this.gbTypeMagie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTypeMagie.Controls.Add(this.rbTerrain);
            this.gbTypeMagie.Controls.Add(this.rbEquipement);
            this.gbTypeMagie.Controls.Add(this.rbRituelle);
            this.gbTypeMagie.Controls.Add(this.rbContinue);
            this.gbTypeMagie.Controls.Add(this.rbQuick);
            this.gbTypeMagie.Controls.Add(this.rbNone);
            this.gbTypeMagie.Location = new System.Drawing.Point(90, 47);
            this.gbTypeMagie.Name = "gbTypeMagie";
            this.gbTypeMagie.Size = new System.Drawing.Size(504, 138);
            this.gbTypeMagie.TabIndex = 2;
            this.gbTypeMagie.TabStop = false;
            this.gbTypeMagie.Text = "Type de magie";
            // 
            // rbTerrain
            // 
            this.rbTerrain.AutoSize = true;
            this.rbTerrain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbTerrain.Location = new System.Drawing.Point(389, 96);
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
            this.rbEquipement.Location = new System.Drawing.Point(201, 96);
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
            this.rbRituelle.Location = new System.Drawing.Point(13, 96);
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
            this.rbContinue.Location = new System.Drawing.Point(389, 41);
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
            this.rbQuick.Location = new System.Drawing.Point(197, 41);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(84, 27);
            this.rbQuick.TabIndex = 1;
            this.rbQuick.Text = "Rapide";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNone.Location = new System.Drawing.Point(13, 41);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(99, 27);
            this.rbNone.TabIndex = 0;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "Normale";
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
            this.btAddMagie.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btAddMagie.Location = new System.Drawing.Point(134, 225);
            this.btAddMagie.Name = "btAddMagie";
            this.btAddMagie.Size = new System.Drawing.Size(427, 46);
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
            this.tbPiege.Margin = new System.Windows.Forms.Padding(0);
            this.tbPiege.Name = "tbPiege";
            this.tbPiege.Padding = new System.Windows.Forms.Padding(10);
            this.tbPiege.Size = new System.Drawing.Size(679, 298);
            this.tbPiege.TabIndex = 2;
            this.tbPiege.Text = "Piège";
            this.tbPiege.UseVisualStyleBackColor = true;
            // 
            // gbTypePiege
            // 
            this.gbTypePiege.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTypePiege.Controls.Add(this.rbContrePiege);
            this.gbTypePiege.Controls.Add(this.rbContinu);
            this.gbTypePiege.Controls.Add(this.rbNormal);
            this.gbTypePiege.Location = new System.Drawing.Point(93, 45);
            this.gbTypePiege.Name = "gbTypePiege";
            this.gbTypePiege.Size = new System.Drawing.Size(494, 142);
            this.gbTypePiege.TabIndex = 3;
            this.gbTypePiege.TabStop = false;
            this.gbTypePiege.Text = "Type de piège";
            // 
            // rbContrePiege
            // 
            this.rbContrePiege.AutoSize = true;
            this.rbContrePiege.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbContrePiege.Location = new System.Drawing.Point(368, 41);
            this.rbContrePiege.Name = "rbContrePiege";
            this.rbContrePiege.Size = new System.Drawing.Size(140, 27);
            this.rbContrePiege.TabIndex = 2;
            this.rbContrePiege.Text = "Contre_Piege";
            this.rbContrePiege.UseVisualStyleBackColor = true;
            // 
            // rbContinu
            // 
            this.rbContinu.AutoSize = true;
            this.rbContinu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbContinu.Location = new System.Drawing.Point(197, 41);
            this.rbContinu.Name = "rbContinu";
            this.rbContinu.Size = new System.Drawing.Size(102, 27);
            this.rbContinu.TabIndex = 1;
            this.rbContinu.Text = "Continue";
            this.rbContinu.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbNormal.Location = new System.Drawing.Point(13, 41);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(99, 27);
            this.rbNormal.TabIndex = 0;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normale";
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
            this.btAddPiege.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btAddPiege.Location = new System.Drawing.Point(134, 225);
            this.btAddPiege.Name = "btAddPiege";
            this.btAddPiege.Size = new System.Drawing.Size(427, 46);
            this.btAddPiege.TabIndex = 1;
            this.btAddPiege.Text = "Ajouter";
            this.btAddPiege.UseVisualStyleBackColor = false;
            this.btAddPiege.Click += new System.EventHandler(this.btAddPiege_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(465, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Effets";
            // 
            // clbEffets
            // 
            this.clbEffets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbEffets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbEffets.CheckOnClick = true;
            this.clbEffets.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.clbEffets.FormattingEnabled = true;
            this.clbEffets.Location = new System.Drawing.Point(469, 144);
            this.clbEffets.Name = "clbEffets";
            this.clbEffets.Size = new System.Drawing.Size(295, 78);
            this.clbEffets.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(73, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "N°";
            // 
            // tbNoCarte
            // 
            this.tbNoCarte.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbNoCarte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNoCarte.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoCarte.Location = new System.Drawing.Point(77, 43);
            this.tbNoCarte.MaxLength = 8;
            this.tbNoCarte.Name = "tbNoCarte";
            this.tbNoCarte.Size = new System.Drawing.Size(182, 30);
            this.tbNoCarte.TabIndex = 8;
            // 
            // FormAjouterCartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(843, 627);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbNoCarte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbContainCarte);
            this.Controls.Add(this.clbEffets);
            this.Controls.Add(this.rtbDescriptCarte);
            this.Controls.Add(this.tbNomCarte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.GroupBox gbTypePiege;
        private System.Windows.Forms.RadioButton rbContrePiege;
        private System.Windows.Forms.RadioButton rbContinu;
        private System.Windows.Forms.RadioButton rbNormal;
    }
}

