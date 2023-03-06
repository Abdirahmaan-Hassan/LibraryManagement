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
    public partial class ViewBookForm : Form
    {
        public ViewBookForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
        SqlCommand cmd = new SqlCommand();

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookForm_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewVB.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void dataGridViewVB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVB.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridViewVB.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select * from NewBook where Bid = "+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtbookname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBauthorN.Text = ds.Tables[0].Rows[0][2].ToString();
            txtBpubli.Text = ds.Tables[0].Rows[0][3].ToString();
            txtDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtbookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtbookquantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void textBoxBookName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBookName.Text != "")
            {
                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewBook where BName LIKE '"+textBoxBookName.Text +"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewVB.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridViewVB.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            textBoxBookName.Clear();
            panel2.Visible = false;
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = txtbookname.Text;
                string bauthor = txtBauthorN.Text;
                string publication = txtBpubli.Text;
                string bdate = txtDate.Text;
                Int64 price = Int64.Parse(txtbookPrice.Text);
                Int64 quant = Int64.Parse(txtbookquantity.Text);

                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "update NewBook set BName = '" + bname + "', BAuthor ='" + bauthor + "',BPubl ='" + publication + "',BPDate='" + bdate + "',BPrice =" + price + ",BQuant=" + quant + " where Bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewBookForm_Load(this, null);
                
            }

            

            //Bid	BName	BAuthor	BPubl	BPDate	BPrice	BQuant

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string bname = txtbookname.Text;
                string bauthor = txtBauthorN.Text;
                string publication = txtBpubli.Text;
                string bdate = txtDate.Text;
                Int64 price = Int64.Parse(txtbookPrice.Text);
                Int64 quant = Int64.Parse(txtbookquantity.Text);

                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                cmd.CommandText = "delete from NewBook where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ViewBookForm_Load(this, null);
            }
        }

        
    }
}
