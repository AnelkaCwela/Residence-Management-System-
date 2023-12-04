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

namespace ONTFINAL
{
    public partial class AddRequests : Form
    {
        public AddRequests()
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

        private void button8_Click(object sender, EventArgs e)
        {
            AddEquipmentType Et = new AddEquipmentType();
            Et.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTutorRequest_Click_1(object sender, EventArgs e)
        {
            Request r = new Request(txtDesctription.Text, int.Parse(cmbStaff.SelectedValue.ToString()), int.Parse(cmbStudent.SelectedValue.ToString()), int.Parse(cmbTaskType.SelectedValue.ToString()), txtDataTimePicker.Text, txtTime.Text);

            int x = baobj.InsRequests(r);
            if (x < 0)
            {
                MessageBox.Show("Request of has been  Added.");
                dataGridView1.DataSource = baobj.GetRequest();


            }
            else
            {
                MessageBox.Show("Request of could not be  Added.");
            }
        }

        private void AddRequests_Load(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;

            txtTime.Text = DT.ToShortTimeString();

            cmbStaff.DataSource = baobj.SelectStaff(beobj);
            cmbStaff.ValueMember = "staffCode";
            cmbStaff.DisplayMember = "lastName";
            //SelectStaff(BEL beobj)


            cmbStudent.DataSource = baobj.GetStudent(beobj);
            cmbStudent.ValueMember = "StudentId";
            cmbStudent.DisplayMember = "Surname";


            //cmbTaskType.Items.Add("Assisting");
            //cmbTaskType.Items.Add("Tutoring");
            //cmbTaskType.Items.Add("Inspection");
            cmbTaskType.DataSource = baobj.GetTaskType();
            cmbTaskType.ValueMember = "TaskTypeCode";
            cmbTaskType.DisplayMember = "TaskTypeDescription";
        }

        private void btnListTutorRequest_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baobj.GetRequest();
        }
    }
}
