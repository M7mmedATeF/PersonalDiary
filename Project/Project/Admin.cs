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
    public partial class Admin : Form
    {
        OracleConnection conn;
        OracleDataAdapter adaptor;
        DataSet ds = new DataSet();
        public Admin(OracleConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Complaints";
            adaptor = new OracleDataAdapter(cmd, conn);
            adaptor.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommandBuilder build = new OracleCommandBuilder(adaptor);
            adaptor.Update(ds.Tables[0]);
        }
    }
}
