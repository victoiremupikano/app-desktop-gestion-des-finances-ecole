namespace FinanceManager.Views.Payment
{
    partial class frmAddPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPayment));
            this.gpTransactAChat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.dteOperation = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMt = new System.Windows.Forms.Label();
            this.txtWording = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelTaux = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataOperUp = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnToModify = new System.Windows.Forms.Button();
            this.btnSaved = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoard = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gpTransactAChat.SuspendLayout();
            this.tableLayoutPanelTaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOperUp)).BeginInit();
            this.SuspendLayout();
            // 
            // gpTransactAChat
            // 
            this.gpTransactAChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpTransactAChat.Controls.Add(this.label2);
            this.gpTransactAChat.Controls.Add(this.txtMontant);
            this.gpTransactAChat.Controls.Add(this.dteOperation);
            this.gpTransactAChat.Controls.Add(this.lblDate);
            this.gpTransactAChat.Controls.Add(this.lblMt);
            this.gpTransactAChat.Controls.Add(this.txtWording);
            this.gpTransactAChat.Location = new System.Drawing.Point(26, 8);
            this.gpTransactAChat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gpTransactAChat.Name = "gpTransactAChat";
            this.gpTransactAChat.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gpTransactAChat.Size = new System.Drawing.Size(856, 139);
            this.gpTransactAChat.TabIndex = 165;
            this.gpTransactAChat.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 189;
            this.label2.Text = "Montant :";
            // 
            // txtMontant
            // 
            this.txtMontant.BackColor = System.Drawing.SystemColors.Control;
            this.txtMontant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontant.Location = new System.Drawing.Point(105, 64);
            this.txtMontant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(310, 27);
            this.txtMontant.TabIndex = 188;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // dteOperation
            // 
            this.dteOperation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteOperation.Location = new System.Drawing.Point(105, 27);
            this.dteOperation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dteOperation.Name = "dteOperation";
            this.dteOperation.Size = new System.Drawing.Size(310, 27);
            this.dteOperation.TabIndex = 183;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(35, 25);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 21);
            this.lblDate.TabIndex = 182;
            this.lblDate.Text = "Date :";
            // 
            // lblMt
            // 
            this.lblMt.AutoSize = true;
            this.lblMt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMt.ForeColor = System.Drawing.Color.Black;
            this.lblMt.Location = new System.Drawing.Point(427, 25);
            this.lblMt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMt.Name = "lblMt";
            this.lblMt.Size = new System.Drawing.Size(152, 21);
            this.lblMt.TabIndex = 140;
            this.lblMt.Text = "Operateur/Libelé :";
            // 
            // txtWording
            // 
            this.txtWording.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWording.BackColor = System.Drawing.SystemColors.Control;
            this.txtWording.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWording.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWording.Location = new System.Drawing.Point(591, 27);
            this.txtWording.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtWording.Multiline = true;
            this.txtWording.Name = "txtWording";
            this.txtWording.Size = new System.Drawing.Size(253, 85);
            this.txtWording.TabIndex = 132;
            // 
            // tableLayoutPanelTaux
            // 
            this.tableLayoutPanelTaux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelTaux.ColumnCount = 1;
            this.tableLayoutPanelTaux.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.00529F));
            this.tableLayoutPanelTaux.Controls.Add(this.dgvDataOperUp, 0, 0);
            this.tableLayoutPanelTaux.Location = new System.Drawing.Point(20, 158);
            this.tableLayoutPanelTaux.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tableLayoutPanelTaux.Name = "tableLayoutPanelTaux";
            this.tableLayoutPanelTaux.RowCount = 1;
            this.tableLayoutPanelTaux.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTaux.Size = new System.Drawing.Size(861, 187);
            this.tableLayoutPanelTaux.TabIndex = 164;
            // 
            // dgvDataOperUp
            // 
            this.dgvDataOperUp.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDataOperUp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataOperUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDataOperUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataOperUp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataOperUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataOperUp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column10,
            this.Column12});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataOperUp.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataOperUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataOperUp.Location = new System.Drawing.Point(4, 5);
            this.dgvDataOperUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDataOperUp.Name = "dgvDataOperUp";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataOperUp.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvDataOperUp.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDataOperUp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataOperUp.Size = new System.Drawing.Size(853, 177);
            this.dgvDataOperUp.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.FillWeight = 150F;
            this.dataGridViewTextBoxColumn5.HeaderText = "ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Noms";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn7.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Niveau";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Trimestre";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mt a payer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mt payer";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Solde";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "fk_trimestry";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "fk_operator";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
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
            this.btnToModify.Location = new System.Drawing.Point(668, 355);
            this.btnToModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToModify.Name = "btnToModify";
            this.btnToModify.Size = new System.Drawing.Size(88, 32);
            this.btnToModify.TabIndex = 167;
            this.btnToModify.Text = "   Modifier";
            this.btnToModify.UseVisualStyleBackColor = false;
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
            this.btnSaved.Location = new System.Drawing.Point(476, 355);
            this.btnSaved.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.Size = new System.Drawing.Size(88, 32);
            this.btnSaved.TabIndex = 169;
            this.btnSaved.Text = "   Ajouter";
            this.btnSaved.UseVisualStyleBackColor = false;
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
            this.btnNew.Location = new System.Drawing.Point(572, 355);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 32);
            this.btnNew.TabIndex = 166;
            this.btnNew.Text = "   Nouveau";
            this.btnNew.UseVisualStyleBackColor = false;
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
            this.btnLoard.Location = new System.Drawing.Point(380, 355);
            this.btnLoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoard.Name = "btnLoard";
            this.btnLoard.Size = new System.Drawing.Size(88, 32);
            this.btnLoard.TabIndex = 170;
            this.btnLoard.Text = "    Charger";
            this.btnLoard.UseVisualStyleBackColor = false;
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
            this.btnDelete.Location = new System.Drawing.Point(764, 355);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 32);
            this.btnDelete.TabIndex = 168;
            this.btnDelete.Text = "   Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmAddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 401);
            this.Controls.Add(this.btnToModify);
            this.Controls.Add(this.btnSaved);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoard);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gpTransactAChat);
            this.Controls.Add(this.tableLayoutPanelTaux);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmAddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail de l\'opération";
            this.Load += new System.EventHandler(this.frmBoxDetail_Load);
            this.gpTransactAChat.ResumeLayout(false);
            this.gpTransactAChat.PerformLayout();
            this.tableLayoutPanelTaux.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataOperUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpTransactAChat;
        private System.Windows.Forms.DateTimePicker dteOperation;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblMt;
        private System.Windows.Forms.TextBox txtWording;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTaux;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.DataGridView dgvDataOperUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnToModify;
        private System.Windows.Forms.Button btnSaved;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoard;
        private System.Windows.Forms.Button btnDelete;
    }
}