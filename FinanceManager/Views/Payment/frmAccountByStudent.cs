using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceManager.Controllers;
using FinanceManager.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace FinanceManager.Views.Payment
{
    public partial class frmAccountByStudent : Form
    {
        public string id, fk_student;

        //Var stockant les resultant de la verification du doublons
        public string resultverfify, resultverfifyInAddRows;

        Services.convertDate valid = new Services.convertDate();
        Services.DtgvServices dgv = new Services.DtgvServices();

        public frmAccountByStudent()
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

        private void MsgNotifyIcon()
        {
            notifyIconArrivage.BalloonTipText = "L'item est déjà dans le panier...";
            notifyIconArrivage.BalloonTipTitle = "Alerte";
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDataOperUp_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDataOperUp.Rows.Count > 0 && dgvDataOperUp.SelectedRows.Count > 0)
            {
                frmAddPayment frm = new frmAddPayment();
                frm.fk_account = dgvDataOperUp.CurrentRow.Cells[9].Value.ToString();
                frm.mt_total = double.Parse(dgvDataOperUp.CurrentRow.Cells[6].Value.ToString().Replace(",", "."));
                frm.Text = "Detail / " + dgvDataOperUp.CurrentRow.Cells[2].Value.ToString();

                frm.ShowDialog();
            }
        }

        private void loardStatusAccountByStudent(string param)
        {
            Models.MAccount obj = new Models.MAccount();
            obj.getStatusAccountByStudent(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataOperUp.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;
                while (dr.Read())
                {
                    dgvDataOperUp.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
                }
                Apps.Query.DR.Close();
            }
            else if (obj.callback["type"] == "failure")
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError(obj.callback["message"]);
            }
            else
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError(obj.callback["message"]);
            }
        }
               
        private void btnChooseArrUp_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchStudent frm = new Search.frmSearchStudent())
            {
                //Instaciation du formulaire
                frm.FRM = "RECEPT";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "RECEPT")
                    {
                        txtNamesArrUp.Text = frm.names;
                        fk_student = frm.id;

                        if (string.IsNullOrEmpty(fk_student))
                        {
                            Services.MsgFRM msg = new Services.MsgFRM();
                            msg.getAttention("Attention, veillez séléctionner l'item (ou l'apprenant) !");
                        }
                        else
                        {
                            loardStatusAccountByStudent(fk_student);
                        }
                    }
                }
            }
        }
    }
}
