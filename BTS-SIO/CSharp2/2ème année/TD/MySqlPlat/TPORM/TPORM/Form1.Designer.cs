namespace TPORM
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.btModifPlat = new System.Windows.Forms.Button();
            this.btAjouterPlat = new System.Windows.Forms.Button();
            this.btValiderModif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btConnexion
            // 
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
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(457, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 211);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 23);
            this.comboBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prix : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calories : ";
            // 
            // cbVegan
            // 
            this.cbVegan.AutoSize = true;
            this.cbVegan.Location = new System.Drawing.Point(0, 315);
            this.cbVegan.Name = "cbVegan";
            this.cbVegan.Size = new System.Drawing.Size(58, 19);
            this.cbVegan.TabIndex = 5;
            this.cbVegan.Text = "Vegan";
            this.cbVegan.UseVisualStyleBackColor = true;
            // 
            // cbGlutenFree
            // 
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
            this.btAffichPlatCat.Location = new System.Drawing.Point(587, 84);
            this.btAffichPlatCat.Name = "btAffichPlatCat";
            this.btAffichPlatCat.Size = new System.Drawing.Size(182, 23);
            this.btAffichPlatCat.TabIndex = 6;
            this.btAffichPlatCat.Text = "Afficher les plats de la catégorie";
            this.btAffichPlatCat.UseVisualStyleBackColor = true;
            // 
            // btPlatMoinsCher
            // 
            this.btPlatMoinsCher.Location = new System.Drawing.Point(609, 133);
            this.btPlatMoinsCher.Name = "btPlatMoinsCher";
            this.btPlatMoinsCher.Size = new System.Drawing.Size(75, 47);
            this.btPlatMoinsCher.TabIndex = 7;
            this.btPlatMoinsCher.Text = "Plat le moins cher ";
            this.btPlatMoinsCher.UseVisualStyleBackColor = true;
            // 
            // btPlatPlusCal
            // 
            this.btPlatPlusCal.Location = new System.Drawing.Point(713, 133);
            this.btPlatPlusCal.Name = "btPlatPlusCal";
            this.btPlatPlusCal.Size = new System.Drawing.Size(75, 47);
            this.btPlatPlusCal.TabIndex = 7;
            this.btPlatPlusCal.Text = "Plat le plus calorique";
            this.btPlatPlusCal.UseVisualStyleBackColor = true;
            // 
            // btNbrPlats
            // 
            this.btNbrPlats.Location = new System.Drawing.Point(609, 214);
            this.btNbrPlats.Name = "btNbrPlats";
            this.btNbrPlats.Size = new System.Drawing.Size(75, 52);
            this.btNbrPlats.TabIndex = 8;
            this.btNbrPlats.Text = "Nombre de plats ";
            this.btNbrPlats.UseVisualStyleBackColor = true;
            // 
            // btPrixMoyen
            // 
            this.btPrixMoyen.Location = new System.Drawing.Point(713, 214);
            this.btPrixMoyen.Name = "btPrixMoyen";
            this.btPrixMoyen.Size = new System.Drawing.Size(75, 52);
            this.btPrixMoyen.TabIndex = 8;
            this.btPrixMoyen.Text = "Prix moyen";
            this.btPrixMoyen.UseVisualStyleBackColor = true;
            // 
            // btSuppPlat
            // 
            this.btSuppPlat.Location = new System.Drawing.Point(609, 282);
            this.btSuppPlat.Name = "btSuppPlat";
            this.btSuppPlat.Size = new System.Drawing.Size(75, 52);
            this.btSuppPlat.TabIndex = 8;
            this.btSuppPlat.Text = "Supprimer le plat";
            this.btSuppPlat.UseVisualStyleBackColor = true;
            // 
            // btModifPlat
            // 
            this.btModifPlat.Location = new System.Drawing.Point(713, 282);
            this.btModifPlat.Name = "btModifPlat";
            this.btModifPlat.Size = new System.Drawing.Size(75, 52);
            this.btModifPlat.TabIndex = 8;
            this.btModifPlat.Text = "Modifier le plat";
            this.btModifPlat.UseVisualStyleBackColor = true;
            // 
            // btAjouterPlat
            // 
            this.btAjouterPlat.Location = new System.Drawing.Point(0, 361);
            this.btAjouterPlat.Name = "btAjouterPlat";
            this.btAjouterPlat.Size = new System.Drawing.Size(75, 52);
            this.btAjouterPlat.TabIndex = 8;
            this.btAjouterPlat.Text = "Ajouter le plat ";
            this.btAjouterPlat.UseVisualStyleBackColor = true;
            // 
            // btValiderModif
            // 
            this.btValiderModif.Location = new System.Drawing.Point(89, 361);
            this.btValiderModif.Name = "btValiderModif";
            this.btValiderModif.Size = new System.Drawing.Size(94, 52);
            this.btValiderModif.TabIndex = 8;
            this.btValiderModif.Text = "Valider les modifications";
            this.btValiderModif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btValiderModif);
            this.Controls.Add(this.btAjouterPlat);
            this.Controls.Add(this.btModifPlat);
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
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btAfficherAllPlats);
            this.Controls.Add(this.lbPlats);
            this.Controls.Add(this.btDeconnexion);
            this.Controls.Add(this.btConnexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.Button btDeconnexion;
        private System.Windows.Forms.ListBox lbPlats;
        private System.Windows.Forms.Button btAfficherAllPlats;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
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
        private System.Windows.Forms.Button btModifPlat;
        private System.Windows.Forms.Button btAjouterPlat;
        private System.Windows.Forms.Button btValiderModif;
        private System.Windows.Forms.Label label4;
    }
}

