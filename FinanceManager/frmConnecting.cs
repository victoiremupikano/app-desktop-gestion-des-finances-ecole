using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using FinanceManager.Properties;

namespace FinanceManager
{
    public partial class frmConnecting : Form
    {
        int mov;
        int movX;
        int movY;

        int[] rqinSpeed = { 4, 6, 8, 3, 5, 6, 7, 4 };
        int loadingSpeed = 2;
        //creation de la variable stockant l"etat de conn à la base de données
        bool EtatBool;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left,
            int top,
            int right,
            int buttom,
            int width,
            int height
            );
        

        public frmConnecting()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 707, 389, 7, 7));
        }

        private void frmConnecting_Load(object sender, EventArgs e)
        {
            //default
            txtUserName.Text = "dev";
            txtPassword.Text = "developper";
        }


        //fx login
        private void login()
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

                    //
                    String type = string.Empty;
                    if (rbAdminCpt.Checked)
                    {
                        type = "Administrateur";
                    }
                    else
                    {
                        type = "Simple User";
                    }
                    Dictionary<string, string> fields = new Dictionary<string, string>
                    {
                        {"type", type },
                        {"user", txtUserName.Text },
                        {"pwd", crypt.Hash(txtPassword.Text) }
                    };
                    LoginLogout linlout = new LoginLogout(fields);
                    linlout.login(linlout);

                    if (linlout.callback["type"] == "success")
                    {
                        if (Apps.Query.DR.HasRows)
                        {

                            //session
                            Models.MUsers user = new Models.MUsers();
                            user.session(fields);
                            Models.MProfile profile = new Models.MProfile();
                            profile.session();
                            Models.MArrival arrival = new Models.MArrival();
                            arrival.session();

                            //frm et new size
                            frmMain frm = new frmMain();
                            //on verifie le dernier preference de l'utilisateur lors de la fermeture du logiciel
                            if (Settings.Default.closingState == "Minimized")
                            {
                                frm.WindowState = FormWindowState.Minimized;
                            }
                            else if (Settings.Default.closingState == "Maximized")
                            {
                                frm.WindowState = FormWindowState.Maximized;
                            }
                            else if (Settings.Default.closingState == "Normal")
                            {
                                frm.WindowState = FormWindowState.Normal;
                            }
                            frm.Show();
                            // sinon on reste au login
                            this.Hide();
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            SettingsApp.frmSettings frm = new SettingsApp.frmSettings();
            frm.ShowDialog();
        }

        private void ckbVisiblePwd_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVisiblePwd.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void frmConnecting_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void frmConnecting_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movY, MousePosition.Y - movY);
            }
        }

        private void frmConnecting_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
