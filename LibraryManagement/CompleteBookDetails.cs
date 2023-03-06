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
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from IRBook where book_return_date is NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DGViewIssuedBooks.DataSource = ds.Tables[0];

            cmd.CommandText = "select * from IRBook where book_return_date is not NULL";
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView2.DataSource = ds1.Tables[0];
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
