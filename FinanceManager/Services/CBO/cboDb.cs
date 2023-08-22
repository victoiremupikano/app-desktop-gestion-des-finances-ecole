using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager.Services.CBO
{
    class cboDb
    {
        public ComboBox cbo;

        public ComboBox cboTrimestry()
        {
            Apps.Schema schema = new Apps.Schema();
            Dictionary<string, string> fields = new Dictionary<string, string>
                {
                    {"query", $"select wording from {schema.table["tb_trimestry"]} where {schema.tb_trimestry["fk_year"]} = {Services.Session.ExerciselSession["id"]} order by {schema.tb_trimestry["wording"]} ASC;"}
                };
            ;

            Services.CBO.Db obj = new Db();
            obj.getDR(fields);
            if (obj.callback["type"] == "success")
            {
                //on vide
                cbo.Items.Clear();
                MySqlDataReader dr = Apps.Query.DR;

                while (dr.Read())
                {
                    cbo.Items.Add(dr[0].ToString());
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
            return cbo;
        }
    }
}
