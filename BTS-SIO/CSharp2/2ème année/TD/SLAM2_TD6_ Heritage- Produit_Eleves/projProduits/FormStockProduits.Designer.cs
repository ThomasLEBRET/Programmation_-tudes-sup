namespace projProduitsHeritage
{
    partial class FormStockProduits
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
            this.openFileDialogStock = new System.Windows.Forms.OpenFileDialog();
            this.btChargerFichier = new System.Windows.Forms.Button();
            this.btEnregistrerFichier = new System.Windows.Forms.Button();
            this.saveFileDialogStock = new System.Windows.Forms.SaveFileDialog();
            this.listBoxProduits = new System.Windows.Forms.ListBox();
            this.btAfficherProduits = new System.Windows.Forms.Button();
            this.btLivrer = new System.Windows.Forms.Button();
            this.btVendre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.btAfficherProduit = new System.Windows.Forms.Button();
            this.gpbAjoutModif = new System.Windows.Forms.GroupBox();
            this.gpbAjoutInformatique = new System.Windows.Forms.GroupBox();
            this.txtAjoutSE = new System.Windows.Forms.TextBox();
            this.txtAjoutSupport = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbAjoutPlateau = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgeMin = new System.Windows.Forms.TextBox();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.txtNbJoueur = new System.Windows.Forms.TextBox();
            this.rdbAjoutInformatique = new System.Windows.Forms.RadioButton();
            this.rdbAjoutPlateau = new System.Windows.Forms.RadioButton();
            this.txtStockProduit = new System.Windows.Forms.TextBox();
            this.btAjouter = new System.Windows.Forms.Button();
            this.txtPrixProduit = new System.Windows.Forms.TextBox();
            this.txtDesiProduit = new System.Windows.Forms.TextBox();
            this.txtIdProduit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbRecherche = new System.Windows.Forms.GroupBox();
            this.chkRechInformatique = new System.Windows.Forms.CheckBox();
            this.chkRechPlateau = new System.Windows.Forms.CheckBox();
            this.chkRechDesi = new System.Windows.Forms.CheckBox();
            this.grpbRechInformatique = new System.Windows.Forms.GroupBox();
            this.chkRechSupport = new System.Windows.Forms.CheckBox();
            this.chkRechSE = new System.Windows.Forms.CheckBox();
            this.txtRechSE = new System.Windows.Forms.TextBox();
            this.txtRechSupport = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.grpbRechPlateau = new System.Windows.Forms.GroupBox();
            this.chkRechAgneMin = new System.Windows.Forms.CheckBox();
            this.chkRechDuree = new System.Windows.Forms.CheckBox();
            this.chkRechNbJoueur = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRechAgeMin = new System.Windows.Forms.TextBox();
            this.txtRechDuree = new System.Windows.Forms.TextBox();
            this.txtRechNbJoueur = new System.Windows.Forms.TextBox();
            this.txtRechDesi = new System.Windows.Forms.TextBox();
            this.btRechercher = new System.Windows.Forms.Button();
            this.btRazStock = new System.Windows.Forms.Button();
            this.gpbAffichageType = new System.Windows.Forms.GroupBox();
            this.chkbAffInformatique = new System.Windows.Forms.CheckBox();
            this.chkbAffPlateau = new System.Windows.Forms.CheckBox();
            this.gpbAjoutModif.SuspendLayout();
            this.gpbAjoutInformatique.SuspendLayout();
            this.gpbAjoutPlateau.SuspendLayout();
            this.gpbRecherche.SuspendLayout();
            this.grpbRechInformatique.SuspendLayout();
            this.grpbRechPlateau.SuspendLayout();
            this.gpbAffichageType.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogStock
            // 
            this.openFileDialogStock.FileName = "openFileDialog1";
            // 
            // btChargerFichier
            // 
            this.btChargerFichier.Location = new System.Drawing.Point(22, 426);
            this.btChargerFichier.Name = "btChargerFichier";
            this.btChargerFichier.Size = new System.Drawing.Size(154, 23);
            this.btChargerFichier.TabIndex = 0;
            this.btChargerFichier.Text = "Charger le  stock d\'un fichier";
            this.btChargerFichier.UseVisualStyleBackColor = true;
            this.btChargerFichier.Click += new System.EventHandler(this.btChargerFichier_Click);
            // 
            // btEnregistrerFichier
            // 
            this.btEnregistrerFichier.Location = new System.Drawing.Point(192, 426);
            this.btEnregistrerFichier.Name = "btEnregistrerFichier";
            this.btEnregistrerFichier.Size = new System.Drawing.Size(147, 23);
            this.btEnregistrerFichier.TabIndex = 1;
            this.btEnregistrerFichier.Text = "Enregistrer le stock";
            this.btEnregistrerFichier.UseVisualStyleBackColor = true;
            this.btEnregistrerFichier.Click += new System.EventHandler(this.btEnregistrerFichier_Click);
            // 
            // listBoxProduits
            // 
            this.listBoxProduits.FormattingEnabled = true;
            this.listBoxProduits.Location = new System.Drawing.Point(3, 124);
            this.listBoxProduits.Name = "listBoxProduits";
            this.listBoxProduits.Size = new System.Drawing.Size(336, 303);
            this.listBoxProduits.TabIndex = 2;
            // 
            // btAfficherProduits
            // 
            this.btAfficherProduits.Location = new System.Drawing.Point(19, 42);
            this.btAfficherProduits.Name = "btAfficherProduits";
            this.btAfficherProduits.Size = new System.Drawing.Size(145, 26);
            this.btAfficherProduits.TabIndex = 3;
            this.btAfficherProduits.Text = "Afficher tous les produits";
            this.btAfficherProduits.UseVisualStyleBackColor = true;
            this.btAfficherProduits.Click += new System.EventHandler(this.btAfficherProduits_Click);
            // 
            // btLivrer
            // 
            this.btLivrer.Location = new System.Drawing.Point(313, 58);
            this.btLivrer.Name = "btLivrer";
            this.btLivrer.Size = new System.Drawing.Size(75, 23);
            this.btLivrer.TabIndex = 4;
            this.btLivrer.Text = "Livrer : ";
            this.btLivrer.UseVisualStyleBackColor = true;
            this.btLivrer.Click += new System.EventHandler(this.btLivrer_Click);
            // 
            // btVendre
            // 
            this.btVendre.Location = new System.Drawing.Point(666, 58);
            this.btVendre.Name = "btVendre";
            this.btVendre.Size = new System.Drawing.Size(75, 23);
            this.btVendre.TabIndex = 5;
            this.btVendre.Text = ": Vendre  ";
            this.btVendre.UseVisualStyleBackColor = true;
            this.btVendre.Click += new System.EventHandler(this.btVendre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id : ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(441, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(44, 20);
            this.txtId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantité : ";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(582, 60);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(66, 20);
            this.txtQte.TabIndex = 9;
            // 
            // btAfficherProduit
            // 
            this.btAfficherProduit.Location = new System.Drawing.Point(423, 95);
            this.btAfficherProduit.Name = "btAfficherProduit";
            this.btAfficherProduit.Size = new System.Drawing.Size(75, 23);
            this.btAfficherProduit.TabIndex = 10;
            this.btAfficherProduit.Text = "Afficher ";
            this.btAfficherProduit.UseVisualStyleBackColor = true;
            this.btAfficherProduit.Click += new System.EventHandler(this.btAfficher_Click);
            // 
            // gpbAjoutModif
            // 
            this.gpbAjoutModif.Controls.Add(this.gpbAjoutInformatique);
            this.gpbAjoutModif.Controls.Add(this.gpbAjoutPlateau);
            this.gpbAjoutModif.Controls.Add(this.rdbAjoutInformatique);
            this.gpbAjoutModif.Controls.Add(this.rdbAjoutPlateau);
            this.gpbAjoutModif.Controls.Add(this.txtStockProduit);
            this.gpbAjoutModif.Controls.Add(this.btAjouter);
            this.gpbAjoutModif.Controls.Add(this.txtPrixProduit);
            this.gpbAjoutModif.Controls.Add(this.txtDesiProduit);
            this.gpbAjoutModif.Controls.Add(this.txtIdProduit);
            this.gpbAjoutModif.Controls.Add(this.label6);
            this.gpbAjoutModif.Controls.Add(this.label5);
            this.gpbAjoutModif.Controls.Add(this.label4);
            this.gpbAjoutModif.Controls.Add(this.label3);
            this.gpbAjoutModif.Location = new System.Drawing.Point(357, 124);
            this.gpbAjoutModif.Name = "gpbAjoutModif";
            this.gpbAjoutModif.Size = new System.Drawing.Size(392, 300);
            this.gpbAjoutModif.TabIndex = 11;
            this.gpbAjoutModif.TabStop = false;
            this.gpbAjoutModif.Text = "Produit : ";
            // 
            // gpbAjoutInformatique
            // 
            this.gpbAjoutInformatique.Controls.Add(this.txtAjoutSE);
            this.gpbAjoutInformatique.Controls.Add(this.txtAjoutSupport);
            this.gpbAjoutInformatique.Controls.Add(this.label10);
            this.gpbAjoutInformatique.Controls.Add(this.label11);
            this.gpbAjoutInformatique.Enabled = false;
            this.gpbAjoutInformatique.Location = new System.Drawing.Point(207, 157);
            this.gpbAjoutInformatique.Name = "gpbAjoutInformatique";
            this.gpbAjoutInformatique.Size = new System.Drawing.Size(180, 114);
            this.gpbAjoutInformatique.TabIndex = 23;
            this.gpbAjoutInformatique.TabStop = false;
            this.gpbAjoutInformatique.Text = "Jeu Informatique";
            // 
            // txtAjoutSE
            // 
            this.txtAjoutSE.Location = new System.Drawing.Point(74, 26);
            this.txtAjoutSE.Name = "txtAjoutSE";
            this.txtAjoutSE.Size = new System.Drawing.Size(100, 20);
            this.txtAjoutSE.TabIndex = 19;
            // 
            // txtAjoutSupport
            // 
            this.txtAjoutSupport.Location = new System.Drawing.Point(77, 57);
            this.txtAjoutSupport.Name = "txtAjoutSupport";
            this.txtAjoutSupport.Size = new System.Drawing.Size(100, 20);
            this.txtAjoutSupport.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "SE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Support";
            // 
            // gpbAjoutPlateau
            // 
            this.gpbAjoutPlateau.Controls.Add(this.label9);
            this.gpbAjoutPlateau.Controls.Add(this.label8);
            this.gpbAjoutPlateau.Controls.Add(this.label7);
            this.gpbAjoutPlateau.Controls.Add(this.txtAgeMin);
            this.gpbAjoutPlateau.Controls.Add(this.txtDuree);
            this.gpbAjoutPlateau.Controls.Add(this.txtNbJoueur);
            this.gpbAjoutPlateau.Location = new System.Drawing.Point(4, 157);
            this.gpbAjoutPlateau.Name = "gpbAjoutPlateau";
            this.gpbAjoutPlateau.Size = new System.Drawing.Size(197, 114);
            this.gpbAjoutPlateau.TabIndex = 22;
            this.gpbAjoutPlateau.TabStop = false;
            this.gpbAjoutPlateau.Text = "Jeu de Plateau";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "nbJoueurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Durée (mn) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Age minimal :";
            // 
            // txtAgeMin
            // 
            this.txtAgeMin.Location = new System.Drawing.Point(70, 82);
            this.txtAgeMin.Name = "txtAgeMin";
            this.txtAgeMin.Size = new System.Drawing.Size(100, 20);
            this.txtAgeMin.TabIndex = 21;
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(70, 48);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(100, 20);
            this.txtDuree.TabIndex = 20;
            // 
            // txtNbJoueur
            // 
            this.txtNbJoueur.Location = new System.Drawing.Point(70, 16);
            this.txtNbJoueur.Name = "txtNbJoueur";
            this.txtNbJoueur.Size = new System.Drawing.Size(100, 20);
            this.txtNbJoueur.TabIndex = 19;
            // 
            // rdbAjoutInformatique
            // 
            this.rdbAjoutInformatique.AutoSize = true;
            this.rdbAjoutInformatique.Location = new System.Drawing.Point(91, 19);
            this.rdbAjoutInformatique.Name = "rdbAjoutInformatique";
            this.rdbAjoutInformatique.Size = new System.Drawing.Size(83, 17);
            this.rdbAjoutInformatique.TabIndex = 15;
            this.rdbAjoutInformatique.Text = "Informatique";
            this.rdbAjoutInformatique.UseVisualStyleBackColor = true;
            this.rdbAjoutInformatique.CheckedChanged += new System.EventHandler(this.rdbPlateau_CheckedChanged);
            // 
            // rdbAjoutPlateau
            // 
            this.rdbAjoutPlateau.AutoSize = true;
            this.rdbAjoutPlateau.Checked = true;
            this.rdbAjoutPlateau.Location = new System.Drawing.Point(20, 19);
            this.rdbAjoutPlateau.Name = "rdbAjoutPlateau";
            this.rdbAjoutPlateau.Size = new System.Drawing.Size(60, 17);
            this.rdbAjoutPlateau.TabIndex = 14;
            this.rdbAjoutPlateau.TabStop = true;
            this.rdbAjoutPlateau.Text = "plateau";
            this.rdbAjoutPlateau.UseVisualStyleBackColor = true;
            this.rdbAjoutPlateau.CheckedChanged += new System.EventHandler(this.rdbPlateau_CheckedChanged);
            // 
            // txtStockProduit
            // 
            this.txtStockProduit.Location = new System.Drawing.Point(77, 125);
            this.txtStockProduit.Name = "txtStockProduit";
            this.txtStockProduit.Size = new System.Drawing.Size(100, 20);
            this.txtStockProduit.TabIndex = 7;
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(63, 271);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 12;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // txtPrixProduit
            // 
            this.txtPrixProduit.Location = new System.Drawing.Point(77, 102);
            this.txtPrixProduit.Name = "txtPrixProduit";
            this.txtPrixProduit.Size = new System.Drawing.Size(100, 20);
            this.txtPrixProduit.TabIndex = 6;
            // 
            // txtDesiProduit
            // 
            this.txtDesiProduit.Location = new System.Drawing.Point(77, 73);
            this.txtDesiProduit.Name = "txtDesiProduit";
            this.txtDesiProduit.Size = new System.Drawing.Size(100, 20);
            this.txtDesiProduit.TabIndex = 5;
            // 
            // txtIdProduit
            // 
            this.txtIdProduit.Location = new System.Drawing.Point(77, 42);
            this.txtIdProduit.Name = "txtIdProduit";
            this.txtIdProduit.Size = new System.Drawing.Size(100, 20);
            this.txtIdProduit.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prix :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "designation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "id :";
            // 
            // gpbRecherche
            // 
            this.gpbRecherche.Controls.Add(this.chkRechInformatique);
            this.gpbRecherche.Controls.Add(this.chkRechPlateau);
            this.gpbRecherche.Controls.Add(this.chkRechDesi);
            this.gpbRecherche.Controls.Add(this.grpbRechInformatique);
            this.gpbRecherche.Controls.Add(this.grpbRechPlateau);
            this.gpbRecherche.Controls.Add(this.txtRechDesi);
            this.gpbRecherche.Controls.Add(this.btRechercher);
            this.gpbRecherche.Location = new System.Drawing.Point(755, 124);
            this.gpbRecherche.Name = "gpbRecherche";
            this.gpbRecherche.Size = new System.Drawing.Size(323, 303);
            this.gpbRecherche.TabIndex = 12;
            this.gpbRecherche.TabStop = false;
            this.gpbRecherche.Text = "Recherche :";
            // 
            // chkRechInformatique
            // 
            this.chkRechInformatique.AutoSize = true;
            this.chkRechInformatique.Location = new System.Drawing.Point(98, 15);
            this.chkRechInformatique.Name = "chkRechInformatique";
            this.chkRechInformatique.Size = new System.Drawing.Size(84, 17);
            this.chkRechInformatique.TabIndex = 28;
            this.chkRechInformatique.Text = "Informatique";
            this.chkRechInformatique.UseVisualStyleBackColor = true;
            this.chkRechInformatique.CheckedChanged += new System.EventHandler(this.chkRechInformatique_CheckedChanged);
            // 
            // chkRechPlateau
            // 
            this.chkRechPlateau.AutoSize = true;
            this.chkRechPlateau.Checked = true;
            this.chkRechPlateau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRechPlateau.Location = new System.Drawing.Point(6, 15);
            this.chkRechPlateau.Name = "chkRechPlateau";
            this.chkRechPlateau.Size = new System.Drawing.Size(62, 17);
            this.chkRechPlateau.TabIndex = 27;
            this.chkRechPlateau.Text = "Plateau";
            this.chkRechPlateau.UseVisualStyleBackColor = true;
            this.chkRechPlateau.CheckedChanged += new System.EventHandler(this.chkRechPlateau_CheckedChanged);
            // 
            // chkRechDesi
            // 
            this.chkRechDesi.AutoSize = true;
            this.chkRechDesi.Location = new System.Drawing.Point(146, 40);
            this.chkRechDesi.Name = "chkRechDesi";
            this.chkRechDesi.Size = new System.Drawing.Size(82, 17);
            this.chkRechDesi.TabIndex = 26;
            this.chkRechDesi.Text = "Designation";
            this.chkRechDesi.UseVisualStyleBackColor = true;
            // 
            // grpbRechInformatique
            // 
            this.grpbRechInformatique.Controls.Add(this.chkRechSupport);
            this.grpbRechInformatique.Controls.Add(this.chkRechSE);
            this.grpbRechInformatique.Controls.Add(this.txtRechSE);
            this.grpbRechInformatique.Controls.Add(this.txtRechSupport);
            this.grpbRechInformatique.Controls.Add(this.label15);
            this.grpbRechInformatique.Controls.Add(this.label20);
            this.grpbRechInformatique.Enabled = false;
            this.grpbRechInformatique.Location = new System.Drawing.Point(8, 184);
            this.grpbRechInformatique.Name = "grpbRechInformatique";
            this.grpbRechInformatique.Size = new System.Drawing.Size(274, 87);
            this.grpbRechInformatique.TabIndex = 25;
            this.grpbRechInformatique.TabStop = false;
            this.grpbRechInformatique.Text = "Jeu Informatique";
            // 
            // chkRechSupport
            // 
            this.chkRechSupport.AutoSize = true;
            this.chkRechSupport.Location = new System.Drawing.Point(188, 54);
            this.chkRechSupport.Name = "chkRechSupport";
            this.chkRechSupport.Size = new System.Drawing.Size(63, 17);
            this.chkRechSupport.TabIndex = 28;
            this.chkRechSupport.Text = "Support";
            this.chkRechSupport.UseVisualStyleBackColor = true;
            // 
            // chkRechSE
            // 
            this.chkRechSE.AutoSize = true;
            this.chkRechSE.Location = new System.Drawing.Point(188, 19);
            this.chkRechSE.Name = "chkRechSE";
            this.chkRechSE.Size = new System.Drawing.Size(40, 17);
            this.chkRechSE.TabIndex = 27;
            this.chkRechSE.Text = "SE";
            this.chkRechSE.UseVisualStyleBackColor = true;
            // 
            // txtRechSE
            // 
            this.txtRechSE.Location = new System.Drawing.Point(71, 20);
            this.txtRechSE.Name = "txtRechSE";
            this.txtRechSE.Size = new System.Drawing.Size(100, 20);
            this.txtRechSE.TabIndex = 19;
            // 
            // txtRechSupport
            // 
            this.txtRechSupport.Location = new System.Drawing.Point(71, 55);
            this.txtRechSupport.Name = "txtRechSupport";
            this.txtRechSupport.Size = new System.Drawing.Size(100, 20);
            this.txtRechSupport.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "SE";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Support";
            // 
            // grpbRechPlateau
            // 
            this.grpbRechPlateau.Controls.Add(this.chkRechAgneMin);
            this.grpbRechPlateau.Controls.Add(this.chkRechDuree);
            this.grpbRechPlateau.Controls.Add(this.chkRechNbJoueur);
            this.grpbRechPlateau.Controls.Add(this.label16);
            this.grpbRechPlateau.Controls.Add(this.label17);
            this.grpbRechPlateau.Controls.Add(this.label18);
            this.grpbRechPlateau.Controls.Add(this.txtRechAgeMin);
            this.grpbRechPlateau.Controls.Add(this.txtRechDuree);
            this.grpbRechPlateau.Controls.Add(this.txtRechNbJoueur);
            this.grpbRechPlateau.Location = new System.Drawing.Point(8, 64);
            this.grpbRechPlateau.Name = "grpbRechPlateau";
            this.grpbRechPlateau.Size = new System.Drawing.Size(274, 114);
            this.grpbRechPlateau.TabIndex = 24;
            this.grpbRechPlateau.TabStop = false;
            this.grpbRechPlateau.Text = "Jeu de Plateau";
            // 
            // chkRechAgneMin
            // 
            this.chkRechAgneMin.AutoSize = true;
            this.chkRechAgneMin.Location = new System.Drawing.Point(188, 84);
            this.chkRechAgneMin.Name = "chkRechAgneMin";
            this.chkRechAgneMin.Size = new System.Drawing.Size(65, 17);
            this.chkRechAgneMin.TabIndex = 29;
            this.chkRechAgneMin.Text = "Age Min";
            this.chkRechAgneMin.UseVisualStyleBackColor = true;
            // 
            // chkRechDuree
            // 
            this.chkRechDuree.AutoSize = true;
            this.chkRechDuree.Location = new System.Drawing.Point(188, 50);
            this.chkRechDuree.Name = "chkRechDuree";
            this.chkRechDuree.Size = new System.Drawing.Size(55, 17);
            this.chkRechDuree.TabIndex = 28;
            this.chkRechDuree.Text = "Durée";
            this.chkRechDuree.UseVisualStyleBackColor = true;
            // 
            // chkRechNbJoueur
            // 
            this.chkRechNbJoueur.AutoSize = true;
            this.chkRechNbJoueur.Location = new System.Drawing.Point(188, 18);
            this.chkRechNbJoueur.Name = "chkRechNbJoueur";
            this.chkRechNbJoueur.Size = new System.Drawing.Size(75, 17);
            this.chkRechNbJoueur.TabIndex = 27;
            this.chkRechNbJoueur.Text = "Nb Joueur";
            this.chkRechNbJoueur.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "nbJoueurs";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Durée (mn) :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Age minimal :";
            // 
            // txtRechAgeMin
            // 
            this.txtRechAgeMin.Location = new System.Drawing.Point(70, 82);
            this.txtRechAgeMin.Name = "txtRechAgeMin";
            this.txtRechAgeMin.Size = new System.Drawing.Size(100, 20);
            this.txtRechAgeMin.TabIndex = 21;
            // 
            // txtRechDuree
            // 
            this.txtRechDuree.Location = new System.Drawing.Point(70, 48);
            this.txtRechDuree.Name = "txtRechDuree";
            this.txtRechDuree.Size = new System.Drawing.Size(100, 20);
            this.txtRechDuree.TabIndex = 20;
            // 
            // txtRechNbJoueur
            // 
            this.txtRechNbJoueur.Location = new System.Drawing.Point(70, 16);
            this.txtRechNbJoueur.Name = "txtRechNbJoueur";
            this.txtRechNbJoueur.Size = new System.Drawing.Size(100, 20);
            this.txtRechNbJoueur.TabIndex = 19;
            // 
            // txtRechDesi
            // 
            this.txtRechDesi.Location = new System.Drawing.Point(6, 38);
            this.txtRechDesi.Name = "txtRechDesi";
            this.txtRechDesi.Size = new System.Drawing.Size(120, 20);
            this.txtRechDesi.TabIndex = 12;
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(6, 277);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(75, 23);
            this.btRechercher.TabIndex = 0;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // btRazStock
            // 
            this.btRazStock.Location = new System.Drawing.Point(12, 4);
            this.btRazStock.Name = "btRazStock";
            this.btRazStock.Size = new System.Drawing.Size(258, 23);
            this.btRazStock.TabIndex = 13;
            this.btRazStock.Text = "Fermeture magasin - Vente de tous les produits";
            this.btRazStock.UseVisualStyleBackColor = true;
            this.btRazStock.Click += new System.EventHandler(this.btRazStock_Click);
            // 
            // gpbAffichageType
            // 
            this.gpbAffichageType.Controls.Add(this.chkbAffInformatique);
            this.gpbAffichageType.Controls.Add(this.chkbAffPlateau);
            this.gpbAffichageType.Controls.Add(this.btAfficherProduits);
            this.gpbAffichageType.Location = new System.Drawing.Point(24, 33);
            this.gpbAffichageType.Name = "gpbAffichageType";
            this.gpbAffichageType.Size = new System.Drawing.Size(212, 72);
            this.gpbAffichageType.TabIndex = 14;
            this.gpbAffichageType.TabStop = false;
            this.gpbAffichageType.Text = "type Jeu";
            // 
            // chkbAffInformatique
            // 
            this.chkbAffInformatique.AutoSize = true;
            this.chkbAffInformatique.Checked = true;
            this.chkbAffInformatique.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbAffInformatique.Location = new System.Drawing.Point(122, 19);
            this.chkbAffInformatique.Name = "chkbAffInformatique";
            this.chkbAffInformatique.Size = new System.Drawing.Size(84, 17);
            this.chkbAffInformatique.TabIndex = 1;
            this.chkbAffInformatique.Text = "Informatique";
            this.chkbAffInformatique.UseVisualStyleBackColor = true;
            // 
            // chkbAffPlateau
            // 
            this.chkbAffPlateau.AutoSize = true;
            this.chkbAffPlateau.Checked = true;
            this.chkbAffPlateau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbAffPlateau.Location = new System.Drawing.Point(19, 19);
            this.chkbAffPlateau.Name = "chkbAffPlateau";
            this.chkbAffPlateau.Size = new System.Drawing.Size(62, 17);
            this.chkbAffPlateau.TabIndex = 0;
            this.chkbAffPlateau.Text = "Plateau";
            this.chkbAffPlateau.UseVisualStyleBackColor = true;
            // 
            // FormStockProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 461);
            this.Controls.Add(this.gpbAffichageType);
            this.Controls.Add(this.btRazStock);
            this.Controls.Add(this.gpbRecherche);
            this.Controls.Add(this.gpbAjoutModif);
            this.Controls.Add(this.btAfficherProduit);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVendre);
            this.Controls.Add(this.btLivrer);
            this.Controls.Add(this.listBoxProduits);
            this.Controls.Add(this.btEnregistrerFichier);
            this.Controls.Add(this.btChargerFichier);
            this.Name = "FormStockProduits";
            this.Text = "Gestion de stock - héritage";
            this.gpbAjoutModif.ResumeLayout(false);
            this.gpbAjoutModif.PerformLayout();
            this.gpbAjoutInformatique.ResumeLayout(false);
            this.gpbAjoutInformatique.PerformLayout();
            this.gpbAjoutPlateau.ResumeLayout(false);
            this.gpbAjoutPlateau.PerformLayout();
            this.gpbRecherche.ResumeLayout(false);
            this.gpbRecherche.PerformLayout();
            this.grpbRechInformatique.ResumeLayout(false);
            this.grpbRechInformatique.PerformLayout();
            this.grpbRechPlateau.ResumeLayout(false);
            this.grpbRechPlateau.PerformLayout();
            this.gpbAffichageType.ResumeLayout(false);
            this.gpbAffichageType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogStock;
        private System.Windows.Forms.Button btChargerFichier;
        private System.Windows.Forms.Button btEnregistrerFichier;
        private System.Windows.Forms.SaveFileDialog saveFileDialogStock;
        private System.Windows.Forms.ListBox listBoxProduits;
        private System.Windows.Forms.Button btAfficherProduits;
        private System.Windows.Forms.Button btLivrer;
        private System.Windows.Forms.Button btVendre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Button btAfficherProduit;
        private System.Windows.Forms.GroupBox gpbAjoutModif;
        private System.Windows.Forms.TextBox txtStockProduit;
        private System.Windows.Forms.TextBox txtPrixProduit;
        private System.Windows.Forms.TextBox txtDesiProduit;
        private System.Windows.Forms.TextBox txtIdProduit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.GroupBox gpbRecherche;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.TextBox txtRechDesi;
        private System.Windows.Forms.Button btRazStock;
        private System.Windows.Forms.GroupBox gpbAffichageType;
        private System.Windows.Forms.CheckBox chkbAffInformatique;
        private System.Windows.Forms.CheckBox chkbAffPlateau;
        private System.Windows.Forms.RadioButton rdbAjoutInformatique;
        private System.Windows.Forms.RadioButton rdbAjoutPlateau;
        private System.Windows.Forms.TextBox txtAgeMin;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.TextBox txtNbJoueur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbAjoutInformatique;
        private System.Windows.Forms.TextBox txtAjoutSE;
        private System.Windows.Forms.TextBox txtAjoutSupport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbAjoutPlateau;
        private System.Windows.Forms.GroupBox grpbRechInformatique;
        private System.Windows.Forms.TextBox txtRechSE;
        private System.Windows.Forms.TextBox txtRechSupport;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpbRechPlateau;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRechAgeMin;
        private System.Windows.Forms.TextBox txtRechDuree;
        private System.Windows.Forms.TextBox txtRechNbJoueur;
        private System.Windows.Forms.CheckBox chkRechDesi;
        private System.Windows.Forms.CheckBox chkRechSupport;
        private System.Windows.Forms.CheckBox chkRechSE;
        private System.Windows.Forms.CheckBox chkRechAgneMin;
        private System.Windows.Forms.CheckBox chkRechDuree;
        private System.Windows.Forms.CheckBox chkRechNbJoueur;
        private System.Windows.Forms.CheckBox chkRechInformatique;
        private System.Windows.Forms.CheckBox chkRechPlateau;
    }
}

