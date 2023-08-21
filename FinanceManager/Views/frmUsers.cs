using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Commercial_Management.Views
{
    public partial class frmUsers : Form
    {
        public string id;
        public string type = string.Empty;

        public frmUsers()
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

        /// <summary>
        /// Controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modify()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || txtUserName.Text == "Nom d'utilisateur" || txtPassword.Text == "Mot de passe")
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                if (msg.getDialog("Etes-vous sûr de vouloir modifier ?"))
                {
                    Services.Crypto crypt = new Services.Crypto();

                    Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"id", id},
                    {"login", txtUserName.Text},
                    {"password", crypt.Hash(txtPassword.Text)},
                    {"type", type}
                };

                    //on passe les donnees dans le controllers
                    Controllers.CUser obj = new Controllers.CUser(fields);
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
                Controllers.CUser obj = new Controllers.CUser(fields);
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
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || txtUserName.Text == "Nom d'utilisateur" || txtPassword.Text == "Mot de passe")
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                Services.Crypto crypt = new Services.Crypto();

                Dictionary<string, string> fields = new Dictionary<string, string>{
                    {"login", txtUserName.Text},
                    {"password", crypt.Hash(txtPassword.Text)},
                    {"type", type},
            };

                //on passe les donnees dans le controllers
                Controllers.CUser obj = new Controllers.CUser(fields);
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
            Models.MUsers obj = new Models.MUsers();
            obj.get();
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvData.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvData.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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

        private void migrate()
        {
            if (dgvData.Rows.Count > 0 && dgvData.SelectedRows.Count > 0)
            {
                id = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtUserName.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
                txtPassword.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
                if(dgvData.CurrentRow.Cells[3].Value.ToString() == "Administrateur")
                {
                    rbAdminCpt.Checked = true;
                }
                else
                {
                    rbSimpleCpt.Checked = true;
                }
            }
        }

        //
        //creation de la methode servant en vérifier si les données numeriques les sont vraiment
        public void notice()
        {
            txtUserName.Text = "Nom d'utilisateur";
            txtPassword.Text = "Mot de passe";        
        }

        private void frmUsersCpt_Load(object sender, EventArgs e)
        {
            //chargement avec le type de copmte user simple
            rbSimpleCpt.Checked = true;
            notice();
            loard();
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Nom d'utilisateur")
            {
                txtUserName.Text = "";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mot de passe";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mot de passe")
            {
                txtPassword.Text = "";
            }
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Nom d'utilisateur";
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            notice();

            btnSaved.Enabled = true;
            btnToModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            loard();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Etes-vous sûr d'avoir inscrit le nouveau mot de passe ?"))
            {
                Services.FRM.frmVerifyPWD frm = new Services.FRM.frmVerifyPWD();

                //provenance de la commande pour la frm
                frm.FRM = "FRM_User";
                frm.txtUserName.Text = this.txtUserName.Text;
                if (dgvData.CurrentRow.Cells[3].Value.ToString() == "Administrateur")
                {
                    frm.rbAdminCpt.Checked = true;
                }
                else
                {
                    frm.rbSimpleCpt.Checked = true;
                }

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        if (frm.FRM == "FRM_User")
                        {
                            modify();
                        }
                    }
                    catch (Exception ex)
                    {
                        //on ne fait rien
                        msg.getError("Erreur " + ex.Message);
                    }
                }
                else
                {
                    msg.getAttention("Erreur, vous n'est pouver modifier ce compte");
                }
            }
            else
            {
                // on ne fait rien
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            migrate();
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            migrate();
        }

        private void rbAdminCpt_CheckedChanged(object sender, EventArgs e)
        {
            type = "Administrateur";
        }

        private void rbSimpleCpt_CheckedChanged(object sender, EventArgs e)
        {
            type = "Simple User";
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0)
            {
                Views.Secure.frmAccess frm = new Secure.frmAccess();
                //on transfert les data
                frm.id_agent = dgvData.CurrentRow.Cells[0].Value.ToString();
                frm.names_agent = dgvData.CurrentRow.Cells[1].Value.ToString();

                //on passe le noms de la personne et son numero de facture sur le titre de la fenetre
                frm.Text = "Ajout des droits d'accès utilisateur [ " + dgvData.CurrentRow.Cells[1].Value.ToString().ToUpper() + " ]";
                frm.ShowDialog();
            }
            else
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Attention, veillez charger la facture !");
            }
        }
    }
}
