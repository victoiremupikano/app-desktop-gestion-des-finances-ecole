namespace Commercial_Management.Services.FRM
{
    partial class frmVerifyPWD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerifyPWD));
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.rbAdminCpt = new System.Windows.Forms.RadioButton();
            this.rbSimpleCpt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(12, 34);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(125, 17);
            this.lblUserName.TabIndex = 139;
            this.lblUserName.Text = "Nom d\'utilisateur :";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(143, 28);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(258, 27);
            this.txtUserName.TabIndex = 138;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(35, 66);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 17);
            this.lblPassword.TabIndex = 140;
            this.lblPassword.Text = "Mot de passe :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(143, 63);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(258, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerify.Location = new System.Drawing.Point(301, 157);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 27);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "Verifier";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // rbAdminCpt
            // 
            this.rbAdminCpt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbAdminCpt.AutoSize = true;
            this.rbAdminCpt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdminCpt.Location = new System.Drawing.Point(143, 98);
            this.rbAdminCpt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAdminCpt.Name = "rbAdminCpt";
            this.rbAdminCpt.Size = new System.Drawing.Size(119, 21);
            this.rbAdminCpt.TabIndex = 2;
            this.rbAdminCpt.TabStop = true;
            this.rbAdminCpt.Text = "Administrateur";
            this.rbAdminCpt.UseVisualStyleBackColor = true;
            this.rbAdminCpt.CheckedChanged += new System.EventHandler(this.rbAdminCpt_CheckedChanged_1);
            // 
            // rbSimpleCpt
            // 
            this.rbSimpleCpt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbSimpleCpt.AutoSize = true;
            this.rbSimpleCpt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimpleCpt.Location = new System.Drawing.Point(268, 98);
            this.rbSimpleCpt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSimpleCpt.Name = "rbSimpleCpt";
            this.rbSimpleCpt.Size = new System.Drawing.Size(132, 21);
            this.rbSimpleCpt.TabIndex = 3;
            this.rbSimpleCpt.TabStop = true;
            this.rbSimpleCpt.Text = "Utilisateur simple";
            this.rbSimpleCpt.UseVisualStyleBackColor = true;
            this.rbSimpleCpt.CheckedChanged += new System.EventHandler(this.rbSimpleCpt_CheckedChanged_1);
            // 
            // frmVerifyPWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 196);
            this.Controls.Add(this.rbAdminCpt);
            this.Controls.Add(this.rbSimpleCpt);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerifyPWD";
            this.Text = "Vérification du mot de passe avant modification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnVerify;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.RadioButton rbAdminCpt;
        public System.Windows.Forms.RadioButton rbSimpleCpt;
    }
}