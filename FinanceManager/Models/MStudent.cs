using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Models
{
    class MStudent
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
                            schema.table["tb_student"],
                                new MySqlParameter($"@{schema.tb_student["names"]}", args["names"]),
                                new MySqlParameter($"@{schema.tb_student["kind"]}", args["kind"]),
                                new MySqlParameter($"@{schema.tb_student["birthday"]}", args["birthday"]),
                                new MySqlParameter($"@{schema.tb_student["children_father"]}", args["children_father"]),
                                new MySqlParameter($"@{schema.tb_student["children_mather"]}", args["children_mather"]),
                                new MySqlParameter($"@{schema.tb_student["religin"]}", args["religin"]),
                                new MySqlParameter($"@{schema.tb_student["adress"]}", args["adress"]),
                                new MySqlParameter($"@{schema.tb_student["tel"]}", args["tel"]),
                                new MySqlParameter($"@{schema.tb_student["level"]}", args["level"]),
                                new MySqlParameter($"@{schema.tb_student["fk_year"]}", args["fk_year"]),
                                new MySqlParameter($"@{schema.tb_student["fk_user"]}", args["fk_user"])
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
                            schema.table["tb_student"],
                                new MySqlParameter($"@{schema.tb_student["id"]}", args["id"]),
                                new MySqlParameter($"@{schema.tb_student["names"]}", args["names"]),
                                new MySqlParameter($"@{schema.tb_student["kind"]}", args["kind"]),
                                new MySqlParameter($"@{schema.tb_student["birthday"]}", args["birthday"]),
                                new MySqlParameter($"@{schema.tb_student["children_father"]}", args["children_father"]),
                                new MySqlParameter($"@{schema.tb_student["children_mather"]}", args["children_mather"]),
                                new MySqlParameter($"@{schema.tb_student["religin"]}", args["religin"]),
                                new MySqlParameter($"@{schema.tb_student["adress"]}", args["adress"]),
                                new MySqlParameter($"@{schema.tb_student["tel"]}", args["tel"]),
                                new MySqlParameter($"@{schema.tb_student["level"]}", args["level"]),
                                new MySqlParameter($"@{schema.tb_student["fk_year"]}", args["fk_year"]),
                                new MySqlParameter($"@{schema.tb_student["fk_user"]}", args["fk_user"])
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
                            schema.table["tb_student"],
                                new MySqlParameter($"@{schema.tb_student["id"]}", args["id"])
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
                    Apps.Query.getData($"select * from {schema.table["tb_student"]} where {schema.tb_student["names"]} like '%{param}%' order by {schema.tb_student["id"]} DESC;");
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
                    Apps.Query.getData($"select * from {schema.table["tb_student"]} order by {schema.tb_student["id"]} DESC;");
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
    }
}
