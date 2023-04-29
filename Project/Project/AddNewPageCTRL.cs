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
        Page page;
        Control containerPanel;
        MyDiaries myDiary;
        bool editFlag = false;
        public AddNewPageCTRL(OracleConnection connection, User userData, Control mainPanel, MyDiaries moveTo, Page page, bool EditMood)
        {
            InitializeComponent();
            conn = connection;
            user = userData;
            containerPanel = mainPanel;
            myDiary = moveTo;
            this.page = page;
            this.editFlag = EditMood;
            initEditMood(page);
        }

        public void initEditMood(Page page)
        {
            headline.Text = page.headline;
            details.Text = page.details;
        }

        private void AddNewPageCTRL_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (editFlag)
                editMood();
            else
                addMood();
            myDiary.resetDiaryPanel();
            HomeController.Navigate(containerPanel, myDiary);
        }

        public void editMood()
        {
            page.headline = (headline.Text);
            page.details = (details.Text);
            DiaryController.editPage(page, conn);
        }

        public void addMood()
        {
            DateTime dt = new DateTime();
            Page page = new Page(-1, (headline.Text), (details.Text), dt.ToString(), dt.ToString(), user.id);
            DiaryController.addNewPage(page, conn);
            myDiary.resetDiaryPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
