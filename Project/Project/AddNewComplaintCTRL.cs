using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Project
{
    public partial class AddNewComplaintCTRL : UserControl
    {
        User user;
        OracleConnection conn;
        Control mainPanel;
        public AddNewComplaintCTRL(OracleConnection conn, User user, Control mainPanel)
        {
            InitializeComponent();
            this.user = user;
            this.conn = conn;
            this.mainPanel = mainPanel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Complaint cp = new Complaint(-1, headline.Text, details.Text, "2020/5/6", 1, user.id);
            ComplaintController.addNewComplaint(cp, conn);
            goBack(sender, e);
        }

        public event EventHandler goBack;
    }
}
