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
    public partial class AddNewPageCTRL : UserControl
    {
        OracleConnection conn;
        User user;
        Control containerPanel;
        MyDiaries myDiary;
        public AddNewPageCTRL(OracleConnection connection, User userData, Control mainPanel, MyDiaries moveTo)
        {
            InitializeComponent();
            conn = connection;
            user = userData;
            containerPanel = mainPanel;
            myDiary = moveTo;
        }

        private void AddNewPageCTRL_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = new DateTime();
                Page page = new Page(-1, headline.Text, details.Text, dt.ToString(), dt.ToString(), user.id);
                DiaryController.addNewPage(page, conn);
                myDiary.resetDiaryPanel();
                HomeController.Navigate(containerPanel, myDiary);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
