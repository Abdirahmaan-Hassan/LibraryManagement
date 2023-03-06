using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure You want to exit", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
           
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBooksForm adb = new AddBooksForm();
            adb.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBookForm vb = new ViewBookForm();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent std = new AddStudent();
            std.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformatio vsi = new ViewStudentInformatio();
            vsi.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ISB = new IssueBooks();
            ISB.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cbd = new CompleteBookDetails();
            cbd.Show();
        }

        private void uSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers u  =new frmUsers();
            u.Show();
        }
    }
}
