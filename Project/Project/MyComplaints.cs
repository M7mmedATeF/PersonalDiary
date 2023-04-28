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
    public partial class MyComplaints : UserControl
    {
        OracleConnection conn;
        User user;
        Control mainPanel;
        public MyComplaints(OracleConnection connection, User userData, Control mainPanel)
        {
            InitializeComponent();
            conn = connection;
            user = userData;
            this.mainPanel = mainPanel;
        }

        private void PagesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyComplaints_Load(object sender, EventArgs e)
        {
            resetCompPanel();
        }

        public void resetCompPanel()
        {
            compPanel.Controls.Clear();
            OracleDataReader dr = ComplaintController.getComplaints(user.id, conn);
            while (dr.Read())
            {
                Complaint comp = new Complaint(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4]), Convert.ToInt32(dr[5]));
                ComplaintCTRL cp = new ComplaintCTRL(comp);
                cp.Margin = new Padding(0);
                compPanel.Controls.Add(cp);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewComplaintCTRL compCTR = new AddNewComplaintCTRL(conn, user, mainPanel);
            compCTR.goBack += new EventHandler(this.goBack);
            HomeController.Navigate(mainPanel, compCTR);
        }

        private void goBack(object sender, EventArgs e)
        {
            this.resetCompPanel();
            HomeController.Navigate(mainPanel, this);
        }
    }
}
