﻿using System;
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
    public partial class Login : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Login()
        {
            InitializeComponent();
        }


        private void buttonlogin_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textpassword.Text != null & textemail.Text != null)
            //    {
            //        var item = db.tblAccounts.Where(s => s.Password == textpassword.Text && s.Email == textemail.Text).FirstOrDefault();  
            //        if (item != null)
            //        {

            //           Splash wc = new Splash();
            //            wc.Show();
            //            this.Hide();


            //        }
            //        else
            //        {
            //            MessageBox.Show("Your Password or Email not exits! Create Your Account...");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Password or Email Incorrect!!, TRY AGAIN!");
            //    }
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}


            if (textemail.Text == ""  || textpassword.Text =="")
            {
                MessageBox.Show("Enter your Email and Password");
            }
            else
            {
                var item = db.tblAccounts.Where(s =>  s.Email == textemail.Text && s.Password == textpassword.Text).FirstOrDefault();

                if (textemail.Text == "Admin" || textpassword.Text == "A123")
                {
                    

                    Splash s = new Splash();
                    s.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalied Email or Password!, TRY AGAIN!!");
                }
                    

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

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
