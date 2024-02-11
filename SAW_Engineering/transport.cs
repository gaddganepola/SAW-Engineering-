using System;
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
    public partial class transport : Form
    {
        public transport()
        {
            InitializeComponent();
        }

        private void transport_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("projectemp") || login.user.Contains("projectman") || login.user.Contains("engineer") || login.user.Contains("inv"))
            {
                panel3.Hide();
                panel4.Hide();
                panel5.Hide();
            }

            if (login.user.Contains("transman"))
            {
                panel5.Hide();
            }

            if (login.user.Contains("admin"))
            {

            }

            if (login.user.Contains("financeman"))
            {
                panel3.Hide();
                panel5.Hide();
            }

            if (login.user.Contains("financeemp"))
            {
                panel3.Hide();
                panel5.Hide();
                panel4.Hide();
            }

        }
    }
}
