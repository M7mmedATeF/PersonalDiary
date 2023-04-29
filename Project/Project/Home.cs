using Oracle.DataAccess.Client;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        OracleConnection conn;
        User user;
        MyDiaries diaryPanel;
        MyComplaints compPanel;
        viewDiary viewDiaryPanel;
        ProfileCTRL profile;
        bool openAdmin = false;
        public Home(OracleConnection connection, User userData)
        {
            conn = connection;
            user = userData;
            InitializeComponent();
            diaryPanel = new MyDiaries(connection, user, ContainerPanel);
            profile = new ProfileCTRL(conn);
            compPanel = new MyComplaints(connection, user);
            diaryPanel.viewEvent += new EventHandler<Page>(viewEvent);
            HomeController.Navigate(ContainerPanel, diaryPanel);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void myDiaries1_Load(object sender, EventArgs e)
        {

        }

        private void Home_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            compPanel.resetCompPanel();
            HomeController.Navigate(ContainerPanel ,compPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diaryPanel.resetDiaryPanel();
            HomeController.Navigate(ContainerPanel, diaryPanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeController.Navigate(ContainerPanel, profile);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin adminFrom = new Admin(conn);
            adminFrom.Show();
        }

        private void viewDiary1_ev(object sender, EventArgs e)
        {

        }

        private void viewEvent(object sender, Page e)
        {
            Page page = e;
            viewDiaryPanel = new viewDiary(page);
            HomeController.Navigate(ContainerPanel, viewDiaryPanel);
        }
    }
}
