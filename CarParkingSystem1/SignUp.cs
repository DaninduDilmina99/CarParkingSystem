using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingSystem1
{
    public partial class SignUp : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public SignUp()
        {
            InitializeComponent();
            this.ActiveControl = textemail;
            textemail.Focus();

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            if(textemail.Text == "" && textconpassword.Text=="" && textconpassword.Text == "")
            {
                MessageBox.Show("Email & Password are EMPTY!", "Sign up Failed!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textpassword.Text == textconpassword.Text)
            {
              //  MessageBox.Show("Your Passwords are NOT MATCHED!");
            }
        }

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
    }
}
