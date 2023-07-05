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
    public partial class MemberForm : Form
    {
        // **** NOTE ****  replace librarian w/ Member name later, once memeber table is created
        //The use of librarian is for testing purposes
        private string librarianName;

        public MemberForm(string librarianName)
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

        private void showWelcomeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
