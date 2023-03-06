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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtEnroll.Clear();
            txtStContact.Clear();
            txtStEmail.Clear();
            txtStName.Clear();
            comboDep.Text = "";
            comboSem.Text = "";
            
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (txtStName.Text != "" && txtEnroll.Text != "" && txtStContact.Text != "" && txtStEmail.Text != "" && comboDep.Text != "" && comboSem.Text != "")
            {


                string name = txtStName.Text;
                string enroll = txtEnroll.Text;
                string dep = comboDep.Text;
                string sem = comboSem.Text;
                Int64 mobile = Int64.Parse(txtStContact.Text);
                string email = txtStEmail.Text;



                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "insert into NewStudent (sname,enroll, dep ,sem, contact, email) values('" + name + "','" + enroll + "','" + dep + "','" + sem + "'," + mobile + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEnroll.Clear();
                txtStContact.Clear();
                txtStEmail.Clear();
                txtStName.Clear();
                comboDep.Text = "";
                comboSem.Text = "";
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
