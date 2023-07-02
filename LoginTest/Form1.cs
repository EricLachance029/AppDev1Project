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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //Establishes connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-VU3ANP7\\SQLEXPRESS01;Initial Catalog=PassTest;Integrated Security=true";
            con.Open();

            //Gets Name, Username and Password from DB, and compares them to textbox input
            SqlCommand cmd = new SqlCommand("SELECT Name, UserName, Password FROM Login2 WHERE UserName = @username AND Password = @password", con);
            //Assigning value from textBoxes to SQL parameter values
            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);

            //Creating a table and filling it with info found in DB
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            //If no info was found in DB (therefore, table wouldn't have any rows), ignore this
            //If at least 1 row found, execute below (print 'Name' from DB, matching username/password) 
            if (dt.Rows.Count > 0)
            {
                string name = dt.Rows[0]["Name"].ToString();
                MessageBox.Show("Login successful, welcome " + name);
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
