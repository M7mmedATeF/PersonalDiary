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
    }
}
