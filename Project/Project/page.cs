using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Page
    {
        public int id, userId;
        public String headline, details;
        public DateTime date, lastModifiedDate;

        public Page(int id, String headline, String details, String date, String lastDate, int userId)
        {
            this.id = id;
            this.userId = userId;
            this.headline = headline;
            this.details = details;
            this.date = Convert.ToDateTime(date);
            this.lastModifiedDate = Convert.ToDateTime(lastDate);
        }
    }
}
