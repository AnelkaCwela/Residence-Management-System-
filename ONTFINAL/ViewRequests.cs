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
    public partial class ViewRequests : Form
    {
        public ViewRequests()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff s = new AddStaff();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateStaff us = new UpdateStaff();
            us.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewReports vr = new ViewReports();
            vr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
