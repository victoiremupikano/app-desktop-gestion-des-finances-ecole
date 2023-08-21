namespace FinanceManager.SettingsApp
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.pnlBaodDroit = new System.Windows.Forms.Panel();
            this.pnlBordGauche = new System.Windows.Forms.Panel();
            this.pnlHaut = new System.Windows.Forms.Panel();
            this.lblConnexion = new System.Windows.Forms.Label();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbServeur = new System.Windows.Forms.TabPage();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.lbldatabase = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtport = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.lblTry = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.picTester = new System.Windows.Forms.PictureBox();
            this.picModifier = new System.Windows.Forms.PictureBox();
            this.toolTipBtnCtrl = new System.Windows.Forms.ToolTip(this.components);
            this.pnlHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbServeur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModifier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBaodDroit
            // 
            this.pnlBaodDroit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBaodDroit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBaodDroit.Location = new System.Drawing.Point(387, 59);
            this.pnlBaodDroit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBaodDroit.Name = "pnlBaodDroit";
            this.pnlBaodDroit.Size = new System.Drawing.Size(3, 363);
            this.pnlBaodDroit.TabIndex = 69;
            // 
            // pnlBordGauche
            // 
            this.pnlBordGauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlBordGauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBordGauche.Location = new System.Drawing.Point(0, 59);
            this.pnlBordGauche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBordGauche.Name = "pnlBordGauche";
            this.pnlBordGauche.Size = new System.Drawing.Size(3, 363);
            this.pnlBordGauche.TabIndex = 66;
            // 
            // pnlHaut
            // 
            this.pnlHaut.Controls.Add(this.lblConnexion);
            this.pnlHaut.Controls.Add(this.picMinimize);
            this.pnlHaut.Controls.Add(this.picClose);
            this.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHaut.Location = new System.Drawing.Point(0, 0);
            this.pnlHaut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHaut.Name = "pnlHaut";
            this.pnlHaut.Size = new System.Drawing.Size(390, 59);
            this.pnlHaut.TabIndex = 55;
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.Location = new System.Drawing.Point(14, 16);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(105, 24);
            this.lblConnexion.TabIndex = 58;
            this.lblConnexion.Text = "Paramètres";
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Image = global::FinanceManager.Properties.Resources.icon_minus_06;
            this.picMinimize.Location = new System.Drawing.Point(326, 12);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(27, 31);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinimize.TabIndex = 7;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Image = global::FinanceManager.Properties.Resources.icon_close;
            this.picClose.Location = new System.Drawing.Point(358, 12);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(27, 31);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbServeur);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(369, 293);
            this.tabControl1.TabIndex = 70;
            // 
            // tbServeur
            // 
            this.tbServeur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbServeur.Controls.Add(this.txtMode);
            this.tbServeur.Controls.Add(this.lblMode);
            this.tbServeur.Controls.Add(this.txtIp);
            this.tbServeur.Controls.Add(this.lblIp);
            this.tbServeur.Controls.Add(this.txtdatabase);
            this.tbServeur.Controls.Add(this.lbldatabase);
            this.tbServeur.Controls.Add(this.txtpassword);
            this.tbServeur.Controls.Add(this.lblpassword);
            this.tbServeur.Controls.Add(this.txtusername);
            this.tbServeur.Controls.Add(this.lblUsername);
            this.tbServeur.Controls.Add(this.txtport);
            this.tbServeur.Controls.Add(this.lblport);
            this.tbServeur.Location = new System.Drawing.Point(4, 25);
            this.tbServeur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbServeur.Name = "tbServeur";
            this.tbServeur.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbServeur.Size = new System.Drawing.Size(361, 264);
            this.tbServeur.TabIndex = 0;
            this.tbServeur.Text = "Serveur";
            // 
            // txtMode
            // 
            this.txtMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMode.BackColor = System.Drawing.Color.White;
            this.txtMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMode.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtMode.Location = new System.Drawing.Point(189, 186);
            this.txtMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMode.MaxLength = 30;
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(166, 21);
            this.txtMode.TabIndex = 13;
            this.txtMode.UseSystemPasswordChar = true;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(185, 162);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(43, 16);
            this.lblMode.TabIndex = 12;
            this.lblMode.Text = "Mode:";
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.White;
            this.txtIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIp.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtIp.Location = new System.Drawing.Point(7, 57);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIp.MaxLength = 15;
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(159, 21);
            this.txtIp.TabIndex = 11;
            this.txtIp.UseSystemPasswordChar = true;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(3, 34);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(21, 16);
            this.lblIp.TabIndex = 10;
            this.lblIp.Text = "Ip:";
            // 
            // txtdatabase
            // 
            this.txtdatabase.BackColor = System.Drawing.Color.White;
            this.txtdatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdatabase.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtdatabase.Location = new System.Drawing.Point(7, 122);
            this.txtdatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdatabase.MaxLength = 25;
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(159, 21);
            this.txtdatabase.TabIndex = 9;
            this.txtdatabase.UseSystemPasswordChar = true;
            // 
            // lbldatabase
            // 
            this.lbldatabase.AutoSize = true;
            this.lbldatabase.Location = new System.Drawing.Point(3, 100);
            this.lbldatabase.Name = "lbldatabase";
            this.lbldatabase.Size = new System.Drawing.Size(92, 16);
            this.lbldatabase.TabIndex = 8;
            this.lbldatabase.Text = "Base de donné:";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtpassword.Location = new System.Drawing.Point(189, 122);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpassword.MaxLength = 30;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(166, 21);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(185, 100);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(84, 16);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Mot de passe:";
            // 
            // txtusername
            // 
            this.txtusername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtusername.Location = new System.Drawing.Point(189, 57);
            this.txtusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtusername.MaxLength = 15;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(166, 21);
            this.txtusername.TabIndex = 5;
            this.txtusername.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(185, 34);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(96, 16);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Nom d\'utlisateur:";
            // 
            // txtport
            // 
            this.txtport.BackColor = System.Drawing.Color.White;
            this.txtport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtport.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtport.Location = new System.Drawing.Point(7, 186);
            this.txtport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtport.MaxLength = 5;
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(159, 21);
            this.txtport.TabIndex = 3;
            this.txtport.UseSystemPasswordChar = true;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(3, 162);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(31, 16);
            this.lblport.TabIndex = 2;
            this.lblport.Text = "Port:";
            // 
            // lblTry
            // 
            this.lblTry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTry.AutoSize = true;
            this.lblTry.Location = new System.Drawing.Point(201, 367);
            this.lblTry.Name = "lblTry";
            this.lblTry.Size = new System.Drawing.Size(37, 16);
            this.lblTry.TabIndex = 85;
            this.lblTry.Text = "Tester";
            // 
            // lblSave
            // 
            this.lblSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(84, 367);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(60, 16);
            this.lblSave.TabIndex = 86;
            this.lblSave.Text = "Enregistrer";
            // 
            // picTester
            // 
            this.picTester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picTester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTester.Image = global::FinanceManager.Properties.Resources.icon_loading;
            this.picTester.Location = new System.Drawing.Point(157, 367);
            this.picTester.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picTester.Name = "picTester";
            this.picTester.Size = new System.Drawing.Size(36, 41);
            this.picTester.TabIndex = 84;
            this.picTester.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.picTester, "Tester");
            this.picTester.Click += new System.EventHandler(this.picTester_Click);
            // 
            // picModifier
            // 
            this.picModifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picModifier.Image = global::FinanceManager.Properties.Resources.icon_floppy_alt;
            this.picModifier.Location = new System.Drawing.Point(41, 367);
            this.picModifier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picModifier.Name = "picModifier";
            this.picModifier.Size = new System.Drawing.Size(36, 41);
            this.picModifier.TabIndex = 83;
            this.picModifier.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.picModifier, "Enregistrer");
            this.picModifier.Click += new System.EventHandler(this.picModifier_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 422);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblTry);
            this.Controls.Add(this.picTester);
            this.Controls.Add(this.picModifier);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlBaodDroit);
            this.Controls.Add(this.pnlBordGauche);
            this.Controls.Add(this.pnlHaut);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.frmParametres_Load);
            this.pnlHaut.ResumeLayout(false);
            this.pnlHaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbServeur.ResumeLayout(false);
            this.tbServeur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picModifier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBaodDroit;
        private System.Windows.Forms.Panel pnlBordGauche;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Panel pnlHaut;
        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbServeur;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label lbldatabase;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.PictureBox picModifier;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.PictureBox picTester;
        private System.Windows.Forms.Label lblTry;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.ToolTip toolTipBtnCtrl;
    }
}