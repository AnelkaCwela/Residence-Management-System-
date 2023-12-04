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
    public partial class UpdateVanue : Form
    {
        public UpdateVanue()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateEquiment ue = new UpdateEquiment();
            ue.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateDepartment ud = new UpdateDepartment();
            ud.Show();
            this.Hide();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void btnAddVanue_Click(object sender, EventArgs e)
        {
            //Venues v = new Venues(int.Parse(dgvVenue.SelectedRows[0].Cells[0].Value.ToString()), txtDescription.Text, int.Parse(txtCapacity.Text));
            int x = baobj.UpdateVenue(int.Parse(dgvVenue.SelectedRows[0].Cells[0].Value.ToString()), txtDescription.Text, int.Parse(txtCapacity.Text));


            if (x < 0)
            {
                MessageBox.Show("Venue  has been Updated.");
                Display();
            }
            else
            {
                MessageBox.Show("Venue  has been Updated.");
            }
        }
        public void Display()
        {
            dgvVenue.DataSource = baobj.GetVenue();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Venues v = new Venues(int.Parse(dgvVenue.SelectedRows[0].Cells[0].Value.ToString()), "Inctive");
            int x = baobj.DeleteVenue(v);

            if (x < 0)
            {
                MessageBox.Show("Venue  has been Deleted.");
                Display();
            }
            else
            {
                MessageBox.Show("Venue  has been Deleted.");
            }
        }

        private void UpdateVanue_Load(object sender, EventArgs e)
        {
            Display();
          
        }

        private void dgvVenue_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           txtCapacity.Text = dgvVenue.SelectedRows[0].Cells[2].Value.ToString();
            txtDescription.Text = dgvVenue.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
