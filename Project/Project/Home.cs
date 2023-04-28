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
        Form1 loginForm;
        bool logout = false;
        public Home(OracleConnection connection, User userData, Form1 loginForm)
        {
            InitializeComponent();
            conn = connection;
            user = userData;
            this.loginForm = loginForm;

            if (user.userLVL == 2)
            {
                adminNavBTN.Visible = true;
                ComplaintBTN.Visible = false;
            }


            initProfile(connection);
            initMyCompPanel(connection, userData);
            initMyDiary(connection, userData);

            HomeController.Navigate(ContainerPanel, diaryPanel);
        }

        private void initProfile(OracleConnection connection)
        {
            profile = new ProfileCTRL(connection);
        }

        private void initMyDiary(OracleConnection connection, User userData)
        {
            diaryPanel = new MyDiaries(connection, userData, ContainerPanel);
            diaryPanel.viewEvent += new EventHandler<Page>(viewEvent);
        }

        private void initMyCompPanel(OracleConnection connection, User userData)
        {
            compPanel = new MyComplaints(connection, userData, ContainerPanel);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout)
                Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            compPanel.resetCompPanel();
            HomeController.Navigate(ContainerPanel, compPanel);
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

        private void viewEvent(object sender, Page page)
        {
            viewDiaryPanel = new viewDiary(page);
            viewDiaryPanel.goBack += new EventHandler(this.button1_Click);
            HomeController.Navigate(ContainerPanel, viewDiaryPanel);
        }

        private void NavPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
            loginForm.Show();
        }
    }
}
