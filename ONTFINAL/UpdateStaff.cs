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
    public partial class UpdateStaff : Form
    {
        public UpdateStaff()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        private void button5_Click(object sender, EventArgs e)
        {
            UpdateStudent us = new UpdateStudent();
            us.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateDepartment ud = new UpdateDepartment();
            ud.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            beobj.name = textBox1.Text;
            dataGridView1.DataSource = baobj.SelectStaffByName(beobj);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            beobj.staffCode = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            beobj.name = txtName.Text;
            beobj.surname = txtSurname.Text;
            beobj.email = txtEmail.Text;

            beobj.phone = txtPhone.Text;
            beobj.ID = txtID.Text;
        
        
            baobj.updateStaff(beobj);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtID.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPhone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            beobj.staffCode= int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            beobj.status = "In-Active";
            baobj.removeStaff(beobj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateEquipmentType upt = new UpdateEquipmentType();
            upt.Show();
            this.Hide();
        }
    }
}
