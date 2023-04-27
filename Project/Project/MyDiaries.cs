﻿using System;
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
    public partial class MyDiaries : UserControl
    {
        OracleConnection conn;
        User user;
        Control containerPanel;

        public MyDiaries(OracleConnection connection, User userData, Control mainPanel)
        {
            InitializeComponent();
            conn = connection;
            user = userData;
            containerPanel = mainPanel;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Clear();
            containerPanel.Controls.Add(new AddNewPageCTRL(conn, user, containerPanel, this));
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void MyDiaries_Load(object sender, EventArgs e)
        {
            resetDiaryPanel();
        }

        public void resetDiaryPanel()
        {
            PagesPanel.Controls.Clear();
            OracleDataReader dr = DiaryController.getPages(user.id, conn);
            while (dr.Read())
            {
                Page pg = new Page(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), Convert.ToInt32(dr[5]));
                DiaryPageCTRL dp = new DiaryPageCTRL(pg);
                dp.view += new EventHandler<Page>(this.viewEvent);
                PagesPanel.Controls.Add(dp);
            }
        }

        public event EventHandler<Page> viewEvent;
    }
}
