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
        public string id_student;
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

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLstStudent_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Lite des apprenants");
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

        private void btnChooseArrUp_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchStudent frm = new Search.frmSearchStudent())
            {
                //Instaciation du formulaire
                frm.FRM = "RPS";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "RPS")
                    {
                        txtNamesArrUp.Text = frm.names;
                        id_student = frm.id;
                    }
                }
            }
        }

        private void btnLoardRpsPay_Click(object sender, EventArgs e)
        {
            // On passe les params
            Models.Reports.rps.id_student = id_student;
            Models.Reports.rps.names_student = txtNamesArrUp.Text;

            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Situation par apprenant");
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

        private void btnLstPaiymentToDya_Click(object sender, EventArgs e)
        {
            // On passe les params
            Models.Reports.rps.dte = valid.mysqlDateFormatByNowValue(DateTime.Now);

            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Paiement du jour");
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

        private void btnLstPaymentFlux_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            Models.Reports.rps obj = new Models.Reports.rps();
            ReportDocument rps = obj.rpsView("Flux de paiement");
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
}
