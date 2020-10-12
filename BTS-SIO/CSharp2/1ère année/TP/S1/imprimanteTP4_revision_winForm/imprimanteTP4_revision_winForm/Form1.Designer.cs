namespace imprimanteTP4_revision_winForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btOption = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbLieu = new System.Windows.Forms.Label();
            this.lbActif = new System.Windows.Forms.Label();
            this.btProp = new System.Windows.Forms.Button();
            this.btRechercheImpr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btPropriete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPages = new System.Windows.Forms.TextBox();
            this.rbSelection = new System.Windows.Forms.RadioButton();
            this.rbPage = new System.Windows.Forms.RadioButton();
            this.rbPageCours = new System.Windows.Forms.RadioButton();
            this.rbTout = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbPages = new System.Windows.Forms.ComboBox();
            this.cbDocument = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbCopiesAssemblee = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbPagesParFeuille = new System.Windows.Forms.ComboBox();
            this.cbEchelle = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOption
            // 
            this.btOption.Location = new System.Drawing.Point(4, 496);
            this.btOption.Name = "btOption";
            this.btOption.Size = new System.Drawing.Size(75, 23);
            this.btOption.TabIndex = 0;
            this.btOption.Text = "Options...";
            this.btOption.UseVisualStyleBackColor = true;
            this.btOption.Click += new System.EventHandler(this.btOption_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(651, 496);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 1;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(559, 496);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.lbLieu);
            this.groupBox1.Controls.Add(this.lbActif);
            this.groupBox1.Controls.Add(this.btProp);
            this.groupBox1.Controls.Add(this.btRechercheImpr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btPropriete);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimante";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Imprimer dans un fichier ",
            "Recto verso manuel"});
            this.checkedListBox1.Location = new System.Drawing.Point(549, 83);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(157, 30);
            this.checkedListBox1.TabIndex = 21;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Commentaire :";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(72, 76);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(84, 13);
            this.lbType.TabIndex = 19;
            this.lbType.Text = "Type imprimante";
            this.lbType.Click += new System.EventHandler(this.lbType_Click);
            // 
            // lbLieu
            // 
            this.lbLieu.AutoSize = true;
            this.lbLieu.Location = new System.Drawing.Point(72, 97);
            this.lbLieu.Name = "lbLieu";
            this.lbLieu.Size = new System.Drawing.Size(80, 13);
            this.lbLieu.TabIndex = 18;
            this.lbLieu.Text = "Lieu imprimante";
            this.lbLieu.Click += new System.EventHandler(this.lbLieu_Click);
            // 
            // lbActif
            // 
            this.lbActif.AutoSize = true;
            this.lbActif.Location = new System.Drawing.Point(72, 54);
            this.lbActif.Name = "lbActif";
            this.lbActif.Size = new System.Drawing.Size(45, 13);
            this.lbActif.TabIndex = 17;
            this.lbActif.Text = "Inactive";
            this.lbActif.Click += new System.EventHandler(this.lbActif_Click);
            // 
            // btProp
            // 
            this.btProp.Location = new System.Drawing.Point(547, 25);
            this.btProp.Name = "btProp";
            this.btProp.Size = new System.Drawing.Size(159, 23);
            this.btProp.TabIndex = 16;
            this.btProp.Text = "Propriétés...";
            this.btProp.UseVisualStyleBackColor = true;
            this.btProp.Click += new System.EventHandler(this.btProp_Click);
            // 
            // btRechercheImpr
            // 
            this.btRechercheImpr.Location = new System.Drawing.Point(549, 54);
            this.btRechercheImpr.Name = "btRechercheImpr";
            this.btRechercheImpr.Size = new System.Drawing.Size(159, 23);
            this.btRechercheImpr.TabIndex = 10;
            this.btRechercheImpr.Text = "Rechercher une imprimante...";
            this.btRechercheImpr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRechercheImpr.UseVisualStyleBackColor = true;
            this.btRechercheImpr.Click += new System.EventHandler(this.btRechercheImpr_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Imprimante";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            // 
            // btPropriete
            // 
            this.btPropriete.Location = new System.Drawing.Point(0, 0);
            this.btPropriete.Name = "btPropriete";
            this.btPropriete.Size = new System.Drawing.Size(75, 23);
            this.btPropriete.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(469, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Où :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etat :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbPages);
            this.groupBox2.Controls.Add(this.rbSelection);
            this.groupBox2.Controls.Add(this.rbPage);
            this.groupBox2.Controls.Add(this.rbPageCours);
            this.groupBox2.Controls.Add(this.rbTout);
            this.groupBox2.Location = new System.Drawing.Point(12, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 212);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etendue de page";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 78);
            this.label13.TabIndex = 5;
            this.label13.Text = resources.GetString("label13.Text");
            // 
            // tbPages
            // 
            this.tbPages.Location = new System.Drawing.Point(75, 78);
            this.tbPages.Name = "tbPages";
            this.tbPages.Size = new System.Drawing.Size(141, 20);
            this.tbPages.TabIndex = 4;
            this.tbPages.TextChanged += new System.EventHandler(this.tbPages_TextChanged);
            // 
            // rbSelection
            // 
            this.rbSelection.AutoSize = true;
            this.rbSelection.Enabled = false;
            this.rbSelection.Location = new System.Drawing.Point(134, 55);
            this.rbSelection.Name = "rbSelection";
            this.rbSelection.Size = new System.Drawing.Size(69, 17);
            this.rbSelection.TabIndex = 3;
            this.rbSelection.TabStop = true;
            this.rbSelection.Text = "Sélection";
            this.rbSelection.UseVisualStyleBackColor = true;
            this.rbSelection.CheckedChanged += new System.EventHandler(this.rbSelection_CheckedChanged);
            // 
            // rbPage
            // 
            this.rbPage.AutoSize = true;
            this.rbPage.Location = new System.Drawing.Point(6, 78);
            this.rbPage.Name = "rbPage";
            this.rbPage.Size = new System.Drawing.Size(61, 17);
            this.rbPage.TabIndex = 2;
            this.rbPage.TabStop = true;
            this.rbPage.Text = "Pages :";
            this.rbPage.UseVisualStyleBackColor = true;
            this.rbPage.CheckedChanged += new System.EventHandler(this.rbPage_CheckedChanged);
            // 
            // rbPageCours
            // 
            this.rbPageCours.AutoSize = true;
            this.rbPageCours.Location = new System.Drawing.Point(6, 55);
            this.rbPageCours.Name = "rbPageCours";
            this.rbPageCours.Size = new System.Drawing.Size(94, 17);
            this.rbPageCours.TabIndex = 1;
            this.rbPageCours.TabStop = true;
            this.rbPageCours.Text = "Page en cours";
            this.rbPageCours.UseVisualStyleBackColor = true;
            this.rbPageCours.CheckedChanged += new System.EventHandler(this.rbPageCours_CheckedChanged);
            // 
            // rbTout
            // 
            this.rbTout.AutoSize = true;
            this.rbTout.Checked = true;
            this.rbTout.Location = new System.Drawing.Point(6, 32);
            this.rbTout.Name = "rbTout";
            this.rbTout.Size = new System.Drawing.Size(47, 17);
            this.rbTout.TabIndex = 0;
            this.rbTout.TabStop = true;
            this.rbTout.Text = "Tout";
            this.rbTout.UseVisualStyleBackColor = true;
            this.rbTout.CheckedChanged += new System.EventHandler(this.rbTout_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Imprimer :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 453);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Imprimer :";
            // 
            // cbPages
            // 
            this.cbPages.FormattingEnabled = true;
            this.cbPages.Location = new System.Drawing.Point(87, 450);
            this.cbPages.Name = "cbPages";
            this.cbPages.Size = new System.Drawing.Size(210, 21);
            this.cbPages.TabIndex = 22;
            this.cbPages.Text = "Page paires et impaires";
            this.cbPages.SelectedIndexChanged += new System.EventHandler(this.cbPages_SelectedIndexChanged);
            // 
            // cbDocument
            // 
            this.cbDocument.FormattingEnabled = true;
            this.cbDocument.Location = new System.Drawing.Point(87, 420);
            this.cbDocument.Name = "cbDocument";
            this.cbDocument.Size = new System.Drawing.Size(210, 21);
            this.cbDocument.TabIndex = 23;
            this.cbDocument.Text = "Document";
            this.cbDocument.SelectedIndexChanged += new System.EventHandler(this.cbDocument_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.cbCopiesAssemblee);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(323, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 151);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Copies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::imprimanteTP4_revision_winForm.Properties.Resources.cp1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbCopiesAssemblee
            // 
            this.cbCopiesAssemblee.AutoSize = true;
            this.cbCopiesAssemblee.Location = new System.Drawing.Point(155, 79);
            this.cbCopiesAssemblee.Name = "cbCopiesAssemblee";
            this.cbCopiesAssemblee.Size = new System.Drawing.Size(116, 17);
            this.cbCopiesAssemblee.TabIndex = 2;
            this.cbCopiesAssemblee.Text = "Copies assemblées";
            this.cbCopiesAssemblee.UseVisualStyleBackColor = true;
            this.cbCopiesAssemblee.CheckedChanged += new System.EventHandler(this.cbCopiesAssemblee_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(122, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nombre de copies :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbPagesParFeuille);
            this.groupBox4.Controls.Add(this.cbEchelle);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(323, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 100);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Zoom";
            // 
            // cbPagesParFeuille
            // 
            this.cbPagesParFeuille.FormattingEnabled = true;
            this.cbPagesParFeuille.Location = new System.Drawing.Point(155, 29);
            this.cbPagesParFeuille.Name = "cbPagesParFeuille";
            this.cbPagesParFeuille.Size = new System.Drawing.Size(210, 21);
            this.cbPagesParFeuille.TabIndex = 26;
            this.cbPagesParFeuille.Text = "1 Page";
            this.cbPagesParFeuille.SelectedIndexChanged += new System.EventHandler(this.cbPagesParFeuille_SelectedIndexChanged);
            // 
            // cbEchelle
            // 
            this.cbEchelle.FormattingEnabled = true;
            this.cbEchelle.Location = new System.Drawing.Point(155, 67);
            this.cbEchelle.Name = "cbEchelle";
            this.cbEchelle.Size = new System.Drawing.Size(210, 21);
            this.cbEchelle.TabIndex = 27;
            this.cbEchelle.Text = "Non";
            this.cbEchelle.SelectedIndexChanged += new System.EventHandler(this.cbEchelle_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Mettre à l\'échelle le papier :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Pages par feuille :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 531);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbPages);
            this.Controls.Add(this.cbDocument);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btOption);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Imprimer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOption;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btPropriete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btRechercheImpr;
        private System.Windows.Forms.Button btProp;
        private System.Windows.Forms.Label lbActif;
        private System.Windows.Forms.Label lbLieu;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTout;
        private System.Windows.Forms.RadioButton rbSelection;
        private System.Windows.Forms.RadioButton rbPage;
        private System.Windows.Forms.RadioButton rbPageCours;
        private System.Windows.Forms.TextBox tbPages;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbPages;
        private System.Windows.Forms.ComboBox cbDocument;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbCopiesAssemblee;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbPagesParFeuille;
        private System.Windows.Forms.ComboBox cbEchelle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

