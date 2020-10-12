namespace calculatrice {
    partial class Form1 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btQuitter = new System.Windows.Forms.Button();
            this.lbNombre1 = new System.Windows.Forms.Label();
            this.tbNombre1 = new System.Windows.Forms.TextBox();
            this.lbNombre2 = new System.Windows.Forms.Label();
            this.tbNombre2 = new System.Windows.Forms.TextBox();
            this.btCalculer = new System.Windows.Forms.Button();
            this.lbResultat = new System.Windows.Forms.Label();
            this.tbResultat = new System.Windows.Forms.TextBox();
            this.btRAZ = new System.Windows.Forms.Button();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.rbDiviser = new System.Windows.Forms.RadioButton();
            this.rbMultiplier = new System.Windows.Forms.RadioButton();
            this.rbSoustraire = new System.Windows.Forms.RadioButton();
            this.rbAddition = new System.Windows.Forms.RadioButton();
            this.gbRadio.SuspendLayout();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(396, 278);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quit";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lbNombre1
            // 
            this.lbNombre1.AutoSize = true;
            this.lbNombre1.Location = new System.Drawing.Point(41, 35);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(53, 13);
            this.lbNombre1.TabIndex = 1;
            this.lbNombre1.Text = "variable 1";
            // 
            // tbNombre1
            // 
            this.tbNombre1.Location = new System.Drawing.Point(22, 71);
            this.tbNombre1.Name = "tbNombre1";
            this.tbNombre1.Size = new System.Drawing.Size(100, 20);
            this.tbNombre1.TabIndex = 2;
            // 
            // lbNombre2
            // 
            this.lbNombre2.AutoSize = true;
            this.lbNombre2.Location = new System.Drawing.Point(41, 138);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(53, 13);
            this.lbNombre2.TabIndex = 3;
            this.lbNombre2.Text = "variable 2";
            // 
            // tbNombre2
            // 
            this.tbNombre2.Location = new System.Drawing.Point(22, 168);
            this.tbNombre2.Name = "tbNombre2";
            this.tbNombre2.Size = new System.Drawing.Size(100, 20);
            this.tbNombre2.TabIndex = 4;
            // 
            // btCalculer
            // 
            this.btCalculer.Location = new System.Drawing.Point(22, 278);
            this.btCalculer.Name = "btCalculer";
            this.btCalculer.Size = new System.Drawing.Size(75, 23);
            this.btCalculer.TabIndex = 5;
            this.btCalculer.Text = "Calculate";
            this.btCalculer.UseVisualStyleBackColor = true;
            this.btCalculer.Click += new System.EventHandler(this.btCalculer_Click);
            // 
            // lbResultat
            // 
            this.lbResultat.AutoSize = true;
            this.lbResultat.Location = new System.Drawing.Point(327, 35);
            this.lbResultat.Name = "lbResultat";
            this.lbResultat.Size = new System.Drawing.Size(37, 13);
            this.lbResultat.TabIndex = 6;
            this.lbResultat.Text = "Result";
            // 
            // tbResultat
            // 
            this.tbResultat.Enabled = false;
            this.tbResultat.Location = new System.Drawing.Point(330, 71);
            this.tbResultat.Multiline = true;
            this.tbResultat.Name = "tbResultat";
            this.tbResultat.Size = new System.Drawing.Size(141, 40);
            this.tbResultat.TabIndex = 7;
            // 
            // btRAZ
            // 
            this.btRAZ.Location = new System.Drawing.Point(201, 278);
            this.btRAZ.Name = "btRAZ";
            this.btRAZ.Size = new System.Drawing.Size(75, 23);
            this.btRAZ.TabIndex = 8;
            this.btRAZ.Text = "RAZ";
            this.btRAZ.UseVisualStyleBackColor = true;
            this.btRAZ.Click += new System.EventHandler(this.btRAZ_Click);
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.rbDiviser);
            this.gbRadio.Controls.Add(this.rbMultiplier);
            this.gbRadio.Controls.Add(this.rbSoustraire);
            this.gbRadio.Controls.Add(this.rbAddition);
            this.gbRadio.Location = new System.Drawing.Point(153, 35);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(123, 150);
            this.gbRadio.TabIndex = 9;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Operator";
            // 
            // rbDiviser
            // 
            this.rbDiviser.AutoSize = true;
            this.rbDiviser.Location = new System.Drawing.Point(7, 106);
            this.rbDiviser.Name = "rbDiviser";
            this.rbDiviser.Size = new System.Drawing.Size(76, 17);
            this.rbDiviser.TabIndex = 3;
            this.rbDiviser.TabStop = true;
            this.rbDiviser.Text = "Division (/)";
            this.rbDiviser.UseVisualStyleBackColor = true;
            // 
            // rbMultiplier
            // 
            this.rbMultiplier.AutoSize = true;
            this.rbMultiplier.Location = new System.Drawing.Point(7, 83);
            this.rbMultiplier.Name = "rbMultiplier";
            this.rbMultiplier.Size = new System.Drawing.Size(99, 17);
            this.rbMultiplier.TabIndex = 2;
            this.rbMultiplier.TabStop = true;
            this.rbMultiplier.Text = "Multiplication (*)";
            this.rbMultiplier.UseVisualStyleBackColor = true;
            // 
            // rbSoustraire
            // 
            this.rbSoustraire.AutoSize = true;
            this.rbSoustraire.Location = new System.Drawing.Point(7, 59);
            this.rbSoustraire.Name = "rbSoustraire";
            this.rbSoustraire.Size = new System.Drawing.Size(96, 17);
            this.rbSoustraire.TabIndex = 1;
            this.rbSoustraire.TabStop = true;
            this.rbSoustraire.Text = "Substraction (-)";
            this.rbSoustraire.UseVisualStyleBackColor = true;
            // 
            // rbAddition
            // 
            this.rbAddition.AutoSize = true;
            this.rbAddition.Location = new System.Drawing.Point(7, 36);
            this.rbAddition.Name = "rbAddition";
            this.rbAddition.Size = new System.Drawing.Size(78, 17);
            this.rbAddition.TabIndex = 0;
            this.rbAddition.TabStop = true;
            this.rbAddition.Text = "Addition (+)";
            this.rbAddition.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::calculatrice.Properties.Resources.bgMaths;
            this.ClientSize = new System.Drawing.Size(483, 313);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.btRAZ);
            this.Controls.Add(this.tbResultat);
            this.Controls.Add(this.lbResultat);
            this.Controls.Add(this.btCalculer);
            this.Controls.Add(this.tbNombre2);
            this.Controls.Add(this.lbNombre2);
            this.Controls.Add(this.tbNombre1);
            this.Controls.Add(this.lbNombre1);
            this.Controls.Add(this.btQuitter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Basic Operator Tester";
            this.Load += new System.EventHandler(this.formulaire1_Load);
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lbNombre1;
        private System.Windows.Forms.TextBox tbNombre1;
        private System.Windows.Forms.Label lbNombre2;
        private System.Windows.Forms.TextBox tbNombre2;
        private System.Windows.Forms.Button btCalculer;
        private System.Windows.Forms.Label lbResultat;
        private System.Windows.Forms.TextBox tbResultat;
        private System.Windows.Forms.Button btRAZ;
        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.RadioButton rbAddition;
        private System.Windows.Forms.RadioButton rbMultiplier;
        private System.Windows.Forms.RadioButton rbSoustraire;
        private System.Windows.Forms.RadioButton rbDiviser;
    }
}

