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
    public partial class AddBooksForm : Form
    {
        public AddBooksForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookname.Text != "" && txtBAName.Text != "" && txtBpulication.Text != "" && txtBPrice.Text != "" && txtBQuantity.Text != "")
            {


                String Bname = txtBookname.Text;
                String bAuthor = txtBAName.Text;
                String publication = txtBpulication.Text;
                String pdate = gunaDateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBPrice.Text);
                Int64 quant = Int64.Parse(txtBQuantity.Text);

                SqlConnection conn = new SqlConnection("server=DESKTOP-0PGLFV3;database=LibraryManagementDB;integrated security = true");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "insert into NewBook (BName,BAuthor,BPubl,BPDate,BPrice,BQuant) values ('" + Bname + "','" + bAuthor + "','" + publication + "','" + pdate + "'," + price + "," + quant + ")";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBAName.Clear();
                txtBookname.Clear();
                txtBPrice.Clear();
                txtBpulication.Clear();
                txtBQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty Fields Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This Will DELETE Your Unsaved DATA", "Are You Sure? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void AddBooksForm_Load(object sender, EventArgs e)
        {

        }
    }
}

