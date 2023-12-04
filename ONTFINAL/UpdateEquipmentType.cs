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
    public partial class UpdateEquipmentType : Form
    {
        public UpdateEquipmentType()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        private void UpdateEquipmentType_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = baobj.GetEquipment();
            comboBox1.DisplayMember = "Description";
            comboBox1.ValueMember = "EquipCode";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EquipmentType equi = new EquipmentType(int.Parse(dgvType.SelectedRows[0].Cells[0].Value.ToString()),txtName.Text,int.Parse(txtYear.Text), cmbStatus.Text);
            baobj.UpdateEquipmentType(equi);
            comboBox1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvType.DataSource = baobj.EquipmentTypeByEquipment(int.Parse(comboBox1.SelectedValue.ToString()));
            }
            catch { }

        }

        private void dgvType_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtName.Text = dgvType.SelectedRows[0].Cells[1].Value.ToString();
            txtYear.Text= dgvType.SelectedRows[0].Cells[2].Value.ToString();
            cmbStatus.Text= dgvType.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            EquipmentType equi = new EquipmentType(int.Parse(dgvType.SelectedRows[0].Cells[0].Value.ToString()), txtName.Text, int.Parse(txtYear.Text),"In-Active");
            baobj.UpdateEquipmentType(equi);
            comboBox1.Enabled = true;
        }
    }
}
