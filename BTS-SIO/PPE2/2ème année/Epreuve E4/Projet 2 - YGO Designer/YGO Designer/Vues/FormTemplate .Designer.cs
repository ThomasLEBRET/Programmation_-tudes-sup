
namespace YGO_Designer
{
    partial class FormTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTemplate));
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btChercherCarte = new System.Windows.Forms.Button();
            this.btAjouterCarte = new System.Windows.Forms.Button();
            this.btHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnFormChild = new System.Windows.Forms.Panel();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnContainer.BackColor = System.Drawing.Color.Black;
            this.pnContainer.Controls.Add(this.btChercherCarte);
            this.pnContainer.Controls.Add(this.btAjouterCarte);
            this.pnContainer.Controls.Add(this.btHome);
            this.pnContainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnContainer.Location = new System.Drawing.Point(1, 1);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(200, 556);
            this.pnContainer.TabIndex = 4;
            // 
            // btChercherCarte
            // 
            this.btChercherCarte.BackColor = System.Drawing.Color.Transparent;
            this.btChercherCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btChercherCarte.FlatAppearance.BorderSize = 0;
            this.btChercherCarte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btChercherCarte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btChercherCarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChercherCarte.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btChercherCarte.ForeColor = System.Drawing.Color.White;
            this.btChercherCarte.Location = new System.Drawing.Point(0, 186);
            this.btChercherCarte.Name = "btChercherCarte";
            this.btChercherCarte.Size = new System.Drawing.Size(200, 87);
            this.btChercherCarte.TabIndex = 2;
            this.btChercherCarte.Text = "Chercher une carte";
            this.btChercherCarte.UseVisualStyleBackColor = false;
            this.btChercherCarte.Click += new System.EventHandler(this.btChercherCarte_Click);
            // 
            // btAjouterCarte
            // 
            this.btAjouterCarte.BackColor = System.Drawing.Color.Transparent;
            this.btAjouterCarte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAjouterCarte.FlatAppearance.BorderSize = 0;
            this.btAjouterCarte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAjouterCarte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btAjouterCarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjouterCarte.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAjouterCarte.ForeColor = System.Drawing.Color.White;
            this.btAjouterCarte.Location = new System.Drawing.Point(0, 93);
            this.btAjouterCarte.Name = "btAjouterCarte";
            this.btAjouterCarte.Size = new System.Drawing.Size(200, 87);
            this.btAjouterCarte.TabIndex = 1;
            this.btAjouterCarte.Text = "Ajouter / Modifier une carte";
            this.btAjouterCarte.UseVisualStyleBackColor = false;
            this.btAjouterCarte.Click += new System.EventHandler(this.btAjouterCarte_Click);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btHome.ForeColor = System.Drawing.Color.White;
            this.btHome.Location = new System.Drawing.Point(0, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(200, 87);
            this.btHome.TabIndex = 0;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(578, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pnFormChild
            // 
            this.pnFormChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnFormChild.BackColor = System.Drawing.Color.DimGray;
            this.pnFormChild.Location = new System.Drawing.Point(199, 1);
            this.pnFormChild.Name = "pnFormChild";
            this.pnFormChild.Size = new System.Drawing.Size(784, 556);
            this.pnFormChild.TabIndex = 5;
            // 
            // FormTemplate
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnFormChild);
            this.Controls.Add(this.pnContainer);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YGO Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTemplate_Load);
            this.pnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Button btAjouterCarte;
        private System.Windows.Forms.Panel pnFormChild;
        private System.Windows.Forms.Button btChercherCarte;
        private System.Windows.Forms.Button Cher;
    }
}

