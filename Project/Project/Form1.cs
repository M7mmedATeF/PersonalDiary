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
    public partial class Form1 : Form
    {
        OracleConnection conn;
        User user = new User();
        public Form1()
        {
            InitializeComponent();
            conn = new OracleConnection("Data source=orcl;User Id=hr;Password = hr;");
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginPanel.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registerPanel.SendToBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            String l_username = l_user.Text;
            String l_password = l_pass.Text;

            OracleCommand loginCMD = new OracleCommand();
            loginCMD.Connection = conn;
            loginCMD.CommandText = "select * from users where user_name = '" + l_username + "' and password = '" + l_password + "'";
            loginCMD.CommandType = CommandType.Text;
            try
            {
                OracleDataReader dr = loginCMD.ExecuteReader();
                while (dr.Read())
                {
                    user.id = Convert.ToInt32(dr[0]);
                    user.name = dr[1].ToString();
                    user.username = dr[2].ToString();
                    user.email = dr[3].ToString();
                }
                Home home = new Home(conn, user);
                this.Hide();
                home.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Username or password is wrong .. check them please");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register();
        }

        private void register()
        {
            String name = rname.Text;
            String username = runame.Text;
            String email = remail.Text;
            String pass = rpass.Text;
            String cpass = rcpass.Text;

            if (pass != cpass)
                MessageBox.Show("passwords must be same");
            else
            {
                OracleCommand regCMD = new OracleCommand();
                regCMD.Connection = conn;
                regCMD.CommandText = "registUser";
                regCMD.CommandType = CommandType.StoredProcedure;
                regCMD.Parameters.Add("name", name);
                regCMD.Parameters.Add("user", username);
                regCMD.Parameters.Add("email", email);
                regCMD.Parameters.Add("pass", pass);

                try
                {
                    regCMD.ExecuteNonQuery();
                    registerPanel.SendToBack();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Somthing went wrong, Please try again later");
                }

                MessageBox.Show("User registerd successfully");
            }
        }

        private void l_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login();
        }

        private void l_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
