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


namespace FinanceManager.Views
{
    public partial class frmAccount : Form
    {
        public string id, fk_trimestry;

        //Var stockant les resultant de la verification du doublons
        public string resultverfify, resultverfifyInAddRows;

        Services.convertDate valid = new Services.convertDate();
        Services.DtgvServices dgv = new Services.DtgvServices();

        public frmAccount()
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

        private void cbo_loader()
        {
            Services.CBO.cboDb cbo = new Services.CBO.cboDb();
            cbo.cbo = cboTrimestry;
            cboTrimestry = cbo.cboTrimestry();
        }
        private void selectChangedcbo_loard(string param)
        {
            Models.MTrimestry obj = new Models.MTrimestry();
            obj.getId(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvData.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                if (dr.Read())
                {
                    fk_trimestry = dr[0].ToString();
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
        
        private void frmArrivage_Load(object sender, EventArgs e)
        {
            cbo_loader();
            MsgNotifyIcon();

            btnSaved.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loardNotInAccount(string param)
        {
            Models.MStudent obj = new Models.MStudent();
            obj.getNotInAccount(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvData.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvData.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
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
            btnDelete.Enabled = true;
            btnSaved.Enabled = false;
        }
        private void searchNotInAccount(string param, string fk_trimestry)
        {
            Models.MStudent obj = new Models.MStudent();
            obj.researchNotInAccount(param, fk_trimestry);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvData.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvData.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString());
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
            btnDelete.Enabled = true;
            btnSaved.Enabled = false;
        }

        private void deleteOper()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Etes-vous sûr de vouloir supprimer ?"))
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", id},
                };
                //on passe les donnees dans le controllers
                Controllers.CAccount obj = new Controllers.CAccount(fields);
                obj.delete(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);
                    loardOper(fk_trimestry);
                    if (string.IsNullOrEmpty(fk_trimestry))
                    {
                        msg.getAttention("Attention, veillez séléctionner l'arrivage !");
                    }
                    else
                    {
                        loardNotInAccount(fk_trimestry);
                    }
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }

                btnSaved.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void saveOper()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (dgvDataOperUp.Rows.Count <= 0)
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                string messages = string.Empty;
                string type = string.Empty;

                foreach (DataGridViewRow dr in dgvDataOperUp.Rows)
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>{
                            {"wording", dr.Cells[4].Value.ToString()},
                            {"fk1", dr.Cells[0].Value.ToString()},
                            {"fk2", dr.Cells[5].Value.ToString().Replace(",", ".")},
                            {"fk_year",  Services.Session.ExerciselSession["id"]},
                            {"fk_user", Services.Session.UserSession["id"]},
                        };

                    //on passe les donnees dans le controllers
                    Controllers.CAccount obj = new Controllers.CAccount(fields);
                    obj.add(obj);

                    if (obj.message["type"] == "success")
                    {
                        messages += (obj.message["message"]) + "/";
                        type = "success";
                    }
                    else if (obj.message["type"] == "failure")
                    {
                        messages += (obj.message["message"]) + "/";
                        type = "failure";
                    }
                    else
                    {
                        messages += (obj.message["message"]) + "/";
                        type = "failure";
                    }
                }
                if (type == "success")
                {
                    msg.getInfo(messages);
                    loardOper(fk_trimestry);
                    if (string.IsNullOrEmpty(fk_trimestry))
                    {
                        msg.getAttention("Attention, veillez séléctionner l'arrivage !");
                    }
                    else
                    {
                        loardNotInAccount(fk_trimestry);
                    }
                }
                else if (type == "failure")
                {
                    msg.getError(messages);
                }
                else
                {
                    msg.getError(messages);
                }
                btnSaved.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void loardOper(string param)
        {
            Models.MAccount obj = new Models.MAccount();
            obj.get(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataOperUp.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;
                while (dr.Read())
                {
                    dgvDataOperUp.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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
            btnSaved.Enabled = false;
            btnDelete.Enabled = true;
        }

        private void btnChargerTLP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fk_trimestry))
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Attention, veillez séléctionner l'arrivage !");
            }
            else
            {
                loardNotInAccount(fk_trimestry);
            }
        }

        private void PasserAuPanierArrMono()
        {
            try
            {
                //
                ///Ajout des lignes dans des produit(Operatios) dans le pnnier
                //
                this.dgvDataOperUp.Rows.Add(this.dgvData.CurrentRow.Cells[0].Value.ToString(), this.dgvData.CurrentRow.Cells[1].Value.ToString(), this.dgvData.CurrentRow.Cells[2].Value.ToString(), this.dgvData.CurrentRow.Cells[3].Value.ToString(), this.dgvData.CurrentRow.Cells[9].Value.ToString(), cboTrimestry.Text, fk_trimestry, null);
                btnSaved.Enabled = true; //activation du btn Enregistrer
            }
            catch (Exception)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Erreur, veillez à selectionner un produit ?");

                btnSaved.Enabled = false; //desactivation du btn Enregistrer
            }
        }
        private void PasserAuPanierArrMultiple()
        {
            foreach (DataGridViewRow dr in dgvData.Rows)
            {
                try
                {
                    this.dgvDataOperUp.Rows.Add(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), dr.Cells[9].Value.ToString(), cboTrimestry.Text, fk_trimestry, null);
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        private void sendAny()
        {
            if (cboTrimestry.Text == string.Empty)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Veillez selectionner un trimestre ?");
            }
            else
            {
                if (dgvData.Rows.Count > 0)
                {
                    if (dgvDataOperUp.Rows.Count < 1)
                    {
                        //on fait passer les produits dans le pannier
                        PasserAuPanierArrMultiple();
                    }
                    else
                    {
                        Services.MsgFRM msg = new Services.MsgFRM();
                        msg.getAttention("Attention !, utliser la sélection unique ?");
                    }
                }
                else
                {
                    Services.MsgFRM msg = new Services.MsgFRM();
                    msg.getAttention("Attention !, utliser la sélection unique ?");
                }
            }
        }
        private void sendOnly()
        {
            if (cboTrimestry.Text == string.Empty)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Veillez selectionner un trimestre ?");
            }
            else
            {
                if (dgvData.Rows.Count > 0)
                {
                    if (dgvDataOperUp.Rows.Count < 1)
                    {
                        //on fait passer le produit dans le pannier
                        PasserAuPanierArrMono();
                    }
                    else
                    {
                        //Recuperatarion de l'id du produit
                        string idereupttoverify = this.dgvData.CurrentRow.Cells[0].Value.ToString();

                        foreach (DataGridViewRow dr in dgvDataOperUp.Rows)
                        {
                            if (dr.Cells[0].Value.ToString() == idereupttoverify)
                            {
                                resultverfifyInAddRows = "content";
                                break;
                            }
                            else
                            {
                                resultverfifyInAddRows = "empty";
                            }
                        }

                        //Verification proprement dite pour vue a faire passer ou non dans le panier
                        if (resultverfifyInAddRows == "empty")
                        {
                            //on fait passer le produit dans le pannier
                            PasserAuPanierArrMono();
                        }
                        else
                        {
                            notifyIconArrivage.BalloonTipText = "L'item est déjà dans le panier...";
                            notifyIconArrivage.BalloonTipTitle = "Alerte";

                            ShowIcon = false;
                            notifyIconArrivage.Visible = true;
                            notifyIconArrivage.ShowBalloonTip(1000);
                        }
                    }
                }
            }
        }

        private void passerUneSélectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sendAny();
        }
        private void passerUnArticleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sendOnly();
        }

        private void txtRechercheGeneral_Click(object sender, EventArgs e)
        {
            if (txtResearch.Text == "Taper ici le text à rechercher")
            {
                txtResearch.Text = string.Empty;
            }
        }

        private void txtRechercheGeneralRArr_TextChanged(object sender, EventArgs e)
        {
            if (txtResearch.Text != "Taper ici le text à rechercher")
            {
                searchNotInAccount(txtResearch.Text, fk_trimestry);
            }
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            sendOnly();
        }

        private void dgvDataOper_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //1
                if (double.Parse(dgvDataOperUp.CurrentRow.Cells[7].Value.ToString().Replace(",", ".")) == 0)
                {
                    //on laisse le zeo dans la zone
                }
                else
                {
                    double result = (double.Parse(dgvDataOperUp.CurrentRow.Cells[7].Value.ToString().Replace(",", ".")) * double.Parse(this.dgvDataOperUp.CurrentRow.Cells[5].Value.ToString().Replace(",", ".")));
                    dgvDataOperUp.CurrentRow.Cells[8].Value = result;
                }
                //2
                if (dgvDataOperUp.CurrentRow.Cells[8].Value.ToString().Replace(",", ".") == string.Empty)
                {
                    //on laisse le zeo dans la zone
                }
                else
                {}
                //on met obligatoirement la sate du jour si le produit est perissable
                if (!string.IsNullOrEmpty(dgvDataOperUp.CurrentRow.Cells[12].Value.ToString()))
                {
                    if (dgvDataOperUp.CurrentRow.Cells[12].Value.ToString() == "true")
                    {
                        dgvDataOperUp.CurrentRow.Cells[13].Value = DateTime.Now;
                        dgvDataOperUp.CurrentRow.Cells[14].Value = DateTime.Now;
                    }
                    else
                    {
                        dgvDataOperUp.CurrentRow.Cells[13].Value = null;
                        dgvDataOperUp.CurrentRow.Cells[14].Value = null;
                    }
                }
                else
                {
                    dgvDataOperUp.CurrentRow.Cells[13].Value = null;
                    dgvDataOperUp.CurrentRow.Cells[14].Value = null;
                }
            }
            catch (Exception ex)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError("Erreur " + ex.Message);
            }
        }

        private void btnChargerOper_Click(object sender, EventArgs e)
        {
            loardOper(fk_trimestry);
        }

        private void btnSuppOper_Click(object sender, EventArgs e)
        {
            deleteOper();
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            dgvDataOperUp = dgv.cutRow(dgvDataOperUp);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //on deverrouille
            dgvDataOperUp.Rows.Clear();

            btnSaved.Enabled = true;
        }

        private void btnAjouterOper_Click(object sender, EventArgs e)
        {
            saveOper();
        }

        private void cboTrimestry_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectChangedcbo_loard(cboTrimestry.Text);
        }
    }
}
