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
                pagesCMD.Parameters.Add("head", HomeController.cypherSTR(page.headline));
                pagesCMD.Parameters.Add("details", HomeController.cypherSTR(page.details));
                pagesCMD.Parameters.Add("id", page.userId);
                pagesCMD.ExecuteNonQuery();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public static void editPage(Page page, OracleConnection conn)
        {
            try
            {
                OracleCommand pageCMD = new OracleCommand();
                pageCMD.Connection = conn;
                pageCMD.CommandText = "update pages set head_line = :h, details = :d, last_modified = current_date where pages.id = :id";
                pageCMD.CommandType = CommandType.Text;
                pageCMD.Parameters.Add("h", HomeController.cypherSTR(page.headline));
                pageCMD.Parameters.Add("d", HomeController.cypherSTR(page.details));
                pageCMD.Parameters.Add("id", page.id);
                pageCMD.ExecuteNonQuery();
            }catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        public static void deletePage(Page page, OracleConnection conn)
        {
            try
            {
                OracleCommand pageCMD = new OracleCommand();
                pageCMD.Connection = conn;
                pageCMD.CommandText = "delete from pages where id = " + page.id;
                pageCMD.CommandType = CommandType.Text;
                pageCMD.ExecuteNonQuery();
            } catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
