using Library_Management_System_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_project
{
    public partial class SupplierForm : Form
    {
        // **** NOTE ****  replace librarian w/ Supplier name later, once memeber table is created
        //The use of librarian is for testing purposes
        private string librarianName;

        public SupplierForm(string librarianName)
        {
            InitializeComponent();
            this.librarianName = librarianName;
            showWelcomeLabel.Text = "Login successful, welcome " + librarianName;
            showWelcomeLabel.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
