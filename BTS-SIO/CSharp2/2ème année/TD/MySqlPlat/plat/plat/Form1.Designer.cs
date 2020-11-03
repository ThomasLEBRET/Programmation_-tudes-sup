namespace plat
{
    partial class Form1
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
            this.lbPlats = new System.Windows.Forms.ListBox();
            this.btTriDefaut = new System.Windows.Forms.Button();
            this.BtTriCatPrix = new System.Windows.Forms.Button();
            this.btTriCatCal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPlats
            // 
            this.lbPlats.FormattingEnabled = true;
            this.lbPlats.ItemHeight = 15;
            this.lbPlats.Location = new System.Drawing.Point(12, 12);
            this.lbPlats.Name = "lbPlats";
            this.lbPlats.Size = new System.Drawing.Size(627, 169);
            this.lbPlats.TabIndex = 0;
            // 
            // btTriDefaut
            // 
            this.btTriDefaut.Location = new System.Drawing.Point(688, 68);
            this.btTriDefaut.Name = "btTriDefaut";
            this.btTriDefaut.Size = new System.Drawing.Size(100, 50);
            this.btTriDefaut.TabIndex = 1;
            this.btTriDefaut.Text = "Tri par défaut";
            this.btTriDefaut.UseVisualStyleBackColor = true;
            this.btTriDefaut.Click += new System.EventHandler(this.btTriDefaut_Click);
            // 
            // BtTriCatPrix
            // 
            this.BtTriCatPrix.Location = new System.Drawing.Point(688, 12);
            this.BtTriCatPrix.Name = "BtTriCatPrix";
            this.BtTriCatPrix.Size = new System.Drawing.Size(100, 50);
            this.BtTriCatPrix.TabIndex = 1;
            this.BtTriCatPrix.Text = "Tri catégorie Prix";
            this.BtTriCatPrix.UseVisualStyleBackColor = true;
            this.BtTriCatPrix.Click += new System.EventHandler(this.BtTriCatPrix_Click);
            // 
            // btTriCatCal
            // 
            this.btTriCatCal.Location = new System.Drawing.Point(688, 124);
            this.btTriCatCal.Name = "btTriCatCal";
            this.btTriCatCal.Size = new System.Drawing.Size(100, 50);
            this.btTriCatCal.TabIndex = 1;
            this.btTriCatCal.Text = "Tri catégorie Calories";
            this.btTriCatCal.UseVisualStyleBackColor = true;
            this.btTriCatCal.Click += new System.EventHandler(this.btTriCatCal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 193);
            this.Controls.Add(this.btTriCatCal);
            this.Controls.Add(this.BtTriCatPrix);
            this.Controls.Add(this.btTriDefaut);
            this.Controls.Add(this.lbPlats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlats;
        private System.Windows.Forms.Button btTriDefaut;
        private System.Windows.Forms.Button BtTriCatPrix;
        private System.Windows.Forms.Button btTriCatCal;
    }
}

