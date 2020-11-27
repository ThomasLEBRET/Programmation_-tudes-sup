
namespace YGO_Designer
{
    partial class FormHomeJoueur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeJoueur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbDeck = new System.Windows.Forms.ListBox();
            this.lbAllDecks = new System.Windows.Forms.ListBox();
            this.gbCreerDeck = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNoDeck = new System.Windows.Forms.TextBox();
            this.tbNomDeck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbNomDeck = new System.Windows.Forms.Label();
            this.lbViable = new System.Windows.Forms.Label();
            this.btViderDeck = new System.Windows.Forms.Button();
            this.gbDecks = new System.Windows.Forms.GroupBox();
            this.gbCartesDeck = new System.Windows.Forms.GroupBox();
            this.btSupprCarte = new System.Windows.Forms.Button();
            this.btSuppExemplaire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCreerDeck.SuspendLayout();
            this.gbDecks.SuspendLayout();
            this.gbCartesDeck.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbDeck
            // 
            this.lbDeck.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeck.FormattingEnabled = true;
            this.lbDeck.ItemHeight = 19;
            this.lbDeck.Location = new System.Drawing.Point(7, 52);
            this.lbDeck.Name = "lbDeck";
            this.lbDeck.Size = new System.Drawing.Size(533, 175);
            this.lbDeck.TabIndex = 3;
            // 
            // lbAllDecks
            // 
            this.lbAllDecks.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllDecks.FormattingEnabled = true;
            this.lbAllDecks.ItemHeight = 23;
            this.lbAllDecks.Location = new System.Drawing.Point(28, 30);
            this.lbAllDecks.Name = "lbAllDecks";
            this.lbAllDecks.Size = new System.Drawing.Size(421, 119);
            this.lbAllDecks.TabIndex = 4;
            this.lbAllDecks.SelectedIndexChanged += new System.EventHandler(this.lbAllDecks_SelectedIndexChanged);
            // 
            // gbCreerDeck
            // 
            this.gbCreerDeck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCreerDeck.Controls.Add(this.button1);
            this.gbCreerDeck.Controls.Add(this.tbNoDeck);
            this.gbCreerDeck.Controls.Add(this.tbNomDeck);
            this.gbCreerDeck.Controls.Add(this.label2);
            this.gbCreerDeck.Controls.Add(this.lbNom);
            this.gbCreerDeck.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCreerDeck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCreerDeck.Location = new System.Drawing.Point(592, 259);
            this.gbCreerDeck.Name = "gbCreerDeck";
            this.gbCreerDeck.Size = new System.Drawing.Size(395, 289);
            this.gbCreerDeck.TabIndex = 5;
            this.gbCreerDeck.TabStop = false;
            this.gbCreerDeck.Text = "Créez votre deck";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Location = new System.Drawing.Point(101, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Créer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbNoDeck
            // 
            this.tbNoDeck.Location = new System.Drawing.Point(145, 95);
            this.tbNoDeck.Name = "tbNoDeck";
            this.tbNoDeck.Size = new System.Drawing.Size(194, 31);
            this.tbNoDeck.TabIndex = 4;
            // 
            // tbNomDeck
            // 
            this.tbNomDeck.Location = new System.Drawing.Point(145, 52);
            this.tbNomDeck.Name = "tbNomDeck";
            this.tbNomDeck.Size = new System.Drawing.Size(194, 31);
            this.tbNomDeck.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(38, 55);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(54, 23);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom ";
            // 
            // lbNomDeck
            // 
            this.lbNomDeck.AutoSize = true;
            this.lbNomDeck.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomDeck.Location = new System.Drawing.Point(13, 23);
            this.lbNomDeck.Name = "lbNomDeck";
            this.lbNomDeck.Size = new System.Drawing.Size(54, 23);
            this.lbNomDeck.TabIndex = 7;
            this.lbNomDeck.Text = "Nom ";
            // 
            // lbViable
            // 
            this.lbViable.AutoSize = true;
            this.lbViable.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViable.Location = new System.Drawing.Point(356, 23);
            this.lbViable.Name = "lbViable";
            this.lbViable.Size = new System.Drawing.Size(65, 23);
            this.lbViable.TabIndex = 8;
            this.lbViable.Text = "Viable ";
            // 
            // btViderDeck
            // 
            this.btViderDeck.BackColor = System.Drawing.Color.Black;
            this.btViderDeck.FlatAppearance.BorderSize = 0;
            this.btViderDeck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btViderDeck.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViderDeck.ForeColor = System.Drawing.SystemColors.Control;
            this.btViderDeck.Location = new System.Drawing.Point(315, 240);
            this.btViderDeck.Name = "btViderDeck";
            this.btViderDeck.Size = new System.Drawing.Size(225, 49);
            this.btViderDeck.TabIndex = 9;
            this.btViderDeck.Text = "Vider le deck";
            this.btViderDeck.UseVisualStyleBackColor = false;
            this.btViderDeck.Click += new System.EventHandler(this.btViderDeck_Click);
            // 
            // gbDecks
            // 
            this.gbDecks.Controls.Add(this.lbAllDecks);
            this.gbDecks.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDecks.ForeColor = System.Drawing.SystemColors.Control;
            this.gbDecks.Location = new System.Drawing.Point(485, 12);
            this.gbDecks.Name = "gbDecks";
            this.gbDecks.Size = new System.Drawing.Size(502, 172);
            this.gbDecks.TabIndex = 10;
            this.gbDecks.TabStop = false;
            this.gbDecks.Text = "Decks";
            // 
            // gbCartesDeck
            // 
            this.gbCartesDeck.Controls.Add(this.btSuppExemplaire);
            this.gbCartesDeck.Controls.Add(this.btSupprCarte);
            this.gbCartesDeck.Controls.Add(this.lbDeck);
            this.gbCartesDeck.Controls.Add(this.btViderDeck);
            this.gbCartesDeck.Controls.Add(this.lbNomDeck);
            this.gbCartesDeck.Controls.Add(this.lbViable);
            this.gbCartesDeck.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCartesDeck.ForeColor = System.Drawing.SystemColors.Control;
            this.gbCartesDeck.Location = new System.Drawing.Point(12, 236);
            this.gbCartesDeck.Name = "gbCartesDeck";
            this.gbCartesDeck.Padding = new System.Windows.Forms.Padding(10);
            this.gbCartesDeck.Size = new System.Drawing.Size(546, 351);
            this.gbCartesDeck.TabIndex = 11;
            this.gbCartesDeck.TabStop = false;
            this.gbCartesDeck.Text = "Cartes";
            // 
            // btSupprCarte
            // 
            this.btSupprCarte.BackColor = System.Drawing.Color.Red;
            this.btSupprCarte.FlatAppearance.BorderSize = 0;
            this.btSupprCarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprCarte.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprCarte.ForeColor = System.Drawing.SystemColors.Control;
            this.btSupprCarte.Location = new System.Drawing.Point(7, 240);
            this.btSupprCarte.Name = "btSupprCarte";
            this.btSupprCarte.Size = new System.Drawing.Size(225, 49);
            this.btSupprCarte.TabIndex = 10;
            this.btSupprCarte.Text = "Supprimer la carte du deck";
            this.btSupprCarte.UseVisualStyleBackColor = false;
            this.btSupprCarte.Click += new System.EventHandler(this.btSupprCarte_Click);
            // 
            // btSuppExemplaire
            // 
            this.btSuppExemplaire.BackColor = System.Drawing.Color.IndianRed;
            this.btSuppExemplaire.FlatAppearance.BorderSize = 0;
            this.btSuppExemplaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuppExemplaire.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuppExemplaire.ForeColor = System.Drawing.SystemColors.Control;
            this.btSuppExemplaire.Location = new System.Drawing.Point(7, 295);
            this.btSuppExemplaire.Name = "btSuppExemplaire";
            this.btSuppExemplaire.Size = new System.Drawing.Size(225, 49);
            this.btSuppExemplaire.TabIndex = 11;
            this.btSuppExemplaire.Text = "Enlever un exemplaire de la carte";
            this.btSuppExemplaire.UseVisualStyleBackColor = false;
            this.btSuppExemplaire.Click += new System.EventHandler(this.btSuppExemplaire_Click);
            // 
            // FormHomeJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gbCartesDeck);
            this.Controls.Add(this.gbDecks);
            this.Controls.Add(this.gbCreerDeck);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeJoueur";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGO Designer - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.VisibleChanged += new System.EventHandler(this.FormHomeJoueur_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCreerDeck.ResumeLayout(false);
            this.gbCreerDeck.PerformLayout();
            this.gbDecks.ResumeLayout(false);
            this.gbCartesDeck.ResumeLayout(false);
            this.gbCartesDeck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbDeck;
        private System.Windows.Forms.ListBox lbAllDecks;
        private System.Windows.Forms.GroupBox gbCreerDeck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNoDeck;
        private System.Windows.Forms.TextBox tbNomDeck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbNomDeck;
        private System.Windows.Forms.Label lbViable;
        private System.Windows.Forms.Button btViderDeck;
        private System.Windows.Forms.GroupBox gbDecks;
        private System.Windows.Forms.GroupBox gbCartesDeck;
        private System.Windows.Forms.Button btSupprCarte;
        private System.Windows.Forms.Button btSuppExemplaire;
    }
}

