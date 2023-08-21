using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Controllers
{
    class CUser
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CUser(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CUser args)
        {
            Models.MUsers obj = new Models.MUsers();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CUser args)
        {
            Models.MUsers obj = new Models.MUsers();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CUser args)
        {
            Models.MUsers obj = new Models.MUsers();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
