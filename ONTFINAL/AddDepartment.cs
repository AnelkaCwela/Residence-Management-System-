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
using DALayer;
using System.Text.RegularExpressions;

namespace ONTFINAL
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
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

        private void button4_Click(object sender, EventArgs e)
        {
            AddVenue v = new AddVenue();
            v.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            AddRequests R = new AddRequests();
            R.Show();
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

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(this.txtName, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtName, null);
            }
        }

        private void txtBuilding_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuilding.Text))
            {
                e.Cancel = true;
                txtBuilding.Focus();
                errorProvider1.SetError(this.txtBuilding, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtBuilding, null);
            }
        }

        private void txtPerson_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                e.Cancel = true;
                txtPerson.Focus();
                errorProvider1.SetError(this.txtPerson, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtPerson, null);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string pattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtEmail, "Enter a valid email address");
                return;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Department de = new Department(txtName.Text, txtBuilding.Text, txtPerson.Text, txtEmail.Text);
                baobj.InsertDepartment(de);
            }
            else
            {

                MessageBox.Show("failed!!\nEnter Valid Data Or Cherk Your Passwords");

            }
        }
    }
    
}
