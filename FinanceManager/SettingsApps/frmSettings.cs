using Commercial_Management.Properties;
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

namespace Commercial_Management.SettingsApp
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmParametres_Load(object sender, EventArgs e)
        {
            // instaciation des valeurs par defaut
            txtIp.Text = Settings.Default.ip;
            txtdatabase.Text = Settings.Default.database;
            txtusername.Text = Settings.Default.user;
            txtpassword.Text = Settings.Default.pwd;
            txtport.Text = Settings.Default.port;
            txtMode.Text = Settings.Default.mode;
        }

        private void picModifier_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (msg.getDialog("Voulez-vous vraiment modifier les paramètres ?"))
            {
                if (string.IsNullOrEmpty(txtdatabase.Text) || string.IsNullOrEmpty(txtIp.Text) || string.IsNullOrEmpty(txtMode.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtport.Text) || string.IsNullOrEmpty(txtusername.Text))
                {
                    msg.getAttention("Il y a des champs obligatoire à remplir avant modification ?");
                }
                else
                {
                    Settings.Default.ip = txtIp.Text;
                    Settings.Default.port = txtport.Text;
                    Settings.Default.database = txtdatabase.Text;
                    Settings.Default.user = txtusername.Text;
                    Settings.Default.pwd = txtpassword.Text;
                    Settings.Default.mode = txtMode.Text;

                    //enregistrement 
                    Settings.Default.Save();
                    msg.getInfo("Successfull, l'application va rédemarrer");
                    Application.Restart();
                }
            }
        }

        private void picTester_Click(object sender, EventArgs e)
        {
            Services.MsgFRM msg = new Services.MsgFRM();
            if (string.IsNullOrEmpty(txtdatabase.Text) || string.IsNullOrEmpty(txtIp.Text) || string.IsNullOrEmpty(txtMode.Text) || string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtport.Text) || string.IsNullOrEmpty(txtusername.Text))
            {
                msg.getAttention("Il y a des champs obligatoire à remplir avant modification ?");
            }
            else
            {
                if (txtMode.Text == "none")
                {
                    //on passent les valeurs en tester
                    Apps.Query.ip_ = txtIp.Text;
                    Apps.Query.port_ = txtport.Text;
                    Apps.Query.mode_ = txtMode.Text;
                    Apps.Query.database_ = txtdatabase.Text;
                    Apps.Query.password_ = txtpassword.Text;
                    Apps.Query.username_ = txtusername  .Text;

                    Apps.Query.try_connexion();
                }
                else
                {
                    msg.getAttention("Connexion Désoler. vous n'etes pas autoriser !");
                }
            }
        }
    }
}
