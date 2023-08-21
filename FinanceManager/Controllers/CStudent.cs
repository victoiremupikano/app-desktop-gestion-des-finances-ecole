using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Controllers
{
    class CStudent
    {
        Dictionary<string, string> fields { get; set; }
        public Dictionary<string, string> message;
        public CStudent(Dictionary<string, string> fields)
        {
            this.fields = fields;
        }
        public void add(CStudent args)
        {
            Models.MStudent obj = new Models.MStudent();
            obj.insert(args.fields);
            message = obj.callback;
        }
        public void update(CStudent args)
        {
            Models.MStudent obj = new Models.MStudent();
            obj.update(args.fields);
            message = obj.callback;
        }
        public void delete(CStudent args)
        {
            Models.MStudent obj = new Models.MStudent();
            obj.delete(args.fields);
            message = obj.callback;
        }
    }
}
