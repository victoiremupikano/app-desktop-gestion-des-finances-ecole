using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Models
{
    class Mtb_year
    {
        public Dictionary<string, string> callback;

        public async void insert(Dictionary<string, string> args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    if (await Apps.Query.insertPrepared(
                            schema.table["tb_year"],
                                new MySqlParameter($"@{schema.tb_year["wording"]}", args["wording"]),
                                new MySqlParameter($"@{schema.tb_year["dteStart"]}", args["dteStart"]),
                                new MySqlParameter($"@{schema.tb_year["dteEnd"]}", args["dteEnd"]),
                                new MySqlParameter($"@{schema.tb_year["status"]}", args["status"]),
                                new MySqlParameter($"@{schema.tb_year["fk_user"]}", args["fk_user"])
                            ))
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "success" }, { "message", "Information enregistrer" }
                        };
                    }
                    else
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "failure" }, { "message", "Enregistrement echouer" }
                        };
                    }
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Enregistrement echouer " + ex.Message}
                    };
            }
        }
        public async void update(Dictionary<string, string> args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();

                    if (await Apps.Query.updatePrepared(
                            schema.table["tb_year"],
                                new MySqlParameter($"@{schema.tb_year["id"]}", args["id"]),
                                new MySqlParameter($"@{schema.tb_year["wording"]}", args["wording"]),
                                new MySqlParameter($"@{schema.tb_year["dteStart"]}", args["dteStart"]),
                                new MySqlParameter($"@{schema.tb_year["dteEnd"]}", args["dteEnd"]),
                                new MySqlParameter($"@{schema.tb_year["status"]}", args["status"]),
                                new MySqlParameter($"@{schema.tb_year["fk_user"]}", args["fk_user"])
                            ))
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "success" }, { "message", "Information modifier" }
                        };
                    }
                    else
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "failure" }, { "message", "Modification echouer" }
                        };
                    }
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Modification echouer " + ex.Message}
                    };
            }

        }
        public async void delete(Dictionary<string, string> args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();

                    if (await Apps.Query.deletePrepared(
                            schema.table["tb_year"],
                                new MySqlParameter($"@{schema.tb_year["id"]}", args["id"])
                           ))
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "success" }, { "message", "Information supprimer" }
                        };
                    }
                    else
                    {
                        callback = new Dictionary<string, string> {
                            { "type", "failure" }, { "message", "Suppression echouer" }
                        };
                    }
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Suppression echouer " + ex.Message}
                    };
            }

        }
        public async void reseach(string param)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select * from {schema.table["tb_year"]} where {schema.tb_year["wording"]} like '%{param}%' order by {schema.tb_year["id"]} DESC;");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }
        public async void get()
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select * from {schema.table["tb_year"]} order by {schema.tb_year["id"]} DESC;");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }

        public async void getActif()
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select * from {schema.table["tb_year"]} where {schema.tb_year["status"]} = 'True' order by {schema.tb_year["id"]} DESC");
                    callback = new Dictionary<string, string> {
                        { "type", "success" }, { "message", "Collecte des données sans soucies" }
                    };
                }
                else
                {
                    callback = new Dictionary<string, string> {
                        { "type", "connection" }, { "message", "Impossible d'acceder à la base de données; vérifier votre connexion" }
                    };
                }
            }
            catch (Exception ex)
            {
                callback = new Dictionary<string, string> {
                        { "type", "failure" }, { "message", "Chargement echouer " + ex.Message}
                    };
            }
        }
        public void session()
        {
            Mtb_year obj = new Mtb_year();
            obj.getActif();
            if (obj.callback["type"] == "success")
            {
                Services.Session.ExerciselSession = new Dictionary<string, string> {
                            { "id", string.Empty},
                            { "dteStart", string.Empty},
                            { "dteEnd", string.Empty},
                            { "status", string.Empty},
                        };

                MySqlDataReader dr = Apps.Query.DR;
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        Services.Session.ExerciselSession = new Dictionary<string, string> {
                            { "id", dr[0].ToString()},
                            { "dteStart", dr[1].ToString()},
                            { "dteEnd", dr[2].ToString()},
                            { "status", dr[3].ToString()},
                        };
                    }
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
    }
}
