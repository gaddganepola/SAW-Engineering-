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
    public partial class finance : Form
    {
        public finance()
        {
            InitializeComponent();
        }

        private void finance_Load(object sender, EventArgs e)
        {
            if (login.user.Contains("emp"))
            {
                panel3.Hide();
                
            }

            if (login.user.Contains("projectman") || login.user.Contains("admin"))
            {
                
            }            
            
        }
    }
}
