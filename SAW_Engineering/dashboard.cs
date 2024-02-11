using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAW_Engineering
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NLDBQLGG\SQLEXPRESS;Initial Catalog=SAW_Engineering;Integrated Security=True");

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT [empName] FROM [dbo].[employee] WHERE [userName] = '" + login.user + "'", conn);
            conn.Open();

            SqlDataReader myR = cmd.ExecuteReader();
            if (myR.HasRows)
            {
                while (myR.Read())
                {

                    label2.Text = myR[0].ToString();

                }
            }
            conn.Close();


            if (login.user != "admin")
            {
                button5.Hide();
            }

            if (login.user.Contains("project"))
            {
                button1.Hide();
                button3.Hide();
            }

            if (login.user.Contains("trans"))
            {
                btnproject.Hide();
                button1.Hide();
                button3.Hide();
                button4.Hide();
            }

            if (login.user.Contains("financeemp"))
            {
                btnproject.Hide();
                //button2.Hide();
                button3.Hide();
                button4.Hide();
            }

            if (login.user.Contains("financeman"))
            {
                btnproject.Hide();
            }

            if (login.user.Contains("engineer"))
            {
                btnproject.Hide();
                button1.Hide();
                //button2.Hide();
            }

            if (login.user.Contains("inv"))
            {
                btnproject.Hide();
                button1.Hide();
                //button2.Hide(); 
                button3.Hide();
            }

            //date and time 
            timer1.Start();
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void btnproject_Click(object sender, EventArgs e)
        {
            project project = new project();
            project.TopLevel = false;
            panel3.Controls.Add(project);
            project.BringToFront();
            project.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            finance finance = new finance();
            finance.TopLevel = false;
            panel3.Controls.Add(finance);
            finance.BringToFront();
            finance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transport transport = new transport();
            transport.TopLevel = false;
            panel3.Controls.Add(transport);
            transport.BringToFront();
            transport.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manufacturing manufacturing = new manufacturing();
            manufacturing.TopLevel = false;
            panel3.Controls.Add(manufacturing);
            manufacturing.BringToFront();
            manufacturing.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();
            inventory.TopLevel = false;
            panel3.Controls.Add(inventory);
            inventory.BringToFront();
            inventory.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setup setup = new setup();
            setup.TopLevel = false;
            panel3.Controls.Add(setup);
            setup.BringToFront();
            setup.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
