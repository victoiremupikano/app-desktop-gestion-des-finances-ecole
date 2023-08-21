using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Controllers
{
    class CAccount
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CAccount(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CAccount args)
        {
            Models.MAccount obj = new Models.MAccount();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CAccount args)
        {
            Models.MAccount obj = new Models.MAccount();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CAccount args)
        {
            Models.MAccount obj = new Models.MAccount();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
