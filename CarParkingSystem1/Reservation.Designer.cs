namespace CarParkingSystem1
{
    partial class Reservation
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
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.lbltotald = new System.Windows.Forms.Label();
            this.lbldtime = new System.Windows.Forms.Label();
            this.lblamount = new System.Windows.Forms.Label();
            this.labelid1 = new System.Windows.Forms.Label();
            this.labelin = new System.Windows.Forms.Label();
            this.labelarrive = new System.Windows.Forms.Label();
            this.labelcp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label7.Location = new System.Drawing.Point(545, 50);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(144, 18);
            label7.TabIndex = 8;
            label7.Text = "Total Departured: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label5.Location = new System.Drawing.Point(709, 50);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 18);
            label5.TabIndex = 8;
            label5.Text = "Departured Amount: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label1.Location = new System.Drawing.Point(7, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 18);
            label1.TabIndex = 8;
            label1.Text = "Search: ";
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.91358F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.08642F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 411);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 295);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 293);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textsearch);
            this.panel2.Controls.Add(this.labelcp);
            this.panel2.Controls.Add(this.labelarrive);
            this.panel2.Controls.Add(this.lbltotald);
            this.panel2.Controls.Add(this.lbldtime);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(this.labelin);
            this.panel2.Controls.Add(this.lblamount);
            this.panel2.Controls.Add(label7);
            this.panel2.Controls.Add(this.labelid1);
            this.panel2.Controls.Add(label5);
            this.panel2.Controls.Add(label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(878, 104);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(334, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "RESERVATION BILL";
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(10, 66);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(120, 20);
            this.textsearch.TabIndex = 9;
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // lbltotald
            // 
            this.lbltotald.AutoSize = true;
            this.lbltotald.BackColor = System.Drawing.Color.Transparent;
            this.lbltotald.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbltotald.ForeColor = System.Drawing.Color.Black;
            this.lbltotald.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbltotald.Location = new System.Drawing.Point(545, 70);
            this.lbltotald.Name = "lbltotald";
            this.lbltotald.Size = new System.Drawing.Size(18, 18);
            this.lbltotald.TabIndex = 8;
            this.lbltotald.Text = "0";
            // 
            // lbldtime
            // 
            this.lbldtime.AutoSize = true;
            this.lbldtime.BackColor = System.Drawing.Color.Transparent;
            this.lbldtime.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbldtime.ForeColor = System.Drawing.Color.Black;
            this.lbldtime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbldtime.Location = new System.Drawing.Point(709, 68);
            this.lbldtime.Name = "lbldtime";
            this.lbldtime.Size = new System.Drawing.Size(32, 18);
            this.lbldtime.TabIndex = 8;
            this.lbldtime.Text = "Rs.";
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.Color.Transparent;
            this.lblamount.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblamount.ForeColor = System.Drawing.Color.Black;
            this.lblamount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblamount.Location = new System.Drawing.Point(758, 68);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(22, 18);
            this.lblamount.TabIndex = 8;
            this.lblamount.Text = "0 ";
            this.lblamount.UseWaitCursor = true;
            // 
            // labelid1
            // 
            this.labelid1.AutoSize = true;
            this.labelid1.BackColor = System.Drawing.Color.Transparent;
            this.labelid1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelid1.ForeColor = System.Drawing.Color.Black;
            this.labelid1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelid1.Location = new System.Drawing.Point(6, 22);
            this.labelid1.Name = "labelid1";
            this.labelid1.Size = new System.Drawing.Size(34, 19);
            this.labelid1.TabIndex = 6;
            this.labelid1.Text = "ID:";
            // 
            // labelin
            // 
            this.labelin.AutoSize = true;
            this.labelin.BackColor = System.Drawing.Color.Transparent;
            this.labelin.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelin.ForeColor = System.Drawing.Color.Black;
            this.labelin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelin.Location = new System.Drawing.Point(444, 50);
            this.labelin.Name = "labelin";
            this.labelin.Size = new System.Drawing.Size(71, 18);
            this.labelin.TabIndex = 8;
            this.labelin.Text = "Total In:";
            // 
            // labelarrive
            // 
            this.labelarrive.AutoSize = true;
            this.labelarrive.BackColor = System.Drawing.Color.Transparent;
            this.labelarrive.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelarrive.ForeColor = System.Drawing.Color.Black;
            this.labelarrive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelarrive.Location = new System.Drawing.Point(444, 68);
            this.labelarrive.Name = "labelarrive";
            this.labelarrive.Size = new System.Drawing.Size(18, 18);
            this.labelarrive.TabIndex = 8;
            this.labelarrive.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            label3.Location = new System.Drawing.Point(337, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(78, 18);
            label3.TabIndex = 8;
            label3.Text = "Capacity:";
            // 
            // labelcp
            // 
            this.labelcp.AutoSize = true;
            this.labelcp.BackColor = System.Drawing.Color.Transparent;
            this.labelcp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            this.labelcp.ForeColor = System.Drawing.Color.Black;
            this.labelcp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelcp.Location = new System.Drawing.Point(337, 68);
            this.labelcp.Name = "labelcp";
            this.labelcp.Size = new System.Drawing.Size(18, 18);
            this.labelcp.TabIndex = 8;
            this.labelcp.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(136, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrchid;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(229, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Print List";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Label lbldtime;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Label labelid1;
        private System.Windows.Forms.Label lbltotald;
        private System.Windows.Forms.Label labelcp;
        private System.Windows.Forms.Label labelarrive;
        private System.Windows.Forms.Label labelin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}