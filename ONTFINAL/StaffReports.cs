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
    public partial class StaffReports : Form
    {
        public StaffReports()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InspectionDetails id = new InspectionDetails();
            id.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StaffSchedules ss = new StaffSchedules();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
