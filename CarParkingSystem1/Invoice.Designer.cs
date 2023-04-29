namespace CarParkingSystem1
{
    partial class Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.labelentrytime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelamount = new System.Windows.Forms.Label();
            this.labeldtime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labeltype = new System.Windows.Forms.Label();
            this.labelcarno = new System.Windows.Forms.Label();
            this.labeldname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxcarno = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(48, 102);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 18);
            label3.TabIndex = 8;
            label3.Text = "Parked Time:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(285, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(63, 20);
            label1.TabIndex = 8;
            label1.Text = "Search: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label6.Location = new System.Drawing.Point(686, 102);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(69, 18);
            label6.TabIndex = 8;
            label6.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label4.Location = new System.Drawing.Point(49, 95);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(108, 18);
            label4.TabIndex = 15;
            label4.Text = "Driver Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(360, 95);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(64, 18);
            label5.TabIndex = 17;
            label5.Text = "Car No:";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label8.Location = new System.Drawing.Point(681, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(49, 18);
            label8.TabIndex = 17;
            label8.Text = "Type:";
            label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.Transparent;
            label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label9.Location = new System.Drawing.Point(320, 102);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(129, 18);
            label9.TabIndex = 8;
            label9.Text = "Departure Time:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(252, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "CAR PARKING RECEIPT";
            // 
            // labelentrytime
            // 
            this.labelentrytime.AutoSize = true;
            this.labelentrytime.BackColor = System.Drawing.Color.Transparent;
            this.labelentrytime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelentrytime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelentrytime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelentrytime.Location = new System.Drawing.Point(162, 102);
            this.labelentrytime.Name = "labelentrytime";
            this.labelentrytime.Size = new System.Drawing.Size(53, 18);
            this.labelentrytime.TabIndex = 8;
            this.labelentrytime.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(label6);
            this.panel1.Controls.Add(this.labelamount);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(this.labeldtime);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.labelentrytime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 268);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(780, 223);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(87, 35);
            this.exit.TabIndex = 12;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(8, 223);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 35);
            this.back.TabIndex = 13;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 82);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.BackColor = System.Drawing.Color.Transparent;
            this.labelamount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelamount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelamount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelamount.Location = new System.Drawing.Point(761, 102);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(81, 18);
            this.labelamount.TabIndex = 8;
            this.labelamount.Text = "Rs. 00.00";
            // 
            // labeldtime
            // 
            this.labeldtime.AutoSize = true;
            this.labeldtime.BackColor = System.Drawing.Color.Transparent;
            this.labeldtime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labeldtime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeldtime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldtime.Location = new System.Drawing.Point(455, 102);
            this.labeldtime.Name = "labeldtime";
            this.labeldtime.Size = new System.Drawing.Size(53, 18);
            this.labeldtime.TabIndex = 8;
            this.labeldtime.Text = "00:00";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 411);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(label8);
            this.panel2.Controls.Add(this.labeltype);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(this.labelcarno);
            this.panel2.Controls.Add(label4);
            this.panel2.Controls.Add(this.labeldname);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBoxcarno);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 131);
            this.panel2.TabIndex = 1;
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.BackColor = System.Drawing.Color.Transparent;
            this.labeltype.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labeltype.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeltype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeltype.Location = new System.Drawing.Point(736, 95);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(106, 18);
            this.labeltype.TabIndex = 18;
            this.labeltype.Text = "Hourly/Daily";
            // 
            // labelcarno
            // 
            this.labelcarno.AutoSize = true;
            this.labelcarno.BackColor = System.Drawing.Color.Transparent;
            this.labelcarno.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelcarno.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelcarno.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelcarno.Location = new System.Drawing.Point(430, 95);
            this.labelcarno.Name = "labelcarno";
            this.labelcarno.Size = new System.Drawing.Size(84, 18);
            this.labelcarno.TabIndex = 18;
            this.labelcarno.Text = "XXX-0000";
            // 
            // labeldname
            // 
            this.labeldname.AutoSize = true;
            this.labeldname.BackColor = System.Drawing.Color.Transparent;
            this.labeldname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labeldname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labeldname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labeldname.Location = new System.Drawing.Point(163, 95);
            this.labeldname.Name = "labeldname";
            this.labeldname.Size = new System.Drawing.Size(53, 18);
            this.labeldname.TabIndex = 16;
            this.labeldname.Text = "00:00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(490, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxcarno
            // 
            this.comboBoxcarno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.comboBoxcarno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxcarno.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.comboBoxcarno.FormattingEnabled = true;
            this.comboBoxcarno.Location = new System.Drawing.Point(354, 13);
            this.comboBoxcarno.Name = "comboBoxcarno";
            this.comboBoxcarno.Size = new System.Drawing.Size(121, 23);
            this.comboBoxcarno.TabIndex = 13;
            this.comboBoxcarno.SelectedIndexChanged += new System.EventHandler(this.comboBoxcarno_SelectedIndexChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelentrytime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.ComboBox comboBoxcarno;
        private System.Windows.Forms.Label labelcarno;
        private System.Windows.Forms.Label labeldname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.Label labeldtime;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button back;
    }
}