namespace FinanceManager.Views.Reports
{
    partial class frmReport_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport_View));
            this.crystalReportViewerAll = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerAll
            // 
            this.crystalReportViewerAll.ActiveViewIndex = -1;
            this.crystalReportViewerAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerAll.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerAll.Name = "crystalReportViewerAll";
            this.crystalReportViewerAll.Size = new System.Drawing.Size(901, 401);
            this.crystalReportViewerAll.TabIndex = 241;
            // 
            // frmReport_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 401);
            this.Controls.Add(this.crystalReportViewerAll);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReport_View";
            this.Text = "Visualizer des rapports";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerAll;
    }
}