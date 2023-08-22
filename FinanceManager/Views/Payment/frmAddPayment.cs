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
using MySql.Data.MySqlClient;

namespace FinanceManager.Views.Payment
{
    public partial class frmAddPayment : Form
    {
        public string id, fk_account;
        public double mt_total = 0;
        Services.convertDate valid = new Services.convertDate();

        public frmAddPayment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modify()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtMontant.Text) || string.IsNullOrEmpty(txtWording.Text))
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                if (msg.getDialog("Etes-vous sûr de vouloir modifier ?"))
                {
                    Dictionary<string, string> fields = new Dictionary<string, string>{
                        {"id", id},
                        {"wording", txtWording.Text},
                        {"mt_payed", txtMontant.Text.Replace(",", ".")},
                        {"fk1", fk_account},
                        {"fk_year", Services.Session.ExerciselSession["id"]},
                        {"fk_user", Services.Session.UserSession["id"]}
                    };

                    //on passe les donnees dans le controllers
                    Controllers.CPayment obj = new Controllers.CPayment(fields);
                    obj.update(obj);

                    if (obj.message["type"] == "success")
                    {
                        msg.getInfo(obj.message["message"]);

                        loard(fk_account);
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
                Controllers.CPayment obj = new Controllers.CPayment(fields);
                obj.delete(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);

                    loard(fk_account);
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

        private void loard(string param)
        {
            Models.MPayment obj = new Models.MPayment();
            obj.getByAccount(param);
            if (obj.callback["type"] == "success")
            {
                //on vide la dgv
                dgvData.Rows.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    dgvData.Rows.Add(dr[0].ToString(), dr[2].ToString(), dr[1].ToString(), dr[3].ToString(), dr[4].ToString());
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
            btnToModify.Enabled = true;
        }

        private void save()
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtMontant.Text) || string.IsNullOrEmpty(txtWording.Text))
            {
                msg.getAttention("Erreur, veiller remplir tous les champs ?");
            }
            else
            {
                Dictionary<string, string> fields = new Dictionary<string, string>{
                        {"wording", txtWording.Text},
                        {"mt_payed", txtMontant.Text.Replace(",", ".")},
                        {"fk1", fk_account},
                        {"fk_year", Services.Session.ExerciselSession["id"]},
                        {"fk_user", Services.Session.UserSession["id"]}
                    };

                //on passe les donnees dans le controllers
                Controllers.CPayment obj = new Controllers.CPayment(fields);
                obj.add(obj);

                if (obj.message["type"] == "success")
                {
                    msg.getInfo(obj.message["message"]);

                    loard(fk_account);
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

        private void migrate()
        {
            if (dgvData.Rows.Count > 0 && dgvData.SelectedRows.Count > 0)
            {
                id = dgvData.CurrentRow.Cells[0].Value.ToString();
                txtMontant.Text = dgvData.CurrentRow.Cells[1].Value.ToString().Replace(".", ",");
                txtWording.Text = dgvData.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void dgvDeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            migrate();
        }

        private void dgvDeta_SelectionChanged(object sender, EventArgs e)
        {
            migrate();
        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ','))
            {
                e.Handled = true;
            }
            TextBox txtDecimal = sender as TextBox;
            try
            {
                if (e.KeyChar == ',' && txtDecimal.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
            catch { }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtWording.Text = "-";
            txtMontant.Text = "0";

            btnDelete.Enabled = false;
            btnToModify.Enabled = false;
            btnSaved.Enabled = true;
        }

        ///FX pour la somme des detaills deja enregistrer
        ///
        private double totDGV()
        {
            Services.DtgvServices dgv = new Services.DtgvServices();
            return dgv.DGV_total(dgvData, 1);
        }

        private void btnSaved_Click(object sender, EventArgs e)
        {
            if (mt_total >= totDGV() + double.Parse(txtMontant.Text.Replace(",", ".")))
            {
                save();
            }
            else
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Attention, le montant payer ne doit pas excedé le solde à payer !");
            }
        }

        private void btnLoard_Click(object sender, EventArgs e)
        {
            loard(fk_account);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void frmAddPayment_Load(object sender, EventArgs e)
        {
            loard(fk_account);
        }

        private void btnToModify_Click(object sender, EventArgs e)
        {
            double nbrToModify = double.Parse(dgvData.CurrentRow.Cells[1].Value.ToString().Replace(",", "."));
            if (mt_total + nbrToModify >= totDGV() + double.Parse(txtMontant.Text.Replace(",", ".")))
            {
                modify();
            }
            else
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getAttention("Attention, le montant payer ne doit pas excedé le solde à payer !");
            }
        }    
    }
}
