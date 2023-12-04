using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONTFINAL
{
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateStaff us = new UpdateStaff();
            us.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddStaff s = new AddStaff();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewRequests vr = new ViewRequests();
            vr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
