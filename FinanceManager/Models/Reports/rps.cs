using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace FinanceManager.Models.Reports
{
    class rps
    {
        public Dictionary<string, string> message;
        private string Query;

        MySqlDataAdapter InvPhisiqueAdapter;
        private ReportDocument document;

        //les dates du rapports
        public static string id_student, names_student, dte = string.Empty;

        private void sql(string byQuery)
        {
            if (byQuery == "Liste apprenants")
            {
                Query = $"select tb_product.id as id, tb_product.reference as ref, tb_product.dci as dci, tb_product.pv as pv, tb_product.cdte as cdte, tb_product.stk as stk, tb_category.design as dci_categ, ((ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Entrée' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0)) / tb_product.cdte) as stk_entrer_c, ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Entrée' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0) as stk_entrer_d, ((ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Sortie' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0)) / tb_product.cdte) as stk_sortie_c, ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Sortie' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0) as stk_sortie_d, ((ifnull(((ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Entrée' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0) - (ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Sortie' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0)))), 0)) / tb_product.cdte) as stk_solde_c, ifnull(((ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Entrée' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0) - (ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Sortie' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0)))), 0) as stk_solde_d, ((ifnull(((ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Entrée' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0) - (ifnull((select sum(ifnull(tb_flux.qtd, 0)) from tb_flux where tb_flux.operation = 'Sortie' and tb_flux.fk_arrival = tf.fk_arrival and tb_flux.fk_product = tf.fk_product), 0)))), 0)) * tb_product.pv) as ptt_solde from tb_flux as tf inner join tb_product on tb_product.id = tf.fk_product inner join tb_category on tb_category.id = tb_product.fk_category where tf.fk_arrival = '{id_arr}' group by tf.fk_product order by tb_product.id ASC;";
            }
            else if (byQuery == "Paiement du jour")
            {
                Query = $"select tf.dte, tf.number as num, tb_invoice.names, tb_invoice.telephone as number, ifnull((select ifnull(sum(tb_flux.qtd * tb_flux.pvt),0) from tb_flux where tb_flux.number = tf.number), 0) as mt_to_pay, ifnull((select ifnull(sum(tb_payement.mt), 0) from tb_payement where tb_payement.number = tf.number), 0) as mt_payed, ((ifnull((select ifnull(sum(tb_flux.qtd * tb_flux.pvt), 0) from tb_flux where tb_flux.number = tf.number), 0)) - (ifnull((select ifnull(sum(tb_payement.mt), 0) from tb_payement where tb_payement.number = tf.number), 0))) as mt_solde from tb_flux as tf inner join tb_invoice on tb_invoice.id = tf.fk_custommer where tf.fk_arrival = '{id_arr}' group by tf.number order by tb_invoice.id DESC;";
            }
            else if (byQuery == "Flux de paiement")
            {
                Query = $"select tf.dte, tf.number as num, tb_invoice.names, tb_invoice.telephone as number, ifnull((select ifnull(sum(tb_flux.qtd * tb_flux.pvt),0) from tb_flux where tb_flux.number = tf.number), 0) as mt_to_pay, ifnull((select ifnull(sum(tb_payement.mt), 0) from tb_payement where tb_payement.number = tf.number), 0) as mt_payed, ((ifnull((select ifnull(sum(tb_flux.qtd * tb_flux.pvt), 0) from tb_flux where tb_flux.number = tf.number), 0)) - (ifnull((select ifnull(sum(tb_payement.mt), 0) from tb_payement where tb_payement.number = tf.number), 0))) as mt_solde from tb_flux as tf inner join tb_invoice on tb_invoice.id = tf.fk_custommer where tf.fk_arrival = '{id_arr}' and date(tf.dte) >= '{dte1}' and date(tf.dte) <= '{dte2}' group by tf.number order by tb_invoice.id DESC;";
            }
            else if (byQuery == "Situation par apprenant")
            {
                Query = $"select tb_product.id as id, tb_product.reference as ref, tb_product.dci as dci, tb_product.pv as pv, tb_product.cdte as cdte, tb_product.stk as stk, tb_category.design as dci_categ from tb_product inner join tb_category on tb_category.id = tb_product.fk_category order by tb_product.id DESC;";
            }
        }

        public ReportDocument rpsView(string parm)
        {
            try
            {
                sql(parm); //le code sql
                string byQuery = parm;

                if (byQuery == "Flux par arrivage")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "flux arr or es");
                    Views.Reports.Documents.CrystalReport_flux_arr_or_es CFACTT = new Views.Reports.Documents.CrystalReport_flux_arr_or_es();
                    CFACTT.SetDataSource(DataSet.Tables["flux arr or es"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "RAPPORT DE STOCK POUR L' ARRIVAGE : " + names_arr.ToUpper();
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Inscription par arrivage")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "subscriber or pay");
                    Views.Reports.Documents.CrystalReport_subscriber_or_pay CFACTT = new Views.Reports.Documents.CrystalReport_subscriber_or_pay();
                    CFACTT.SetDataSource(DataSet.Tables["subscriber or pay"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "RAPPORT DES INSCRIPTIONS POUR L' ARRIVAGE : " + names_arr.ToUpper();
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Inscription par arrivage et par dates")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "subscriber or pay");
                    Views.Reports.Documents.CrystalReport_subscriber_or_pay CFACTT = new Views.Reports.Documents.CrystalReport_subscriber_or_pay();
                    CFACTT.SetDataSource(DataSet.Tables["subscriber or pay"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "RAPPORT DES INSCRIPTIONS POUR L' ARRIVAGE : " + names_arr.ToUpper() + " DU : " + dte1 + " AU : " + dte2;
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Liste des produits")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "product");
                    Views.Reports.Documents.CrystalReport_product CFACTT = new Views.Reports.Documents.CrystalReport_product();
                    CFACTT.SetDataSource(DataSet.Tables["product"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DES PRODUITS";
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Liste des produits avec code barre")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "product bc");
                    Views.Reports.Documents.CrystalReport_product_bc CFACTT = new Views.Reports.Documents.CrystalReport_product_bc();
                    CFACTT.SetDataSource(DataSet.Tables["product bc"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DES PRODUITS AVEC CODES BARRES";
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Mvt par produit")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "mvt");
                    Views.Reports.Documents.CrystalReport_mvt CFACTT = new Views.Reports.Documents.CrystalReport_mvt();
                    CFACTT.SetDataSource(DataSet.Tables["mvt"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DES VENTES POUR LE PRODUIT : " + names_product.ToUpper();
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Mvt par produit et par dates")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "mvt");
                    Views.Reports.Documents.CrystalReport_mvt CFACTT = new Views.Reports.Documents.CrystalReport_mvt();
                    CFACTT.SetDataSource(DataSet.Tables["mvt"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DES VENTES POUR LE PRODUIT : " + names_product.ToUpper() + " DU : " + dte1 + " AU : " + dte2;
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Mvt par produit et par arrivage")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "mvt");
                    Views.Reports.Documents.CrystalReport_mvt CFACTT = new Views.Reports.Documents.CrystalReport_mvt();
                    CFACTT.SetDataSource(DataSet.Tables["mvt"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DES VENTES POUR LE PRODUIT : " + names_product.ToUpper() + " DANS L'ARRIVAGE : " + names_arr.ToUpper();
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Mvt par produit et par arrivage et par dates")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "mvt");
                    Views.Reports.Documents.CrystalReport_mvt CFACTT = new Views.Reports.Documents.CrystalReport_mvt();
                    CFACTT.SetDataSource(DataSet.Tables["mvt"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DES VENTES POUR LE PRODUIT : " + names_product.ToUpper() + " DANS L'ARRIVAGE : " + names_arr.ToUpper() + " DU : " + dte1 + " AU : " + dte2;
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Liste des paiements")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "subscriber or pay");
                    Views.Reports.Documents.CrystalReport_subscriber_or_pay CFACTT = new Views.Reports.Documents.CrystalReport_subscriber_or_pay();
                    CFACTT.SetDataSource(DataSet.Tables["subscriber or pay"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "RAPPORT DES PAIEMENTS";
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Liste des paiements et par dates")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "subscriber or pay");
                    Views.Reports.Documents.CrystalReport_subscriber_or_pay CFACTT = new Views.Reports.Documents.CrystalReport_subscriber_or_pay();
                    CFACTT.SetDataSource(DataSet.Tables["subscriber or pay"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "RAPPORT DES PAIEMENTS DU : " + dte1 + " AU " + dte2;
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Etat global du stock")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "flux arr or es");
                    Views.Reports.Documents.CrystalReport_flux_arr_or_es CFACTT = new Views.Reports.Documents.CrystalReport_flux_arr_or_es();
                    CFACTT.SetDataSource(DataSet.Tables["flux arr or es"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "RAPPORT GLOBAL DE STOCK PAR PRODUIT";
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Facture")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "invoice");
                    Views.Reports.Documents.CrystalReport_invoice CFACTT = new Views.Reports.Documents.CrystalReport_invoice();
                    CFACTT.SetDataSource(DataSet.Tables["invoice"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Reçu")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "receive");
                    Views.Reports.Documents.CrystalReport_invoice_received_pay CFACTT = new Views.Reports.Documents.CrystalReport_invoice_received_pay();
                    CFACTT.SetDataSource(DataSet.Tables["receive"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    //On passe le document
                    document = CFACTT;
                }
                else if (byQuery == "Perissable")
                {
                    InvPhisiqueAdapter = new MySqlDataAdapter(Query, Apps.Query.conn);
                    InvPhisiqueAdapter.SelectCommand.CommandTimeout = 0;
                    Views.Reports.DataSet1 DataSet = new Views.Reports.DataSet1();
                    InvPhisiqueAdapter.Fill(DataSet, "perissable");
                    Views.Reports.Documents.CrystalReport_perissable CFACTT = new Views.Reports.Documents.CrystalReport_perissable();
                    CFACTT.SetDataSource(DataSet.Tables["perissable"]);
                    // entete du rapport
                    TextObject designation = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextDesignation"];
                    designation.Text = Services.Session.ProfileSession["names"];
                    TextObject nrc = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNRC"];
                    nrc.Text = Services.Session.ProfileSession["nrc"];
                    TextObject adress = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextAdress"];
                    adress.Text = Services.Session.ProfileSession["adress"];
                    TextObject tele = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextNumber"];
                    tele.Text = Services.Session.ProfileSession["tele"];
                    TextObject title = (TextObject)CFACTT.ReportDefinition.Sections["Section1"].ReportObjects["TextTitle"];
                    title.Text = "LISTE DE PRODUIT PERISSABLE POUR L'ARRIVAGE : " + names_arr.ToUpper();
                    //On passe le document
                    document = CFACTT;
                }
                message = new Dictionary<string, string> {
                    { "type", "success" }, { "message", "Rapport générer" }
                };
            }
            catch (Exception ex)
            {
                message = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Erreur du rapport générer " + ex.ToString() }
                    };
            }
            return document;
        }
    }
}
