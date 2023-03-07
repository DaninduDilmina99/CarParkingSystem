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
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpassword.Text != null & textemail.Text != null)
                {
                    var item = db.tblAccounts.Where(s => s.Password == textpassword.Text && s.Email == textemail.Text).FirstOrDefault();  
                    if (item != null)
                    {

                        WelcomeScreen wc = new WelcomeScreen();
                        wc.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Your Password or Email not exits! Create Your Account...");
                    }
                }
                else
                {
                    MessageBox.Show("Password or Email Incorrect!!, TRY AGAIN!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
