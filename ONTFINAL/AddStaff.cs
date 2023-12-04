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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();

        private void button1_Click(object sender, EventArgs e)
        {
            StaffHome sh = new StaffHome();
            sh.Show();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = baobj.SelectStaff(beobj);
            int r = 0, n = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (txtEmail.Text == dt.Rows[r][4].ToString() || txtID.Text == dt.Rows[r][3].ToString())
                {
                    n++;
                }
                r++;
            }
            if ((ValidateChildren(ValidationConstraints.Enabled)))
            {
                if (txtpassword.Text == txtConfirm.Text)
                {
                    if (n <= 0)
                    {
                        beobj.name = txtName.Text;
                        beobj.surname = txtSurname.Text;
                        beobj.email = txtEmail.Text;
                        beobj.password = txtpassword.Text;
                        beobj.phone = txtPhone.Text;
                        beobj.sq1 = cmbQuest1.Text;
                        beobj.answer1 = txtAnswer1.Text;
                        beobj.sq2 = cmbQuest2.Text;
                        beobj.answer2 = txtAnswer2.Text;
                        beobj.ID = txtID.Text;   
                        beobj.status = "Active";
                        beobj.depCode = int.Parse(comboBox1.SelectedValue.ToString());

                        if (cbIntern.Checked == true)
                        {
                            beobj.staffType = cbIntern.Text;

                        }
                        else if (cbStudentAs.Checked == true)
                        {
                            beobj.staffType = cbStudentAs.Text;

                        }
                        else if (cbWorker.Checked == true)
                        {
                            beobj.staffType = cbWorker.Text;

                        }
                        int x;
                        x = baobj.InsertStaff(beobj);

                        if (x > 0)
                        {
                            MessageBox.Show("Staff Registered");
                            btnSubmit.Text = "Submitted";
                            btnSubmit.BackColor = Color.Green;
                        }
                    }
                    else
                    {

                        MessageBox.Show("failed!!\nUser already registered");
                        btnSubmit.Text = "Try Submitting Again";
                        btnSubmit.BackColor = Color.Red;
                    }

                }
                else
                {

                    MessageBox.Show("failed!!\nCherk Your Passwords!!!");
                    btnSubmit.Text = "Try Submitting Again";
                    btnSubmit.BackColor = Color.Red;
                }
            }
            else
            {

                MessageBox.Show("failed!!\nEnter Valid Data");
                btnSubmit.Text = "Try Submitting Again";
                btnSubmit.BackColor = Color.Red;
            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
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

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                e.Cancel = true;
                comboBox1.Focus();
                errorProvider1.SetError(this.comboBox1, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.comboBox1, null);
            }
        }

        private void txtpassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                e.Cancel = true;
                txtpassword.Focus();
                errorProvider1.SetError(this.txtpassword, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtpassword, null);
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

        private void cmbQuest1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbQuest1.Text))
            {
                e.Cancel = true;
                cmbQuest1.Focus();
                errorProvider1.SetError(this.cmbQuest1, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbQuest1, null);
            }

        }

        private void txtAnswer1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer1.Text))
            {
                e.Cancel = true;
                txtAnswer1.Focus();
                errorProvider1.SetError(this.txtAnswer1, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtAnswer1, null);
            }
        }

        private void cmbQuest2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbQuest2.Text))
            {
                e.Cancel = true;
                cmbQuest2.Focus();
                errorProvider1.SetError(this.cmbQuest2, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.cmbQuest2, null);
            }
        }

        private void txtAnswer2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAnswer2.Text))
            {
                e.Cancel = true;
                txtAnswer2.Focus();
                errorProvider1.SetError(this.txtAnswer2, "Enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(this.txtAnswer2, null);
            }
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            //try
            //{
                DataTable dat = new DataTable();
                dat = baobj.GetUser();int n = 0, l = 0;
                foreach(DataRow dr in dat.Rows)
                {
                    n++;
                }
            if(dat.Rows[n-1][1].ToString() == "ICT Administrator")
            { cbIntern.Text = "INFO@IT Administrator"; cbWorker.Hide(); cbStudentAs.Hide();


                DataTable d = new DataTable();
                d = baobj.SelectStaff(beobj);
                int x = 0;
                foreach (DataRow dr in d.Rows)
                {

                    string g = d.Rows[x][5].ToString();

                    if (g == "INFO@IT Administrator")
                    {
                        l = 1;
                    }
                    x++;

                }
                if (l == 1) { cbIntern.Enabled = false; }

            }



             
            //}
            //catch { }
            cmbQuest1.Items.Add("Who Is Your Best Friend?");
            cmbQuest1.Items.Add("Where were you born?");
            cmbQuest2.Items.Add("Which colour is your favourite?");
            cmbQuest2.Items.Add("Which pat is your favourite?");

            comboBox1.DataSource = baobj.GetDepartment();
            comboBox1.DisplayMember = "DepartName";
            comboBox1.ValueMember = "DepartCode";
        }
    }
}
