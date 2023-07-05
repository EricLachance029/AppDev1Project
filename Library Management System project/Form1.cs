/************ FORM NOTES *****************
 * Form1 - WelcomePage
 * Form2 - PopupLibrarianLogin
 * Form3 - LibrarianForm
 * Form4 - MemberLogin
 * Form5 - MemberForm
 * Form6 - NonMemberForm
 * Form7 - SupplierLogin
 * Form8 - SupplierForm
 ****************************************/



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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /****************************************************************************** Button to Librarian Form *****/
        private void librarianButton_Click(object sender, EventArgs e)
        {
            PopupLibrarianLogin frm2 = new PopupLibrarianLogin();
            frm2.Show();
        }


        /****************************************************************************** Button to Member Form *****/
        private void memberButton_Click(object sender, EventArgs e)
        {
            PopupMemberLogin frm4 = new PopupMemberLogin();
            frm4.Show();
        }


        /****************************************************************************** Button to non-Member Form *****/
        private void nonmemberButton_Click(object sender, EventArgs e)
        {
            NonMemberForm frm6 = new NonMemberForm();
            frm6.Show();
        }


        /****************************************************************************** Button to Supplier Form *****/
        private void supplierButton_Click(object sender, EventArgs e)
        {
            SupplierLogin frm7 = new SupplierLogin();
            frm7.Show();
        }
    }
}
