using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager.Views.Search
{
    public partial class frmSearchStudent : Form
    {
        Services.DtgvServices dgv = new Services.DtgvServices();

        public string FRM;

        public string id { get; set; }
        public string names { get; set; }

        public frmSearchStudent()
        {
            InitializeComponent();
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

        private void nbrDgv()
        {
            Int64 NbrData = dgv.DGV_number_line(dgvData);
            txtNbrArr.Text = NbrData.ToString();
        }

        private void recup()
        {
            id = dgvData.CurrentRow.Cells[0].Value.ToString();
            names = dgvData.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtNomArr_TextChanged(object sender, EventArgs e)
        {
            search(txtResearch.Text.Replace("'", "''"));
        }

        private void btnCharger_Click(object sender, EventArgs e)
        {
            loard();
        }

        private void frmSearchInvoice_Load(object sender, EventArgs e)
        {
            loard();
            nbrDgv();
        }

        private void dgvData_DoubleClick(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count > 0 && dgvData.SelectedRows.Count > 0)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            recup();
        }
    }
}
