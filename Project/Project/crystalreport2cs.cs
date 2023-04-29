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
    public partial class crystalreport2cs : Form
    {
        CrystalReport4 CR;
        public crystalreport2cs()
        {
            InitializeComponent();
        }

        private void crystalreport2cs_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport4();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
