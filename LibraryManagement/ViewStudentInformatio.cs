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
    public partial class ViewStudentInformatio : Form
    {
        public ViewStudentInformatio()
        {
            InitializeComponent();
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchPhone.Text != "")
            {
                //lblView.Visible = false;
                panelUpdate.Visible = false;
                Image image = Image.FromFile("C:\\Users\\Abdishakuur Hassan\\Downloads\\Liberay Management System Icon and Images\\Liberay Management System img\\search1.gif");
                pictureBox1.Image = image;

                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from NewStudent where contact LIKE '%"+txtSearchPhone.Text+"%' ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                DGViewStudents.DataSource = ds.Tables[0];
            }
            else
            {
                //lblView.Visible = true;
                panelUpdate.Visible = true;
                Image image = Image.FromFile("C:\\Users\\Abdishakuur Hassan\\Downloads\\Liberay Management System Icon and Images\\Liberay Management System img\\search.gif");
                pictureBox1.Image = image;

                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

                DGViewStudents.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudentInformatio_Load(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            DGViewStudents.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void DGViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGViewStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DGViewStudents.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panelUpdate.Visible = true;

            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from NewStudent where stuid="+bid+"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtSname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            comboDep.Text = ds.Tables[0].Rows[0][3].ToString();
            comboSem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtSname.Text;
            string enroll = txtEnrollment.Text;
            string dep = comboDep.Text;
            string sem = comboSem.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;

            if (MessageBox.Show("Data will Be UPDATED. Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {


                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update NewStudent set sname='" + sname + "',enroll='" + enroll + "',dep='" + dep + "',sem='" + sem + "',contact='" + contact + "',email='" + email + "' where stuid=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                ViewStudentInformatio_Load(this, null);
            }
            else
            {

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformatio_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will Be DELETED. Confirm", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete from NewStudent  where stuid=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                ViewStudentInformatio_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will Be Lost.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
