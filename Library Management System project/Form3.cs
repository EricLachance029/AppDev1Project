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
    public partial class LibrarianForm : Form
    {
        private string librarianName;

        public LibrarianForm(string librarianName)
        {
            InitializeComponent();
            this.librarianName = librarianName;
            showWelcomeLabel.Text = "Login successful, welcome " + librarianName;
            showWelcomeLabel.Show();


        }

        private void showWelcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
