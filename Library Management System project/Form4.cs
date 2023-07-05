using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_project
{
    public partial class PopupMemberLogin : Form
    {
        public PopupMemberLogin()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Establishes connection
            SqlConnection con = new SqlConnection();

            /******************************************************************************************************************
             * This line is for the DB address on my computer, When testing on your PC, comment this one out and add your own, 
             * that way it'll be quick to Test on either one of our computer since we just need to cxomment/un-comment out 1 line 
             ******************************************************************************************************************/
            con.ConnectionString = "Data Source=DESKTOP-VU3ANP7\\SQLEXPRESS01;Initial Catalog=LibraryManagementSystemDB;Integrated Security=true";
            // Copy line above but with your DB address here, then comment out line above, don't delete it

            
            con.Open();

            //Gets Name, Username and Password from DB, and compares them to textbox input
            SqlCommand cmd = new SqlCommand("SELECT LibrarianID, FirstName, Username, Password FROM LibrarianInfo WHERE UserName = @username AND Password = @password", con);
            //Assigning value from textBoxes to SQL parameter values
            cmd.Parameters.AddWithValue("@username", userTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passTextBox.Text);

            //Creating a table and filling it with info found in DB
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //If no info was found in DB (therefore, table wouldn't have any rows), ignore this
            if (dt.Rows.Count > 0)
            {

                //If User/Pass matches, close main + login window, and open librarianForm
                string LibrarianName = dt.Rows[0]["FirstName"].ToString();
                MemberForm librarianForm = new MemberForm(LibrarianName);
                librarianForm.Show();

                this.Close();





            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void welcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username or Password is incorrect");
        }
        


        
    }
}

