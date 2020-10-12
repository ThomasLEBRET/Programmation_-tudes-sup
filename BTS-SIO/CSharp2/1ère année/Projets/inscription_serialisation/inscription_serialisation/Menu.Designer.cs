namespace inscription_serialisation
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lbPseudo = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbInfo = new System.Windows.Forms.PictureBox();
            this.pbDevine = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbMemory = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClassement = new System.Windows.Forms.PictureBox();
            this.pbQuitter = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClassement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.Location = new System.Drawing.Point(12, 9);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(204, 57);
            this.lbPseudo.TabIndex = 1;
            this.lbPseudo.Text = "Username";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(507, 9);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(119, 57);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "Score";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pbInfo);
            this.groupBox1.Controls.Add(this.pbDevine);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pbMemory);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activités";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(343, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "Classement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(436, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Info";
            // 
            // pbInfo
            // 
            this.pbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbInfo.Image = global::inscription_serialisation.Properties.Resources.think;
            this.pbInfo.Location = new System.Drawing.Point(525, 29);
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.Size = new System.Drawing.Size(150, 100);
            this.pbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInfo.TabIndex = 7;
            this.pbInfo.TabStop = false;
            this.pbInfo.Click += new System.EventHandler(this.pbInfo_Click);
            // 
            // pbDevine
            // 
            this.pbDevine.BackColor = System.Drawing.Color.White;
            this.pbDevine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDevine.Image = global::inscription_serialisation.Properties.Resources.quiz;
            this.pbDevine.Location = new System.Drawing.Point(156, 150);
            this.pbDevine.Name = "pbDevine";
            this.pbDevine.Size = new System.Drawing.Size(189, 100);
            this.pbDevine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDevine.TabIndex = 6;
            this.pbDevine.TabStop = false;
            this.pbDevine.Click += new System.EventHandler(this.pbDevine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Devine";
            // 
            // pbMemory
            // 
            this.pbMemory.BackColor = System.Drawing.Color.White;
            this.pbMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMemory.Image = global::inscription_serialisation.Properties.Resources.mystere;
            this.pbMemory.Location = new System.Drawing.Point(156, 29);
            this.pbMemory.Name = "pbMemory";
            this.pbMemory.Size = new System.Drawing.Size(100, 100);
            this.pbMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemory.TabIndex = 4;
            this.pbMemory.TabStop = false;
            this.pbMemory.Click += new System.EventHandler(this.pbMemory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Memory";
            // 
            // pbClassement
            // 
            this.pbClassement.BackColor = System.Drawing.Color.Transparent;
            this.pbClassement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClassement.Image = global::inscription_serialisation.Properties.Resources.classement;
            this.pbClassement.Location = new System.Drawing.Point(614, 245);
            this.pbClassement.Name = "pbClassement";
            this.pbClassement.Size = new System.Drawing.Size(158, 92);
            this.pbClassement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClassement.TabIndex = 6;
            this.pbClassement.TabStop = false;
            this.pbClassement.Click += new System.EventHandler(this.pbClassement_Click);
            // 
            // pbQuitter
            // 
            this.pbQuitter.BackColor = System.Drawing.Color.Transparent;
            this.pbQuitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbQuitter.Image = global::inscription_serialisation.Properties.Resources.btQuitter;
            this.pbQuitter.Location = new System.Drawing.Point(12, 274);
            this.pbQuitter.Name = "pbQuitter";
            this.pbQuitter.Size = new System.Drawing.Size(75, 75);
            this.pbQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuitter.TabIndex = 5;
            this.pbQuitter.TabStop = false;
            this.pbQuitter.Click += new System.EventHandler(this.pbQuitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pbClassement);
            this.Controls.Add(this.pbQuitter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.lbPseudo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClassement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMemory;
        private System.Windows.Forms.PictureBox pbQuitter;
        private System.Windows.Forms.PictureBox pbClassement;
        private System.Windows.Forms.PictureBox pbDevine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}