using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public static class HomeController
    {
        public static void Navigate(Control ContainerPanel, Control panel)
        {
            panel.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Clear();
            ContainerPanel.Controls.Add(panel);
        }

        public static String cypherSTR(String str)
        {
            String rt = "";
            foreach (char c in str)
            {
                rt += (char)((int)c + 1);
            }
            return rt;
        }

        public static String decryptSTR(String str)
        {
            String rt = "";
            foreach (char c in str)
            {
                rt += (char)((int)c - 1);
            }
            return rt;
        }

        public static String FormateDate(DateTime dt)
        {
            Dictionary<int, String> monthes = new Dictionary<int, string>();
            monthes.Add(1, "Jan");
            monthes.Add(2, "Feb");
            monthes.Add(3, "Mar");
            monthes.Add(4, "Apr");
            monthes.Add(5, "May");
            monthes.Add(6, "Jun");
            monthes.Add(7, "Jui");
            monthes.Add(8, "Aug");
            monthes.Add(9, "Sep");
            monthes.Add(10, "Oct");
            monthes.Add(11, "Nov");
            monthes.Add(12, "Dec");

            String rt = monthes[dt.Month] + " ";
            rt += dt.Day + ", ";
            rt += dt.Year;
            
            return rt;
        }
    }
}
