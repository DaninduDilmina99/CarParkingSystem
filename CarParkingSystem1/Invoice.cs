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
    public partial class Invoice : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Invoice()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            comboBoxcarno.DataSource = db.tblDepartures.ToList();
            comboBoxcarno.ValueMember = "Car_No";
            comboBoxcarno.DisplayMember = "Car_no";
        }

        private void comboBoxcarno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                tblDeparture obj = comboBoxcarno.SelectedItem as tblDeparture;
                if (obj != null)
                {
                    labeldname.Text = obj.Driver.ToString();
                    labeltype.Text = obj.Type.ToString();
                    labelentrytime.Text = obj.P_Time.ToString();
                    labelamount.Text = obj.Amount.ToString();
                    labelcarno.Text = obj.Car_No.ToString();
                    labeldtime.Text = obj.Departure_Time.ToString();

                }
                Cursor.Current = Cursors.Default;
                var chk1 = db.tblDepartures.Where(s => s.Car_No == comboBoxcarno.Text || s.Driver == comboBoxcarno.Text);
                if (chk1 != null)
                {
                    dataGridView1.DataSource = chk1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics myg = this.CreateGraphics();
                bitmap = new Bitmap(this.Width, this.Size.Height, myg);
                Graphics mg = Graphics.FromImage(bitmap);
                mg.CopyFromScreen(this.Location.X, Location.Y, 0, 0, this.Size);
                printPreviewDialog1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!");

            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Reservation S = new Reservation();
            S.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Login S = new Login();
            S.Show();
            this.Hide();
        }
    }
}
