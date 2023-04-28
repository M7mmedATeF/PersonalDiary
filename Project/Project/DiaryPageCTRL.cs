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
    public partial class DiaryPageCTRL : UserControl
    {
        public Page page;
        public DiaryPageCTRL(Page page)
        {
            InitializeComponent();
            this.page = page;
            headline.Text = Splitter(page.headline, 20);
            date.Text = HomeController.FormateDate(page.date);
            detaile.Text = Splitter(page.details, 100);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        /* Data In Controls */
        public event EventHandler<Page> view;
        public event EventHandler<Page> edit;
        public event EventHandler<Page> delete;

        private void DiaryPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            view(sender, page);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit(sender, page);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete(sender, page);
        }
    }
}
