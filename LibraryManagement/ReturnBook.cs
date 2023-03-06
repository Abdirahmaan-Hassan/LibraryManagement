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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearchEnroll.Clear();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from IRBook where std_enroll ='" + txtSearchEnroll.Text + "' and book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                DgViewReturnBook.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid ID or No Book ISSUED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtSearchEnroll.Clear();
        }

        string bname;
        string bdate;
        Int64 rowid;
        private void DgViewReturnBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (DgViewReturnBook.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(DgViewReturnBook.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = DgViewReturnBook.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = DgViewReturnBook.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            txtBookname.Text = bname;
            txtBookIssueDate.Text = bdate;

              
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = "update IRBook set book_return_date='" + Date_Return_Field.Text + "' where std_enroll='" + txtSearchEnroll.Text + "' and id="+rowid+"";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Reteurn Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }

        private void txtSearchEnroll_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchEnroll.Text == "")
            {
                panel2.Visible = false;
                DgViewReturnBook.DataSource = null;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }
    }
}
