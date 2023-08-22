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


namespace FinanceManager.Views
{
    public partial class frmStudent : Form
    {
        public string id;

        Services.convertDate valid = new Services.convertDate();
        Services.DtgvServices dgv = new Services.DtgvServices();

        public frmStudent()
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

        private void frmArrivage_Load(object sender, EventArgs e)
        {
            btnToModify.Enabled = false;
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

        //
        //Debut du code pour la student .;
        //
        #region student

        private void viderLesTxt()
        {
            txtNames.Text = txtFather.Text = txtMather.Text = txtReligin.Text = txtTel.Text = string.Empty;
        }

        /// <summary>
        /// Controle student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void migrate()
        {
            if (dgvData.Rows.Count > 0 && dgvData.SelectedRows.Count > 0)
            {
                viderLesTxt();

                id = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtNames.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                cboKind.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                dteBirthday.Value = DateTime.Parse(dgvData.CurrentRow.Cells[3].Value.ToString());
                txtFather.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
                txtMather.Text = dgvData.CurrentRow.Cells[5].Value.ToString();
                txtReligin.Text = dgvData.CurrentRow.Cells[6].Value.ToString();
                txtAdress.Text = dgvData.CurrentRow.Cells[7].Value.ToString();
                txtTel.Text = dgvData.CurrentRow.Cells[8].Value.ToString();
                cboLevel.Text = dgvData.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void modify()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(txtNames.Text) || string.IsNullOrEmpty(cboKind.Text) || string.IsNullOrEmpty(txtFather.Text) || string.IsNullOrEmpty(txtMather.Text) || string.IsNullOrEmpty(cboLevel.Text))
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                if (msg.getDialog("Etes-vous sûr de vouloir modifier ?"))
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>{
                        {"id", id},
                        {"names", txtNames.Text},
                        {"kind", cboKind.Text},
                        {"birthday", valid.mysqlDateFormat(dteBirthday)},
                        {"children_father", txtFather.Text},
                        {"children_mather", txtMather.Text},
                        {"religin", txtReligin.Text},
                        {"adress", txtAdress.Text},
                        {"tel", txtTel.Text},
                        {"fk_year", Services.Session.ExerciselSession["id"]},
                        {"fk_user", Services.Session.UserSession["id"]},
                    };

                    //on passe les donnees dans le controllers
                    Controllers.CStudent obj = new Controllers.CStudent(fields);
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
                    btnDelete.Enabled = true;
                    btnToModify.Enabled = true;
                    btnSaved.Enabled = false;
                }
            }
        }

        private void delete()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Etes-vous sûr de vouloir supprimer ?"))
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", id},
                };
                //on passe les donnees dans le controllers
                Controllers.CStudent obj = new Controllers.CStudent(fields);
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
                btnDelete.Enabled = true;
                btnToModify.Enabled = true;
                btnSaved.Enabled = false;
            }
        }

        private void save()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtNames.Text) || string.IsNullOrEmpty(cboKind.Text) || string.IsNullOrEmpty(txtFather.Text) || string.IsNullOrEmpty(txtMather.Text) || string.IsNullOrEmpty(cboLevel.Text))
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"names", txtNames.Text},
                    {"kind", cboKind.Text},
                    {"birthday", valid.mysqlDateFormat(dteBirthday)},
                    {"children_father", txtFather.Text},
                    {"children_mather", txtMather.Text},
                    {"religin", txtReligin.Text},
                    {"adress", txtAdress.Text},
                    {"tel", txtTel.Text},
                    {"fk_year", Services.Session.ExerciselSession["id"]},
                    {"fk_user", Services.Session.UserSession["id"]},
                };

                //on passe les donnees dans le controllers
                Controllers.CStudent obj = new Controllers.CStudent(fields);
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
                btnDelete.Enabled = true;
                btnToModify.Enabled = true;
                btnSaved.Enabled = false;
            }
        }

        private void loard()
        {
            Models.MStudent obj = new Models.MStudent();
            obj.get();
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
            btnToModify.Enabled = true;
            btnSaved.Enabled = false;
        }

        private void search(string param)
        {
            Models.MStudent obj = new Models.MStudent();
            obj.reseach(param);
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
        }

        #endregion

        #region eventsClickstudent

        private void txtRechercheArriv_Click(object sender, EventArgs e)
        {
            if (txtRechercheArriv.Text == "Taper ici le text à rechercher")
            {
                txtRechercheArriv.Text = "";
            }
        }

        #endregion

        #region btnCtrl student
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
            viderLesTxt();

            btnDelete.Enabled = false;
            btnSaved.Enabled = true;
            btnToModify.Enabled = false;
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
            migrate();
        }

        private void dgvDataAddArrival_SelectionChanged(object sender, EventArgs e)
        {
            migrate();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            migrate();
        }

        #endregion

        private void txtResearchAdd_TextChanged(object sender, EventArgs e)
        {
            search(txtResearch.Text);
        }
    }
}
