﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAW_Engineering
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("project") || login.user.Contains("project") || login.user.Contains("engineer"))
            {
                panel5.Hide();
                panel4.Hide();
                panel3.Hide();
            }

            if (login.user.Contains("finance"))
            {
                panel5.Hide();
                panel2.Hide();
                panel3.Hide();
            }

            if (login.user.Contains("inv"))
            {
                panel5.Hide();
                
            }
        }
    }
}