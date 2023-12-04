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
using System.Text.RegularExpressions;

namespace ONTFINAL
{
    public partial class AddStudent : Form
    {
        public AddStudent()
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

        private void btnSubStud_Click(object sender, EventArgs e)
        {


            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                beobj.name = txtName.Text;
                beobj.surname = txtSurname.Text;
                beobj.email = txtEmail.Text;

                beobj.phone = txtPhone.Text;
                beobj.course = cmbCourse.Text;
                beobj.YearOfStudy = cmbYearOfStudy.Text;

                beobj.ID = txtID.Text;
                beobj.status = "Active";

                if (baobj.InsertStudent(beobj) < 0)
                {
                    MessageBox.Show("Student Registered");
                    btnSubStud.Text = "Submitted";
                    btnSubStud.BackColor = Color.Green;
                }
                else
                {

                    MessageBox.Show("failed!!\nEnter Valid Data Or Cherk Your Passwords");
                    btnSubStud.Text = "Try Submitting Again";
                    btnSubStud.BackColor = Color.Red;
                }

            }
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

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string pattern = "(^1300\\d{6}$)|(^1800|1900|1902\\d{6}$)|(^0[2|3|7|8]{1}[0-9]{8}$)|(^13\\d{4}$)|(^04\\d{2,3}\\d{6}$)";
            if (Regex.IsMatch(txtPhone.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtPhone, "Enter a valid Phone Number");
                return;
            }
        }

        private void cmbCourse_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCourse.Text))
            {
                e.Cancel = true;
                cmbCourse.Focus();
                errorProvider1.SetError(this.cmbCourse, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbCourse, null);
            }

        }

        private void cmbYearOfStudy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbYearOfStudy.Text))
            {
                e.Cancel = true;
                cmbYearOfStudy.Focus();
                errorProvider1.SetError(this.cmbYearOfStudy, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbYearOfStudy, null);
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

        private void AddStudent_Load(object sender, EventArgs e)
        {
            cmbCourse.Items.Add("Software Development");
            cmbCourse.Items.Add("Communication Networks");
            cmbCourse.Items.Add("Support Services");

       
            cmbYearOfStudy.Items.Add("1st year");
            cmbYearOfStudy.Items.Add("2nd year");
            cmbYearOfStudy.Items.Add("3rd year");
            cmbYearOfStudy.Items.Add("Ad Diploma");

        }
    }
}
