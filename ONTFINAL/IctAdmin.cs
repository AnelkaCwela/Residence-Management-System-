using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BALayer;
using BELayer;

namespace ONTFINAL
{
    public partial class IctAdmin : Form
    {
        public IctAdmin()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        private void button1_Click(object sender, EventArgs e)
        {
            AddDepartment ad = new AddDepartment();
            ad.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateDepartment ad = new UpdateDepartment();
            ad.Show();
            this.Hide();
        }

        private void IctAdmin_Load(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
