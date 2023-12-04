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
    public partial class UpdateDepartment : Form
    {
        public UpdateDepartment()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStaff us = new UpdateStaff();
            us.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateEquiment ue = new UpdateEquiment();
            ue.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateVanue uv = new UpdateVanue();
            uv.Show();
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


            //Venues v = new Venues(int.Parse(dgvVenue.SelectedRows[0].Cells[0].Value.ToString()), txtDescription.Text, int.Parse(txtCapacity.Text));
            Department de = new Department(txtName.Text,txtBuilding.Text,txtPerson.Text,txtEmail.Text);
            baobj.UpdateDepartment(de);
            MessageBox.Show("Department  has been Updated.");
        }

        private void dataDepartment_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dataDepartment.SelectedRows[0].Cells[1].Value.ToString();
            txtBuilding.Text = dataDepartment.SelectedRows[0].Cells[2].Value.ToString();
            txtPerson.Text = dataDepartment.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataDepartment.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void UpdateDepartment_Load(object sender, EventArgs e)
        {
            dataDepartment.DataSource= baobj.GetDepartment();
        }
    }

}

