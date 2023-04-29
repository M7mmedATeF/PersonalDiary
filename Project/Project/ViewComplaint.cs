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
    public partial class ViewComplaint : UserControl
    {
        Complaint comp;
        public ViewComplaint(Complaint cp)
        {
            InitializeComponent();
            comp = cp;
        }

        private void ViewComplaint_Load(object sender, EventArgs e)
        {
            hedline.Text = comp.headline;
            detaile.Text = comp.details;
            status.Text = comp.headline;
            AddDate.Text = HomeController.FormateDate(comp.date);
            if (comp.status == 1)
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
    }
}
