using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Complaint
    {
        public int id, userId, status;
        public String headline, details;
        public DateTime date;

        public Complaint(int id, String headline, String details, String date, int status, int userId)
        {
            this.id = id;
            this.userId = userId;
            this.headline = headline;
            this.details = details;
            this.date = Convert.ToDateTime(date);
            this.status = status;
        }
    }
}
