using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Project
{
    public static class ComplaintController
    {
        public static OracleDataReader getComplaints(int id, OracleConnection conn)
        {
            OracleCommand pagesCMD = new OracleCommand();
            pagesCMD.Connection = conn;
            pagesCMD.CommandText = "Select * from complaints where user_id = :n ORDER by status ASC";
            pagesCMD.CommandType = System.Data.CommandType.Text;
            pagesCMD.Parameters.Add("n", id);
            OracleDataReader dr = pagesCMD.ExecuteReader();
            return dr;
        }
    }
}
