namespace testControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boiteConnexion1 = new control_WPF.BoiteConnexion();
            this.SuspendLayout();
            // 
            // boiteConnexion1
            // 
            this.boiteConnexion1.Location = new System.Drawing.Point(73, 32);
            this.boiteConnexion1.Name = "boiteConnexion1";
            this.boiteConnexion1.Size = new System.Drawing.Size(292, 184);
            this.boiteConnexion1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 262);
            this.Controls.Add(this.boiteConnexion1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Connexion";
            this.ResumeLayout(false);

        }

        #endregion

        private control_WPF.BoiteConnexion boiteConnexion1;
    }
}

