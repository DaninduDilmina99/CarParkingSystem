namespace CarParkingSystem1
{
    partial class Login
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
            this.textemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonsignup = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CheckbxShowPas = new System.Windows.Forms.CheckBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.textpassword = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DimGray;
            label3.Location = new System.Drawing.Point(27, 127);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(74, 17);
            label3.TabIndex = 2;
            label3.Text = "Password: ";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textemail
            // 
            this.textemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textemail.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textemail.ForeColor = System.Drawing.Color.Gray;
            this.textemail.Location = new System.Drawing.Point(29, 88);
            this.textemail.Margin = new System.Windows.Forms.Padding(4);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(212, 33);
            this.textemail.TabIndex = 5;
            this.textemail.TextChanged += new System.EventHandler(this.textemail_TextChanged);
            this.textemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textemail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(27, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "User Name: ";
            // 
            // buttonlogin
            // 
            this.buttonlogin.AutoSize = true;
            this.buttonlogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonlogin.FlatAppearance.BorderSize = 0;
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonlogin.ForeColor = System.Drawing.Color.White;
            this.buttonlogin.Location = new System.Drawing.Point(29, 271);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(212, 33);
            this.buttonlogin.TabIndex = 6;
            this.buttonlogin.Text = "SIGN IN";
            this.buttonlogin.UseVisualStyleBackColor = false;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(78, 374);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create An Account";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // buttonsignup
            // 
            this.buttonsignup.AutoSize = true;
            this.buttonsignup.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonsignup.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsignup.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignup.ForeColor = System.Drawing.Color.White;
            this.buttonsignup.Location = new System.Drawing.Point(27, 393);
            this.buttonsignup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonsignup.Name = "buttonsignup";
            this.buttonsignup.Size = new System.Drawing.Size(212, 33);
            this.buttonsignup.TabIndex = 8;
            this.buttonsignup.Text = "SIGN UP";
            this.buttonsignup.UseVisualStyleBackColor = false;
            this.buttonsignup.Click += new System.EventHandler(this.buttonsignup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(233, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // CheckbxShowPas
            // 
            this.CheckbxShowPas.AutoSize = true;
            this.CheckbxShowPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckbxShowPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckbxShowPas.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckbxShowPas.ForeColor = System.Drawing.Color.DimGray;
            this.CheckbxShowPas.Location = new System.Drawing.Point(133, 188);
            this.CheckbxShowPas.Margin = new System.Windows.Forms.Padding(4);
            this.CheckbxShowPas.Name = "CheckbxShowPas";
            this.CheckbxShowPas.Size = new System.Drawing.Size(109, 19);
            this.CheckbxShowPas.TabIndex = 9;
            this.CheckbxShowPas.Text = "Show Password";
            this.CheckbxShowPas.UseVisualStyleBackColor = true;
            this.CheckbxShowPas.CheckedChanged += new System.EventHandler(this.CheckbxShowPas_CheckedChanged);
            // 
            // btnclear
            // 
            this.btnclear.AutoSize = true;
            this.btnclear.BackColor = System.Drawing.SystemColors.Window;
            this.btnclear.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnclear.Location = new System.Drawing.Point(29, 317);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(212, 33);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textpassword.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.ForeColor = System.Drawing.Color.Gray;
            this.textpassword.Location = new System.Drawing.Point(29, 150);
            this.textpassword.Margin = new System.Windows.Forms.Padding(4);
            this.textpassword.Multiline = true;
            this.textpassword.Name = "textpassword";
            this.textpassword.PasswordChar = '*';
            this.textpassword.Size = new System.Drawing.Size(212, 33);
            this.textpassword.TabIndex = 5;
            this.textpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textpassword_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(269, 452);
            this.Controls.Add(this.CheckbxShowPas);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.buttonsignup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonsignup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CheckbxShowPas;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox textpassword;
    }
}

