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
    public partial class AddEquipmentType : Form
    {
        public AddEquipmentType()
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

        private void button6_Click(object sender, EventArgs e)
        {
            AddDepartment dp = new AddDepartment();
            dp.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddEquipmentType Et = new AddEquipmentType();
            Et.Show();
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

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                e.Cancel = true;
                txtYear.Focus();
                errorProvider1.SetError(this.txtYear, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtYear, null);
            }
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                EquipmentType et = new EquipmentType(txtName.Text, int.Parse(txtYear.Text), cmbStatus.Text, int.Parse(comboBox1.SelectedValue.ToString()));
                baobj.InsertEquipmentType(et);
            }
            else
            {

                MessageBox.Show("failed!!\nEnter Valid Data Or Cherk Your Passwords");

            }
        }

        private void AddEquipmentType_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baobj.GetEquipment();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "EquipCode";
        }
    }
}
