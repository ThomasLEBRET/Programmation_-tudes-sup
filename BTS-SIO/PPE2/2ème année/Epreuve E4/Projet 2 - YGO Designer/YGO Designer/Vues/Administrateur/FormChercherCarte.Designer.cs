
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
            this.btChercheParNom = new System.Windows.Forms.Button();
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
            this.paCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttr)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 8;
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
            this.tbNoCarte.TabIndex = 9;
            // 
            // tbNomCarte
            // 
            this.tbNomCarte.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbNomCarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNomCarte.Location = new System.Drawing.Point(760, 25);
            this.tbNomCarte.MaxLength = 8;
            this.tbNomCarte.Name = "tbNomCarte";
            this.tbNomCarte.PlaceholderText = "12345678";
            this.tbNomCarte.Size = new System.Drawing.Size(212, 23);
            this.tbNomCarte.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 27);
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
            this.btChercherParNum.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChercherParNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChercherParNum.Location = new System.Drawing.Point(38, 85);
            this.btChercherParNum.Name = "btChercherParNum";
            this.btChercherParNum.Size = new System.Drawing.Size(238, 45);
            this.btChercherParNum.TabIndex = 12;
            this.btChercherParNum.Text = "Chercher par numéro";
            this.btChercherParNum.UseVisualStyleBackColor = false;
            this.btChercherParNum.Click += new System.EventHandler(this.btChercherParNum_Click);
            // 
            // btChercheParNom
            // 
            this.btChercheParNom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChercheParNom.BackColor = System.Drawing.Color.Black;
            this.btChercheParNom.FlatAppearance.BorderSize = 0;
            this.btChercheParNom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btChercheParNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btChercheParNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChercheParNom.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChercheParNom.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChercheParNom.Location = new System.Drawing.Point(681, 85);
            this.btChercheParNom.Name = "btChercheParNom";
            this.btChercheParNom.Size = new System.Drawing.Size(238, 45);
            this.btChercheParNom.TabIndex = 13;
            this.btChercheParNom.Text = "Chercher par nom partiel";
            this.btChercheParNom.UseVisualStyleBackColor = false;
            this.btChercheParNom.Click += new System.EventHandler(this.btChercheParNom_Click);
            // 
            // lbCartes
            // 
            this.lbCartes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCartes.FormattingEnabled = true;
            this.lbCartes.ItemHeight = 15;
            this.lbCartes.Location = new System.Drawing.Point(38, 179);
            this.lbCartes.Name = "lbCartes";
            this.lbCartes.Size = new System.Drawing.Size(457, 349);
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
            this.paCarte.Location = new System.Drawing.Point(630, 179);
            this.paCarte.Name = "paCarte";
            this.paCarte.Size = new System.Drawing.Size(308, 349);
            this.paCarte.TabIndex = 15;
            // 
            // pbTypeMP
            // 
            this.pbTypeMP.BackColor = System.Drawing.Color.Transparent;
            this.pbTypeMP.Location = new System.Drawing.Point(266, 120);
            this.pbTypeMP.Name = "pbTypeMP";
            this.pbTypeMP.Size = new System.Drawing.Size(30, 28);
            this.pbTypeMP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTypeMP.TabIndex = 20;
            this.pbTypeMP.TabStop = false;
            // 
            // lbMaPi
            // 
            this.lbMaPi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaPi.AutoSize = true;
            this.lbMaPi.BackColor = System.Drawing.Color.Transparent;
            this.lbMaPi.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaPi.ForeColor = System.Drawing.Color.Black;
            this.lbMaPi.Location = new System.Drawing.Point(108, 117);
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
            this.lbDef.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDef.ForeColor = System.Drawing.Color.Black;
            this.lbDef.Location = new System.Drawing.Point(195, 316);
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
            this.lbAtk.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAtk.ForeColor = System.Drawing.Color.Black;
            this.lbAtk.Location = new System.Drawing.Point(19, 316);
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
            this.lbNv.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNv.ForeColor = System.Drawing.Color.Black;
            this.lbNv.Location = new System.Drawing.Point(201, 11);
            this.lbNv.Name = "lbNv";
            this.lbNv.Size = new System.Drawing.Size(16, 23);
            this.lbNv.TabIndex = 16;
            this.lbNv.Text = "1";
            // 
            // pbNv
            // 
            this.pbNv.BackColor = System.Drawing.Color.Transparent;
            this.pbNv.Image = ((System.Drawing.Image)(resources.GetObject("pbNv.Image")));
            this.pbNv.Location = new System.Drawing.Point(224, 15);
            this.pbNv.Name = "pbNv";
            this.pbNv.Size = new System.Drawing.Size(21, 19);
            this.pbNv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbNv.TabIndex = 3;
            this.pbNv.TabStop = false;
            // 
            // pbAttr
            // 
            this.pbAttr.BackColor = System.Drawing.Color.Transparent;
            this.pbAttr.Location = new System.Drawing.Point(266, 0);
            this.pbAttr.Name = "pbAttr";
            this.pbAttr.Size = new System.Drawing.Size(42, 43);
            this.pbAttr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAttr.TabIndex = 2;
            this.pbAttr.TabStop = false;
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbDescription.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbDescription.Location = new System.Drawing.Point(19, 151);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(270, 162);
            this.rtbDescription.TabIndex = 1;
            this.rtbDescription.Text = "";
            // 
            // rtbNom
            // 
            this.rtbNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbNom.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbNom.Location = new System.Drawing.Point(19, 49);
            this.rtbNom.Name = "rtbNom";
            this.rtbNom.ReadOnly = true;
            this.rtbNom.Size = new System.Drawing.Size(270, 65);
            this.rtbNom.TabIndex = 0;
            this.rtbNom.Text = "";
            // 
            // ilAttrib
            // 
            this.ilAttrib.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilAttrib.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAttrib.ImageStream")));
            this.ilAttrib.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAttrib.Images.SetKeyName(0, "divin.png");
            this.ilAttrib.Images.SetKeyName(1, "vent.png");
            this.ilAttrib.Images.SetKeyName(2, "feu.png");
            this.ilAttrib.Images.SetKeyName(3, "eau.png");
            this.ilAttrib.Images.SetKeyName(4, "terre.png");
            this.ilAttrib.Images.SetKeyName(5, "lumiere.png");
            this.ilAttrib.Images.SetKeyName(6, "tenebre.png");
            this.ilAttrib.Images.SetKeyName(7, "Continue.png");
            this.ilAttrib.Images.SetKeyName(8, "Equipement.png");
            this.ilAttrib.Images.SetKeyName(9, "magie.png");
            this.ilAttrib.Images.SetKeyName(10, "piege.png");
            this.ilAttrib.Images.SetKeyName(11, "Rituel.png");
            this.ilAttrib.Images.SetKeyName(12, "Terrain.png");
            // 
            // FormChercherCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.paCarte);
            this.Controls.Add(this.lbCartes);
            this.Controls.Add(this.btChercheParNom);
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
            this.paCarte.ResumeLayout(false);
            this.paCarte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTypeMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAttr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNoCarte;
        private System.Windows.Forms.TextBox tbNomCarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChercherParNum;
        private System.Windows.Forms.Button btChercheParNom;
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
    }
}

