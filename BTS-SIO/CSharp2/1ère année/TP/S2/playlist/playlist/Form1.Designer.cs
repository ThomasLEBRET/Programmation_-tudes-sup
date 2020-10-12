namespace playlist
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
            this.btQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitre = new System.Windows.Forms.TextBox();
            this.tbInterprète = new System.Windows.Forms.TextBox();
            this.nudDurée = new System.Windows.Forms.NumericUpDown();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btRAZ = new System.Windows.Forms.Button();
            this.btVerifier = new System.Windows.Forms.Button();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudEnleveChanson = new System.Windows.Forms.NumericUpDown();
            this.btSupprimeChanson = new System.Windows.Forms.Button();
            this.btEnregisterSerialisation = new System.Windows.Forms.Button();
            this.btCharger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurée)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnleveChanson)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(488, 553);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Intreprète : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Durée (en secondes) : ";
            // 
            // tbTitre
            // 
            this.tbTitre.Location = new System.Drawing.Point(294, 27);
            this.tbTitre.Name = "tbTitre";
            this.tbTitre.Size = new System.Drawing.Size(235, 20);
            this.tbTitre.TabIndex = 4;
            // 
            // tbInterprète
            // 
            this.tbInterprète.Location = new System.Drawing.Point(294, 89);
            this.tbInterprète.Name = "tbInterprète";
            this.tbInterprète.Size = new System.Drawing.Size(235, 20);
            this.tbInterprète.TabIndex = 5;
            // 
            // nudDurée
            // 
            this.nudDurée.Location = new System.Drawing.Point(294, 144);
            this.nudDurée.Maximum = new decimal(new int[] {
            90000,
            0,
            0,
            0});
            this.nudDurée.Name = "nudDurée";
            this.nudDurée.Size = new System.Drawing.Size(151, 20);
            this.nudDurée.TabIndex = 6;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Location = new System.Drawing.Point(18, 226);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(180, 63);
            this.btEnregistrer.TabIndex = 7;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // btRAZ
            // 
            this.btRAZ.Location = new System.Drawing.Point(273, 245);
            this.btRAZ.Name = "btRAZ";
            this.btRAZ.Size = new System.Drawing.Size(106, 44);
            this.btRAZ.TabIndex = 8;
            this.btRAZ.Text = "RAZ";
            this.btRAZ.UseVisualStyleBackColor = true;
            // 
            // btVerifier
            // 
            this.btVerifier.Location = new System.Drawing.Point(57, 315);
            this.btVerifier.Name = "btVerifier";
            this.btVerifier.Size = new System.Drawing.Size(236, 37);
            this.btVerifier.TabIndex = 9;
            this.btVerifier.Text = "Vérifier";
            this.btVerifier.UseVisualStyleBackColor = true;
            this.btVerifier.Click += new System.EventHandler(this.btVerifier_Click);
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.Location = new System.Drawing.Point(42, 379);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(275, 199);
            this.lbPlaylist.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temps total de la playliste :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre de chansons : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enlever une chanson :";
            // 
            // nudEnleveChanson
            // 
            this.nudEnleveChanson.Location = new System.Drawing.Point(451, 377);
            this.nudEnleveChanson.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEnleveChanson.Name = "nudEnleveChanson";
            this.nudEnleveChanson.Size = new System.Drawing.Size(62, 20);
            this.nudEnleveChanson.TabIndex = 17;
            this.nudEnleveChanson.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btSupprimeChanson
            // 
            this.btSupprimeChanson.Location = new System.Drawing.Point(438, 403);
            this.btSupprimeChanson.Name = "btSupprimeChanson";
            this.btSupprimeChanson.Size = new System.Drawing.Size(75, 23);
            this.btSupprimeChanson.TabIndex = 18;
            this.btSupprimeChanson.Text = "Supprimer";
            this.btSupprimeChanson.UseVisualStyleBackColor = true;
            this.btSupprimeChanson.Click += new System.EventHandler(this.btSupprimeChanson_Click);
            // 
            // btEnregisterSerialisation
            // 
            this.btEnregisterSerialisation.Location = new System.Drawing.Point(334, 513);
            this.btEnregisterSerialisation.Name = "btEnregisterSerialisation";
            this.btEnregisterSerialisation.Size = new System.Drawing.Size(75, 23);
            this.btEnregisterSerialisation.TabIndex = 19;
            this.btEnregisterSerialisation.Text = "Enregistrer";
            this.btEnregisterSerialisation.UseVisualStyleBackColor = true;
            this.btEnregisterSerialisation.Click += new System.EventHandler(this.btEnregisterSerialisation_Click);
            // 
            // btCharger
            // 
            this.btCharger.Location = new System.Drawing.Point(438, 513);
            this.btCharger.Name = "btCharger";
            this.btCharger.Size = new System.Drawing.Size(125, 23);
            this.btCharger.TabIndex = 20;
            this.btCharger.Text = "Charger une playlist";
            this.btCharger.UseVisualStyleBackColor = true;
            this.btCharger.Click += new System.EventHandler(this.btCharger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 588);
            this.Controls.Add(this.btCharger);
            this.Controls.Add(this.btEnregisterSerialisation);
            this.Controls.Add(this.btSupprimeChanson);
            this.Controls.Add(this.nudEnleveChanson);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.btVerifier);
            this.Controls.Add(this.btRAZ);
            this.Controls.Add(this.btEnregistrer);
            this.Controls.Add(this.nudDurée);
            this.Controls.Add(this.tbInterprète);
            this.Controls.Add(this.tbTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDurée)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnleveChanson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitre;
        private System.Windows.Forms.TextBox tbInterprète;
        private System.Windows.Forms.NumericUpDown nudDurée;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btRAZ;
        private System.Windows.Forms.Button btVerifier;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudEnleveChanson;
        private System.Windows.Forms.Button btSupprimeChanson;
        private System.Windows.Forms.Button btEnregisterSerialisation;
        private System.Windows.Forms.Button btCharger;
    }
}

