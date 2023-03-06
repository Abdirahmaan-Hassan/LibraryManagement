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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {


                SqlConnection conn = new SqlConnection("server=.; database=LibraryManagementDB; integrated security=true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "insert into loginTbl (username, pass) values('" + txtUserName.Text + "','" + txtPassword.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("New User Has Been Registred!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 fr1 = new Form1();
                this.Hide();
                fr1.Show();
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields!", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
