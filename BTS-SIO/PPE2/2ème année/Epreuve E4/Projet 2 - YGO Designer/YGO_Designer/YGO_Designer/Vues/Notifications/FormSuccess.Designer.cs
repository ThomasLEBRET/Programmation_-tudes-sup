namespace YGO_Designer.Vues.Joueur
{
    partial class FormSuccess
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
            this.components = new System.ComponentModel.Container();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.timClose = new System.Windows.Forms.Timer(this.components);
            this.timBeforeClose = new System.Windows.Forms.Timer(this.components);
            this.gbSuccess = new System.Windows.Forms.GroupBox();
            this.lbDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.gbSuccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::YGO_Designer.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(331, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(39, 44);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // timClose
            // 
            this.timClose.Interval = 150;
            this.timClose.Tick += new System.EventHandler(this.timClose_Tick);
            // 
            // timBeforeClose
            // 
            this.timBeforeClose.Enabled = true;
            this.timBeforeClose.Interval = 1000;
            this.timBeforeClose.Tick += new System.EventHandler(this.timBeforeClose_Tick);
            // 
            // gbSuccess
            // 
            this.gbSuccess.Controls.Add(this.lbDesc);
            this.gbSuccess.Controls.Add(this.pbClose);
            this.gbSuccess.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSuccess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbSuccess.Location = new System.Drawing.Point(12, 12);
            this.gbSuccess.Name = "gbSuccess";
            this.gbSuccess.Size = new System.Drawing.Size(376, 126);
            this.gbSuccess.TabIndex = 3;
            this.gbSuccess.TabStop = false;
            this.gbSuccess.Text = "Succès";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesc.Location = new System.Drawing.Point(6, 36);
            this.lbDesc.MaximumSize = new System.Drawing.Size(350, 80);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(254, 26);
            this.lbDesc.TabIndex = 2;
            this.lbDesc.Text = "Votre deck a bien été créé ";
            // 
            // FormSuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.Controls.Add(this.gbSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSuccess";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.gbSuccess.ResumeLayout(false);
            this.gbSuccess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Timer timClose;
        private System.Windows.Forms.Timer timBeforeClose;
        private System.Windows.Forms.GroupBox gbSuccess;
        private System.Windows.Forms.Label lbDesc;
    }
}