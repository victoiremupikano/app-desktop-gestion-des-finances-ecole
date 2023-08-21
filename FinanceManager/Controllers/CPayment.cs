using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Controllers
{
    class CPayment
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CPayment(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CPayment args)
        {
            Models.MPayment obj = new Models.MPayment();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CPayment args)
        {
            Models.MPayment obj = new Models.MPayment();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CPayment args)
        {
            Models.MPayment obj = new Models.MPayment();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
