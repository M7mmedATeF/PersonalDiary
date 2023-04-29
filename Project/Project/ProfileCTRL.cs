using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Project
{
    public partial class ProfileCTRL : UserControl
    {
        OracleConnection conn;
        public ProfileCTRL(OracleConnection conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void ProfileCTRL_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            update();
        }

        private void update() {
            String Name = uName.Text;
            String Email = uEmail.Text;
            String pass = uPass.Text;
            String cpass = uCpass.Text;
            String id=  uID.Text;

            if (pass != cpass)
                MessageBox.Show("passwords must be same");
            else
            {
                OracleCommand upd = new OracleCommand();
                upd.Connection = conn;
                upd.CommandText = "update Users set name=:Name , password=:pass , email=:Email where ID=:id";

                upd.Parameters.Add("Name", Name);
                upd.Parameters.Add("pass", pass);
                upd.Parameters.Add("Email", Email);           
                upd.Parameters.Add("id", id);

                try
                {
                    upd.ExecuteNonQuery();
                    MessageBox.Show("data updated successfully");

                }
                catch (Exception err)
                {
                    MessageBox.Show("something wrong please try again");
                }
 
            }
        }

        
    }
}
