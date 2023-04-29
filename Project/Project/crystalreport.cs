using System;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Project
{
    public partial class crystalreport : Form
    {
        CrystalReport3 CR;
        public crystalreport()
        {
            InitializeComponent();
        }

        private void crystalreport_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            //CR.SetParameterValue(1,Convert.ToInt32(textBox1.Text));
            crystalReportViewer1.ReportSource = CR;
        }
    }

}
