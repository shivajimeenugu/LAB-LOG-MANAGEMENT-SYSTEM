namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.date_and_time = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.con_sts_btn = new System.Windows.Forms.Button();
            this.periods = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.TextBox();
            this.ipnum = new System.Windows.Forms.Label();
            this.pcname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.logme = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 169);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(224, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(877, 43);
            this.label5.TabIndex = 2;
            this.label5.Text = "LAB LOG FORM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(231, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(877, 88);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dr Yc James Yen Govt Polytechnic,Kuppam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.date_and_time);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.con_sts_btn);
            this.panel2.Controls.Add(this.periods);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.ipnum);
            this.panel2.Controls.Add(this.pcname);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logme);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.name);
            this.panel2.Location = new System.Drawing.Point(19, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 480);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(747, 352);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(131, 35);
            this.logout_btn.TabIndex = 19;
            this.logout_btn.Text = "LOG OUT";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // date_and_time
            // 
            this.date_and_time.AutoSize = true;
            this.date_and_time.BackColor = System.Drawing.Color.Transparent;
            this.date_and_time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_and_time.ForeColor = System.Drawing.Color.Red;
            this.date_and_time.Location = new System.Drawing.Point(503, 63);
            this.date_and_time.Name = "date_and_time";
            this.date_and_time.Size = new System.Drawing.Size(17, 17);
            this.date_and_time.TabIndex = 18;
            this.date_and_time.Text = "0";
            this.date_and_time.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(391, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "DATE & TIME";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // con_sts_btn
            // 
            this.con_sts_btn.BackColor = System.Drawing.Color.Red;
            this.con_sts_btn.ForeColor = System.Drawing.Color.White;
            this.con_sts_btn.Location = new System.Drawing.Point(957, 3);
            this.con_sts_btn.Name = "con_sts_btn";
            this.con_sts_btn.Size = new System.Drawing.Size(165, 34);
            this.con_sts_btn.TabIndex = 16;
            this.con_sts_btn.Text = "connection status";
            this.con_sts_btn.UseVisualStyleBackColor = false;
            this.con_sts_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // periods
            // 
            this.periods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periods.FormattingEnabled = true;
            this.periods.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.periods.Location = new System.Drawing.Point(505, 290);
            this.periods.Name = "periods";
            this.periods.Size = new System.Drawing.Size(373, 24);
            this.periods.TabIndex = 14;
            this.periods.SelectedIndexChanged += new System.EventHandler(this.periods_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(244, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "NO OF PERIODS:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(365, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 28);
            this.label10.TabIndex = 11;
            this.label10.Text = "LAB:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(505, 249);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(373, 22);
            this.lab.TabIndex = 10;
            this.lab.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // ipnum
            // 
            this.ipnum.AutoSize = true;
            this.ipnum.BackColor = System.Drawing.Color.Transparent;
            this.ipnum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipnum.ForeColor = System.Drawing.Color.Red;
            this.ipnum.Location = new System.Drawing.Point(502, 132);
            this.ipnum.Name = "ipnum";
            this.ipnum.Size = new System.Drawing.Size(32, 17);
            this.ipnum.TabIndex = 9;
            this.ipnum.Text = "IP1";
            // 
            // pcname
            // 
            this.pcname.AutoSize = true;
            this.pcname.BackColor = System.Drawing.Color.Transparent;
            this.pcname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcname.ForeColor = System.Drawing.Color.Red;
            this.pcname.Location = new System.Drawing.Point(502, 100);
            this.pcname.Name = "pcname";
            this.pcname.Size = new System.Drawing.Size(61, 17);
            this.pcname.TabIndex = 8;
            this.pcname.Text = "NAME1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "IP:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = " PC NAME:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(3, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1120, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "©SHIVAJI MEENUGU  17101-CM-210";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // logme
            // 
            this.logme.Location = new System.Drawing.Point(506, 352);
            this.logme.Name = "logme";
            this.logme.Size = new System.Drawing.Size(131, 35);
            this.logme.TabIndex = 4;
            this.logme.Text = "LOG ME";
            this.logme.UseVisualStyleBackColor = true;
            this.logme.Click += new System.EventHandler(this.logme_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(390, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "PIN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(505, 205);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(373, 22);
            this.pin.TabIndex = 2;
            this.pin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(390, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(505, 164);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(373, 22);
            this.name.TabIndex = 0;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LAB LOG FORM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox periods;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox lab;
        private System.Windows.Forms.Label ipnum;
        private System.Windows.Forms.Label pcname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button logme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button con_sts_btn;
        private System.Windows.Forms.Label date_and_time;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button logout_btn;
    }
}

