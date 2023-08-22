using FinanceManager.Views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Models
{
    class MAccount
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
                            schema.table["tb_account"],
                                new MySqlParameter($"@{schema.tb_account["wording"]}", args["wording"]),
                                new MySqlParameter($"@{schema.tb_account["fk1"]}", args["fk1"]),
                                new MySqlParameter($"@{schema.tb_account["fk2"]}", args["fk2"]),
                                new MySqlParameter($"@{schema.tb_account["fk_year"]}", args["fk_year"]),
                                new MySqlParameter($"@{schema.tb_account["fk_user"]}", args["fk_user"])
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
                            schema.table["tb_account"],
                                new MySqlParameter($"@{schema.tb_account["id"]}", args["id"]),
                                new MySqlParameter($"@{schema.tb_account["wording"]}", args["wording"]),
                                new MySqlParameter($"@{schema.tb_account["fk1"]}", args["fk1"]),
                                new MySqlParameter($"@{schema.tb_account["fk2"]}", args["fk2"]),
                                new MySqlParameter($"@{schema.tb_account["fk_year"]}", args["fk_year"]),
                                new MySqlParameter($"@{schema.tb_account["fk_user"]}", args["fk_user"])
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
                            schema.table["tb_account"],
                                new MySqlParameter($"@{schema.tb_account["id"]}", args["id"])
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
                    Apps.Query.getData($"select * from {schema.table["tb_account"]} where {schema.tb_account["wording"]} like '%{param}%' order by {schema.tb_account["id"]} DESC;");
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
        public async void get(string param)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select student.student_id, student.names, student.kind, student.level, trimestry.wording, account.fk_trimestry, account.account_id from account inner join student on student.student_id = account.fk_student inner join trimestry on trimestry.trimestry_id = account.fk_trimestry where account.fk_trimestry = '{param}' order by {schema.tb_account["id"]} DESC;");
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
        public async void getStatusAccountByStudent(string param)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select student.student_id, student.names, student.kind, student.level, trimestry.wording, trimestry.mt_to_pay, ifnull((select sum(ifnull(payment.mt_payed, 0)) from payment where payment.fk_account = tf.account_id),0) as mt_payed, (trimestry.mt_to_pay - (ifnull((select sum(ifnull(payment.mt_payed, 0)) from payment where payment.fk_account = tf.account_id),0))) as solde, tf.fk_trimestry, tf.account_id from account as tf inner join student on student.student_id = tf.fk_student inner join trimestry on trimestry.trimestry_id = tf.fk_trimestry where student.student_id = '{param}' and {schema.tb_account["fk_year"]} = '{Services.Session.ExerciselSession["id"]}';");
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
