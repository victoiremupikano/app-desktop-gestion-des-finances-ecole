using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Apps
{
    class Schema
    {
        public Dictionary<string, string> table = new Dictionary<string, string> {
            { "tb_year", "year" },
            { "tb_student", "student" },
            { "tb_trimestry", "trimestry" },
            { "tb_account", "account" },
            { "tb_payment", "payment" },
        };

        /// <summary>
        /// les champs des differentes tables
        /// </summary>
        public Dictionary<string, string> tb_year = new Dictionary<string, string> {
            { "id", "id_year" },
            { "wording", "wording" },
            { "dteStart", "dteStart" },
            { "dteEnd", "dteEnd" },
            { "status", "status" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> tb_student = new Dictionary<string, string> {
            { "id", "id" },
            { "design", "design" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> under_menu = new Dictionary<string, string> {
            { "id", "id" },
            { "design", "design" },
            { "fk", "fk_menu" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> arrival = new Dictionary<string, string> {
            { "id", "id" },
            { "design", "design" },
            { "descript", "descript" },
            { "status", "status" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> category = new Dictionary<string, string> {
            { "id", "id" },
            { "design", "design" },
            { "descript", "descript" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> invoice = new Dictionary<string, string> {
            { "id", "id" },
            { "names", "names" },
            { "tel", "telephone" },
            { "dte", "dte" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> product = new Dictionary<string, string> {
            { "id", "id" },
            { "ref", "reference" },
            { "dci", "dci" },
            { "pv", "pv" },
            { "cdte", "cdte" },
            { "stkAlert", "stk" },
            { "isperiscope", "isperiscope" },
            { "fk", "fk_category" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> profile = new Dictionary<string, string> {
            { "id", "id" },
            { "names", "names" },
            { "nrc", "nrc" },
            { "identNat", "identNat" },
            { "adress", "adress" },
            { "tel", "telephone" },
            { "logo", "logo" },
            { "fk_user", "fk_user" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> user = new Dictionary<string, string> {
            { "id", "id" },
            { "login", "login" },
            { "password", "password" },
            { "type", "type" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };

        public Dictionary<string, string> flux = new Dictionary<string, string> {
            { "id", "id" },
            { "num", "number" },
            { "dte", "dte" },
            { "qtg", "qtg" },
            { "qtd", "qtd" },
            { "pvt", "pvt" },
            { "fk1", "fk_arrival" },
            { "fk2", "fk_product" },
            { "fk3", "fk_custommer" },
            { "oper", "operation" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "dte_start_isperiscope", "dte_start_isperiscope" },
            { "dte_end_isperiscope", "dte_end_isperiscope" },
            { "row_added","row_add" },
            { "row_updated","row_update" }
        };

        public Dictionary<string, string> payment = new Dictionary<string, string> {
            { "id", "id" },
            { "dte", "dte" },
            { "mt", "mt" },
            { "oper", "operator" },
            { "num", "number" },
            { "fk_user", "fk_user" },
            { "fk_profile", "fk_profile" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
    }
}
