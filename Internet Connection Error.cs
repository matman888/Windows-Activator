﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activator_GUI
{
    public partial class Internet_Connection_Error : Form
    {
        public Internet_Connection_Error()
        {
            InitializeComponent();
        }

        private void Internet_Connection_Error_Load(object sender, EventArgs e)
        {

        }

        private void butn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Internet_Connection_Error_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
