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

namespace CarParkingSystem1
{
    public partial class SignUp : Form
    {
        //DataClasses1DataContext db = new DataClasses1DataContext();

        string connectionString = @"Data Source=danie\\sqlexpress;Initial Catalog=CarResavationDB;Integrated Security=True";

        public SignUp()
        {
            InitializeComponent();
            this.ActiveControl = textemail;
            textemail.Focus();
        }

       // SqlConnection connection = new SqlConnection("Data Source=danie\\sqlexpress;Initial Catalog=CarResavationDB;Integrated Security=True");

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            if (textemail.Text == "" || textconpassword.Text == "" || textconpassword.Text == "")
            {
                MessageBox.Show("Email or Password are EMPTY!", "Registration Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textpassword.Text != textconpassword.Text)
            {
                MessageBox.Show("Your Passwords are NOT MATCHED!");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Email", textemail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", textpassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfull");
                    Clear();
                }
            }
            
            
            
            
            
            //....................................................................

            //if(textemail.Text == "" && textconpassword.Text=="" && textconpassword.Text == "")
            //{
            //    MessageBox.Show("Email & Password are EMPTY!", "Sign up Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if(textpassword.Text == textconpassword.Text)
            //{
            //  //  MessageBox.Show("Your Passwords are NOT MATCHED!");
            //}


            //..............................................................

            //try
            //{
            //    if (textemail.Text != "" && textpassword.Text != "" && textconpassword.Text != "")
            //    {
            //        if (textpassword.Text == textconpassword.Text)
            //        {
            //            int v = Check(textemail.Text);
            //            if (v != 1)
            //            {
            //                connection.Open();
            //                SqlCommand command = new SqlCommand("insert into tblAccounts values (@Email, @textpassword)", connection);
            //                command.Parameters.AddWithValue("@Email", textemail.Text);
            //                command.Parameters.AddWithValue("@Password", textpassword.Text);
            //                command.ExecuteNonQuery();
            //                connection.Close();
            //                MessageBox.Show("Registration Successfully!");
            //                textemail.Text = "";
            //                textpassword.Text = "";
            //                textconpassword.Text = "";
            //            }
            //            else
            //            {
            //                MessageBox.Show("Your Already Registerd!");
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Password doest Matched!");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Your textboxers are Empty!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}






        }

        private void Clear()
        {
            textemail.Text = "";
            textpassword.Text = "";
            textconpassword.Text = "";
            
        }

        //private int Check(string textemail)
        //{
        //    connection.Open();
        //    String query = "select count (*) from tblAccounts where email = '" + textemail + "'";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    int v = (int)command.ExecuteScalar();
        //    connection.Close();
        //    return v;

        //}

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                textpassword.PasswordChar = '\0';
                textconpassword.PasswordChar= '\0';
            }
            else
            {
                textpassword.PasswordChar = '*';
                textconpassword.PasswordChar = '*';
            }
        }

        private void textemail_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textpassword_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textemail.Text = "";
            textpassword.Text = "";
            textconpassword.Text = "";
            textemail.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login s = new Login();
            s.Show();
            this.Hide();
        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
