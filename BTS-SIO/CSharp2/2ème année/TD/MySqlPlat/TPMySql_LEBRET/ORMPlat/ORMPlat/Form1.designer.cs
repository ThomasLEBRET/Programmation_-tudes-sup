namespace ORMPlat
{
    partial class Form1
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
            this.btConnexion = new System.Windows.Forms.Button();
            this.btDeconnexion = new System.Windows.Forms.Button();
            this.lbPlats = new System.Windows.Forms.ListBox();
            this.btAfficherAllPlats = new System.Windows.Forms.Button();
            this.cbCategoriePlat = new System.Windows.Forms.ComboBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVegan = new System.Windows.Forms.CheckBox();
            this.cbGlutenFree = new System.Windows.Forms.CheckBox();
            this.btAffichPlatCat = new System.Windows.Forms.Button();
            this.btPlatMoinsCher = new System.Windows.Forms.Button();
            this.btPlatPlusCal = new System.Windows.Forms.Button();
            this.btNbrPlats = new System.Windows.Forms.Button();
            this.btPrixMoyen = new System.Windows.Forms.Button();
            this.btSuppPlat = new System.Windows.Forms.Button();
            this.btAjouterPlat = new System.Windows.Forms.Button();
            this.btValiderModif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.tbCal = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.lbConnexion = new System.Windows.Forms.Label();
            this.btValidModif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnexion
            // 
            this.btConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConnexion.Location = new System.Drawing.Point(541, 28);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(101, 23);
            this.btConnexion.TabIndex = 0;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // btDeconnexion
            // 
            this.btDeconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeconnexion.Location = new System.Drawing.Point(669, 28);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(100, 23);
            this.btDeconnexion.TabIndex = 0;
            this.btDeconnexion.Text = "Déconnexion";
            this.btDeconnexion.UseVisualStyleBackColor = true;
            this.btDeconnexion.Click += new System.EventHandler(this.btDeconnexion_Click);
            // 
            // lbPlats
            // 
            this.lbPlats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPlats.FormattingEnabled = true;
            this.lbPlats.ItemHeight = 15;
            this.lbPlats.Location = new System.Drawing.Point(189, 114);
            this.lbPlats.Name = "lbPlats";
            this.lbPlats.Size = new System.Drawing.Size(399, 229);
            this.lbPlats.TabIndex = 1;
            // 
            // btAfficherAllPlats
            // 
            this.btAfficherAllPlats.Location = new System.Drawing.Point(189, 85);
            this.btAfficherAllPlats.Name = "btAfficherAllPlats";
            this.btAfficherAllPlats.Size = new System.Drawing.Size(198, 23);
            this.btAfficherAllPlats.TabIndex = 2;
            this.btAfficherAllPlats.Text = "Afficher tous les plats";
            this.btAfficherAllPlats.UseVisualStyleBackColor = true;
            this.btAfficherAllPlats.Click += new System.EventHandler(this.btAfficherAllPlats_Click);
            // 
            // cbCategoriePlat
            // 
            this.cbCategoriePlat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategoriePlat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriePlat.FormattingEnabled = true;
            this.cbCategoriePlat.Location = new System.Drawing.Point(457, 85);
            this.cbCategoriePlat.Name = "cbCategoriePlat";
            this.cbCategoriePlat.Size = new System.Drawing.Size(121, 23);
            this.cbCategoriePlat.Sorted = true;
            this.cbCategoriePlat.TabIndex = 3;
            // 
            // cbCat
            // 
            this.cbCat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Location = new System.Drawing.Point(68, 211);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(100, 23);
            this.cbCat.Sorted = true;
            this.cbCat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prix : ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories : ";
            // 
            // cbVegan
            // 
            this.cbVegan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbVegan.AutoSize = true;
            this.cbVegan.Location = new System.Drawing.Point(12, 315);
            this.cbVegan.Name = "cbVegan";
            this.cbVegan.Size = new System.Drawing.Size(58, 19);
            this.cbVegan.TabIndex = 5;
            this.cbVegan.Text = "Vegan";
            this.cbVegan.UseVisualStyleBackColor = true;
            // 
            // cbGlutenFree
            // 
            this.cbGlutenFree.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbGlutenFree.AutoSize = true;
            this.cbGlutenFree.Location = new System.Drawing.Point(89, 315);
            this.cbGlutenFree.Name = "cbGlutenFree";
            this.cbGlutenFree.Size = new System.Drawing.Size(83, 19);
            this.cbGlutenFree.TabIndex = 5;
            this.cbGlutenFree.Text = "GlutenFree";
            this.cbGlutenFree.UseVisualStyleBackColor = true;
            // 
            // btAffichPlatCat
            // 
            this.btAffichPlatCat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAffichPlatCat.Location = new System.Drawing.Point(587, 84);
            this.btAffichPlatCat.Name = "btAffichPlatCat";
            this.btAffichPlatCat.Size = new System.Drawing.Size(182, 23);
            this.btAffichPlatCat.TabIndex = 6;
            this.btAffichPlatCat.Text = "Afficher les plats de la catégorie";
            this.btAffichPlatCat.UseVisualStyleBackColor = true;
            this.btAffichPlatCat.Click += new System.EventHandler(this.btAffichPlatCat_Click);
            // 
            // btPlatMoinsCher
            // 
            this.btPlatMoinsCher.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btPlatMoinsCher.Location = new System.Drawing.Point(609, 133);
            this.btPlatMoinsCher.Name = "btPlatMoinsCher";
            this.btPlatMoinsCher.Size = new System.Drawing.Size(75, 47);
            this.btPlatMoinsCher.TabIndex = 7;
            this.btPlatMoinsCher.Text = "Plat le moins cher ";
            this.btPlatMoinsCher.UseVisualStyleBackColor = true;
            this.btPlatMoinsCher.Click += new System.EventHandler(this.btPlatMoinsCher_Click);
            // 
            // btPlatPlusCal
            // 
            this.btPlatPlusCal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btPlatPlusCal.Location = new System.Drawing.Point(713, 133);
            this.btPlatPlusCal.Name = "btPlatPlusCal";
            this.btPlatPlusCal.Size = new System.Drawing.Size(75, 47);
            this.btPlatPlusCal.TabIndex = 7;
            this.btPlatPlusCal.Text = "Plat le plus calorique";
            this.btPlatPlusCal.UseVisualStyleBackColor = true;
            this.btPlatPlusCal.Click += new System.EventHandler(this.btPlatPlusCal_Click);
            // 
            // btNbrPlats
            // 
            this.btNbrPlats.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btNbrPlats.Location = new System.Drawing.Point(609, 214);
            this.btNbrPlats.Name = "btNbrPlats";
            this.btNbrPlats.Size = new System.Drawing.Size(75, 52);
            this.btNbrPlats.TabIndex = 8;
            this.btNbrPlats.Text = "Nombre de plats ";
            this.btNbrPlats.UseVisualStyleBackColor = true;
            this.btNbrPlats.Click += new System.EventHandler(this.btNbrPlats_Click);
            // 
            // btPrixMoyen
            // 
            this.btPrixMoyen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btPrixMoyen.Location = new System.Drawing.Point(713, 214);
            this.btPrixMoyen.Name = "btPrixMoyen";
            this.btPrixMoyen.Size = new System.Drawing.Size(75, 52);
            this.btPrixMoyen.TabIndex = 8;
            this.btPrixMoyen.Text = "Prix moyen";
            this.btPrixMoyen.UseVisualStyleBackColor = true;
            this.btPrixMoyen.Click += new System.EventHandler(this.btPrixMoyen_Click);
            // 
            // btSuppPlat
            // 
            this.btSuppPlat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSuppPlat.Location = new System.Drawing.Point(609, 282);
            this.btSuppPlat.Name = "btSuppPlat";
            this.btSuppPlat.Size = new System.Drawing.Size(75, 52);
            this.btSuppPlat.TabIndex = 8;
            this.btSuppPlat.Text = "Supprimer le plat";
            this.btSuppPlat.UseVisualStyleBackColor = true;
            this.btSuppPlat.Click += new System.EventHandler(this.btSuppPlat_Click);
            // 
            // btAjouterPlat
            // 
            this.btAjouterPlat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btAjouterPlat.Location = new System.Drawing.Point(12, 361);
            this.btAjouterPlat.Name = "btAjouterPlat";
            this.btAjouterPlat.Size = new System.Drawing.Size(75, 52);
            this.btAjouterPlat.TabIndex = 8;
            this.btAjouterPlat.Text = "Ajouter le plat ";
            this.btAjouterPlat.UseVisualStyleBackColor = true;
            this.btAjouterPlat.Click += new System.EventHandler(this.btAjouterPlat_Click);
            // 
            // btValiderModif
            // 
            this.btValiderModif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btValiderModif.Location = new System.Drawing.Point(109, 361);
            this.btValiderModif.Name = "btValiderModif";
            this.btValiderModif.Size = new System.Drawing.Size(74, 52);
            this.btValiderModif.TabIndex = 8;
            this.btValiderModif.Text = "Modifier le plat ";
            this.btValiderModif.UseVisualStyleBackColor = true;
            this.btValiderModif.Click += new System.EventHandler(this.btValiderModif_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom : ";
            // 
            // tbNom
            // 
            this.tbNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbNom.Location = new System.Drawing.Point(68, 178);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 23);
            this.tbNom.TabIndex = 9;
            // 
            // tbPrix
            // 
            this.tbPrix.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPrix.Location = new System.Drawing.Point(68, 240);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(100, 23);
            this.tbPrix.TabIndex = 9;
            // 
            // tbCal
            // 
            this.tbCal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCal.Location = new System.Drawing.Point(68, 270);
            this.tbCal.Name = "tbCal";
            this.tbCal.Size = new System.Drawing.Size(100, 23);
            this.tbCal.TabIndex = 9;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(12, 12);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 10;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbConnexion
            // 
            this.lbConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbConnexion.AutoSize = true;
            this.lbConnexion.Location = new System.Drawing.Point(409, 32);
            this.lbConnexion.Name = "lbConnexion";
            this.lbConnexion.Size = new System.Drawing.Size(109, 15);
            this.lbConnexion.TabIndex = 11;
            this.lbConnexion.Text = "Connection fermée";
            // 
            // btValidModif
            // 
            this.btValidModif.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btValidModif.Location = new System.Drawing.Point(610, 340);
            this.btValidModif.Name = "btValidModif";
            this.btValidModif.Size = new System.Drawing.Size(159, 52);
            this.btValidModif.TabIndex = 12;
            this.btValidModif.Text = "Valider les modifications";
            this.btValidModif.UseVisualStyleBackColor = true;
            this.btValidModif.Click += new System.EventHandler(this.btValidModif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btValidModif);
            this.Controls.Add(this.lbConnexion);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.tbCal);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btValiderModif);
            this.Controls.Add(this.btAjouterPlat);
            this.Controls.Add(this.btSuppPlat);
            this.Controls.Add(this.btPrixMoyen);
            this.Controls.Add(this.btNbrPlats);
            this.Controls.Add(this.btPlatPlusCal);
            this.Controls.Add(this.btPlatMoinsCher);
            this.Controls.Add(this.btAffichPlatCat);
            this.Controls.Add(this.cbGlutenFree);
            this.Controls.Add(this.cbVegan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.cbCategoriePlat);
            this.Controls.Add(this.btAfficherAllPlats);
            this.Controls.Add(this.lbPlats);
            this.Controls.Add(this.btDeconnexion);
            this.Controls.Add(this.btConnexion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.Button btDeconnexion;
        private System.Windows.Forms.ListBox lbPlats;
        private System.Windows.Forms.Button btAfficherAllPlats;
        private System.Windows.Forms.ComboBox cbCategoriePlat;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbVegan;
        private System.Windows.Forms.CheckBox cbGlutenFree;
        private System.Windows.Forms.Button btAffichPlatCat;
        private System.Windows.Forms.Button btPlatMoinsCher;
        private System.Windows.Forms.Button btPlatPlusCal;
        private System.Windows.Forms.Button btNbrPlats;
        private System.Windows.Forms.Button btPrixMoyen;
        private System.Windows.Forms.Button btSuppPlat;
        private System.Windows.Forms.Button btAjouterPlat;
        private System.Windows.Forms.Button btValiderModif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.TextBox tbCal;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lbConnexion;
        private System.Windows.Forms.Button btValidModif;
    }
}

