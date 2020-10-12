namespace date_nuls
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
            this.nudJour = new System.Windows.Forms.NumericUpDown();
            this.nudMois = new System.Windows.Forms.NumericUpDown();
            this.nudAnnee = new System.Windows.Forms.NumericUpDown();
            this.btFormatCourt = new System.Windows.Forms.Button();
            this.btFormatLong = new System.Windows.Forms.Button();
            this.btEstBissextile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudJour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMois)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(315, 156);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Année";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mois";
            // 
            // nudJour
            // 
            this.nudJour.Location = new System.Drawing.Point(124, 22);
            this.nudJour.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudJour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJour.Name = "nudJour";
            this.nudJour.Size = new System.Drawing.Size(43, 20);
            this.nudJour.TabIndex = 4;
            this.nudJour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudJour.ValueChanged += new System.EventHandler(this.nudJour_ValueChanged);
            // 
            // nudMois
            // 
            this.nudMois.Location = new System.Drawing.Point(124, 61);
            this.nudMois.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMois.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMois.Name = "nudMois";
            this.nudMois.Size = new System.Drawing.Size(43, 20);
            this.nudMois.TabIndex = 5;
            this.nudMois.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMois.ValueChanged += new System.EventHandler(this.nudMois_ValueChanged);
            // 
            // nudAnnee
            // 
            this.nudAnnee.Location = new System.Drawing.Point(124, 95);
            this.nudAnnee.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudAnnee.Name = "nudAnnee";
            this.nudAnnee.Size = new System.Drawing.Size(80, 20);
            this.nudAnnee.TabIndex = 6;
            this.nudAnnee.ValueChanged += new System.EventHandler(this.nudAnnee_ValueChanged);
            // 
            // btFormatCourt
            // 
            this.btFormatCourt.Location = new System.Drawing.Point(272, 61);
            this.btFormatCourt.Name = "btFormatCourt";
            this.btFormatCourt.Size = new System.Drawing.Size(102, 23);
            this.btFormatCourt.TabIndex = 7;
            this.btFormatCourt.Text = "Format Court";
            this.btFormatCourt.UseVisualStyleBackColor = true;
            this.btFormatCourt.Click += new System.EventHandler(this.btFormatCourt_Click);
            // 
            // btFormatLong
            // 
            this.btFormatLong.Location = new System.Drawing.Point(272, 92);
            this.btFormatLong.Name = "btFormatLong";
            this.btFormatLong.Size = new System.Drawing.Size(102, 23);
            this.btFormatLong.TabIndex = 8;
            this.btFormatLong.Text = "Format Long";
            this.btFormatLong.UseVisualStyleBackColor = true;
            this.btFormatLong.Click += new System.EventHandler(this.btFormatLong_Click);
            // 
            // btEstBissextile
            // 
            this.btEstBissextile.Location = new System.Drawing.Point(29, 146);
            this.btEstBissextile.Name = "btEstBissextile";
            this.btEstBissextile.Size = new System.Drawing.Size(175, 23);
            this.btEstBissextile.TabIndex = 9;
            this.btEstBissextile.Text = "Vérifier si l\'année est bissextile";
            this.btEstBissextile.UseVisualStyleBackColor = true;
            this.btEstBissextile.Click += new System.EventHandler(this.btEstBissextile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 191);
            this.Controls.Add(this.btEstBissextile);
            this.Controls.Add(this.btFormatLong);
            this.Controls.Add(this.btFormatCourt);
            this.Controls.Add(this.nudAnnee);
            this.Controls.Add(this.nudMois);
            this.Controls.Add(this.nudJour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudJour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMois)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudJour;
        private System.Windows.Forms.NumericUpDown nudMois;
        private System.Windows.Forms.NumericUpDown nudAnnee;
        private System.Windows.Forms.Button btFormatCourt;
        private System.Windows.Forms.Button btFormatLong;
        private System.Windows.Forms.Button btEstBissextile;
    }
}

