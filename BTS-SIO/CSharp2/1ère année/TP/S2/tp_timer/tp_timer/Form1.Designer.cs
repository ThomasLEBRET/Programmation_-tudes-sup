namespace tp_timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbMot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbmonTheme = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbmesAnimaux = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbmonTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmesAnimaux)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "clique sur l\'image qui correspond à : ";
            this.label1.Visible = false;
            // 
            // lbMot
            // 
            this.lbMot.AutoSize = true;
            this.lbMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMot.ForeColor = System.Drawing.Color.Blue;
            this.lbMot.Location = new System.Drawing.Point(135, 212);
            this.lbMot.Name = "lbMot";
            this.lbMot.Size = new System.Drawing.Size(65, 25);
            this.lbMot.TabIndex = 2;
            this.lbMot.Text = "RIEN";
            this.lbMot.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choisi ton thème";
            // 
            // pbmonTheme
            // 
            this.pbmonTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbmonTheme.Image = global::tp_timer.Properties.Resources.nainNomProf;
            this.pbmonTheme.Location = new System.Drawing.Point(12, 21);
            this.pbmonTheme.Name = "pbmonTheme";
            this.pbmonTheme.Size = new System.Drawing.Size(116, 111);
            this.pbmonTheme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmonTheme.TabIndex = 3;
            this.pbmonTheme.TabStop = false;
            this.pbmonTheme.Tag = "1";
            this.pbmonTheme.Click += new System.EventHandler(this.pbmonTheme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbmesAnimaux
            // 
            this.pbmesAnimaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbmesAnimaux.Image = global::tp_timer.Properties.Resources.ecureil;
            this.pbmesAnimaux.Location = new System.Drawing.Point(223, 21);
            this.pbmesAnimaux.Name = "pbmesAnimaux";
            this.pbmesAnimaux.Size = new System.Drawing.Size(118, 111);
            this.pbmesAnimaux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmesAnimaux.TabIndex = 5;
            this.pbmesAnimaux.TabStop = false;
            this.pbmesAnimaux.Click += new System.EventHandler(this.pbmesAnimaux_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.pbmesAnimaux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbmonTheme);
            this.Controls.Add(this.lbMot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbmonTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmesAnimaux)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMot;
        private System.Windows.Forms.PictureBox pbmonTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbmesAnimaux;
    }
}

