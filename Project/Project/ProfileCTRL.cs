﻿using System;
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
    }
}
