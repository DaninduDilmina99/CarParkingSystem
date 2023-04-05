using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingSystem1
{
    public partial class Reservation : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            var ld = db.tblDepartures.ToList();
            dataGridView1.DataSource = ld;
            display();

        }

        public void display()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lblamount.Text = sum.ToString();

            var slot = db.tblSlots.Count();
            labelcp.Text = slot.ToString();
            var pca = db.tblArrivals.Count();
            labelarrive.Text = pca.ToString();

            var pca1 = db.tblDepartures.Count();
            lbltotald.Text = pca1.ToString();
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            if (textsearch.Text == "")
            {
                load1();
            }
            else
            {
                
                var chk1 = db.tblDepartures.Where(s => s.Car_No == textsearch.Text || s.Driver == textsearch.Text || s.Type == textsearch.Text).ToList();
                if (chk1 != null)
                {
                    dataGridView1.DataSource = chk1;
                    display();
                }
            }
        }
        private void load1()
        {
            var ld = db.tblDepartures.ToList();
            dataGridView1.DataSource = ld;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter p = new DGVPrinter();
            p.printDocument = printDocument1;
            p.Title = "Report";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Invoice i = new Invoice();
            i.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            WelcomeScreen b = new WelcomeScreen();
            b.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Login et = new Login();
            et.Show();
            this.Hide();
        }
    }
}
