namespace FinanceManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHautMenu = new System.Windows.Forms.Panel();
            this.lblTimeCurrent = new System.Windows.Forms.Label();
            this.pnlBasArrivage = new System.Windows.Forms.Panel();
            this.btnArrivage = new System.Windows.Forms.Button();
            this.btbOtherOption = new System.Windows.Forms.Button();
            this.pnlBasFactures = new System.Windows.Forms.Panel();
            this.pnlBasRapports = new System.Windows.Forms.Panel();
            this.pnlBasProduits = new System.Windows.Forms.Panel();
            this.btnFactures = new System.Windows.Forms.Button();
            this.btnRapport = new System.Windows.Forms.Button();
            this.btnMolecules = new System.Windows.Forms.Button();
            this.pnlCentraleFrmmain = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnMessager = new System.Windows.Forms.Button();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMenuPrincipale = new System.Windows.Forms.MenuStrip();
            this.arrivageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moleculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.EtiquetteUserCon = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsplUserConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStripEtatSoft = new System.Windows.Forms.StatusStrip();
            this.annéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trimestreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHautMenu.SuspendLayout();
            this.pnlCentraleFrmmain.SuspendLayout();
            this.menuStripMenuPrincipale.SuspendLayout();
            this.statusStripEtatSoft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHautMenu
            // 
            this.pnlHautMenu.Controls.Add(this.lblTimeCurrent);
            this.pnlHautMenu.Controls.Add(this.pnlBasArrivage);
            this.pnlHautMenu.Controls.Add(this.btnArrivage);
            this.pnlHautMenu.Controls.Add(this.btbOtherOption);
            this.pnlHautMenu.Controls.Add(this.pnlBasFactures);
            this.pnlHautMenu.Controls.Add(this.pnlBasRapports);
            this.pnlHautMenu.Controls.Add(this.pnlBasProduits);
            this.pnlHautMenu.Controls.Add(this.btnFactures);
            this.pnlHautMenu.Controls.Add(this.btnRapport);
            this.pnlHautMenu.Controls.Add(this.btnMolecules);
            this.pnlHautMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHautMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlHautMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHautMenu.Name = "pnlHautMenu";
            this.pnlHautMenu.Size = new System.Drawing.Size(1262, 73);
            this.pnlHautMenu.TabIndex = 0;
            // 
            // lblTimeCurrent
            // 
            this.lblTimeCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimeCurrent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCurrent.Location = new System.Drawing.Point(1000, 9);
            this.lblTimeCurrent.Name = "lblTimeCurrent";
            this.lblTimeCurrent.Size = new System.Drawing.Size(179, 57);
            this.lblTimeCurrent.TabIndex = 118;
            this.lblTimeCurrent.Text = "TIME";
            this.lblTimeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlBasArrivage
            // 
            this.pnlBasArrivage.BackColor = System.Drawing.Color.Black;
            this.pnlBasArrivage.Location = new System.Drawing.Point(9, 63);
            this.pnlBasArrivage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBasArrivage.Name = "pnlBasArrivage";
            this.pnlBasArrivage.Size = new System.Drawing.Size(147, 6);
            this.pnlBasArrivage.TabIndex = 10;
            // 
            // btnArrivage
            // 
            this.btnArrivage.FlatAppearance.BorderSize = 0;
            this.btnArrivage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrivage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrivage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnArrivage.Image = global::FinanceManager.Properties.Resources.arrow_expand_alt3;
            this.btnArrivage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArrivage.Location = new System.Drawing.Point(3, 4);
            this.btnArrivage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrivage.Name = "btnArrivage";
            this.btnArrivage.Size = new System.Drawing.Size(151, 57);
            this.btnArrivage.TabIndex = 0;
            this.btnArrivage.Text = "           Apprenants   ";
            this.btnArrivage.UseVisualStyleBackColor = true;
            this.btnArrivage.Click += new System.EventHandler(this.btnArrivage_Click);
            // 
            // btbOtherOption
            // 
            this.btbOtherOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btbOtherOption.BackgroundImage = global::FinanceManager.Properties.Resources.icone_menu;
            this.btbOtherOption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbOtherOption.FlatAppearance.BorderSize = 0;
            this.btbOtherOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbOtherOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbOtherOption.ForeColor = System.Drawing.SystemColors.Control;
            this.btbOtherOption.Location = new System.Drawing.Point(1185, 9);
            this.btbOtherOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbOtherOption.Name = "btbOtherOption";
            this.btbOtherOption.Size = new System.Drawing.Size(61, 57);
            this.btbOtherOption.TabIndex = 8;
            this.btbOtherOption.UseVisualStyleBackColor = true;
            // 
            // pnlBasFactures
            // 
            this.pnlBasFactures.BackColor = System.Drawing.Color.Black;
            this.pnlBasFactures.Location = new System.Drawing.Point(303, 63);
            this.pnlBasFactures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBasFactures.Name = "pnlBasFactures";
            this.pnlBasFactures.Size = new System.Drawing.Size(137, 6);
            this.pnlBasFactures.TabIndex = 3;
            // 
            // pnlBasRapports
            // 
            this.pnlBasRapports.BackColor = System.Drawing.Color.Black;
            this.pnlBasRapports.Location = new System.Drawing.Point(445, 63);
            this.pnlBasRapports.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBasRapports.Name = "pnlBasRapports";
            this.pnlBasRapports.Size = new System.Drawing.Size(137, 6);
            this.pnlBasRapports.TabIndex = 3;
            // 
            // pnlBasProduits
            // 
            this.pnlBasProduits.BackColor = System.Drawing.Color.Black;
            this.pnlBasProduits.Location = new System.Drawing.Point(160, 63);
            this.pnlBasProduits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBasProduits.Name = "pnlBasProduits";
            this.pnlBasProduits.Size = new System.Drawing.Size(137, 6);
            this.pnlBasProduits.TabIndex = 3;
            // 
            // btnFactures
            // 
            this.btnFactures.FlatAppearance.BorderSize = 0;
            this.btnFactures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactures.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactures.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFactures.Image = global::FinanceManager.Properties.Resources.icon_id_alt;
            this.btnFactures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactures.Location = new System.Drawing.Point(303, 4);
            this.btnFactures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFactures.Name = "btnFactures";
            this.btnFactures.Size = new System.Drawing.Size(137, 57);
            this.btnFactures.TabIndex = 2;
            this.btnFactures.Text = "        Payements";
            this.btnFactures.UseVisualStyleBackColor = true;
            this.btnFactures.Click += new System.EventHandler(this.btnFactures_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.FlatAppearance.BorderSize = 0;
            this.btnRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRapport.Image = global::FinanceManager.Properties.Resources.icon_cart;
            this.btnRapport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapport.Location = new System.Drawing.Point(445, 4);
            this.btnRapport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Size = new System.Drawing.Size(137, 57);
            this.btnRapport.TabIndex = 4;
            this.btnRapport.Text = "            Rapport";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // btnMolecules
            // 
            this.btnMolecules.FlatAppearance.BorderSize = 0;
            this.btnMolecules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMolecules.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMolecules.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMolecules.Image = global::FinanceManager.Properties.Resources.icon_toolbox;
            this.btnMolecules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMolecules.Location = new System.Drawing.Point(160, 4);
            this.btnMolecules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMolecules.Name = "btnMolecules";
            this.btnMolecules.Size = new System.Drawing.Size(137, 57);
            this.btnMolecules.TabIndex = 1;
            this.btnMolecules.Text = "        Comptes";
            this.btnMolecules.UseVisualStyleBackColor = true;
            this.btnMolecules.Click += new System.EventHandler(this.btnMolecules_Click);
            // 
            // pnlCentraleFrmmain
            // 
            this.pnlCentraleFrmmain.Controls.Add(this.btnConfig);
            this.pnlCentraleFrmmain.Controls.Add(this.btnMessager);
            this.pnlCentraleFrmmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentraleFrmmain.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlCentraleFrmmain.Location = new System.Drawing.Point(0, 97);
            this.pnlCentraleFrmmain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCentraleFrmmain.Name = "pnlCentraleFrmmain";
            this.pnlCentraleFrmmain.Size = new System.Drawing.Size(1262, 582);
            this.pnlCentraleFrmmain.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.Lime;
            this.btnConfig.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfig.FlatAppearance.BorderSize = 2;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::FinanceManager.Properties.Resources.database;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfig.Location = new System.Drawing.Point(1109, 176);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(98, 95);
            this.btnConfig.TabIndex = 13;
            this.btnConfig.Text = "Config ONLINE";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnMessager
            // 
            this.btnMessager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMessager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMessager.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMessager.FlatAppearance.BorderSize = 2;
            this.btnMessager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessager.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessager.ForeColor = System.Drawing.Color.White;
            this.btnMessager.Image = global::FinanceManager.Properties.Resources.Message;
            this.btnMessager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMessager.Location = new System.Drawing.Point(1109, 73);
            this.btnMessager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMessager.Name = "btnMessager";
            this.btnMessager.Size = new System.Drawing.Size(98, 95);
            this.btnMessager.TabIndex = 14;
            this.btnMessager.Text = "Messagerie";
            this.btnMessager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMessager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMessager.UseVisualStyleBackColor = false;
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopteToolStripMenuItem,
            this.annéeToolStripMenuItem,
            this.trimestreToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.outilsToolStripMenuItem.Text = "Paramètres";
            this.outilsToolStripMenuItem.Click += new System.EventHandler(this.outilsToolStripMenuItem_Click);
            // 
            // CopteToolStripMenuItem
            // 
            this.CopteToolStripMenuItem.Name = "CopteToolStripMenuItem";
            this.CopteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CopteToolStripMenuItem.Text = "Utilisateur";
            this.CopteToolStripMenuItem.Click += new System.EventHandler(this.CopteToolStripMenuItem_Click);
            // 
            // menuStripMenuPrincipale
            // 
            this.menuStripMenuPrincipale.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.menuStripMenuPrincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outilsToolStripMenuItem,
            this.arrivageToolStripMenuItem,
            this.moleculesToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.rapportsToolStripMenuItem});
            this.menuStripMenuPrincipale.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenuPrincipale.Name = "menuStripMenuPrincipale";
            this.menuStripMenuPrincipale.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMenuPrincipale.Size = new System.Drawing.Size(1262, 24);
            this.menuStripMenuPrincipale.TabIndex = 1;
            this.menuStripMenuPrincipale.Text = "menuStrip1";
            // 
            // arrivageToolStripMenuItem
            // 
            this.arrivageToolStripMenuItem.Name = "arrivageToolStripMenuItem";
            this.arrivageToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.arrivageToolStripMenuItem.Text = "Apprenants";
            this.arrivageToolStripMenuItem.Click += new System.EventHandler(this.arrivageToolStripMenuItem_Click);
            // 
            // moleculesToolStripMenuItem
            // 
            this.moleculesToolStripMenuItem.Name = "moleculesToolStripMenuItem";
            this.moleculesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.moleculesToolStripMenuItem.Text = "Comptes";
            this.moleculesToolStripMenuItem.Click += new System.EventHandler(this.moleculesToolStripMenuItem_Click);
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.facturesToolStripMenuItem.Text = "Payement";
            this.facturesToolStripMenuItem.Click += new System.EventHandler(this.facturesToolStripMenuItem_Click);
            // 
            // rapportsToolStripMenuItem
            // 
            this.rapportsToolStripMenuItem.Name = "rapportsToolStripMenuItem";
            this.rapportsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.rapportsToolStripMenuItem.Text = "Rapports";
            this.rapportsToolStripMenuItem.Click += new System.EventHandler(this.rapportsToolStripMenuItem_Click);
            // 
            // timerPrincipal
            // 
            this.timerPrincipal.Interval = 1000;
            this.timerPrincipal.Tick += new System.EventHandler(this.timerPrincipal_Tick);
            // 
            // EtiquetteUserCon
            // 
            this.EtiquetteUserCon.BackColor = System.Drawing.SystemColors.Control;
            this.EtiquetteUserCon.Name = "EtiquetteUserCon";
            this.EtiquetteUserCon.Size = new System.Drawing.Size(146, 17);
            this.EtiquetteUserCon.Text = "Utulisateur connécter : ";
            // 
            // tsplUserConnected
            // 
            this.tsplUserConnected.BackColor = System.Drawing.SystemColors.Control;
            this.tsplUserConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsplUserConnected.ForeColor = System.Drawing.Color.DimGray;
            this.tsplUserConnected.Name = "tsplUserConnected";
            this.tsplUserConnected.Size = new System.Drawing.Size(15, 17);
            this.tsplUserConnected.Text = "?";
            // 
            // statusStripEtatSoft
            // 
            this.statusStripEtatSoft.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripEtatSoft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EtiquetteUserCon,
            this.tsplUserConnected});
            this.statusStripEtatSoft.Location = new System.Drawing.Point(0, 679);
            this.statusStripEtatSoft.Name = "statusStripEtatSoft";
            this.statusStripEtatSoft.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripEtatSoft.Size = new System.Drawing.Size(1262, 22);
            this.statusStripEtatSoft.TabIndex = 79;
            this.statusStripEtatSoft.Text = "statusStripInfoLogicielle";
            // 
            // annéeToolStripMenuItem
            // 
            this.annéeToolStripMenuItem.Name = "annéeToolStripMenuItem";
            this.annéeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.annéeToolStripMenuItem.Text = "Année";
            // 
            // trimestreToolStripMenuItem
            // 
            this.trimestreToolStripMenuItem.Name = "trimestreToolStripMenuItem";
            this.trimestreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trimestreToolStripMenuItem.Text = "Trimestre";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1262, 701);
            this.Controls.Add(this.pnlCentraleFrmmain);
            this.Controls.Add(this.statusStripEtatSoft);
            this.Controls.Add(this.pnlHautMenu);
            this.Controls.Add(this.menuStripMenuPrincipale);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMenuPrincipale;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des finances";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlHautMenu.ResumeLayout(false);
            this.pnlCentraleFrmmain.ResumeLayout(false);
            this.menuStripMenuPrincipale.ResumeLayout(false);
            this.menuStripMenuPrincipale.PerformLayout();
            this.statusStripEtatSoft.ResumeLayout(false);
            this.statusStripEtatSoft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHautMenu;
        private System.Windows.Forms.Button btnFactures;
        private System.Windows.Forms.Button btnRapport;
        private System.Windows.Forms.Button btnMolecules;
        private System.Windows.Forms.Panel pnlCentraleFrmmain;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopteToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMenuPrincipale;
        private System.Windows.Forms.ToolStripMenuItem rapportsToolStripMenuItem;
        private System.Windows.Forms.Button btbOtherOption;
        private System.Windows.Forms.Button btnArrivage;
        internal System.Windows.Forms.Label lblTimeCurrent;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnMessager;
        public System.Windows.Forms.Panel pnlBasFactures;
        public System.Windows.Forms.Panel pnlBasRapports;
        public System.Windows.Forms.Panel pnlBasProduits;
        public System.Windows.Forms.Panel pnlBasArrivage;
        private System.Windows.Forms.ToolStripStatusLabel EtiquetteUserCon;
        private System.Windows.Forms.ToolStripStatusLabel tsplUserConnected;
        private System.Windows.Forms.StatusStrip statusStripEtatSoft;
        private System.Windows.Forms.ToolStripMenuItem arrivageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moleculesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem annéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trimestreToolStripMenuItem;
    }
}