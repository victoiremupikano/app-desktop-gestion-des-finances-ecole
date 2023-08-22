using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceManager.Properties;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace FinanceManager.Views
{
    public partial class frmAccount : Form
    {
        public string id_add_arrival;
        public string id_current_oper;
        public string id_current_arrival;

        string dtconf, dtexp;
        //Var stockant les resultant de la verification du doublons dans l'ancien facture
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

        //fx pour la mise en application des acces
        private void applyAccess()
        {
            Models.MAccess obj = new Models.MAccess();
            //menu 'Déclarer'
            if(obj.getVal(Services.Session.UserSession["id"], "Arrivages", "Déclarer") == false)
            {
                tabControlArr.TabPages.Remove(tabPageDeclareArr);
            }
            //Remplir
            if (obj.getVal(Services.Session.UserSession["id"], "Arrivages", "Remplir") == false)
            {
                tabControlArr.TabPages.Remove(tabPage1);
            }
        }

        //mettre en couleur le dgv selon la gestion de produit perissable
        private void searchPeriscopeProduct(int cell1, int cell2)
        {
            // on verifie les produits perimer ou expirer
            Services.DtgvServices dgv = new Services.DtgvServices();
            dgvDataOperUp = dgv.DGV_row_cell_style_color(dgvDataOperUp, cell1, cell2);
        }

        private void frmArrivage_Load(object sender, EventArgs e)
        {
            //access
            applyAccess();

            MsgNotifyIcon();

            //remplissage ethiquette
            EthiquetteArr();

            btnToModifyAdd.Enabled = false;
            btnSavedAdd.Enabled = false;
            btnDeleteAdd.Enabled = false;

            btnToModifyUp.Enabled = false;
            btnSavedUp.Enabled = false;
            btnDeleteUp.Enabled = false;

            //verouillage de l'interface
            RendreInvisible();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        //Debut du code pour la add arrival .;
        //
        #region add arrival

        private void viderLesTxt()
        {
            txtDesign.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        //fonction nous aidant ethiquetter
        private void EthiquetteArr()
        {
            txtDesign.Text = "Nom de l'arrivage";
            txtDescription.Text = "Description de l'arrivage";
            txtResearchUp.Text = "Taper ici le text à rechercher";
        }

        //fonction nous aidant à verouillez l'interface de saisie
        private void RendreInvisible()
        {
            //rendre invisible l'interface de saisie
            txtDesign.Visible = false;
            txtDescription.Visible = false;
            chkStatus.Visible = false;

            gpEncadrdgvArriv.Dock = DockStyle.Fill;// mettre  en fill la listviw
        }

        //fonction nous aidant à rétablir l'interface de saisie
        private void RetablirInvisibliter()
        {
            //
            /// Code gestion de l'interfce de saisie
            //
            gpEncadrdgvArriv.Dock = DockStyle.Bottom;// mettre  en fill la listviw

            //rendre visible l'interface de saisie
            txtDescription.Visible = true;
            txtDesign.Visible = true;
            chkStatus.Visible = true;
        }


        /// <summary>
        /// Controle add arrival
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void migrateClick()
        {
            if (dgvDataAddArrival.Rows.Count > 0 && dgvDataAddArrival.SelectedRows.Count > 0)
            {
                id_add_arrival = dgvDataAddArrival.CurrentRow.Cells[0].Value.ToString();
                txtDesign.Text = dgvDataAddArrival.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dgvDataAddArrival.CurrentRow.Cells[2].Value.ToString();
                if (dgvDataAddArrival.CurrentRow.Cells[3].Value.ToString() == "True")
                {
                    chkStatus.Checked = true;
                }
                else
                {
                    chkStatus.Checked = false;
                }
            }
        }

        private void migrate()
        {
            if (dgvDataAddArrival.Rows.Count > 0 && dgvDataAddArrival.SelectedRows.Count > 0)
            {
                RetablirInvisibliter();
                viderLesTxt();

                id_add_arrival = dgvDataAddArrival.CurrentRow.Cells[0].Value.ToString();
                txtDesign.Text = dgvDataAddArrival.CurrentRow.Cells[1].Value.ToString();
                txtDescription.Text = dgvDataAddArrival.CurrentRow.Cells[2].Value.ToString();
                if (dgvDataAddArrival.CurrentRow.Cells[3].Value.ToString() == "True")
                {
                    chkStatus.Checked = true;
                }
                else
                {
                    chkStatus.Checked = false;
                }
            }
        }

        private void modify()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(id_add_arrival) || string.IsNullOrEmpty(txtDesign.Text) || string.IsNullOrEmpty(txtDescription.Text) || txtDesign.Text == "Nom de l'arrivage" || txtDescription.Text == "Description de l'arrivage")
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                if (msg.getDialog("Etes-vous sûr de vouloir modifier ?"))
                {
                    string status = string.Empty;
                    if (chkStatus.Checked)
                    {
                        status = "True";
                    }
                    else
                    {
                        status = "False";
                    }
                    Dictionary<string, string> fields = new Dictionary<string, string>{
                        {"id", id_add_arrival},
                        {"design", txtDesign.Text},
                        {"descript", txtDescription.Text},
                        {"status", status},
                        {"fk_user", Services.Session.UserSession["id"]},
                        {"fk_profile", Services.Session.ProfileSession["id"]},
                    };

                    //on passe les donnees dans le controllers
                    Controllers.CArrival obj = new Controllers.CArrival(fields);
                    obj.update(obj);

                    if (obj.message["type"] == "success")
                    {
                        msg.getInfo(obj.message["message"]);

                        loard();
                    }
                    else if (obj.message["type"] == "failure")
                    {
                        msg.getError(obj.message["message"]);
                    }
                    else
                    {
                        msg.getError(obj.message["message"]);
                    }
                    btnDeleteAdd.Enabled = true;
                    btnToModifyAdd.Enabled = true;
                    btnSavedAdd.Enabled = false;
                }
            }
        }

        private void delete()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Etes-vous sûr de vouloir supprimer ?"))
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", id_add_arrival},
                };
                //on passe les donnees dans le controllers
                Controllers.CArrival obj = new Controllers.CArrival(fields);
                obj.delete(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);

                    loard();
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
                btnDeleteAdd.Enabled = true;
                btnToModifyAdd.Enabled = true;
                btnSavedAdd.Enabled = false;
            }
        }

        private void save()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtDesign.Text) || string.IsNullOrEmpty(txtDescription.Text) || txtDesign.Text == "Nom de l'arrivage" || txtDescription.Text == "Description de l'arrivage")
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                string status = string.Empty;
                if (chkStatus.Checked)
                {
                    status = "True";
                }
                else
                {
                    status = "False";
                }
                Dictionary<string, string> fields = new Dictionary<string, string>{
                        {"design", txtDesign.Text},
                        {"descript", txtDescription.Text},
                        {"status", status},
                        {"fk_user", Services.Session.UserSession["id"]},
                        {"fk_profile", Services.Session.ProfileSession["id"]},
                    };

                //on passe les donnees dans le controllers
                Controllers.CArrival obj = new Controllers.CArrival(fields);
                obj.add(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);

                    loard();
                }
                else if (obj.message["type"] == "failure")
                {
                    msg.getError(obj.message["message"]);
                }
                else
                {
                    msg.getError(obj.message["message"]);
                }
                btnDeleteAdd.Enabled = true;
                btnToModifyAdd.Enabled = true;
                btnSavedAdd.Enabled = false;
            }
        }

        private void loard()
        {
            Models.MArrival obj = new Models.MArrival();
            obj.get();
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataAddArrival.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvDataAddArrival.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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
            btnDeleteAdd.Enabled = true;
            btnToModifyAdd.Enabled = true;
            btnSavedAdd.Enabled = false;

            RendreInvisible();
        }

        private void search(string param)
        {
            Models.MArrival obj = new Models.MArrival();
            obj.reseach(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataAddArrival.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvDataAddArrival.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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

        #endregion

        #region eventsClickAdd Arrival
        private void txtdesignArriv_Click(object sender, EventArgs e)
        {
            if (txtDesign.Text == "Nom de l'arrivage")
            {
                txtDesign.Text = string.Empty;
            }
            if (txtDescription.Text == string.Empty)
            {
                txtDescription.Text = "Description de l'arrivage";
            }
        }

        private void txtdescription_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "Description de l'arrivage")
            {
                txtDescription.Text = string.Empty;
            }
            if (txtDesign.Text == string.Empty)
            {
                txtDesign.Text = "Nom de l'arrivage";
            }
        }

        private void txtRechercheArriv_Click(object sender, EventArgs e)
        {
            if (txtRechercheArriv.Text == "Taper ici le text à rechercher")
            {
                txtRechercheArriv.Text = "";
            }
        }

        #endregion

        #region btnCtrl Add Arrival
        private void btnCharger_Click(object sender, EventArgs e)
        {
            loard();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            RetablirInvisibliter();
            EthiquetteArr();
            
            btnDeleteAdd.Enabled = false;
            btnSavedAdd.Enabled = true;
            btnToModifyAdd.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            modify();
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void dgvDataAddArrival_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            migrateClick();
        }

        private void dgvDataAddArrival_SelectionChanged(object sender, EventArgs e)
        {
            migrateClick();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            migrate();
        }

        #endregion
        //
        //Fin du code pour la add arrival .;
        //
        private void MsgNotifyIcon()
        {
            notifyIconArrivage.BalloonTipText = "L'article est déjà dans le panier...";
            notifyIconArrivage.BalloonTipTitle = "Alerte";
        }

        //
        //Debut du code pour la add recept arrival;
        //
        #region ctrl
        private void loardProNotInArrival(string param)
        {
            //on verrouille
            dgvDataProUp.Enabled = false;

            Models.MProduct obj = new Models.MProduct();
            obj.getNotInArrival(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataProUp.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvDataProUp.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), dr[6].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[7].ToString());
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
        private void searchPro(string reseach, string id_arr)
        {
            Models.MProduct obj = new Models.MProduct();
            obj.reseachNotInArrival(reseach, id_arr);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataProUp.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvDataProUp.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), dr[6].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[7].ToString());
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
            searchPeriscopeProduct(12, 14);
        }

        /// <summary>
        /// Controle add arrival
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
        private void migrateOper()
        {
            if (dgvDataOperUp.Rows.Count > 0 && dgvDataOperUp.SelectedRows.Count > 0)
            {
                id_current_oper = dgvDataOperUp.CurrentRow.Cells[10].Value.ToString();
            }
        }

        private void modifyOper()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (dgvDataOperUp.Rows.Count <= 0)
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                if (msg.getDialog("Etes-vous sûr de vouloir modifier ?"))
                {
                    string messages = string.Empty;
                    string type = string.Empty;

                    foreach (DataGridViewRow dr in dgvDataOperUp.Rows)
                    {
                        string dteConf, dteExp = string.Empty;
                        if (dr.Cells[12].Value.ToString() == "true")
                        {
                            dteConf = valid.mysqlDateFormatByNowValue(DateTime.Parse(dr.Cells[13].Value.ToString()));
                            dteExp = valid.mysqlDateFormatByNowValue(DateTime.Parse(dr.Cells[14].Value.ToString()));
                        }
                        else
                        {
                            dteConf = null;
                            dteExp = null;
                        }
                        Dictionary<string, string> fields = new Dictionary<string, string>{
                            {"id", dr.Cells[10].Value.ToString()},
                            {"num", null},
                            {"dte", valid.mysqlDateFormatByNowValue(DateTime.Parse(dr.Cells[11].Value.ToString()))},
                            {"qtg", dr.Cells[7].Value.ToString().Replace(",", ".")},
                            {"qtd", dr.Cells[8].Value.ToString().Replace(",", ".")},
                            {"pvt", dr.Cells[4].Value.ToString().Replace(",", ".")},
                            {"fk1", dr.Cells[9].Value.ToString()},
                            {"fk2", dr.Cells[0].Value.ToString()},
                            {"fk3", null},
                            {"oper", "Entrée"},
                            {"fk_user", Services.Session.UserSession["id"]},
                            {"fk_profile", Services.Session.ProfileSession["id"]},
                            {"dte_start_isperiscope", dteConf},
                            {"dte_end_isperiscope", dteExp},
                        };

                        //on passe les donnees dans le controllers
                        Controllers.CFlux obj = new Controllers.CFlux(fields);
                        obj.update(obj);

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
                        loardOper();
                    }
                    else if (type == "failure")
                    {
                        msg.getError(messages);
                    }
                    else
                    {
                        msg.getError(messages);
                    }

                    btnToModifyUp.Enabled = true;
                    btnSavedUp.Enabled = false;
                    btnDeleteUp.Enabled = true;
                }
            }
        }

        private void deleteOper()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Etes-vous sûr de vouloir supprimer ?"))
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", id_current_oper},
                };
                //on passe les donnees dans le controllers
                Controllers.CFlux obj = new Controllers.CFlux(fields);
                obj.delete(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);
                    loardOper();
                    if (string.IsNullOrEmpty(id_current_arrival))
                    {
                        msg.getAttention("Attention, veillez séléctionner l'arrivage !");
                    }
                    else
                    {
                        loardProNotInArrival(id_current_arrival);
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

                btnToModifyUp.Enabled = true;
                btnSavedUp.Enabled = false;
                btnDeleteUp.Enabled = true;
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
                    if (dr.IsNewRow || double.Parse(dr.Cells[8].Value.ToString().Replace(",", ".")) == 0) continue; // fonction nous permettant de se limter; pour ne pas enregistrer une nouvel ligne vide
                    {
                        string dteConf, dteExp = string.Empty;
                        if (dr.Cells[12].Value.ToString() == "true")
                        {
                            dteConf = valid.mysqlDateFormatByNowValue(DateTime.Parse(dr.Cells[13].Value.ToString()));
                            dteExp = valid.mysqlDateFormatByNowValue(DateTime.Parse(dr.Cells[14].Value.ToString()));
                        }
                        else
                        {
                            dteConf = null;
                            dteExp = null;
                        }
                        Dictionary<string, string> fields = new Dictionary<string, string>{
                            {"num", null},
                            {"dte", dr.Cells[11].Value.ToString()},
                            {"qtg", dr.Cells[7].Value.ToString().Replace(",", ".")},
                            {"qtd", dr.Cells[8].Value.ToString().Replace(",", ".")},
                            {"pvt", dr.Cells[4].Value.ToString().Replace(",", ".")},
                            {"fk1", dr.Cells[9].Value.ToString()},
                            {"fk2", dr.Cells[0].Value.ToString()},
                            {"fk3", null},
                            {"oper", "Entrée"},
                            {"fk_user", Services.Session.UserSession["id"]},
                            {"fk_profile", Services.Session.ProfileSession["id"]},
                            {"dte_start_isperiscope", dteConf},
                            {"dte_end_isperiscope", dteExp},
                        };

                        //on passe les donnees dans le controllers
                        Controllers.CFlux obj = new Controllers.CFlux(fields);
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
                }
                if (type == "success")
                {
                    msg.getInfo(messages);
                    loardOper();
                    if (string.IsNullOrEmpty(id_current_arrival))
                    {
                        msg.getAttention("Attention, veillez séléctionner l'arrivage !");
                    }
                    else
                    {
                        loardProNotInArrival(id_current_arrival);
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
                btnToModifyUp.Enabled = true;
                btnSavedUp.Enabled = false;
                btnDeleteUp.Enabled = true;
            }
        }

        private void loardOper()
        {
            Models.MFlux obj = new Models.MFlux();
            obj.getArr(id_current_arrival);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvDataOperUp.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;
                while (dr.Read())
                {
                    if (dr[12].ToString() == "true")
                    {
                        if (string.IsNullOrEmpty(dr[13].ToString()))
                        {
                            dtconf = DateTime.Now.ToString();
                        }
                        else
                        {
                            dtconf = dr[13].ToString();
                        }
                        if (string.IsNullOrEmpty(dr[14].ToString()))
                        {
                            dtexp = DateTime.Now.ToString();
                        }
                        else
                        {
                            dtexp = dr[14].ToString();
                        }
                    }
                    else
                    {
                        dtconf = dr[13].ToString();
                        dtexp = dr[14].ToString();
                    }
                    dgvDataOperUp.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dtconf, dtexp);
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

            searchPeriscopeProduct(12, 14);

            btnToModifyUp.Enabled = true;
            btnSavedUp.Enabled = false;
            btnDeleteUp.Enabled = true;
        }

        #endregion

        #region btn
        private void btnChooseArrivages_Click(object sender, EventArgs e)
        {
            using (Views.Search.frmSearchArrival frm = new Search.frmSearchArrival())
            {
                //Instaciation du formulaire
                frm.FRM = "RECEPT ARRIVAL";
                frm.Size = new Size(558, frmMain.ActiveForm.Size.Height - 40);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.FRM == "RECEPT ARRIVAL")
                    {
                        txtNamesArrUp.Text = frm.names;
                        id_current_arrival = frm.id;

                        if (string.IsNullOrEmpty(id_current_arrival))
                        {
                            Services.MsgFRM msg = new Services.MsgFRM();
                            msg.getAttention("Attention, veillez séléctionner l'arrivage !");
                        }
                        else
                        {
                            loardProNotInArrival(id_current_arrival);
                        }
                    }
                }
            }
        }

        private void btnChargerTLP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_current_arrival))
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Attention, veillez séléctionner l'arrivage !");
            }
            else
            {
                loardProNotInArrival(id_current_arrival);
            }
        }

        #endregion

        private void PasserAuPanierArrMono()
        {
            try
            {
                //
                ///Ajout des lignes dans des produit(Operatios) dans le pnnier
                //
                string dteConf, dteExp, isperiscope = string.Empty;
                if (this.dgvDataProUp.CurrentRow.Cells[7].Value.ToString() == "true")
                {
                    isperiscope = "true";
                    dteConf = dteExp = DateTime.Now.ToString();
                }
                else
                {
                    isperiscope = "false";
                    dteConf = null;
                    dteExp = null;
                }
                this.dgvDataOperUp.Rows.Add(this.dgvDataProUp.CurrentRow.Cells[0].Value.ToString(), this.dgvDataProUp.CurrentRow.Cells[1].Value.ToString(), this.dgvDataProUp.CurrentRow.Cells[2].Value.ToString(), this.dgvDataProUp.CurrentRow.Cells[3].Value.ToString(), this.dgvDataProUp.CurrentRow.Cells[4].Value.ToString().Replace(".", ","), this.dgvDataProUp.CurrentRow.Cells[5].Value.ToString().Replace(".", ","), this.dgvDataProUp.CurrentRow.Cells[6].Value.ToString().Replace(".", ","), 0, 0, id_current_arrival, string.Empty, valid.mysqlDatetimeFormat(dteUp), isperiscope, dteConf, dteExp);
                btnSavedUp.Enabled = true; //activation du btn Enregistrer
            }
            catch (Exception)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Erreur, veillez à selectionner un produit ?");

                btnSavedUp.Enabled = false; //desactivation du btn Enregistrer
            }
        }
        private void PasserAuPanierArrMultiple()
        {
            foreach (DataGridViewRow dr in dgvDataProUp.Rows)
            {
                try
                {
                    if (dr.Selected != true) continue;//fonction nous permettant de se limter; pour ne pas enregistrer une nouvel ligne vide
                    {
                        string dteConf, dteExp, isperiscope = string.Empty;
                        if (dr.Cells[7].Value.ToString() == "true")
                        {
                            isperiscope = "true";
                            dteConf = dteExp = DateTime.Now.ToString();
                        }
                        else
                        {
                            isperiscope = "false";
                            dteConf = null;
                            dteExp = null;
                        }
                        this.dgvDataOperUp.Rows.Add(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString(), dr.Cells[2].Value.ToString(), dr.Cells[3].Value.ToString(), dr.Cells[4].Value.ToString().Replace(".", ","), dr.Cells[5].Value.ToString().Replace(".", ","), dr.Cells[6].Value.ToString().Replace(".", ","), 0, 0, id_current_arrival, string.Empty, valid.mysqlDatetimeFormat(dteUp), isperiscope, dteConf, dteExp);
                    }
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        private void sendAny()
        {
            if (txtNamesArrUp.Text == string.Empty)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Veillez selectionner un arrivage contenneur ?");
            }
            else
            {
                if (dgvDataProUp.Rows.Count > 0)
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
            if (txtNamesArrUp.Text == string.Empty)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Veillez selectionner un arrivage contenneur ?");
            }
            else
            {
                if (dgvDataProUp.Rows.Count > 0)
                {
                    if (dgvDataOperUp.Rows.Count < 1)
                    {
                        //on fait passer le produit dans le pannier
                        PasserAuPanierArrMono();
                    }
                    else
                    {
                        //Recuperatarion de l'id du produit
                        string idereupttoverify = this.dgvDataProUp.CurrentRow.Cells[0].Value.ToString();

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
                            notifyIconArrivage.BalloonTipText = "L'article est déjà dans le panier...";
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
            if (txtResearchUp.Text == "Taper ici le text à rechercher")
            {
                txtResearchUp.Text = string.Empty;
            }
        }

        private void txtRechercheGeneralRArr_TextChanged(object sender, EventArgs e)
        {
            if (txtResearchUp.Text != "Taper ici le text à rechercher")
            {
                if (txtResearchUp.Text.Contains("/"))
                {
                    //pour faciliter on crée des variables
                    var val = txtResearchUp.Text;
                    //separtion de val text et entier
                    var valSeparer = val.Split('/');
                    //stockage de valeur separer
                    string part1 = valSeparer[0];
                    string part2 = valSeparer[1];

                    searchPro(part2, id_current_arrival);
                }
                else
                {
                    searchPro(txtResearchUp.Text, id_current_arrival);
                }
            }
        }

        private void dgvDataProUp_DoubleClick(object sender, EventArgs e)
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

        private void dgvDataOper_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            migrateOper();
        }

        private void dgvDataOper_SelectionChanged(object sender, EventArgs e)
        {
            migrateOper();
        }

        private void btnChargerOper_Click(object sender, EventArgs e)
        {
            loardOper();
        }

        private void btnModifierOper_Click(object sender, EventArgs e)
        {
            modifyOper();
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
            dgvDataProUp.Enabled = true;
            dgvDataOperUp.Rows.Clear();

            btnSavedUp.Enabled = true;
            btnDeleteAdd.Enabled = false;
            btnToModifyAdd.Enabled = false;
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtResearchUp.Text != "Taper ici le text à rechercher")
            {
                search(txtResearchAdd.Text.Replace("'", "''"));
            }
        }

        private void btnAjouterOper_Click(object sender, EventArgs e)
        {
            saveOper();
        }


        ////
        ///SUPRESSION DE TOUS L'ARRIVAGE
        ///
        private void deletePayment(string param)
        {
            Models.MArrival obj = new Models.MArrival();
            obj.delAllPaymentByNum(param);
            if (obj.callback["type"] == "success")
            {
                MySqlDataReader dr = Apps.Query.DR;
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
        private void loardInvoiceByArr(string param)
        {
            Models.MArrival obj = new Models.MArrival();
            obj.getAllInvoiceByArr(param);
            if (obj.callback["type"] == "success")
            {
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    deletePayment(dr[1].ToString());
                }
                Apps.Query.DR.Close();

                deleteAllDataByArr(param);
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
        private void deleteAllDataByArr(string param)
        {
            Models.MArrival obj = new Models.MArrival();
            obj.delAllDataByArr(param);
            if (obj.callback["type"] == "success")
            {
                MySqlDataReader dr = Apps.Query.DR;
                Apps.Query.DR.Close();

                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getInfo("Suppression complète des tous les données de l'arrivage (" + txtNamesArrUp.Text + ") éfféctuer avec succès");

                deleteCobtainerByArr(param);
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
               
        private void deleteCobtainerByArr(string param)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", param},
                };
            //on passe les donnees dans le controllers
            Controllers.CArrival obj = new Controllers.CArrival(fields);
            obj.delete(obj);

            if (obj.message["type"] == "success")
            {
                msg.getInfo("Suppression du conteneur avec succès");

                //on vide tous
                txtNamesArrUp.Text = string.Empty;
                id_current_arrival = string.Empty;
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

        private void btnDeleteAllUp_Click(object sender, EventArgs e)
        {
            
        }
        //
        //Fin du code pour la add recept arrival;
        //
    }
}
