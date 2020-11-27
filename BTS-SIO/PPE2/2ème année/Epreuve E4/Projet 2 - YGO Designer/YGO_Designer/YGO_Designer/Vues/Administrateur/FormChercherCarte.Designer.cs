
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChercherCarte));
            this.label7 = new System.Windows.Forms.Label();
            this.tbNoCarte = new System.Windows.Forms.TextBox();
            this.tbNomCarte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btChercherParNum = new System.Windows.Forms.Button();
            this.lbCartes = new System.Windows.Forms.ListBox();
            this.paCarte = new System.Windows.Forms.Panel();
            this.pbTypeMP = new System.Windows.Forms.PictureBox();
            this.lbMaPi = new System.Windows.Forms.Label();
            this.lbDef = new System.Windows.Forms.Label();
            this.lbAtk = new System.Windows.Forms.Label();
            this.lbNv = new System.Windows.Forms.Label();
            this.pbNv = new System.Windows.Forms.PictureBox();
            this.pbAttr = new System.Windows.Forms.PictureBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.rtbNom = new System.Windows.Forms.RichTextBox();
            this.ilAttrib = new System.Windows.Forms.ImageList(this.components);
            this.btDelete = new System.Windows.Forms.Button();
            this.lbDecks = new System.Windows.Forms.ListBox();
            this.gbDecks = new System.Windows.Forms.GroupBox();
            this.gbResultat = new System.Windows.Forms.GroupBox();
            this.bgCarte = new System.Windows.Forms.GroupBox();
            this.paCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttr)).BeginInit();
            this.gbDecks.SuspendLayout();
            this.gbResultat.SuspendLayout();
            this.bgCarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "N°";
            // 
            // tbNoCarte
            // 
            this.tbNoCarte.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbNoCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoCarte.Location = new System.Drawing.Point(56, 23);
            this.tbNoCarte.MaxLength = 8;
            this.tbNoCarte.Name = "tbNoCarte";
            this.tbNoCarte.Size = new System.Drawing.Size(182, 31);
            this.tbNoCarte.TabIndex = 9;
            // 
            // tbNomCarte
            // 
            this.tbNomCarte.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbNomCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomCarte.Location = new System.Drawing.Point(929, 22);
            this.tbNomCarte.MaxLength = 8;
            this.tbNomCarte.Name = "tbNomCarte";
            this.tbNomCarte.Size = new System.Drawing.Size(182, 31);
            this.tbNomCarte.TabIndex = 11;
            this.tbNomCarte.TextChanged += new System.EventHandler(this.tbNomCarte_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(638, 18);
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
            this.btChercherParNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btChercherParNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChercherParNum.Location = new System.Drawing.Point(56, 74);
            this.btChercherParNum.Name = "btChercherParNum";
            this.btChercherParNum.Size = new System.Drawing.Size(181, 60);
            this.btChercherParNum.TabIndex = 12;
            this.btChercherParNum.Text = "Chercher par numéro";
            this.btChercherParNum.UseVisualStyleBackColor = false;
            this.btChercherParNum.Click += new System.EventHandler(this.btChercherParNum_Click);
            // 
            // lbCartes
            // 
            this.lbCartes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCartes.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCartes.FormattingEnabled = true;
            this.lbCartes.ItemHeight = 23;
            this.lbCartes.Location = new System.Drawing.Point(23, 42);
            this.lbCartes.Name = "lbCartes";
            this.lbCartes.Size = new System.Drawing.Size(428, 188);
            this.lbCartes.TabIndex = 14;
            this.lbCartes.SelectedIndexChanged += new System.EventHandler(this.lbCartes_SelectedIndexChanged);
            // 
            // paCarte
            // 
            this.paCarte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.paCarte.BackColor = System.Drawing.Color.DarkGray;
            this.paCarte.Controls.Add(this.pbTypeMP);
            this.paCarte.Controls.Add(this.lbMaPi);
            this.paCarte.Controls.Add(this.lbDef);
            this.paCarte.Controls.Add(this.lbAtk);
            this.paCarte.Controls.Add(this.lbNv);
            this.paCarte.Controls.Add(this.pbNv);
            this.paCarte.Controls.Add(this.pbAttr);
            this.paCarte.Controls.Add(this.rtbDescription);
            this.paCarte.Controls.Add(this.rtbNom);
            this.paCarte.ForeColor = System.Drawing.Color.White;
            this.paCarte.Location = new System.Drawing.Point(15, 27);
            this.paCarte.Name = "paCarte";
            this.paCarte.Size = new System.Drawing.Size(349, 408);
            this.paCarte.TabIndex = 15;
            // 
            // pbTypeMP
            // 
            this.pbTypeMP.BackColor = System.Drawing.Color.Transparent;
            this.pbTypeMP.Location = new System.Drawing.Point(300, 101);
            this.pbTypeMP.Name = "pbTypeMP";
            this.pbTypeMP.Size = new System.Drawing.Size(30, 28);
            this.pbTypeMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTypeMP.TabIndex = 20;
            this.pbTypeMP.TabStop = false;
            // 
            // lbMaPi
            // 
            this.lbMaPi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaPi.AutoSize = true;
            this.lbMaPi.BackColor = System.Drawing.Color.Transparent;
            this.lbMaPi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbMaPi.ForeColor = System.Drawing.Color.Black;
            this.lbMaPi.Location = new System.Drawing.Point(152, 101);
            this.lbMaPi.Name = "lbMaPi";
            this.lbMaPi.Size = new System.Drawing.Size(137, 23);
            this.lbMaPi.TabIndex = 19;
            this.lbMaPi.Text = "[CARTE MAGIE]";
            // 
            // lbDef
            // 
            this.lbDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDef.AutoSize = true;
            this.lbDef.BackColor = System.Drawing.Color.Transparent;
            this.lbDef.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbDef.ForeColor = System.Drawing.Color.Black;
            this.lbDef.Location = new System.Drawing.Point(223, 361);
            this.lbDef.Name = "lbDef";
            this.lbDef.Size = new System.Drawing.Size(50, 23);
            this.lbDef.TabIndex = 18;
            this.lbDef.Text = "DEF/ ";
            // 
            // lbAtk
            // 
            this.lbAtk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAtk.AutoSize = true;
            this.lbAtk.BackColor = System.Drawing.Color.Transparent;
            this.lbAtk.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbAtk.ForeColor = System.Drawing.Color.Black;
            this.lbAtk.Location = new System.Drawing.Point(12, 361);
            this.lbAtk.Name = "lbAtk";
            this.lbAtk.Size = new System.Drawing.Size(52, 23);
            this.lbAtk.TabIndex = 17;
            this.lbAtk.Text = "ATK/ ";
            // 
            // lbNv
            // 
            this.lbNv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNv.AutoSize = true;
            this.lbNv.BackColor = System.Drawing.Color.Transparent;
            this.lbNv.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbNv.ForeColor = System.Drawing.Color.Black;
            this.lbNv.Location = new System.Drawing.Point(273, 10);
            this.lbNv.Name = "lbNv";
            this.lbNv.Size = new System.Drawing.Size(16, 23);
            this.lbNv.TabIndex = 16;
            this.lbNv.Text = "1";
            // 
            // pbNv
            // 
            this.pbNv.BackColor = System.Drawing.Color.Transparent;
            this.pbNv.Image = ((System.Drawing.Image)(resources.GetObject("pbNv.Image")));
            this.pbNv.Location = new System.Drawing.Point(239, 10);
            this.pbNv.Name = "pbNv";
            this.pbNv.Size = new System.Drawing.Size(28, 23);
            this.pbNv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNv.TabIndex = 3;
            this.pbNv.TabStop = false;
            // 
            // pbAttr
            // 
            this.pbAttr.BackColor = System.Drawing.Color.Transparent;
            this.pbAttr.Location = new System.Drawing.Point(306, 3);
            this.pbAttr.Name = "pbAttr";
            this.pbAttr.Size = new System.Drawing.Size(40, 40);
            this.pbAttr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAttr.TabIndex = 2;
            this.pbAttr.TabStop = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbDescription.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.rtbDescription.Location = new System.Drawing.Point(16, 131);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(314, 209);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "";
            // 
            // rtbNom
            // 
            this.rtbNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbNom.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.rtbNom.Location = new System.Drawing.Point(16, 42);
            this.rtbNom.Name = "rtbNom";
            this.rtbNom.ReadOnly = true;
            this.rtbNom.Size = new System.Drawing.Size(314, 56);
            this.rtbNom.TabIndex = 0;
            this.rtbNom.Text = "";
            // 
            // ilAttrib
            // 
            this.ilAttrib.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAttrib.ImageStream")));
            this.ilAttrib.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAttrib.Images.SetKeyName(0, "divin.png");
            this.ilAttrib.Images.SetKeyName(1, "vent.png");
            this.ilAttrib.Images.SetKeyName(2, "feu.png");
            this.ilAttrib.Images.SetKeyName(3, "eau.png");
            this.ilAttrib.Images.SetKeyName(4, "terre.png");
            this.ilAttrib.Images.SetKeyName(5, "lumiere.png");
            this.ilAttrib.Images.SetKeyName(6, "tenebre.png");
            this.ilAttrib.Images.SetKeyName(7, "magie.png");
            this.ilAttrib.Images.SetKeyName(8, "piege.png");
            this.ilAttrib.Images.SetKeyName(9, "Terrain.png");
            this.ilAttrib.Images.SetKeyName(10, "Rituelle.png");
            this.ilAttrib.Images.SetKeyName(11, "Terrain.png");
            this.ilAttrib.Images.SetKeyName(12, "Rapide.png");
            this.ilAttrib.Images.SetKeyName(13, "Equipement.png");
            this.ilAttrib.Images.SetKeyName(14, "Continue.png");
            this.ilAttrib.Images.SetKeyName(15, "Normale.png");
            this.ilAttrib.Images.SetKeyName(16, "Contre_Piege.png");
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.AutoSize = true;
            this.btDelete.BackColor = System.Drawing.Color.Black;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.FlatAppearance.BorderSize = 0;
            this.btDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btDelete.Location = new System.Drawing.Point(818, 103);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(258, 46);
            this.btDelete.TabIndex = 16;
            this.btDelete.Text = "Supprimer/Ajouter";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbDecks
            // 
            this.lbDecks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDecks.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecks.FormattingEnabled = true;
            this.lbDecks.ItemHeight = 23;
            this.lbDecks.Location = new System.Drawing.Point(44, 29);
            this.lbDecks.Name = "lbDecks";
            this.lbDecks.Size = new System.Drawing.Size(392, 119);
            this.lbDecks.TabIndex = 17;
            this.lbDecks.Visible = false;
            this.lbDecks.SelectedIndexChanged += new System.EventHandler(this.lbDecks_SelectedIndexChanged);
            // 
            // gbDecks
            // 
            this.gbDecks.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbDecks.Controls.Add(this.lbDecks);
            this.gbDecks.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDecks.ForeColor = System.Drawing.SystemColors.Control;
            this.gbDecks.Location = new System.Drawing.Point(33, 416);
            this.gbDecks.Name = "gbDecks";
            this.gbDecks.Padding = new System.Windows.Forms.Padding(0);
            this.gbDecks.Size = new System.Drawing.Size(477, 171);
            this.gbDecks.TabIndex = 18;
            this.gbDecks.TabStop = false;
            this.gbDecks.Text = "Sélectionnez le deck ";
            // 
            // gbResultat
            // 
            this.gbResultat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbResultat.Controls.Add(this.lbCartes);
            this.gbResultat.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultat.ForeColor = System.Drawing.SystemColors.Control;
            this.gbResultat.Location = new System.Drawing.Point(33, 158);
            this.gbResultat.Name = "gbResultat";
            this.gbResultat.Padding = new System.Windows.Forms.Padding(0);
            this.gbResultat.Size = new System.Drawing.Size(477, 252);
            this.gbResultat.TabIndex = 19;
            this.gbResultat.TabStop = false;
            this.gbResultat.Text = "Résultats";
            // 
            // bgCarte
            // 
            this.bgCarte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bgCarte.Controls.Add(this.paCarte);
            this.bgCarte.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgCarte.ForeColor = System.Drawing.SystemColors.Control;
            this.bgCarte.Location = new System.Drawing.Point(688, 176);
            this.bgCarte.Name = "bgCarte";
            this.bgCarte.Padding = new System.Windows.Forms.Padding(0);
            this.bgCarte.Size = new System.Drawing.Size(388, 456);
            this.bgCarte.TabIndex = 20;
            this.bgCarte.TabStop = false;
            this.bgCarte.Text = "Carte";
            // 
            // FormChercherCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1121, 712);
            this.Controls.Add(this.bgCarte);
            this.Controls.Add(this.gbResultat);
            this.Controls.Add(this.gbDecks);
            this.Controls.Add(this.btDelete);
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
            this.VisibleChanged += new System.EventHandler(this.FormChercherCarte_VisibleChanged);
            this.paCarte.ResumeLayout(false);
            this.paCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttr)).EndInit();
            this.gbDecks.ResumeLayout(false);
            this.gbResultat.ResumeLayout(false);
            this.bgCarte.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNoCarte;
        private System.Windows.Forms.TextBox tbNomCarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChercherParNum;
        private System.Windows.Forms.ListBox lbCartes;
        private System.Windows.Forms.Panel paCarte;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.RichTextBox rtbNom;
        private System.Windows.Forms.ImageList ilAttrib;
        private System.Windows.Forms.Label lbNv;
        private System.Windows.Forms.PictureBox pbNv;
        private System.Windows.Forms.PictureBox pbAttr;
        private System.Windows.Forms.Label lbDef;
        private System.Windows.Forms.Label lbAtk;
        private System.Windows.Forms.Label lbMaPi;
        private System.Windows.Forms.PictureBox pbTypeMP;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ListBox lbDecks;
        private System.Windows.Forms.GroupBox gbDecks;
        private System.Windows.Forms.GroupBox gbResultat;
        private System.Windows.Forms.GroupBox bgCarte;
    }
}

