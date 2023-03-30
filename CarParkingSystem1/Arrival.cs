using DGVPrinterHelper;
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
            load();
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
            int ir = e.RowIndex;
            labelid.Text = dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textdriver.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textcar.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
            textstime.Text = dataGridView1.Rows[ir].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[ir].Cells[4].Value.ToString();
            checkedListBox1.Text = dataGridView1.Rows[ir].Cells[5].Value.ToString();
            lblarrivaltm.Text = dataGridView1.Rows[ir].Cells[6].Value.ToString();
            //lblcarno.Text = dataGridView1.Rows[ir].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & textdriver.Text != null & textcar.Text != null & textstime.Text != null & checkedListBox1.Text != null & comboBox1.Text != null)
                {


                    if (MessageBox.Show("Do you want to Edit Record!", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sno = textcar.Text;
                        var chk = db.tblArrivals.Where(o => o.Car_No == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tblArrivals.Where(o => o.ID == st).FirstOrDefault();
                            s.Driver_Name = textdriver.Text;
                            s.Car_No = textcar.Text;
                            s.Category = checkedListBox1.Text;
                            s.Stay_Time = textstime.Text;
                            s.Selected_Slot = comboBox1.Text;
                            s.A_Time = DateTime.Now;
                            db.SubmitChanges();
                            MessageBox.Show("Data Update!");
                            load();
                        }

                        else
                        {
                            MessageBox.Show("This Car No Already Added!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Record not selected... TRY AGAIN!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null)
                {


                    if (MessageBox.Show("Do you want to Delete Record!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int st = Convert.ToInt32(labelid.Text);
                        var s = db.tblArrivals.Where(o => o.ID == st).FirstOrDefault();
                        db.tblArrivals.DeleteOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Deleted!");
                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Record not selected... TRY AGAIN!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Arrival Report";
            p.SubTitle = string.Format("Date: {0}", DateTime.Now);
            p.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            p.printDocument = printDocument1;
            p.PageNumbers = true;

            p.PageNumberInHeader = true;

            p.PorportionalColumns = true;
            p.HeaderCellAlignment = StringAlignment.Near;
            p.Footer = "Car Parking System";
            p.FooterSpacing = 15;
            p.PrintDataGridView(dataGridView1);
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                load();
            }
            else
            {
                searchdata();
            }
        }

        public void searchdata()
        {

            try
            {
                if (textsearch.Text != null)
                {
                    string sk = textsearch.Text;
                    var chk = db.tblArrivals.Where(o => o.Driver_Name == sk || o.Car_No == sk || o.Category == sk ).ToList();
                    if (chk != null)
                    {
                        dataGridView1.DataSource = chk;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }
    }
}
