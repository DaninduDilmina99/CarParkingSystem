using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingSystem1
{
    public partial class Arrival : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Arrival()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeScreen w = new WelcomeScreen();
            w.Show();
            this.Hide();
        }

        public void load()
        {
            var ld = db.tblArrivals.ToList();
            dataGridView1.DataSource = ld;
            labelid.Text = "";
            textdriver.Text = "";
            textcar.Text = "";
            textstime.Text = "";
            checkedListBox1.Text = "";

            var total = db.tblArrivals.Count();
            lbltotal.Text = total.ToString();
            
            



        }

        private void Arrival_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = db.tblSlots.ToList();
            comboBox1.ValueMember = "Slot_No";
            comboBox1.DisplayMember = "Slot_No";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textdriver.Text != null & textcar.Text != null & textstime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {
                    string sno = textcar.Text;
                    var chk = db.tblArrivals.Where(o => o.Car_No == sno).FirstOrDefault();
                    if (chk == null)
                    {
                        tblArrival s = new tblArrival();
                        s.Driver_Name = textdriver.Text;
                        s.Car_No = textcar.Text;
                        s.Category = checkedListBox1.Text;
                        s.Stay_Time = textstime.Text;
                        s.Selected_Slot = comboBox1.Text;
                        s.A_Time = DateTime.Now;
                        db.tblArrivals.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Parking Successfully!");
                        
                        load();
                    }
                    else
                    {
                        MessageBox.Show("This Car Already Parked!");
                    }
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
