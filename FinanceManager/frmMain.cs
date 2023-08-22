using FinanceManager.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //creation de la fonction ou methode de rapatriement des frm dans le formulaire Principale
        private Form activeForm = null;
        private void callMultiForm(Form chilForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            pnlCentraleFrmmain.Controls.Add(chilForm);
            pnlCentraleFrmmain.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //rendre les panels de bas invisible au demarrage

            this.pnlBasPayment.Visible = false;
            this.pnlBasAccount.Visible = false;
            this.pnlBasRapports.Visible = false;
            this.pnlBasStudent.Visible = false;
            //demarrage de l'App en plein ecran
            this.WindowState = FormWindowState.Maximized;

            //Fonction de demarrage du timer
            StartMyTime();
        }

        /// <summary>
        /// Gestion de l'heure afficher dans l'interface principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void MyTime()
        {
            string seconde = DateTime.Now.Second.ToString();
            string minute = DateTime.Now.Minute.ToString();

            if ((double.Parse(seconde) < 10) && (double.Parse(seconde) >= 0))
            {
                seconde = "0" + seconde;
            }

            if ((double.Parse(minute) < 10) && (double.Parse(minute) >= 0))
            {
                minute = "0" + minute;
            }

            lblTimeCurrent.Text = DateTime.Now.Hour + " : " + minute + " : " + seconde;

        }

        //Fonction de demarrage du timer
        private void StartMyTime()
        {
            timerPrincipal.Start();
            MyTime(); //Mise en jour de l'heure a l'instantanée

        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            MyTime(); //Mise en jour de l'heure a l'instantanée
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Settings.Default.closingState = "Minimized";
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                Settings.Default.closingState = "Maximized";
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.closingState = "Normal";
            }
            Settings.Default.Save();
            Application.Exit();
        }

        #region called-FRM
        private void call_user()
        {
            try
            {
                if (!Views.frmUsers.IsFormOpen(typeof(Views.frmUsers)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.frmUsers());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasPayment.Visible = false;
                    this.pnlBasAccount.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasStudent.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_year()
        {
            try
            {
                if (!Views.frmYear.IsFormOpen(typeof(Views.frmYear)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.frmYear());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasPayment.Visible = false;
                    this.pnlBasAccount.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasStudent.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_trimestry()
        {
            try
            {
                if (!Views.frmTrimestry.IsFormOpen(typeof(Views.frmTrimestry)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.frmTrimestry());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn

                    this.pnlBasPayment.Visible = false;
                    this.pnlBasAccount.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasStudent.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_student()
        {
            try
            {
                if (!Views.frmSearchStudent.IsFormOpen(typeof(Views.frmSearchStudent)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.frmStudent());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn

                    this.pnlBasPayment.Visible = false;
                    this.pnlBasAccount.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasStudent.Visible = true;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_account()
        {
            try
            {
                if (!Views.frmAccount.IsFormOpen(typeof(Views.frmAccount)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.frmAccount());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn

                    this.pnlBasPayment.Visible = false;
                    this.pnlBasAccount.Visible = true;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasStudent.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }

        private void call_payment()
        {
            try
            {
                if (!Views.Payment.frmAccountByStudent.IsFormOpen(typeof(Views.Payment.frmAccountByStudent)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.Payment.frmAccountByStudent());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn

                    this.pnlBasPayment.Visible = true;
                    this.pnlBasAccount.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasStudent.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }


        #endregion

        #region menu-haut
        private void CopteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_user();
        }

        private void annéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_year();
        }

        private void trimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_trimestry();
        }

        private void arrivageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_student();
        }

        private void moleculesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_account();
        }

        private void facturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            call_payment();
        }

        private void rapportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region btn
        private void btnStudent_Click(object sender, EventArgs e)
        {
            call_student();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            call_account();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            call_payment();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
