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
                Query = $"select * from student order by student.names ASC";
            }
            else if (byQuery == "Paiement du jour")
            {
                Query = $"select student.student_id, student.names, student.kind, student.level, trimestry.wording, trimestry.mt_to_pay, ifnull(tf.mt_payed,0) as mt_payed, account.fk_trimestry, account.account_id from payment as tf inner join account on account.account_id = tf.fk_account inner join student on student.student_id = account.fk_student inner join trimestry on trimestry.trimestry_id = account.fk_trimestry where date(tf.row_add) = '{dte}' and tf.fk_year = '{Services.Session.ExerciselSession["id"]}' order by date(tf.row_add) ASC;";
            }
            else if (byQuery == "Flux de paiement")
            {
                Query = $"select student.student_id, student.names, student.kind, student.level, trimestry.wording, trimestry.mt_to_pay, ifnull(tf.mt_payed,0) as mt_payed, account.fk_trimestry, account.account_id from payment as tf inner join account on account.account_id = tf.fk_account inner join student on student.student_id = account.fk_student inner join trimestry on trimestry.trimestry_id = account.fk_trimestry and tf.fk_year = '{Services.Session.ExerciselSession["id"]}' order by date(tf.row_add) ASC;";
            }
            else if (byQuery == "Situation par apprenant")
            {
                Query = $"select student.student_id, student.names, student.kind, student.level, trimestry.wording, trimestry.mt_to_pay, ifnull(tf.mt_payed,0) as mt_payed, account.fk_trimestry, account.account_id from payment as tf inner join account on account.account_id = tf.fk_account inner join student on student.student_id = account.fk_student inner join trimestry on trimestry.trimestry_id = account.fk_trimestry where student.student_id = '{id_student}' and tf.fk_year = '{Services.Session.ExerciselSession["id"]}' order by date(tf.row_add) ASC;";
            }
        }

        public ReportDocument rpsView(string parm)
        {
            try
            {
                sql(parm); //le code sql
                string byQuery = parm;

                if (byQuery == "Liste apprenants")
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
                else if (byQuery == "Paiement du jour")
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
                else if (byQuery == "Flux de paiement")
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
                else if (byQuery == "Situation par apprenant")
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
