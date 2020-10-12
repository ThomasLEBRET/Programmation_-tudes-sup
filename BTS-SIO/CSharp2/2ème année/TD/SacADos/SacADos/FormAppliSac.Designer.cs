namespace SacADos
{
    partial class FormAppliSac
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
            this.lbArmoire = new System.Windows.Forms.ListBox();
            this.lbSacADos = new System.Windows.Forms.ListBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAjouterArticle = new System.Windows.Forms.Button();
            this.tbPoids = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUtilite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPoidsMax = new System.Windows.Forms.Label();
            this.lbPoidsActuel = new System.Windows.Forms.Label();
            this.btViderSac = new System.Windows.Forms.Button();
            this.btVersSacADos = new System.Windows.Forms.Button();
            this.btVersArmoire = new System.Windows.Forms.Button();
            this.btSupprimerArticle = new System.Windows.Forms.Button();
            this.tbPoidsMaxSacADos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btModifierPoidsMax = new System.Windows.Forms.Button();
            this.btRempliAutoSac = new System.Windows.Forms.Button();
            this.tbUtilPoids = new System.Windows.Forms.TextBox();
            this.tbUtilUtilite = new System.Windows.Forms.TextBox();
            this.btModifPoids = new System.Windows.Forms.Button();
            this.btModifUtilite = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btTriArmoire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btQuitter.Location = new System.Drawing.Point(12, 327);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbArmoire
            // 
            this.lbArmoire.FormattingEnabled = true;
            this.lbArmoire.HorizontalScrollbar = true;
            this.lbArmoire.Location = new System.Drawing.Point(12, 144);
            this.lbArmoire.Name = "lbArmoire";
            this.lbArmoire.Size = new System.Drawing.Size(300, 147);
            this.lbArmoire.TabIndex = 1;
            // 
            // lbSacADos
            // 
            this.lbSacADos.FormattingEnabled = true;
            this.lbSacADos.HorizontalScrollbar = true;
            this.lbSacADos.Location = new System.Drawing.Point(588, 144);
            this.lbSacADos.Name = "lbSacADos";
            this.lbSacADos.Size = new System.Drawing.Size(300, 147);
            this.lbSacADos.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(80, 24);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(151, 20);
            this.tbNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // btAjouterArticle
            // 
            this.btAjouterArticle.Location = new System.Drawing.Point(34, 115);
            this.btAjouterArticle.Name = "btAjouterArticle";
            this.btAjouterArticle.Size = new System.Drawing.Size(75, 23);
            this.btAjouterArticle.TabIndex = 5;
            this.btAjouterArticle.Text = "Ajouter";
            this.btAjouterArticle.UseVisualStyleBackColor = true;
            this.btAjouterArticle.Click += new System.EventHandler(this.btAjouterArticle_Click);
            // 
            // tbPoids
            // 
            this.tbPoids.Location = new System.Drawing.Point(80, 54);
            this.tbPoids.Name = "tbPoids";
            this.tbPoids.Size = new System.Drawing.Size(85, 20);
            this.tbPoids.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Poids";
            // 
            // tbUtilite
            // 
            this.tbUtilite.Location = new System.Drawing.Point(124, 89);
            this.tbUtilite.Name = "tbUtilite";
            this.tbUtilite.Size = new System.Drawing.Size(85, 20);
            this.tbUtilite.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Utilité (de 1 à 20)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            // 
            // lbPoidsMax
            // 
            this.lbPoidsMax.AutoSize = true;
            this.lbPoidsMax.Location = new System.Drawing.Point(577, 96);
            this.lbPoidsMax.Name = "lbPoidsMax";
            this.lbPoidsMax.Size = new System.Drawing.Size(106, 13);
            this.lbPoidsMax.TabIndex = 13;
            this.lbPoidsMax.Text = "Poids Sac à dos max";
            // 
            // lbPoidsActuel
            // 
            this.lbPoidsActuel.AutoSize = true;
            this.lbPoidsActuel.Location = new System.Drawing.Point(577, 125);
            this.lbPoidsActuel.Name = "lbPoidsActuel";
            this.lbPoidsActuel.Size = new System.Drawing.Size(116, 13);
            this.lbPoidsActuel.TabIndex = 14;
            this.lbPoidsActuel.Text = "Poids Sac à dos actuel";
            // 
            // btViderSac
            // 
            this.btViderSac.Location = new System.Drawing.Point(783, 297);
            this.btViderSac.Name = "btViderSac";
            this.btViderSac.Size = new System.Drawing.Size(105, 40);
            this.btViderSac.TabIndex = 15;
            this.btViderSac.Text = "Vider le sac à dos";
            this.btViderSac.UseVisualStyleBackColor = true;
            this.btViderSac.Click += new System.EventHandler(this.btViderSac_Click);
            // 
            // btVersSacADos
            // 
            this.btVersSacADos.Location = new System.Drawing.Point(207, 297);
            this.btVersSacADos.Name = "btVersSacADos";
            this.btVersSacADos.Size = new System.Drawing.Size(105, 40);
            this.btVersSacADos.TabIndex = 16;
            this.btVersSacADos.Text = "Transfert vers sac à dos";
            this.btVersSacADos.UseVisualStyleBackColor = true;
            this.btVersSacADos.Click += new System.EventHandler(this.btVersSacADos_Click);
            // 
            // btVersArmoire
            // 
            this.btVersArmoire.Location = new System.Drawing.Point(588, 297);
            this.btVersArmoire.Name = "btVersArmoire";
            this.btVersArmoire.Size = new System.Drawing.Size(105, 40);
            this.btVersArmoire.TabIndex = 17;
            this.btVersArmoire.Text = "Transfère vers armoire";
            this.btVersArmoire.UseVisualStyleBackColor = true;
            this.btVersArmoire.Click += new System.EventHandler(this.btVersArmoire_Click);
            // 
            // btSupprimerArticle
            // 
            this.btSupprimerArticle.Location = new System.Drawing.Point(12, 297);
            this.btSupprimerArticle.Name = "btSupprimerArticle";
            this.btSupprimerArticle.Size = new System.Drawing.Size(123, 23);
            this.btSupprimerArticle.TabIndex = 18;
            this.btSupprimerArticle.Text = "Supprimer l\'article";
            this.btSupprimerArticle.UseVisualStyleBackColor = true;
            this.btSupprimerArticle.Click += new System.EventHandler(this.btSupprimerArticle_Click);
            // 
            // tbPoidsMaxSacADos
            // 
            this.tbPoidsMaxSacADos.Location = new System.Drawing.Point(788, 54);
            this.tbPoidsMaxSacADos.Name = "tbPoidsMaxSacADos";
            this.tbPoidsMaxSacADos.Size = new System.Drawing.Size(100, 20);
            this.tbPoidsMaxSacADos.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Modifier le poids max du sac à dos";
            // 
            // btModifierPoidsMax
            // 
            this.btModifierPoidsMax.Location = new System.Drawing.Point(813, 82);
            this.btModifierPoidsMax.Name = "btModifierPoidsMax";
            this.btModifierPoidsMax.Size = new System.Drawing.Size(75, 23);
            this.btModifierPoidsMax.TabIndex = 21;
            this.btModifierPoidsMax.Text = "Actualiser";
            this.btModifierPoidsMax.UseVisualStyleBackColor = true;
            this.btModifierPoidsMax.Click += new System.EventHandler(this.btModifierPoidsMax_Click);
            // 
            // btRempliAutoSac
            // 
            this.btRempliAutoSac.Location = new System.Drawing.Point(462, 144);
            this.btRempliAutoSac.Name = "btRempliAutoSac";
            this.btRempliAutoSac.Size = new System.Drawing.Size(120, 53);
            this.btRempliAutoSac.TabIndex = 22;
            this.btRempliAutoSac.Text = "Remplir automatiquement le sac à dos ";
            this.btRempliAutoSac.UseVisualStyleBackColor = true;
            this.btRempliAutoSac.Click += new System.EventHandler(this.btRempliAutoSac_Click);
            // 
            // tbUtilPoids
            // 
            this.tbUtilPoids.Location = new System.Drawing.Point(395, 218);
            this.tbUtilPoids.Name = "tbUtilPoids";
            this.tbUtilPoids.Size = new System.Drawing.Size(50, 20);
            this.tbUtilPoids.TabIndex = 23;
            // 
            // tbUtilUtilite
            // 
            this.tbUtilUtilite.Location = new System.Drawing.Point(395, 262);
            this.tbUtilUtilite.Name = "tbUtilUtilite";
            this.tbUtilUtilite.Size = new System.Drawing.Size(50, 20);
            this.tbUtilUtilite.TabIndex = 24;
            // 
            // btModifPoids
            // 
            this.btModifPoids.Location = new System.Drawing.Point(451, 216);
            this.btModifPoids.Name = "btModifPoids";
            this.btModifPoids.Size = new System.Drawing.Size(75, 23);
            this.btModifPoids.TabIndex = 25;
            this.btModifPoids.Text = "Actualiser";
            this.btModifPoids.UseVisualStyleBackColor = true;
            this.btModifPoids.Click += new System.EventHandler(this.btModifPoids_Click);
            // 
            // btModifUtilite
            // 
            this.btModifUtilite.Location = new System.Drawing.Point(451, 260);
            this.btModifUtilite.Name = "btModifUtilite";
            this.btModifUtilite.Size = new System.Drawing.Size(75, 23);
            this.btModifUtilite.TabIndex = 26;
            this.btModifUtilite.Text = "Actualiser";
            this.btModifUtilite.UseVisualStyleBackColor = true;
            this.btModifUtilite.Click += new System.EventHandler(this.btModifUtilite_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Modifier poids";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Modifier utilite";
            // 
            // btTriArmoire
            // 
            this.btTriArmoire.Location = new System.Drawing.Point(350, 327);
            this.btTriArmoire.Name = "btTriArmoire";
            this.btTriArmoire.Size = new System.Drawing.Size(57, 30);
            this.btTriArmoire.TabIndex = 29;
            this.btTriArmoire.Text = "Trier ";
            this.btTriArmoire.UseVisualStyleBackColor = true;
            this.btTriArmoire.Click += new System.EventHandler(this.btTriArmoire_Click);
            // 
            // FormAppliSac
            // 
            this.AcceptButton = this.btAjouterArticle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.btQuitter;
            this.ClientSize = new System.Drawing.Size(900, 362);
            this.Controls.Add(this.btTriArmoire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btModifUtilite);
            this.Controls.Add(this.btModifPoids);
            this.Controls.Add(this.tbUtilUtilite);
            this.Controls.Add(this.tbUtilPoids);
            this.Controls.Add(this.btRempliAutoSac);
            this.Controls.Add(this.btModifierPoidsMax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPoidsMaxSacADos);
            this.Controls.Add(this.btSupprimerArticle);
            this.Controls.Add(this.btVersArmoire);
            this.Controls.Add(this.btVersSacADos);
            this.Controls.Add(this.btViderSac);
            this.Controls.Add(this.lbPoidsActuel);
            this.Controls.Add(this.lbPoidsMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUtilite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPoids);
            this.Controls.Add(this.btAjouterArticle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbSacADos);
            this.Controls.Add(this.lbArmoire);
            this.Controls.Add(this.btQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAppliSac";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAppliSac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.ListBox lbArmoire;
        private System.Windows.Forms.ListBox lbSacADos;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAjouterArticle;
        private System.Windows.Forms.TextBox tbPoids;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUtilite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPoidsMax;
        private System.Windows.Forms.Label lbPoidsActuel;
        private System.Windows.Forms.Button btViderSac;
        private System.Windows.Forms.Button btVersSacADos;
        private System.Windows.Forms.Button btVersArmoire;
        private System.Windows.Forms.Button btSupprimerArticle;
        private System.Windows.Forms.TextBox tbPoidsMaxSacADos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btModifierPoidsMax;
        private System.Windows.Forms.Button btRempliAutoSac;
        private System.Windows.Forms.TextBox tbUtilPoids;
        private System.Windows.Forms.TextBox tbUtilUtilite;
        private System.Windows.Forms.Button btModifPoids;
        private System.Windows.Forms.Button btModifUtilite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btTriArmoire;
    }
}

