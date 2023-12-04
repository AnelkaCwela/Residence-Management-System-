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
    public partial class firstRegistration : Form
    {
        public firstRegistration()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        DAL da = new DAL();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if ((ValidateChildren(ValidationConstraints.Enabled)) && (txtPassword.Text == txtConfirm.Text))
            {
                beobj.name = txtName.Text;
                beobj.surname = txtSurname.Text;
                beobj.email = txtEmail.Text;
                beobj.password = txtPassword.Text;
                beobj.phone = txtStaffNo.Text;
                beobj.sq1 = cmbQues1.Text;
                beobj.answer1 = txtAswer1.Text;
                beobj.sq2 = cmbQues2.Text;
                beobj.answer2 = txtAnswer2.Text;
                beobj.ID = txtID.Text;
                beobj.track = "1";
                beobj.status = "Active";
                Department dep = new Department("ICT", "R-Block", "Mr James", "s219130728@mandela.ac.za");
                baobj.InsertDepartment(dep);
               
                DataTable dt = new DataTable();
                dt=baobj.GetDepartment();
                beobj.depCode = int.Parse(dt.Rows[0][0].ToString());
                //MessageBox.Show(beobj.depCode.ToString());
                beobj.staffType = "ICT Administrator";
                int x;
                x = baobj.InsertStaff(beobj);
                int v;
                v = baobj.InsertTrack(beobj);
                if (x > 0 && v > 0)
                {
                    MessageBox.Show("ICT Help Desk Administrator Registered");
                }
            }
            else
            {

                MessageBox.Show("failed!!\nEnter Valid Data Or Cherk Your Passwords");

            }
        }

        private void firstRegistration_Load(object sender, EventArgs e)
        {
            cmbQues1.Items.Add("Who Is Your Best Friend?");
            cmbQues1.Items.Add("Where were you born?");
            cmbQues2.Items.Add("Which colour is your favourite?");
            cmbQues2.Items.Add("Which pat is your favourite?");
            
        }

        private void txtName_Leave(object sender, EventArgs e)
        {

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

        private void txtID_Leave(object sender, EventArgs e)
        {
            string pattern = "(((\\d{2}((0[13578]|1[02])(0[1-9]|[12]\\d|3[01])|(0[13456789]|1[012])(0[1-9]|[12]\\d|30)|02(0[1-9]|1\\d|2[0-8])))|([02468][048]|[13579][26])0229))(( |-)(\\d{4})( |-)(\\d{3})|(\\d{7}))";
            if (Regex.IsMatch(txtID.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtID, "Enter a valid ID number");
                return;
            }
        }

        private void txtStaffNo_Leave(object sender, EventArgs e)
        {
            string pattern = "(^1300\\d{6}$)|(^1800|1900|1902\\d{6}$)|(^0[2|3|7|8]{1}[0-9]{8}$)|(^13\\d{4}$)|(^04\\d{2,3}\\d{6}$)";
            if (Regex.IsMatch(txtStaffNo.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtStaffNo, "Enter a valid Phone Number");
                return;
            }
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



        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(this.txtPassword, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtPassword, null);
            }
        }

        private void txtSurname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                e.Cancel = true;
                txtSurname.Focus();
                errorProvider1.SetError(this.txtSurname, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtSurname, null);
            }
        }

        private void txtConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirm.Text))
            {
                e.Cancel = true;
                txtConfirm.Focus();
                errorProvider1.SetError(this.txtConfirm, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtConfirm, null);
            }
        }

        private void cmbQues1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbQues1.Text))
            {
                e.Cancel = true;
                cmbQues1.Focus();
                errorProvider1.SetError(this.cmbQues1, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbQues1, null);
            }
        }

        private void txtAswer1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAswer1.Text))
            {
                e.Cancel = true;
                txtAswer1.Focus();
                errorProvider1.SetError(this.txtAswer1, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtAswer1, null);
            }
        }

        private void cmbQues2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbQues2.Text))
            {
                e.Cancel = true;
                cmbQues2.Focus();
                errorProvider1.SetError(this.cmbQues2, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbQues2, null);
            }
        }

        private void txtAnswer2_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
