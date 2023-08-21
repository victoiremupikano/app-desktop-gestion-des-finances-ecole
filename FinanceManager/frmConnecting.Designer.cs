namespace FinanceManager
{
    partial class frmConnecting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnecting));
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSettings = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlSouligneurUserName = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlSouligneurPassword = new System.Windows.Forms.Panel();
            this.pnlBordGauche = new System.Windows.Forms.Panel();
            this.pnlBaodDroit = new System.Windows.Forms.Panel();
            this.ckbVisiblePwd = new System.Windows.Forms.CheckBox();
            this.pictureBoxLogo2 = new System.Windows.Forms.PictureBox();
            this.toolTipBtnCtrl = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHaut
            // 
            this.pnlHaut.Controls.Add(this.panel1);
            this.pnlHaut.Controls.Add(this.picSettings);
            this.pnlHaut.Controls.Add(this.picMinimize);
            this.pnlHaut.Controls.Add(this.picClose);
            this.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(541, 59);
            this.pnlHaut.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(538, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 59);
            this.panel1.TabIndex = 54;
            // 
            // picSettings
            // 
            this.picSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSettings.Image = global::FinanceManager.Properties.Resources.icon_cog;
            this.picSettings.Location = new System.Drawing.Point(427, 17);
            this.picSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(27, 31);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 54;
            this.picSettings.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.picSettings, "Paramètres");
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Image = global::FinanceManager.Properties.Resources.icon_minus_06;
            this.picMinimize.Location = new System.Drawing.Point(461, 17);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 31);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 7;
            this.picMinimize.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.picMinimize, "Minimiser");
            this.picMinimize.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::FinanceManager.Properties.Resources.icon_close;
            this.picClose.Location = new System.Drawing.Point(493, 17);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(27, 31);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.picClose, "Fermer");
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(245, 17);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(152, 31);
            this.lblConnexion.TabIndex = 7;
            this.lblConnexion.Text = "Connexion";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(249, 130);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(249, 69);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 17);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "Nom d\'utilisateur :";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(251, 225);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 55);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Connexion";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUserName.Location = new System.Drawing.Point(254, 96);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(253, 16);
            this.txtUserName.TabIndex = 1;
            // 
            // pnlSouligneurUserName
            // 
            this.pnlSouligneurUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlSouligneurUserName.Location = new System.Drawing.Point(253, 116);
            this.pnlSouligneurUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSouligneurUserName.Name = "pnlSouligneurUserName";
            this.pnlSouligneurUserName.Size = new System.Drawing.Size(257, 5);
            this.pnlSouligneurUserName.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(255, 156);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 16);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pnlSouligneurPassword
            // 
            this.pnlSouligneurPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlSouligneurPassword.Location = new System.Drawing.Point(251, 176);
            this.pnlSouligneurPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlSouligneurPassword.Name = "pnlSouligneurPassword";
            this.pnlSouligneurPassword.Size = new System.Drawing.Size(257, 5);
            this.pnlSouligneurPassword.TabIndex = 25;
            // 
            // pnlBordGauche
            // 
            this.pnlBordGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBordGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordGauche.Location = new System.Drawing.Point(0, 59);
            this.pnlBordGauche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBordGauche.Name = "pnlBordGauche";
            this.pnlBordGauche.Size = new System.Drawing.Size(3, 257);
            this.pnlBordGauche.TabIndex = 27;
            // 
            // pnlBaodDroit
            // 
            this.pnlBaodDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBaodDroit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBaodDroit.Location = new System.Drawing.Point(538, 59);
            this.pnlBaodDroit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBaodDroit.Name = "pnlBaodDroit";
            this.pnlBaodDroit.Size = new System.Drawing.Size(3, 257);
            this.pnlBaodDroit.TabIndex = 31;
            // 
            // ckbVisiblePwd
            // 
            this.ckbVisiblePwd.AutoSize = true;
            this.ckbVisiblePwd.BackColor = System.Drawing.SystemColors.Control;
            this.ckbVisiblePwd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbVisiblePwd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVisiblePwd.ForeColor = System.Drawing.Color.Black;
            this.ckbVisiblePwd.Location = new System.Drawing.Point(251, 189);
            this.ckbVisiblePwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbVisiblePwd.Name = "ckbVisiblePwd";
            this.ckbVisiblePwd.Size = new System.Drawing.Size(65, 21);
            this.ckbVisiblePwd.TabIndex = 54;
            this.ckbVisiblePwd.Text = "Visible";
            this.ckbVisiblePwd.UseVisualStyleBackColor = false;
            this.ckbVisiblePwd.CheckedChanged += new System.EventHandler(this.ckbVisiblePwd_CheckedChanged);
            // 
            // pictureBoxLogo2
            // 
            this.pictureBoxLogo2.Image = global::FinanceManager.Properties.Resources.ic2;
            this.pictureBoxLogo2.Location = new System.Drawing.Point(29, 69);
            this.pictureBoxLogo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo2.Name = "pictureBoxLogo2";
            this.pictureBoxLogo2.Size = new System.Drawing.Size(204, 131);
            this.pictureBoxLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo2.TabIndex = 3;
            this.pictureBoxLogo2.TabStop = false;
            // 
            // frmConnecting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 316);
            this.Controls.Add(this.ckbVisiblePwd);
            this.Controls.Add(this.pnlBaodDroit);
            this.Controls.Add(this.pnlBordGauche);
            this.Controls.Add(this.lblConnexion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pnlSouligneurPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pnlSouligneurUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pictureBoxLogo2);
            this.Controls.Add(this.pnlHaut);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConnecting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmConnecting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmConnecting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConnecting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmConnecting_MouseUp);
            this.pnlHaut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.PictureBox pictureBoxLogo2;
        private System.Windows.Forms.Label lblConnexion;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Panel pnlSouligneurUserName;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Panel pnlSouligneurPassword;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Panel pnlBordGauche;
        private System.Windows.Forms.Panel pnlBaodDroit;
        private System.Windows.Forms.PictureBox picSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckbVisiblePwd;
        private System.Windows.Forms.ToolTip toolTipBtnCtrl;
    }
}

