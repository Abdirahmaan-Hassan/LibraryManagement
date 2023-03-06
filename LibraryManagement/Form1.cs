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
namespace LibraryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsnLog_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void txtUsnLog_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsnLog.Text == "Username")
            {
                txtUsnLog.Clear();
            }
        }

        private void txtPassLog_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassLog.Text == "Password")
            {
                txtPassLog.Clear();
                txtPassLog.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from loginTbl where username = '" +txtUsnLog.Text+ "' and pass ='" +txtPassLog.Text+"' ";
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm s = new SignUpForm();
            this.Hide();
            s.Show();
        }
    }
}
