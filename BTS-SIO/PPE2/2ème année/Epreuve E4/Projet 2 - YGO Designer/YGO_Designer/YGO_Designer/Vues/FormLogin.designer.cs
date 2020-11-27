
namespace YGO_Designer
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.btSingin = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold);
            this.lbUserName.Location = new System.Drawing.Point(192, 134);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(191, 29);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Nom d\'utilisateur";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold);
            this.lbPassword.Location = new System.Drawing.Point(235, 205);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(148, 29);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Mot de passe";
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUserName.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(404, 139);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(208, 24);
            this.tbUserName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(404, 207);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(208, 24);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold);
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLogin.Location = new System.Drawing.Point(305, 257);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(340, 49);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Connexion";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btSingin
            // 
            this.btSingin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSingin.BackColor = System.Drawing.Color.DarkRed;
            this.btSingin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSingin.FlatAppearance.BorderSize = 0;
            this.btSingin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btSingin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btSingin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSingin.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btSingin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btSingin.Location = new System.Drawing.Point(305, 340);
            this.btSingin.Name = "btSingin";
            this.btSingin.Size = new System.Drawing.Size(340, 49);
            this.btSingin.TabIndex = 5;
            this.btSingin.Text = "Inscription";
            this.btSingin.UseVisualStyleBackColor = false;
            this.btSingin.Click += new System.EventHandler(this.btSingin_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.BackColor = System.Drawing.Color.DarkRed;
            this.btClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.btClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btClose.Location = new System.Drawing.Point(-2, 426);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(181, 62);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Quitter";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(10, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(293, 104);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(843, 486);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSingin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGO Designer - Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btSingin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

