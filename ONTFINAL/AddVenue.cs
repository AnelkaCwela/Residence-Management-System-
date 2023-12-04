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
using DALayer;
using BELayer;
using System.Text.RegularExpressions;

namespace ONTFINAL
{
    public partial class AddVenue : Form
    {
        public AddVenue()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();

        private void button6_Click(object sender, EventArgs e)
        {
            AddDepartment dp = new AddDepartment();
            dp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff s = new AddStaff();
            s.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStudent st = new AddStudent();
            st.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEquipments E = new AddEquipments();
            E.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddRequests R = new AddRequests();
            R.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddEquipmentType Et = new AddEquipmentType();
            Et.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddVanue_Click(object sender, EventArgs e)
        {
            Venues venues = new Venues(txtDescription.Text, int.Parse(txtCapacity.Text),"Active");

            int x = baobj.InsertVenue(venues);
            if (x < 0)
            {
                MessageBox.Show("Venue of {0} has been  Added.");
                Display();
            }
            else
            {
                MessageBox.Show("Venue of {0} could not be  Added.");
            }
        }
        public void Display()
        {
            dgvVenue.DataSource = baobj.GetVenue();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(this.txtDescription, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtDescription, null);
            }
        }

        private void txtCapacity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCapacity.Text))
            {
                e.Cancel = true;
                txtCapacity.Focus();
                errorProvider1.SetError(this.txtCapacity, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtCapacity, null);
            }
        }
    }
}
