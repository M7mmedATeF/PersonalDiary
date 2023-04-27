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
    public static class DiaryController
    {
        public static OracleDataReader getPages(int id, OracleConnection conn)
        {
            OracleCommand pagesCMD = new OracleCommand();
            pagesCMD.Connection = conn;
            pagesCMD.CommandText = "Select * from pages where user_id = :n ORDER BY ID DESC";
            pagesCMD.CommandType = System.Data.CommandType.Text;
            pagesCMD.Parameters.Add("n", id);
            OracleDataReader dr = pagesCMD.ExecuteReader();
            return dr;
        }

        public static void addNewPage(Page page, OracleConnection conn)
        {
            try
            {
                OracleCommand pagesCMD = new OracleCommand();
                pagesCMD.Connection = conn;
                pagesCMD.CommandText = "addPage";
                pagesCMD.CommandType = System.Data.CommandType.StoredProcedure;
                pagesCMD.Parameters.Add("head", page.headline);
                pagesCMD.Parameters.Add("details", page.details);
                pagesCMD.Parameters.Add("id", page.userId);
                pagesCMD.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
