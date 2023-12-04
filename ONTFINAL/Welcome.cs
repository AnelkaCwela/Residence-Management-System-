using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BALayer;
using BELayer;

namespace ONTFINAL
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        //private void btnSignIn_Click(object sender, EventArgs e)
        //{
        //    btnStart.Enabled = true;
        //    lblWelcom.Text = "You Are Welcom";
        //}

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool dataInserted = true;
            try
            {
               

                DataTable df = new DataTable();
                df = baobj.SelectTrack(beobj);
                string f;
                string l = "1";
              
                f = df.Rows[0][0].ToString();
                MessageBox.Show("hERE");
                if (f == l)
                {
                    
                    Login f3 = new Login();
                    f3.ShowDialog();
                    this.Hide();
                    this.Close();
                }

            }
            catch
            {
                dataInserted = false;
            }
            if(dataInserted==false)
            {
                firstRegistration f2 = new firstRegistration();
                f2.ShowDialog();
                this.Hide();
                this.Close();
            }

        }









        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcom_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            label2.Text = "Ready";
        }
    }
}
