using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager
{
    internal class LoginLogout
    {
        public Dictionary<string, string> callback;
        Dictionary<string, string> fields;
        public LoginLogout(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }

        /// <summary>
        /// Connextion
        public async void login(LoginLogout args)
        {
            try
            {
                if (await Apps.Query.Open())
                {
                    Apps.Schema schema = new Apps.Schema();
                    Apps.Query.getData($"select * from {schema.table["tb_user"]} where {schema.tb_user["login"]} = '{args.fields["tb_user"]}' and {schema.tb_user["password"]} = '{args.fields["pwd"]}'';");
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
                        { "type", "failure" }, { "message", "Connexion echouer " + ex.Message}
                    };
            }
        }
    }
}
