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
    public partial class SlotsForm : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public SlotsForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WelcomeScreen S = new WelcomeScreen();
            S.Show();
            this.Hide();
        }

        public void reset()
        {
            textsno.Text = "";
            textlocation.Text = "";
            labelid.Text = "";

        }
        public void load()
        {
            var lod = db.tblSlots.ToList();
            dataGridView1.DataSource = lod;

        }
       
        //Add Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textsno.Text != null & textlocation.Text != null)
                {
                    string sno = textsno.Text;
                    var chk = db.tblSlots.Where(o => o.Slot_No == sno).FirstOrDefault();
                    if (chk == null)
                    {
                        tblSlot s = new tblSlot();
                        s.Slot_No = textsno.Text;
                        s.Location = textlocation.Text;
                        db.tblSlots.InsertOnSubmit(s);
                        db.SubmitChanges();
                        MessageBox.Show("Data Inserted!");
                        reset();
                        load();
                    }
                    else
                    {
                        MessageBox.Show("This Slot No Already Added!");
                    }
                }
                else
                {
                    MessageBox.Show("Slot no or Location box empty... TRY AGAIN!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SlotsForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int ir = e.RowIndex;
            labelid.Text =  dataGridView1.Rows[ir].Cells[0].Value.ToString();
            textsno.Text = dataGridView1.Rows[ir].Cells[1].Value.ToString();
            textlocation.Text = dataGridView1.Rows[ir].Cells[2].Value.ToString();
        }


        //Edit Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null & textsno.Text != null & textlocation.Text != null)
                {


                    if (MessageBox.Show("Do you want to Edit Record!", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        string sno = textsno.Text;
                        var chk = db.tblSlots.Where(o => o.Slot_No == sno).FirstOrDefault();
                        if (chk == null)
                        {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tblSlots.Where(o=>o.ID==st).FirstOrDefault();
                            s.Slot_No = textsno.Text;
                            s.Location = textlocation.Text;
                            
                            db.SubmitChanges();
                            MessageBox.Show("Data Update!");
                            reset();
                            load();
                        }

                        else
                        {
                            MessageBox.Show("This Slot No Already Added!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Slot no or Location box empty... TRY AGAIN!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelid.Text != null )
                {


                    if (MessageBox.Show("Do you want to Delete Record!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                            int st = Convert.ToInt32(labelid.Text);
                            var s = db.tblSlots.Where(o => o.ID == st).FirstOrDefault();
                            db.tblSlots.DeleteOnSubmit(s);

                            db.SubmitChanges();
                            MessageBox.Show("Data Delete!");
                            reset();
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

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            if(textsearch.Text == "") 
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
                    var chk = db.tblSlots.Where(o => o.Slot_No == sk || o.Location == sk).ToList();
                    if(chk!= null)
                    {
                        dataGridView1.DataSource = chk;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");

            }
        }
    }
}
