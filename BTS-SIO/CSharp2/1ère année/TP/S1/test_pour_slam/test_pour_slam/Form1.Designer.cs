namespace test_pour_slam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btScore = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChoix = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbWhile = new System.Windows.Forms.CheckBox();
            this.cbSwitch = new System.Windows.Forms.CheckBox();
            this.cbIf = new System.Windows.Forms.CheckBox();
            this.cbFor = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btWF = new System.Windows.Forms.Button();
            this.btCmd = new System.Windows.Forms.Button();
            this.pbWF = new System.Windows.Forms.PictureBox();
            this.pbCmd = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCmd)).BeginInit();
            this.SuspendLayout();
            // 
            // btScore
            // 
            this.btScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btScore.Location = new System.Drawing.Point(273, 433);
            this.btScore.Name = "btScore";
            this.btScore.Size = new System.Drawing.Size(215, 41);
            this.btScore.TabIndex = 1;
            this.btScore.Text = "Voir mon Score ...";
            this.btScore.UseVisualStyleBackColor = true;
            this.btScore.Click += new System.EventHandler(this.btScore_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(699, 478);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(75, 23);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChoix);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thème 1";
            // 
            // cbChoix
            // 
            this.cbChoix.FormattingEnabled = true;
            this.cbChoix.Items.AddRange(new object[] {
            "int",
            "string ",
            "bool",
            "char"});
            this.cbChoix.Location = new System.Drawing.Point(9, 48);
            this.cbChoix.Name = "cbChoix";
            this.cbChoix.Size = new System.Drawing.Size(205, 21);
            this.cbChoix.TabIndex = 1;
            this.cbChoix.Text = "Choisir entre les 5 réponses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.rb4);
            this.groupBox2.Controls.Add(this.rb3);
            this.groupBox2.Controls.Add(this.rb2);
            this.groupBox2.Controls.Add(this.rb1);
            this.groupBox2.Location = new System.Drawing.Point(422, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 129);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thème 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comment fait-on un retour à la ligne \r\nsans utiliser WriteLine() ?";
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(167, 106);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(38, 17);
            this.rb4.TabIndex = 3;
            this.rb4.TabStop = true;
            this.rb4.Text = "\\w";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(167, 52);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(35, 17);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "\\x";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(18, 106);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(33, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "\\t";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(18, 52);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(36, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "\\n";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbWhile);
            this.groupBox3.Controls.Add(this.cbSwitch);
            this.groupBox3.Controls.Add(this.cbIf);
            this.groupBox3.Controls.Add(this.cbFor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(21, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 167);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thème 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Citez plusieurs méthodes pour\r\nfaire une boucle ";
            // 
            // cbWhile
            // 
            this.cbWhile.AutoSize = true;
            this.cbWhile.Location = new System.Drawing.Point(9, 117);
            this.cbWhile.Name = "cbWhile";
            this.cbWhile.Size = new System.Drawing.Size(50, 17);
            this.cbWhile.TabIndex = 4;
            this.cbWhile.Text = "while";
            this.cbWhile.UseVisualStyleBackColor = true;
            // 
            // cbSwitch
            // 
            this.cbSwitch.AutoSize = true;
            this.cbSwitch.Location = new System.Drawing.Point(9, 94);
            this.cbSwitch.Name = "cbSwitch";
            this.cbSwitch.Size = new System.Drawing.Size(56, 17);
            this.cbSwitch.TabIndex = 3;
            this.cbSwitch.Text = "switch";
            this.cbSwitch.UseVisualStyleBackColor = true;
            // 
            // cbIf
            // 
            this.cbIf.AutoSize = true;
            this.cbIf.Location = new System.Drawing.Point(9, 71);
            this.cbIf.Name = "cbIf";
            this.cbIf.Size = new System.Drawing.Size(31, 17);
            this.cbIf.TabIndex = 2;
            this.cbIf.Text = "if";
            this.cbIf.UseVisualStyleBackColor = true;
            // 
            // cbFor
            // 
            this.cbFor.AutoSize = true;
            this.cbFor.Location = new System.Drawing.Point(9, 48);
            this.cbFor.Name = "cbFor";
            this.cbFor.Size = new System.Drawing.Size(38, 17);
            this.cbFor.TabIndex = 1;
            this.cbFor.Text = "for";
            this.cbFor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btWF);
            this.groupBox4.Controls.Add(this.btCmd);
            this.groupBox4.Controls.Add(this.pbWF);
            this.groupBox4.Controls.Add(this.pbCmd);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(306, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(434, 227);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thème 4";
            // 
            // btWF
            // 
            this.btWF.Location = new System.Drawing.Point(229, 186);
            this.btWF.Name = "btWF";
            this.btWF.Size = new System.Drawing.Size(172, 23);
            this.btWF.TabIndex = 4;
            this.btWF.Text = "Image 2";
            this.btWF.UseVisualStyleBackColor = true;
            this.btWF.Click += new System.EventHandler(this.btWF_Click);
            // 
            // btCmd
            // 
            this.btCmd.Location = new System.Drawing.Point(22, 186);
            this.btCmd.Name = "btCmd";
            this.btCmd.Size = new System.Drawing.Size(172, 23);
            this.btCmd.TabIndex = 3;
            this.btCmd.Text = "Image 1";
            this.btCmd.UseVisualStyleBackColor = true;
            this.btCmd.Click += new System.EventHandler(this.btCmd_Click);
            // 
            // pbWF
            // 
            this.pbWF.Image = ((System.Drawing.Image)(resources.GetObject("pbWF.Image")));
            this.pbWF.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbWF.InitialImage")));
            this.pbWF.Location = new System.Drawing.Point(241, 38);
            this.pbWF.Name = "pbWF";
            this.pbWF.Size = new System.Drawing.Size(160, 142);
            this.pbWF.TabIndex = 2;
            this.pbWF.TabStop = false;
            // 
            // pbCmd
            // 
            this.pbCmd.Image = ((System.Drawing.Image)(resources.GetObject("pbCmd.Image")));
            this.pbCmd.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCmd.InitialImage")));
            this.pbCmd.Location = new System.Drawing.Point(22, 38);
            this.pbCmd.Name = "pbCmd";
            this.pbCmd.Size = new System.Drawing.Size(172, 142);
            this.pbCmd.TabIndex = 1;
            this.pbCmd.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Quelle fenêtre représente un programme exécuté en mode console ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btScore);
            this.Controls.Add(this.btQuitter);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Test pour SLAM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btScore;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChoix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbWhile;
        private System.Windows.Forms.CheckBox cbSwitch;
        private System.Windows.Forms.CheckBox cbIf;
        private System.Windows.Forms.CheckBox cbFor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbWF;
        private System.Windows.Forms.PictureBox pbCmd;
        private System.Windows.Forms.Button btWF;
        private System.Windows.Forms.Button btCmd;
    }
}

