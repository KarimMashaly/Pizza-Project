﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            Form frm = new frmOrder();

            frm.FormClosed += (s, args) => this.Show();
            // To reload Form1 after closing Form2

            frm.Show();
            this.Hide();
        }
    }
}
