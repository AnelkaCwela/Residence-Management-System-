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
    public partial class AddEquipments : Form
    {
        public AddEquipments()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                e.Cancel = true;
                cmbStatus.Focus();
                errorProvider1.SetError(this.cmbStatus, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbStatus, null);
            }
        }

        private void cmbVenue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbVenue.Text))
            {
                e.Cancel = true;
                cmbVenue.Focus();
                errorProvider1.SetError(this.cmbVenue, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbVenue, null);
            }
        }

        private void cmbType_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(cmbType.Text))
            //{
            //    e.Cancel = true;
            //    cmbType.Focus();
            //    errorProvider1.SetError(this.cmbType, "Enter you name");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(this.cmbType, null);
            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddStudent st = new AddStudent();
            st.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff s = new AddStaff();
            s.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDepartment dd = new AddDepartment();
            dd.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            AddEquipmentType xdfg = new AddEquipmentType();
            xdfg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                Equipment de = new Equipment(txtName.Text,int.Parse(cmbVenue.SelectedValue.ToString()),cmbStatus.Text);
                baobj.InsertEquipment(de);
            }
            else
            {

                MessageBox.Show("failed!!\nEnter Valid Data Or Cherk Your Passwords");

            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void AddEquipments_Load(object sender, EventArgs e)
        {
            cmbVenue.DataSource = baobj.GetVenue();
          
            cmbVenue.ValueMember = "VenueCode";
            cmbVenue.DisplayMember = "VenueDescription";
        }
    }
}
