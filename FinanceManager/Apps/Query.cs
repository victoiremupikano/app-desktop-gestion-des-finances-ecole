using FinanceManager.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Apps
{
    class Query
    {
        /// <summary>
        /// conexion a la db
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        // var portant la connexion
        public static MySqlConnection conn;

        //les variables de connexion pour le test de connection avant validation
        public static string ip_ { set; get; }
        public static string port_ { set; get; }
        public static string mode_ { set; get; }
        public static string database_ { set; get; }
        public static string username_ { set; get; }
        public static string password_ { set; get; }

        //creation du constructeur avec les parametres de connection à la base de données
        public static void connection()
        {
            string ip = Settings.Default.ip;
            string database = Settings.Default.database;
            string username = Settings.Default.user;
            string password = Settings.Default.pwd;
            string port = Settings.Default.port;

            string connection_string = "server=" + ip + "; port=" + port + "; user=" + username + "; password=" + password + "; database=" + database + "; Max Pool Size=50000; Pooling=True";

            conn = new MySqlConnection(connection_string);
        }
        public static void try_connexion()
        {
            try
            {
                MySqlConnection conn_ = new MySqlConnection();

                string connection_string = "server=" + ip_ + "; port=" + port_ + "; user=" + username_ + "; password=" + password_ + "; database=" + database_ + "; Max Pool Size=50000; Pooling=True";

                conn_ = new MySqlConnection(connection_string);

                if (conn_.State == ConnectionState.Closed)
                {
                    conn_.Open();
                    Services.MsgFRM msg = new Services.MsgFRM();
                    msg.getInfo("Connexion établie");
                }
                else
                {
                    conn_.Close();
                    Services.MsgFRM msg = new Services.MsgFRM();
                    msg.getError("Connexion échouer");
                }
            }
            catch (Exception)
            {
                Services.MsgFRM msg = new Services.MsgFRM();
                msg.getError("Connexion échouer");
            }
        }
        public static async Task<bool> Open()
        {
            connection();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            var openAsync = conn?.OpenAsync();
            if (openAsync == null) return false;
            await openAsync;
            return true;
        }
        public static async Task<bool> Close()
        {
            var closeAsync = conn?.CloseAsync();
            if (closeAsync == null) return false;
            await closeAsync;
            return true;
        }

        /// <summary>
        /// Insertion, modification, ... dans la db
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="sqlParams"></param>
        /// <returns></returns>
        public async static Task<bool> insertPrepared(string tableName, params MySqlParameter[] sqlParams)
        {
            //produce comma delimited list of param names with leading @ stripped eg. Param1, Param2, Param3
            string columnNameStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName.Substring(1)));

            //produce comma delimited list of param eg. @Param1, @Param2, @Param3
            string valueParamStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName));

            string insertSql = string.Format(
                "INSERT INTO {0} ({1}) VALUES ({2})",
                tableName,
                columnNameStr,
                valueParamStr
            );
            bool result = false;
            using (var command = new MySqlCommand(insertSql, conn))
            {
                command.Parameters.AddRange(sqlParams);
                await command.ExecuteScalarAsync();
                result = true;
            }
            return result;
        }
        public static async Task<bool> updatePrepared(string tableName, MySqlParameter keyParam, params MySqlParameter[] sqlParams)
        {
            //Param1 = @Param1, Param2 = @Param2, @Param3 = @Param3, etc.
            string updateParamStr = string.Join(
                ", ",
                sqlParams.Select(sqlParam => string.Format("{0} = {1}", sqlParam.ParameterName.Substring(1), sqlParam.ParameterName))
                );

            //param = @param
            string keyMatchStr = string.Format("{0} = {1}",
                keyParam.ParameterName.Substring(1),
                keyParam.ParameterName);
            //sql query

            string updateSql = string.Format("UPDATE {0} SET {1} WHERE {2}",
                tableName,
                updateParamStr,
                keyMatchStr);
            bool result = false;
            using (var command = new MySqlCommand(updateSql, conn))
            {
                command.Parameters.Add(keyParam);
                command.Parameters.AddRange(sqlParams);
                await command.ExecuteScalarAsync();
                result = true;
            }
            return result;
        }
        public static async Task<bool> deletePrepared(string tableName, params MySqlParameter[] sqlParams)
        {
            //produce comma delimited list of param names with leading @ stripped eg. Param1, Param2, Param3
            string columnNameStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName.Substring(1)));

            //produce comma delimited list of param eg. @Param1, @Param2, @Param3
            string valueParamStr = string.Join(", ", sqlParams.Select(sqlParam => sqlParam.ParameterName));

            string deleteSql = string.Format(
                "DELETE FROM {0} WHERE {1} = {2}",
                tableName,
                columnNameStr,
                valueParamStr
            );
            bool result = false;
            using (var command = new MySqlCommand(deleteSql, conn))
            {
                command.Parameters.AddRange(sqlParams);
                await command.ExecuteScalarAsync();
                result = true;
            }
            return result;
        }

        public static async Task<Dictionary<string, object>> FetchArrayDict(string query)
        {
            var dictionary = new Dictionary<string, object>();
            using (var command = new MySqlCommand(query, conn))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            var key = reader.GetName(i);
                            var value = reader[i];
                            dictionary.Add(key, value);
                        }
                    }
                }
            }
            return dictionary;
        }
        public static async Task<List<object>> FetchArrayList(string query)
        {
            var list = new List<object>();
            using (var command = new MySqlCommand(query, conn))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        for (var i = 0; i < reader.FieldCount; i++)
                        {
                            var value = reader[i];
                            list.Add(value);
                        }
                    }
                }
            }
            return list;
        }
        public static async Task<int> FetchOnValue(string query)
        {
            int id = 0;
            using (var command = new MySqlCommand(query, conn))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString());
                    }
                }
            }
            return id;
        }

        public static MySqlDataReader DR;
        public static void getData(string query)
        {
            var command = new MySqlCommand(query, conn);
            DR = command.ExecuteReader();
        }

        public static void getExecute(string query)
        {
            var command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
        }
        public static DataTable DT;
        public static void getDataTable(string query)
        {
            DT = new DataTable();
            DT.Clear();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            sda.Fill(DT);
        }
    }
}
