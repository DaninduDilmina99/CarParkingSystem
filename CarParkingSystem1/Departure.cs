using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarParkingSystem1
{
    public partial class Departure : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Departure()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textpamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeScreen w = new WelcomeScreen();
            w.Show();
            this.Hide();

        }

        private void Departure_Load(object sender, EventArgs e)
        {
            try
            {
                var dblod = db.tblDepartures.ToList();
                dataGridView1.DataSource = dblod;
                comboBoxcarno.DataSource = db.tblArrivals.ToList();
                comboBoxcarno.ValueMember = "Car_No";
                comboBoxcarno.DisplayMember = "Car_no";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxcarno.Text != null & labeldname.Text != null & labelptime.Text != null & labelptime.Text != null )
                {

                    tblDeparture s = new tblDeparture();
                    s.Car_No = comboBoxcarno.Text;
                    s.Driver = labeldname.Text;
                    s.Type = labelptype.Text;
                    s.P_Time = labelptime.Text;

                    decimal str =  Convert.ToDecimal(labelptime.Text);
                    decimal amt = Convert.ToDecimal(textpamount.Text);
                    decimal amttotal = str * amt;

                    s.Amount = amttotal;
                    
                    s.Departure_Time = DateTime.Now;
                    db.tblDepartures.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Departure Successfully!");

                    load();
                }
                   
                else
                {
                    MessageBox.Show("Input values are empty... TRY AGAIN!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void load()
        {
            var dblod = db.tblDepartures.ToList();
            dataGridView1.DataSource = dblod;
            comboBoxcarno.DataSource = db.tblArrivals.ToList();
            comboBoxcarno.ValueMember = "Car_No";
            comboBoxcarno.DisplayMember = "Car_no";
        }

        private void comboBoxcarno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tblArrival obj = comboBoxcarno.SelectedItem as tblArrival;
                if(obj != null)
                {
                    labeldname.Text = obj.Driver_Name.ToString();
                    labelptype.Text=obj.Category.ToString();
                    labelptime.Text=obj.Stay_Time.ToString();
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
