using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceManager.Models;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FinanceManager.Views.Reports
{
    public partial class frmReport_UI : Form
    {
        public string id_arr, id_invoice, id_product;
        Services.convertDate valid = new Services.convertDate();

        public frmReport_UI()
        {
            InitializeComponent();
        }

        //interface servant à verifier si un frm est dejà active
        public static bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name == formType.Name)
                {
                    return true;
                }
            }
            return false;
        }

        //fx pour la mise en application des acces
        private void applyAccess()
        {
            Models.MAccess obj = new Models.MAccess();
            //'Arrivages'
            if (obj.getVal(Services.Session.UserSession["id"], "Rapport", "Arrivages") == false)
            {
                tabControlRps.TabPages.Remove(tabPageIReg1);
            }
            //'Mvt ventes'
            if (obj.getVal(Services.Session.UserSession["id"], "Rapport", "Mvt ventes") == false)
            {
                tabControlRps.TabPages.Remove(tabPageIReg2);
            }
            //'Paiement'
            if (obj.getVal(Services.Session.UserSession["id"], "Rapport", "Paiement") == false)
            {
                tabControlRps.TabPages.Remove(tabPageIReg3);
            }
            //'Etat stock'
            if (obj.getVal(Services.Session.UserSession["id"], "Rapport", "Etat stock") == false)
            {
                tabControlRps.TabPages.Remove(tabPageIReg4);
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region arrivages
        //flux arrivages
        private void btnLoardRegArrF_Click(object sender, EventArgs e)
        {
            // On passe les params
            Models.Reports.rps.id_arr = id_arr;
            Models.Reports.rps.names_arr = txtNamesArrRpsArrF.Text;

            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Flux par arrivage");
            if (obj.message["type"] == "success")
            {
                crystalReportViewerAll.ReportSource = rps;
            }
            else if (obj.message["type"] == "failure")
            {
                msg.getError(obj.message["message"]);
            }
            else
            {
                msg.getError(obj.message["message"]);
            }
        }

        private void btnChooseArrRegArrF_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchArrival frm = new Search.frmSearchArrival())
            {
                //Instaciation du formulaire
                frm.FRM = "REG";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "REG")
                    {
                        txtNamesArrRpsArrF.Text = frm.names;
                        id_arr = frm.id;
                    }
                }
            }
        }
        // inscriptions
        private void btnChooseArrRegArrI_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchArrival frm = new Search.frmSearchArrival())
            {
                //Instaciation du formulaire
                frm.FRM = "REG";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "REG")
                    {
                        txtNamesArrRpsArrI.Text = frm.names;
                        id_arr = frm.id;
                    }
                }
            }
        }   

        private void btnLoardRegArrI_Click(object sender, EventArgs e)
        {
            if (chkEneabledUseDteRpsArrI.Checked == true)
            {
                // On passe les params
                // On passe les params
                Models.Reports.rps.id_arr = id_arr;
                Models.Reports.rps.names_arr = txtNamesArrRpsArrI.Text;
                Models.Reports.rps.dte1 = valid.mysqlDateFormat(dteStartRpsArrI);
                Models.Reports.rps.dte2 = valid.mysqlDateFormat(dteEndRpsArrI);

                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Inscription par arrivage et par dates");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
            else
            {
                // On passe les params
                Models.Reports.rps.id_arr = id_arr;
                Models.Reports.rps.names_arr = txtNamesArrRpsArrI.Text;

                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Inscription par arrivage");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
        }

        #endregion

        #region mvt_ventes
        // produit
        private void btnLoardRegPro_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Liste des produits");
            if (obj.message["type"] == "success")
            {
                crystalReportViewerAll.ReportSource = rps;
            }
            else if (obj.message["type"] == "failure")
            {
                msg.getError(obj.message["message"]);
            }
            else
            {
                msg.getError(obj.message["message"]);
            }
        }
        // produit et code barre
        private void btnLoardProBC_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Liste des produits avec code barre");
            if (obj.message["type"] == "success")
            {
                crystalReportViewerAll.ReportSource = rps;
            }
            else if (obj.message["type"] == "failure")
            {
                msg.getError(obj.message["message"]);
            }
            else
            {
                msg.getError(obj.message["message"]);
            }
        }
        // fiche de stock
        private void btnChooseProRegFS_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchPro frm = new Search.frmSearchPro())
            {
                //Instaciation du formulaire
                frm.FRM = "REG";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "REG")
                    {
                        id_product = frm.id;
                        txtNamesProRpsFS.Text = frm.designPro;
                    }
                }
            }
        }

        private void btnChooseArrRegFS_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchArrival frm = new Search.frmSearchArrival())
            {
                //Instaciation du formulaire
                frm.FRM = "REG";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "REG")
                    {
                        txtNamesArrRpsFS.Text = frm.names;
                        id_arr = frm.id;
                    }
                }
            }
        }

        private void btnLoardRegFS_Click(object sender, EventArgs e)
        {
            if (chkUseArrChooseArrRpsFS.Checked == true && chkUseDteRpsFS.Checked == false)
            {
                // On passe les params
                Models.Reports.rps.id_product = id_product;
                Models.Reports.rps.names_product = txtNamesProRpsFS.Text;
                Models.Reports.rps.id_arr = id_arr;
                Models.Reports.rps.names_arr = txtNamesArrRpsFS.Text;
                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Mvt par produit et par arrivage");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
            else if (chkUseArrChooseArrRpsFS.Checked == false && chkUseDteRpsFS.Checked == false)
            {
                // On passe les params
                Models.Reports.rps.id_product = id_product;
                Models.Reports.rps.names_product = txtNamesProRpsFS.Text;
                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Mvt par produit");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
            else if (chkUseArrChooseArrRpsFS.Checked == true && chkUseDteRpsFS.Checked == true)
            {
                // On passe les params
                Models.Reports.rps.id_product = id_product;
                Models.Reports.rps.names_product = txtNamesProRpsFS.Text;
                Models.Reports.rps.id_arr = id_arr;
                Models.Reports.rps.names_arr = txtNamesArrRpsFS.Text;
                Models.Reports.rps.dte1 = valid.mysqlDateFormat(dteStartRpsFS);
                Models.Reports.rps.dte2 = valid.mysqlDateFormat(dteEndRpsFS);
                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Mvt par produit et par arrivage et par dates");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
            else if (chkUseArrChooseArrRpsFS.Checked == false && chkUseDteRpsFS.Checked == true)
            {
                // On passe les params
                Models.Reports.rps.id_product = id_product;
                Models.Reports.rps.names_product = txtNamesProRpsFS.Text;
                Models.Reports.rps.dte1 = valid.mysqlDateFormat(dteStartRpsFS);
                Models.Reports.rps.dte2 = valid.mysqlDateFormat(dteEndRpsFS);
                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Mvt par produit et par dates");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
        }

        #endregion

        #region payement
        //paiement
        private void btnChooseCustommerRegPay_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchInvoice frm = new Search.frmSearchInvoice())
            {
                //Instaciation du formulaire
                frm.FRM = "REG";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "REG")
                    {
                        id_invoice = frm.id;
                        txtNamesCustommerRpsPay.Text = frm.names;
                    }
                }
            }
        }

        private void frmReport_UI_Load(object sender, EventArgs e)
        {
            //access
            applyAccess();
        }

        private void btnLoardRegPay_Click(object sender, EventArgs e)
        {
            if (chkEneabledUseDteRpsPay.Checked == true)
            {
                // On passe les params
                Models.Reports.rps.id_invoice = id_invoice;
                Models.Reports.rps.names_custommer = txtNamesCustommerRpsPay.Text;
                Models.Reports.rps.dte1 = valid.mysqlDateFormat(dteStartRpsPay);
                Models.Reports.rps.dte2 = valid.mysqlDateFormat(dteEndRpsPay);

                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Liste des paiements et par dates");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
            else
            {
                // On passe les params
                Models.Reports.rps.id_invoice = id_invoice;
                Models.Reports.rps.names_custommer = txtNamesCustommerRpsPay.Text;
                Services.MsgFRM msg = new Services.MsgFRM();
                Models.Reports.rps obj = new Models.Reports.rps();
                ReportDocument rps = obj.rpsView("Liste des paiements");
                if (obj.message["type"] == "success")
                {
                    crystalReportViewerAll.ReportSource = rps;
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
            }
        }

        // perissable
        private void btnChooseArrRegArrPr_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchArrival frm = new Search.frmSearchArrival())
            {
                //Instaciation du formulaire
                frm.FRM = "Pr";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "Pr")
                    {
                        txtNamesArrRegArrPr.Text = frm.names;
                        id_arr = frm.id;
                    }
                }
            }
        }

        private void btnLoardRpsArrPr_Click(object sender, EventArgs e)
        {
            // On passe les params
            Models.Reports.rps.id_arr = id_arr;
            Models.Reports.rps.names_arr = txtNamesArrRegArrPr.Text;
            Models.Reports.rps.dteNow = valid.mysqlDateFormat(dteDteDURegPr);

            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Perissable");
            if (obj.message["type"] == "success")
            {
                crystalReportViewerAll.ReportSource = rps;
            }
            else if (obj.message["type"] == "failure")
            {
                msg.getError(obj.message["message"]);
            }
            else
            {
                msg.getError(obj.message["message"]);
            }
        }
        #endregion

        #region status ou etat
        //Etat
        private void btnLoardES_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Etat global du stock");
            if (obj.message["type"] == "success")
            {
                crystalReportViewerAll.ReportSource = rps;
            }
            else if (obj.message["type"] == "failure")
            {
                msg.getError(obj.message["message"]);
            }
            else
            {
                msg.getError(obj.message["message"]);
            }
        }
        #endregion
    }
}
