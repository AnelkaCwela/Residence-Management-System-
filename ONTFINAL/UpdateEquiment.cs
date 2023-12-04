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
    public partial class UpdateEquiment : Form
    {
        public UpdateEquiment()
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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStaff us = new UpdateStaff();
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

        private void UpdateEquiment_Load(object sender, EventArgs e)
        {
            dgvEquip.DataSource = baobj.GetEquipment();
            cmbVenue.DataSource = baobj.GetVenue();

            cmbVenue.ValueMember = "VenueCode";
            cmbVenue.DisplayMember = "VenueDescription";
        }

        private void dgvEquip_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dgvEquip.SelectedRows[0].Cells[1].Value.ToString();
            cmbStatus.Text= dgvEquip.SelectedRows[0].Cells[2].Value.ToString();
            //cmbVenue.Text= dgvEquip.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            beobj.depCode= int.Parse(cmbVenue.Text = dgvEquip.SelectedRows[0].Cells[0].Value.ToString());
            beobj.name = txtName.Text;
            beobj.status = cmbStatus.Text;
            beobj.VCode = int.Parse(cmbVenue.SelectedValue.ToString());

            baobj.UpdateEquipment(beobj);
        }

        private void dgvEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
