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

        //public ComboBox cboMember()
        //{
        //    Apps.Schema schema = new Apps.Schema();
        //    Dictionary<string, string> fields = new Dictionary<string, string>
        //        {
        //            {"query", $"select names_member from {schema.table["tb_member"]} order by {schema.tb_member["id"]} DESC;"}
        //        };
        //    ;

        //    Services.CBO.Db obj = new Db();
        //    obj.getDR(fields);
        //    if (obj.callback["type"] == "success")
        //    {
        //        //on vide
        //        cbo.Items.Clear();
        //        MySqlDataReader dr = Apps.Query.DR;

        //        while (dr.Read())
        //        {
        //            cbo.Items.Add(dr[0].ToString());
        //        }
        //        Apps.Query.DR.Close();
        //    }
        //    else if (obj.callback["type"] == "failure")
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    else
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    return cbo;
        //}

        //public ComboBox cboService()
        //{
        //    Apps.Schema schema = new Apps.Schema();
        //    Dictionary<string, string> fields = new Dictionary<string, string>
        //        {
        //            {"query", $"select names_services from {schema.table["tb_services"]} order by {schema.tb_services["id"]} DESC;"}
        //        };
        //    ;

        //    Services.CBO.Db obj = new Db();
        //    obj.getDR(fields);
        //    if (obj.callback["type"] == "success")
        //    {
        //        //on vide
        //        cbo.Items.Clear();
        //        MySqlDataReader dr = Apps.Query.DR;

        //        while (dr.Read())
        //        {
        //            cbo.Items.Add(dr[0].ToString());
        //        }
        //        Apps.Query.DR.Close();
        //    }
        //    else if (obj.callback["type"] == "failure")
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    else
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    return cbo;
        //}

        //public ComboBox cboJob(string param)
        //{
        //    Apps.Schema schema = new Apps.Schema();
        //    Dictionary<string, string> fields = new Dictionary<string, string>
        //        {
        //            {"query", $"select names_job from {schema.table["tb_job"]} where {schema.tb_job["fk_serv"]} = '{param}' order by {schema.tb_job["id"]} DESC;"}
        //        };
        //    ;

        //    Services.CBO.Db obj = new Db();
        //    obj.getDR(fields);
        //    if (obj.callback["type"] == "success")
        //    {
        //        //on vide
        //        cbo.Items.Clear();
        //        MySqlDataReader dr = Apps.Query.DR;

        //        while (dr.Read())
        //        {
        //            cbo.Items.Add(dr[0].ToString());
        //        }
        //        Apps.Query.DR.Close();
        //    }
        //    else if (obj.callback["type"] == "failure")
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    else
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    return cbo;
        //}

        //public ComboBox cboDayInHourlyPartial(string param)
        //{
        //    Apps.Schema schema = new Apps.Schema();
        //    Dictionary<string, string> fields = new Dictionary<string, string>
        //        {
        //            {"query", $"select hourly.day_hourly from hourly where hourly.isNormal = 'False' and hourly.fk_job = '{param}' group by hourly.day_hourly order by hourly.id_hourly DESC;"}
        //        };
        //    ;

        //    Services.CBO.Db obj = new Db();
        //    obj.getDR(fields);
        //    if (obj.callback["type"] == "success")
        //    {
        //        //on vide
        //        cbo.Items.Clear();
        //        MySqlDataReader dr = Apps.Query.DR;

        //        while (dr.Read())
        //        {
        //            cbo.Items.Add(dr[0].ToString());
        //        }
        //        Apps.Query.DR.Close();
        //    }
        //    else if (obj.callback["type"] == "failure")
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    else
        //    {
        //        Services.MsgFRM msg = new Services.MsgFRM();
        //        msg.getError(obj.callback["message"]);
        //    }
        //    return cbo;
        //}
    }
}
