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
            OracleCommand compCMD = new OracleCommand();
            compCMD.Connection = conn;
            compCMD.CommandText = "Select * from complaints where user_id = :n ORDER by status ASC";
            compCMD.CommandType = System.Data.CommandType.Text;
            compCMD.Parameters.Add("n", id);
            OracleDataReader dr = compCMD.ExecuteReader();
            return dr;
        }

        public static void addNewComplaint(Complaint cp, OracleConnection conn)
        {
            OracleCommand compCMD = new OracleCommand();
            compCMD.Connection = conn;
            compCMD.CommandText = "INSERT INTO complaints (id, head_line, details, add_date, status, user_id) Values (compIdSeq.nextval, :h, :d, current_date, 1, :u)";
            compCMD.CommandType = System.Data.CommandType.Text;
            compCMD.Parameters.Add(":head", cp.headline);
            compCMD.Parameters.Add(":det", cp.details);
            compCMD.Parameters.Add(":uid", cp.userId);
            compCMD.ExecuteNonQuery();
        }
    }
}
