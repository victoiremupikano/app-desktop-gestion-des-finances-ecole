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

            this.pnlBasFactures.Visible = false;
            this.pnlBasProduits.Visible = false;
            this.pnlBasRapports.Visible = false;
            this.pnlBasArrivage.Visible = false;
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
        
                    this.pnlBasFactures.Visible = false;
                    this.pnlBasProduits.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasArrivage.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_mollecules()
        {
            try
            {
                if (!Views.Product.frmMolecules.IsFormOpen(typeof(Views.Product.frmMolecules)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.Product.frmMolecules());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasFactures.Visible = false;
                    this.pnlBasProduits.Visible = true;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasArrivage.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_arrival()
        {
            try
            {
                if (!Views.Arrival.frmYear.IsFormOpen(typeof(Views.Arrival.frmYear)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.Arrival.frmYear());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasFactures.Visible = false;
                    this.pnlBasProduits.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasArrivage.Visible = true;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_custommer()
        {
            try
            {
                if (!Views.Custommer.frmInvoice.IsFormOpen(typeof(Views.Custommer.frmInvoice)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.Custommer.frmInvoice());

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasFactures.Visible = false;
                    this.pnlBasProduits.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasArrivage.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_flux()
        {
            try
            {
                if (!Views.Flux.frmFlux.IsFormOpen(typeof(Views.Flux.frmFlux)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.Flux.frmFlux());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasFactures.Visible = true;
                    this.pnlBasProduits.Visible = false;
                    this.pnlBasRapports.Visible = false;
                    this.pnlBasArrivage.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
        private void call_reports()
        {
            try
            {
                if (!Views.Reports.frmReport_UI.IsFormOpen(typeof(Views.Reports.frmReport_UI)))
                {
                    //code pur repatrier la frm concerner dans le pnlCentral
                    callMultiForm(new Views.Reports.frmReport_UI());
                    //...
                    //.. votre code concernant le boutton

                    //rendre les panels de bas invisible au clic btn sauf pour le btn
        
                    this.pnlBasFactures.Visible = false;
                    this.pnlBasProduits.Visible = false;
                    this.pnlBasRapports.Visible = true;
                    this.pnlBasArrivage.Visible = false;
                }
                else
                {
                    //on ne fait rien
                }
            }
            catch { }
        }
    }
}
