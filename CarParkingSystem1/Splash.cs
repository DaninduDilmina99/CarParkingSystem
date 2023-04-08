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
    public partial class Splash : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public Splash()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 279)
            {
                timer1.Stop();
                WelcomeScreen wc = new WelcomeScreen();
                wc.Show();
                this.Hide();
            }
            

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            //timer1.Start();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
