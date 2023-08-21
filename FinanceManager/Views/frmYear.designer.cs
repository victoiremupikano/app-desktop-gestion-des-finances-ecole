namespace FinanceManager.Views
{
    partial class frmYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYear));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtRechercheArriv = new System.Windows.Forms.TextBox();
            this.notifyIconArrivage = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPageA1 = new System.Windows.Forms.TabPage();
            this.txtResearchAdd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gpArrivGen = new System.Windows.Forms.GroupBox();
            this.dteEnd = new System.Windows.Forms.DateTimePicker();
            this.lblAu = new System.Windows.Forms.Label();
            this.dteStart = new System.Windows.Forms.DateTimePicker();
            this.lblDu = new System.Windows.Forms.Label();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.txtWording = new System.Windows.Forms.TextBox();
            this.gpEncadrdgvArriv = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripAddArrival = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlArr = new System.Windows.Forms.TabControl();
            this.toolTipBtnCtrl = new System.Windows.Forms.ToolTip(this.components);
            this.picReseachAdd = new System.Windows.Forms.PictureBox();
            this.btnToModify = new System.Windows.Forms.Button();
            this.btnSaved = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoard = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picSearchTLP = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.tabPageA1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gpArrivGen.SuspendLayout();
            this.gpEncadrdgvArriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.contextMenuStripAddArrival.SuspendLayout();
            this.tabControlArr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReseachAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchTLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRechercheArriv
            // 
            this.txtRechercheArriv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRechercheArriv.BackColor = System.Drawing.SystemColors.Control;
            this.txtRechercheArriv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRechercheArriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercheArriv.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRechercheArriv.Location = new System.Drawing.Point(57, 405);
            this.txtRechercheArriv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRechercheArriv.Name = "txtRechercheArriv";
            this.txtRechercheArriv.Size = new System.Drawing.Size(381, 17);
            this.txtRechercheArriv.TabIndex = 141;
            this.txtRechercheArriv.Click += new System.EventHandler(this.txtRechercheArriv_Click);
            // 
            // notifyIconArrivage
            // 
            this.notifyIconArrivage.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconArrivage.Icon")));
            this.notifyIconArrivage.Text = "Arrivage";
            this.notifyIconArrivage.Visible = true;
            // 
            // tabPageA1
            // 
            this.tabPageA1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageA1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageA1.Controls.Add(this.picReseachAdd);
            this.tabPageA1.Controls.Add(this.txtResearchAdd);
            this.tabPageA1.Controls.Add(this.btnToModify);
            this.tabPageA1.Controls.Add(this.btnSaved);
            this.tabPageA1.Controls.Add(this.btnNew);
            this.tabPageA1.Controls.Add(this.btnLoard);
            this.tabPageA1.Controls.Add(this.btnDelete);
            this.tabPageA1.Controls.Add(this.tableLayoutPanel2);
            this.tabPageA1.Location = new System.Drawing.Point(4, 30);
            this.tabPageA1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageA1.Name = "tabPageA1";
            this.tabPageA1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageA1.Size = new System.Drawing.Size(903, 360);
            this.tabPageA1.TabIndex = 0;
            this.tabPageA1.Text = " Année     ";
            // 
            // txtResearchAdd
            // 
            this.txtResearchAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtResearchAdd.BackColor = System.Drawing.SystemColors.Control;
            this.txtResearchAdd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResearchAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtResearchAdd.Location = new System.Drawing.Point(50, 319);
            this.txtResearchAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResearchAdd.Name = "txtResearchAdd";
            this.txtResearchAdd.Size = new System.Drawing.Size(315, 20);
            this.txtResearchAdd.TabIndex = 240;
            this.toolTipBtnCtrl.SetToolTip(this.txtResearchAdd, "Recherche");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.10753F));
            this.tableLayoutPanel2.Controls.Add(this.gpArrivGen, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 7);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(892, 301);
            this.tableLayoutPanel2.TabIndex = 132;
            // 
            // gpArrivGen
            // 
            this.gpArrivGen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpArrivGen.Controls.Add(this.dteEnd);
            this.gpArrivGen.Controls.Add(this.lblAu);
            this.gpArrivGen.Controls.Add(this.dteStart);
            this.gpArrivGen.Controls.Add(this.lblDu);
            this.gpArrivGen.Controls.Add(this.chkStatus);
            this.gpArrivGen.Controls.Add(this.txtWording);
            this.gpArrivGen.Controls.Add(this.gpEncadrdgvArriv);
            this.gpArrivGen.Location = new System.Drawing.Point(3, 4);
            this.gpArrivGen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpArrivGen.Name = "gpArrivGen";
            this.gpArrivGen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpArrivGen.Size = new System.Drawing.Size(886, 293);
            this.gpArrivGen.TabIndex = 1;
            this.gpArrivGen.TabStop = false;
            this.gpArrivGen.Text = "Ajouter une nouvelle année";
            // 
            // dteEnd
            // 
            this.dteEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dteEnd.Location = new System.Drawing.Point(589, 38);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Size = new System.Drawing.Size(291, 27);
            this.dteEnd.TabIndex = 138;
            // 
            // lblAu
            // 
            this.lblAu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAu.AutoSize = true;
            this.lblAu.Location = new System.Drawing.Point(551, 39);
            this.lblAu.Name = "lblAu";
            this.lblAu.Size = new System.Drawing.Size(33, 21);
            this.lblAu.TabIndex = 137;
            this.lblAu.Text = "Au";
            // 
            // dteStart
            // 
            this.dteStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dteStart.Location = new System.Drawing.Point(254, 38);
            this.dteStart.Name = "dteStart";
            this.dteStart.Size = new System.Drawing.Size(291, 27);
            this.dteStart.TabIndex = 136;
            // 
            // lblDu
            // 
            this.lblDu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDu.AutoSize = true;
            this.lblDu.Location = new System.Drawing.Point(216, 39);
            this.lblDu.Name = "lblDu";
            this.lblDu.Size = new System.Drawing.Size(32, 21);
            this.lblDu.TabIndex = 135;
            this.lblDu.Text = "Du";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(8, 38);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(142, 25);
            this.chkStatus.TabIndex = 134;
            this.chkStatus.Text = "Cochez si actif";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtWording
            // 
            this.txtWording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWording.BackColor = System.Drawing.SystemColors.Control;
            this.txtWording.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWording.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWording.Location = new System.Drawing.Point(156, 36);
            this.txtWording.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWording.Name = "txtWording";
            this.txtWording.Size = new System.Drawing.Size(54, 31);
            this.txtWording.TabIndex = 132;
            this.toolTipBtnCtrl.SetToolTip(this.txtWording, "Désignation de l\'arrivage");
            this.txtWording.Click += new System.EventHandler(this.txtdesignArriv_Click);
            // 
            // gpEncadrdgvArriv
            // 
            this.gpEncadrdgvArriv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpEncadrdgvArriv.Controls.Add(this.dgvData);
            this.gpEncadrdgvArriv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpEncadrdgvArriv.Location = new System.Drawing.Point(7, 75);
            this.gpEncadrdgvArriv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpEncadrdgvArriv.Name = "gpEncadrdgvArriv";
            this.gpEncadrdgvArriv.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gpEncadrdgvArriv.Size = new System.Drawing.Size(873, 210);
            this.gpEncadrdgvArriv.TabIndex = 44;
            this.gpEncadrdgvArriv.TabStop = false;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgvData.ContextMenuStrip = this.contextMenuStripAddArrival;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(3, 24);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(867, 182);
            this.dgvData.TabIndex = 13;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataAddArrival_CellClick);
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvDataAddArrival_SelectionChanged);
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Designation";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Du";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Au";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Etat";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // contextMenuStripAddArrival
            // 
            this.contextMenuStripAddArrival.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemModify});
            this.contextMenuStripAddArrival.Name = "contextMenuStripRemplissage";
            this.contextMenuStripAddArrival.Size = new System.Drawing.Size(209, 26);
            // 
            // toolStripMenuItemModify
            // 
            this.toolStripMenuItemModify.Name = "toolStripMenuItemModify";
            this.toolStripMenuItemModify.Size = new System.Drawing.Size(208, 22);
            this.toolStripMenuItemModify.Text = "Modifier l\'enregistrement";
            this.toolStripMenuItemModify.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabControlArr
            // 
            this.tabControlArr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlArr.Controls.Add(this.tabPageA1);
            this.tabControlArr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlArr.Location = new System.Drawing.Point(1, 37);
            this.tabControlArr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlArr.Name = "tabControlArr";
            this.tabControlArr.SelectedIndex = 0;
            this.tabControlArr.Size = new System.Drawing.Size(911, 394);
            this.tabControlArr.TabIndex = 239;
            // 
            // picReseachAdd
            // 
            this.picReseachAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picReseachAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picReseachAdd.Image = global::FinanceManager.Properties.Resources.Search_24x24;
            this.picReseachAdd.Location = new System.Drawing.Point(13, 316);
            this.picReseachAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picReseachAdd.Name = "picReseachAdd";
            this.picReseachAdd.Size = new System.Drawing.Size(27, 28);
            this.picReseachAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReseachAdd.TabIndex = 241;
            this.picReseachAdd.TabStop = false;
            // 
            // btnToModify
            // 
            this.btnToModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToModify.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnToModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnToModify.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToModify.ForeColor = System.Drawing.Color.Black;
            this.btnToModify.Image = global::FinanceManager.Properties.Resources.Edit_16x16;
            this.btnToModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToModify.Location = new System.Drawing.Point(699, 316);
            this.btnToModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnToModify.Name = "btnToModify";
            this.btnToModify.Size = new System.Drawing.Size(84, 32);
            this.btnToModify.TabIndex = 134;
            this.btnToModify.Text = "   Modifier";
            this.btnToModify.UseVisualStyleBackColor = false;
            this.btnToModify.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSaved
            // 
            this.btnSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaved.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaved.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.ForeColor = System.Drawing.Color.Black;
            this.btnSaved.Image = global::FinanceManager.Properties.Resources.Add_16x16;
            this.btnSaved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaved.Location = new System.Drawing.Point(516, 316);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(81, 32);
            this.btnSaved.TabIndex = 136;
            this.btnSaved.Text = "   Ajouter";
            this.btnSaved.UseVisualStyleBackColor = false;
            this.btnSaved.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = global::FinanceManager.Properties.Resources.New_16x16;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(603, 316);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(90, 32);
            this.btnNew.TabIndex = 133;
            this.btnNew.Text = "   Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLoard
            // 
            this.btnLoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoard.ForeColor = System.Drawing.Color.Black;
            this.btnLoard.Image = global::FinanceManager.Properties.Resources.Download_16x16;
            this.btnLoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoard.Location = new System.Drawing.Point(422, 316);
            this.btnLoard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoard.Name = "btnLoard";
            this.btnLoard.Size = new System.Drawing.Size(88, 32);
            this.btnLoard.TabIndex = 137;
            this.btnLoard.Text = "    Charger";
            this.btnLoard.UseVisualStyleBackColor = false;
            this.btnLoard.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = global::FinanceManager.Properties.Resources.Delete_16x16;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(789, 316);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 32);
            this.btnDelete.TabIndex = 135;
            this.btnDelete.Text = "   Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // picSearchTLP
            // 
            this.picSearchTLP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSearchTLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearchTLP.Location = new System.Drawing.Point(21, 403);
            this.picSearchTLP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picSearchTLP.Name = "picSearchTLP";
            this.picSearchTLP.Size = new System.Drawing.Size(27, 28);
            this.picSearchTLP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearchTLP.TabIndex = 238;
            this.picSearchTLP.TabStop = false;
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
            // frmYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 440);
            this.Controls.Add(this.tabControlArr);
            this.Controls.Add(this.picSearchTLP);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.txtRechercheArriv);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmYear";
            this.Text = "Gestion des arrivages";
            this.Load += new System.EventHandler(this.frmArrivage_Load);
            this.tabPageA1.ResumeLayout(false);
            this.tabPageA1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gpArrivGen.ResumeLayout(false);
            this.gpArrivGen.PerformLayout();
            this.gpEncadrdgvArriv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.contextMenuStripAddArrival.ResumeLayout(false);
            this.tabControlArr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picReseachAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchTLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.TextBox txtRechercheArriv;
        private System.Windows.Forms.PictureBox picSearchTLP;
        private System.Windows.Forms.NotifyIcon notifyIconArrivage;
        private System.Windows.Forms.TabPage tabPageA1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gpArrivGen;
        private System.Windows.Forms.TextBox txtWording;
        private System.Windows.Forms.GroupBox gpEncadrdgvArriv;
        private System.Windows.Forms.TabControl tabControlArr;
        private System.Windows.Forms.Button btnToModify;
        private System.Windows.Forms.Button btnSaved;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoard;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAddArrival;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemModify;
        private System.Windows.Forms.PictureBox picReseachAdd;
        private System.Windows.Forms.TextBox txtResearchAdd;
        private System.Windows.Forms.ToolTip toolTipBtnCtrl;
        private System.Windows.Forms.DateTimePicker dteEnd;
        private System.Windows.Forms.Label lblAu;
        private System.Windows.Forms.DateTimePicker dteStart;
        private System.Windows.Forms.Label lblDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}