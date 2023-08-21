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
            { "fk_user", "fk_user" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> tb_student = new Dictionary<string, string> {
            { "id", "id" },
            { "names", "names" },
            { "kind", "kind" },
            { "birthday", "birthday" },
            { "children_father", "children_father" },
            { "children_mather", "children_mather" },
            { "religin", "religin" },
            { "adress", "adress" },
            { "tel", "tel" },
            { "fk_year", "fk_year" },
            { "fk_user", "fk_user" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> tb_trimestry = new Dictionary<string, string> {
            { "id", "trimestry_id" },
            { "wording", "wording" },
            { "mt_to_pay", "mt_to_pay" },
            { "fk_year", "fk_year" },
            { "fk_user", "fk_user" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> tb_account = new Dictionary<string, string> {
            { "id", "account_id" },
            { "wording", "wording" },
            { "fk1", "fk_student" },
            { "fk2", "fk_trimestry" },
            { "fk_year", "fk_year" },
            { "fk_user", "fk_user" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
        public Dictionary<string, string> tb_payment = new Dictionary<string, string> {
            { "id", "payment_id" },
            { "wording", "wording" },
            { "my_payed", "my_payed" },
            { "fk1", "fk_account" },
            { "fk_year", "fk_year" },
            { "fk_user", "fk_user" },
            { "row_added","row_add"},
            { "row_updated","row_update"}
        };
    }
}
