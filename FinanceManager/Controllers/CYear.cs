using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Controllers
{
    class CYear
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CYear(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CYear args)
        {
            Models.MYear obj = new Models.MYear();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CYear args)
        {
            Models.MYear obj = new Models.MYear();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CYear args)
        {
            Models.MYear obj = new Models.MYear();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
