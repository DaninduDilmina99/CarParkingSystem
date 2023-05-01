using DGVPrinterHelper;
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indexrow = e.RowIndex;
            labelid1.Text = dataGridView1.Rows[indexrow].Cells[0].Value.ToString();
            lbldtime.Text = dataGridView1.Rows[indexrow].Cells[6].Value.ToString();
            lblpfee.Text = dataGridView1.Rows[indexrow].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & labeldname.Text != null & labelptime.Text != null & labelptime.Text != null)
                {


                    if (MessageBox.Show("Do you want to Edit Record!", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        int st = Convert.ToInt32(labelid1.Text);
                        var s = db.tblDepartures.Where(o => o.ID == st).FirstOrDefault();
                        s.Car_No = comboBoxcarno.Text;
                        s.Driver = labeldname.Text;
                        s.Type = labelptype.Text; 
                        s.P_Time = labelptime.Text;

                        decimal str = Convert.ToDecimal(labelptime.Text);
                        decimal amt = Convert.ToDecimal(textpamount.Text);
                        decimal amttotal = str * amt;
                        s.Amount = amttotal;
                        s.Departure_Time = DateTime.Now;
                        db.SubmitChanges();
                        MessageBox.Show("Data Update!");
                        load();
                    }
                }
                else
                {
                    MessageBox.Show("Record not Selected... TRY AGAIN!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Amount not Entered! Try Again!!");
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
                        int st = Convert.ToInt32(labelid1.Text);
                        var s = db.tblDepartures.Where(o => o.ID == st).FirstOrDefault();
                        db.tblDepartures.DeleteOnSubmit(s);
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
            p.Title = "Departure Report";
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
                load1();
            }
            else
            {
                //searchdata();
                // car_ no == combomoxcarno.Text da enne kiyala balann
                var chk1 = db.tblDepartures.Where(s => s.Car_No == textsearch.Text || s.Driver == textsearch.Text || s.Type == textsearch.Text).ToList();
                if (chk1 != null)
                {
                    dataGridView1.DataSource = chk1;
                }
            }
        }
        private void load1()
        {
            var ld = db.tblDepartures.ToList();
            dataGridView1.DataSource = ld;
        }
    }
}
