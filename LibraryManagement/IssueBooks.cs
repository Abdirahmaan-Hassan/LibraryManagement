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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd = new SqlCommand("select BName from NewBook", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    comboBName.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "")
            {
                string eid = txtEnrollment.Text;
                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from NewStudent where enroll LIKE '%" + eid + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                //------------------------------------------------------------------
                //code to count how many book has been issued on this enrollment number
                cmd.CommandText = "select count(std_enroll) from IRBook where std_enroll LIKE '%" + eid + "%' and book_return_date is null";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                DA.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //----------------------------------------------------------------

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtStName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtStDep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtStSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtStContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtStEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtStName.Clear();
                    txtStDep.Clear();
                    txtStSem.Clear();
                    txtStContact.Clear();
                    txtStEmail.Clear();
                    MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                txtStName.Clear();
                txtStDep.Clear();
                txtStEmail.Clear();
                txtStSem.Clear();
                txtStContact.Clear();
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtStName.Text != "")
            {
                if (comboBName.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = txtEnrollment.Text;
                    string stname = txtStName.Text;
                    string stdep = txtStDep.Text;
                    string sem = txtStSem.Text;
                    Int64 contact = Int64.Parse(txtStContact.Text);
                    string email = txtStEmail.Text;
                    string bookname = comboBName.Text;
                    string bookissuedate = gunaDateTimePickerBIDate.Text;

                    SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.CommandText = "insert into IRBook (std_enroll, std_name, std_dep, std_sem, std_contact, std_email, book_name, book_issue_date) values('"+enroll+"','"+stname+"','"+stdep+"','"+sem+"',"+contact+",'"+email+"','"+bookname+"','"+bookissuedate+"')";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected Book. Or Maximum Number Of Book Has Been ISSUED", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnREFRE_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
            
        }
    }
}
