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
    public partial class viewDiary : UserControl
    {
        Page page;
        public viewDiary(Page pg)
        {
            InitializeComponent();
            page = pg;
        }

        private void viewDiary_Load(object sender, EventArgs e)
        {
            hedline.Text = page.headline;
            detaile.Text = page.details;
            AddDate.Text = HomeController.FormateDate(page.date);
            LastModDate.Text = HomeController.FormateDate(page.lastModifiedDate);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler goBack;
    }
}
