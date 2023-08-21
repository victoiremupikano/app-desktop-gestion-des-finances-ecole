using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Controllers
{
    class CTrimestry
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CTrimestry(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CTrimestry args)
        {
            Models.MTrimestry obj = new Models.MTrimestry();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CTrimestry args)
        {
            Models.MTrimestry obj = new Models.MTrimestry();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CTrimestry args)
        {
            Models.MTrimestry obj = new Models.MTrimestry();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
