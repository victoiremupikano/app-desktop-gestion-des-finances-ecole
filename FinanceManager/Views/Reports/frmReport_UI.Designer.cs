namespace FinanceManager.Views.Reports
{
    partial class frmReport_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport_UI));
            this.notifyIconFluxCartExists = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.crystalReportViewerAll = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.toolTipBtnCtrl = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoardRpsPay = new System.Windows.Forms.Button();
            this.btnChooseArrUp = new System.Windows.Forms.Button();
            this.tabPageIReg4 = new System.Windows.Forms.TabPage();
            this.btnLstPaiymentToDya = new System.Windows.Forms.Button();
            this.btnLstPaymentFlux = new System.Windows.Forms.Button();
            this.btnLstStudent = new System.Windows.Forms.Button();
            this.tabPageIReg3 = new System.Windows.Forms.TabPage();
            this.txtNamesArrUp = new System.Windows.Forms.TextBox();
            this.tabControlRps = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.tabPageIReg4.SuspendLayout();
            this.tabPageIReg3.SuspendLayout();
            this.tabControlRps.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconFluxCartExists
            // 
            this.notifyIconFluxCartExists.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconFluxCartExists.Icon")));
            this.notifyIconFluxCartExists.Text = "Arrivage";
            this.notifyIconFluxCartExists.Visible = true;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = global::FinanceManager.Properties.Resources.icon_close;
            this.pictureBoxClose.Location = new System.Drawing.Point(890, 6);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 133;
            this.pictureBoxClose.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.pictureBoxClose, "Fermer");
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.Image = global::FinanceManager.Properties.Resources.icon_minus_06;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(861, 6);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(22, 23);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 134;
            this.pictureBoxMinimize.TabStop = false;
            this.toolTipBtnCtrl.SetToolTip(this.pictureBoxMinimize, "Minimiser");
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            // 
            // crystalReportViewerAll
            // 
            this.crystalReportViewerAll.ActiveViewIndex = -1;
            this.crystalReportViewerAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewerAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerAll.Location = new System.Drawing.Point(6, 141);
            this.crystalReportViewerAll.Name = "crystalReportViewerAll";
            this.crystalReportViewerAll.Size = new System.Drawing.Size(906, 295);
            this.crystalReportViewerAll.TabIndex = 241;
            this.crystalReportViewerAll.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnLoardRpsPay
            // 
            this.btnLoardRpsPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoardRpsPay.BackColor = System.Drawing.Color.White;
            this.btnLoardRpsPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoardRpsPay.FlatAppearance.BorderSize = 0;
            this.btnLoardRpsPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoardRpsPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoardRpsPay.ForeColor = System.Drawing.Color.Black;
            this.btnLoardRpsPay.Image = global::FinanceManager.Properties.Resources.Download_16x16;
            this.btnLoardRpsPay.Location = new System.Drawing.Point(860, 11);
            this.btnLoardRpsPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoardRpsPay.Name = "btnLoardRpsPay";
            this.btnLoardRpsPay.Size = new System.Drawing.Size(35, 36);
            this.btnLoardRpsPay.TabIndex = 363;
            this.toolTipBtnCtrl.SetToolTip(this.btnLoardRpsPay, "Charger");
            this.btnLoardRpsPay.UseVisualStyleBackColor = false;
            this.btnLoardRpsPay.Click += new System.EventHandler(this.btnLoardRpsPay_Click);
            // 
            // btnChooseArrUp
            // 
            this.btnChooseArrUp.BackgroundImage = global::FinanceManager.Properties.Resources.Find_16x16;
            this.btnChooseArrUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseArrUp.FlatAppearance.BorderSize = 0;
            this.btnChooseArrUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseArrUp.Location = new System.Drawing.Point(7, 13);
            this.btnChooseArrUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseArrUp.Name = "btnChooseArrUp";
            this.btnChooseArrUp.Size = new System.Drawing.Size(42, 37);
            this.btnChooseArrUp.TabIndex = 364;
            this.toolTipBtnCtrl.SetToolTip(this.btnChooseArrUp, "Choisissez un arrivage");
            this.btnChooseArrUp.UseVisualStyleBackColor = true;
            this.btnChooseArrUp.Click += new System.EventHandler(this.btnChooseArrUp_Click);
            // 
            // tabPageIReg4
            // 
            this.tabPageIReg4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageIReg4.Controls.Add(this.btnLstPaiymentToDya);
            this.tabPageIReg4.Controls.Add(this.btnLstPaymentFlux);
            this.tabPageIReg4.Controls.Add(this.btnLstStudent);
            this.tabPageIReg4.Location = new System.Drawing.Point(4, 30);
            this.tabPageIReg4.Name = "tabPageIReg4";
            this.tabPageIReg4.Size = new System.Drawing.Size(903, 63);
            this.tabPageIReg4.TabIndex = 4;
            this.tabPageIReg4.Text = " Rapport global    ";
            // 
            // btnLstPaiymentToDya
            // 
            this.btnLstPaiymentToDya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLstPaiymentToDya.BackColor = System.Drawing.Color.White;
            this.btnLstPaiymentToDya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLstPaiymentToDya.FlatAppearance.BorderSize = 0;
            this.btnLstPaiymentToDya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLstPaiymentToDya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLstPaiymentToDya.ForeColor = System.Drawing.Color.Black;
            this.btnLstPaiymentToDya.Image = global::FinanceManager.Properties.Resources.Download_16x16;
            this.btnLstPaiymentToDya.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLstPaiymentToDya.Location = new System.Drawing.Point(213, 13);
            this.btnLstPaiymentToDya.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLstPaiymentToDya.Name = "btnLstPaiymentToDya";
            this.btnLstPaiymentToDya.Size = new System.Drawing.Size(182, 36);
            this.btnLstPaiymentToDya.TabIndex = 356;
            this.btnLstPaiymentToDya.Text = "Paiement du jour";
            this.btnLstPaiymentToDya.UseVisualStyleBackColor = false;
            this.btnLstPaiymentToDya.Click += new System.EventHandler(this.btnLstPaiymentToDya_Click);
            // 
            // btnLstPaymentFlux
            // 
            this.btnLstPaymentFlux.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLstPaymentFlux.BackColor = System.Drawing.Color.White;
            this.btnLstPaymentFlux.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLstPaymentFlux.FlatAppearance.BorderSize = 0;
            this.btnLstPaymentFlux.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLstPaymentFlux.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLstPaymentFlux.ForeColor = System.Drawing.Color.Black;
            this.btnLstPaymentFlux.Image = global::FinanceManager.Properties.Resources.Download_16x16;
            this.btnLstPaymentFlux.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLstPaymentFlux.Location = new System.Drawing.Point(401, 13);
            this.btnLstPaymentFlux.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLstPaymentFlux.Name = "btnLstPaymentFlux";
            this.btnLstPaymentFlux.Size = new System.Drawing.Size(200, 36);
            this.btnLstPaymentFlux.TabIndex = 355;
            this.btnLstPaymentFlux.Text = "Flux de paiement";
            this.btnLstPaymentFlux.UseVisualStyleBackColor = false;
            this.btnLstPaymentFlux.Click += new System.EventHandler(this.btnLstPaymentFlux_Click);
            // 
            // btnLstStudent
            // 
            this.btnLstStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLstStudent.BackColor = System.Drawing.Color.White;
            this.btnLstStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLstStudent.FlatAppearance.BorderSize = 0;
            this.btnLstStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLstStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLstStudent.ForeColor = System.Drawing.Color.Black;
            this.btnLstStudent.Image = global::FinanceManager.Properties.Resources.Download_16x16;
            this.btnLstStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLstStudent.Location = new System.Drawing.Point(7, 13);
            this.btnLstStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLstStudent.Name = "btnLstStudent";
            this.btnLstStudent.Size = new System.Drawing.Size(200, 36);
            this.btnLstStudent.TabIndex = 353;
            this.btnLstStudent.Text = "Liste des apprenants";
            this.btnLstStudent.UseVisualStyleBackColor = false;
            this.btnLstStudent.Click += new System.EventHandler(this.btnLstStudent_Click);
            // 
            // tabPageIReg3
            // 
            this.tabPageIReg3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageIReg3.Controls.Add(this.txtNamesArrUp);
            this.tabPageIReg3.Controls.Add(this.btnChooseArrUp);
            this.tabPageIReg3.Controls.Add(this.btnLoardRpsPay);
            this.tabPageIReg3.Location = new System.Drawing.Point(4, 30);
            this.tabPageIReg3.Name = "tabPageIReg3";
            this.tabPageIReg3.Size = new System.Drawing.Size(903, 63);
            this.tabPageIReg3.TabIndex = 3;
            this.tabPageIReg3.Text = " Rapport de paiement    ";
            // 
            // txtNamesArrUp
            // 
            this.txtNamesArrUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamesArrUp.BackColor = System.Drawing.SystemColors.Control;
            this.txtNamesArrUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamesArrUp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNamesArrUp.Location = new System.Drawing.Point(55, 21);
            this.txtNamesArrUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamesArrUp.Name = "txtNamesArrUp";
            this.txtNamesArrUp.ReadOnly = true;
            this.txtNamesArrUp.Size = new System.Drawing.Size(347, 20);
            this.txtNamesArrUp.TabIndex = 365;
            // 
            // tabControlRps
            // 
            this.tabControlRps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlRps.Controls.Add(this.tabPageIReg4);
            this.tabControlRps.Controls.Add(this.tabPageIReg3);
            this.tabControlRps.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlRps.Location = new System.Drawing.Point(1, 37);
            this.tabControlRps.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlRps.Name = "tabControlRps";
            this.tabControlRps.SelectedIndex = 0;
            this.tabControlRps.Size = new System.Drawing.Size(911, 97);
            this.tabControlRps.TabIndex = 239;
            // 
            // frmReport_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 440);
            this.Controls.Add(this.crystalReportViewerAll);
            this.Controls.Add(this.tabControlRps);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReport_UI";
            this.Text = "Gestion des arrivages";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.tabPageIReg4.ResumeLayout(false);
            this.tabPageIReg3.ResumeLayout(false);
            this.tabPageIReg3.PerformLayout();
            this.tabControlRps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.NotifyIcon notifyIconFluxCartExists;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerAll;
        private System.Windows.Forms.ToolTip toolTipBtnCtrl;
        private System.Windows.Forms.TabPage tabPageIReg4;
        private System.Windows.Forms.Button btnLstPaiymentToDya;
        private System.Windows.Forms.Button btnLstPaymentFlux;
        private System.Windows.Forms.Button btnLstStudent;
        private System.Windows.Forms.TabPage tabPageIReg3;
        private System.Windows.Forms.Button btnLoardRpsPay;
        private System.Windows.Forms.TabControl tabControlRps;
        private System.Windows.Forms.TextBox txtNamesArrUp;
        private System.Windows.Forms.Button btnChooseArrUp;
    }
}