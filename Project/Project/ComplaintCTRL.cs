using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ComplaintCTRL : UserControl
    {
        Complaint complaint;
        public ComplaintCTRL(Complaint cp)
        {
            InitializeComponent();
            complaint = cp;
            headline.Text = Splitter(cp.headline, 30);
            detaile.Text = Splitter(cp.details, 100);
            if(cp.status == 1)
            {
                status.Text = "In Queue";
                status.ForeColor = Color.FromArgb(220, 26, 26);
            }
            else
            {
                status.Text = "Fixed";
                status.ForeColor = Color.FromArgb(82, 200, 94);
            }
        }

        private void ComplaintCTRL_Load(object sender, EventArgs e)
        {

        }
        private String Splitter(String str, int len)
        {
            if (str.Length > len)
            {
                String rt = "";
                for (int i = 0; i < len; i++)
                {
                    rt += str[i];
                }
                return rt + "...";
            }
            else
            {
                return str;
            }
        }
    }
}
