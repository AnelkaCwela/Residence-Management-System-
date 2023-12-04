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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ONTFINAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static int x;
        public bool check;
        bool Times = false, tTimes = false;
        public BEL beobj = new BEL();
        public BAL baobj = new BAL();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beobj.Email = txtEmai.Text;
            beobj.Password = txtPasswor.Text;
            int H = 0;
            int m = 0;

            DataTable d = new DataTable();
            d = baobj.SelectStaff(beobj);

            beobj.s=0;
            int staffPath = 20190000;
          


            int n = 0;
            foreach (DataRow dr in d.Rows)
            {
                string l = d.Rows[n][4].ToString();
                string x = d.Rows[n][6].ToString();
                string g = d.Rows[n][5].ToString();

                if (beobj.Email == l)
                {
                    H++;
                    beobj.s = int.Parse(d.Rows[n][0].ToString()) + staffPath;
                    if (beobj.Password == x)
                    {
                        m++;
                        if (g == "ICT Administrator")
                        {
                            beobj.staffType = g;
                            baobj.InsertUser(beobj);
                            IctAdmin f5 = new IctAdmin();
                            f5.Show();

                        }
                        else if (g == "INFO@IT Administrator")
                        {
                            beobj.staffType = g;
                            baobj.InsertUser(beobj);

                           AdminHome f5 = new AdminHome();
                            f5.Show();


                        }
                        else if (g == "Intern" || g == "INFO@IT Worker")
                        {
                            beobj.staffType = g;
                            baobj.InsertUser(beobj);
                            StaffHome f6 = new StaffHome();
                            f6.Show();
                        }
                        else if (g == "Student Assistant")
                        {

                            //Form7 f7 = new Form7();
                            //f7.Show();
                        }
                    }

                    

                }

                n++;
            }
            if (m <= 0)
            {
                lblYourPass.ForeColor = Color.Red;
                lblYourPass.Text = "Incorect pin";
            }
            if (H <= 0)
            {
                lblYourPass.ForeColor = Color.Red;
                lblYourPass.Text = "Check your email add";
            }
            if (beobj.s > 0)
            {
                //lbStaffNom.Text = s.ToString();
            }
         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Welcome f1 = new Welcome();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool someError = false;
            try
            {



                btnShow.Hide();
                button1.Hide();
                lblYourPass.Text = "";
                check = false;

                button2.Text = "Submit";
                txtPasswor.Hide();
                pictureBox2.Hide();
                button2.BackColor = Color.Violet;
                label2.Text = "Enter your id number";
                lblPass.Text = "Click submit to \nview this Question";
                DataTable dt = new DataTable();
                int n = 0;

                dt = baobj.SelectStaff(beobj);

                foreach (DataRow dr in dt.Rows)
                {
                    if (txtEmai.Text == dt.Rows[n][3].ToString())
                    {
                        x = n;
                        check = true;
                        lblYourPass.Text = "";
                        txtPasswor.UseSystemPasswordChar = false;
                     
                    }

                    n++;

                }

                if (check == true)
                {
                    MessageBox.Show(dt.Rows[x][7].ToString());
                    label3.Text = dt.Rows[x][7].ToString();
                    pictureBox2.Show();
                    txtPasswor.Show();
                   

                }
                if (check == false && x != 0)
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = "Invalid Information doesn't match!!";

                }
                if (txtPasswor.Text == dt.Rows[x][8].ToString())
                {
                    label4.Text = "Here is your " + dt.Rows[x][6].ToString();
                    btnBack.Show();

                }
            }
            catch
            {
                someError = true;
            }
            if(someError==true)
            {
                MessageBox.Show("Error some hwfdsgjhb");
            }
            else
            {
                txtPasswor.Text = "";
                pictureBox2.Hide();
            }
         
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPasswor.UseSystemPasswordChar == true)
            {
                txtPasswor.UseSystemPasswordChar = false;
                btnShow.Text = "Hide";
            }
            else if (txtPasswor.UseSystemPasswordChar == false)
            {
                txtPasswor.UseSystemPasswordChar = true;
                btnShow.Text = "Show";
            }
        }

       
     
        private void txtEmai_Click(object sender, EventArgs e)
        {
            txtEmai.Text = "";
        }

        private void txtPasswor_Click(object sender, EventArgs e)
        {
            txtPasswor.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPasswor.UseSystemPasswordChar = true;
          
            lblYourPass.Text = "";
            Times = false;
            btnBack.Hide();
        }
    }
}
