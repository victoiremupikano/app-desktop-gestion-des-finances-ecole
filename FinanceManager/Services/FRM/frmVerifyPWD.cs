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

namespace Commercial_Management.Services.FRM
{
    public partial class frmVerifyPWD : Form
    {
        public string FRM { get; set; }
        public string type = string.Empty;

        public frmVerifyPWD()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                msg.getError("Erreur, veillez renseigner le nom d'utilisateur ?");
            }
            else
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    msg.getError("Erreur, veillez renseigner le mot de passe ?");
                }
                else
                {
                    Services.Crypto crypt = new Services.Crypto();

                    Dictionary<string, string> fields = new Dictionary<string, string>
                    {
                        {"user", txtUserName.Text },
                        {"pwd", crypt.Hash(txtPassword.Text) },
                        {"type", type }
                    };
                    LoginLogout linlout = new LoginLogout(fields);
                    linlout.login(linlout);

                    if (linlout.callback["type"] == "success")
                    {
                        if (Apps.Query.DR.HasRows)
                        {
                            //on retourne normalement
                            DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else
                        {
                            msg.getError("Il y a pas des données correspondant ?");
                        }
                        Apps.Query.DR.Close();
                    }
                    else if (linlout.callback["type"] == "failure")
                    {
                        msg.getError(linlout.callback["message"]);
                    }
                    else
                    {
                        msg.getError(linlout.callback["message"]);
                    }
                }
            }
        }

        private void rbSimpleCpt_CheckedChanged_1(object sender, EventArgs e)
        {
            type = "Simple User";
        }

        private void rbAdminCpt_CheckedChanged_1(object sender, EventArgs e)
        {
            type = "Administrateur";
        }
    }
}
