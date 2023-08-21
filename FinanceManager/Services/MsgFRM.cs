using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager.Services
{
    class MsgFRM
    {
        public void getError(string msg)
        {
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void getAttention(string msg)
        {
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void getInfo(string msg)
        {
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public bool getDialog(string msg)
        {
            bool value;
            if (MessageBox.Show(msg, "Dialogue", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                value = true;

            }
            else
            {
                value = false;
            }
            return value;
        }
    }
}
