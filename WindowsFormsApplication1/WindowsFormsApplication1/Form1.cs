using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;
using System.Net;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data.Common;
using System.Configuration;





namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string update_pin_flag, update_time_flag,update_date_flag;
        string server = ConfigurationManager.AppSettings["host"];
        string database = ConfigurationManager.AppSettings["database_name"];
        string uid = ConfigurationManager.AppSettings["username"];
        string password = ConfigurationManager.AppSettings["password"];
        string port = ConfigurationManager.AppSettings["port"];

        
        
        public Form1()
        {
            InitializeComponent();

            //MessageBox.Show(server, "Done");
            




            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" + "PORT=" + port + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {

                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    con_sts_btn.Text = "Connected";
                    con_sts_btn.BackColor = Color.Green;
                    con_sts_btn.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {

                con_sts_btn.Text = "Not Connected";
                con_sts_btn.BackColor = Color.Red;
                con_sts_btn.ForeColor = Color.White;

            }

            logout_btn.Enabled = false;
            string computer_name = System.Windows.Forms.SystemInformation.ComputerName;
            string host_name = Dns.GetHostName();
            string ip = Dns.GetHostByName(host_name).AddressList[0].ToString();
            string dandt1 = DateTime.Now.ToString("yyy-MM-dd");
            string dandt2 = DateTime.Now.ToString("HH:mm:ss");

            date_and_time.Text = dandt1 + "---" + dandt2;
            pcname.Text = computer_name;
            ipnum.Text = ip;
            string std_name = name.Text;
            string std_pin = pin.Text;

                   

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
        public void add_log() { 
        
        }

        private void logme_Click(object sender, EventArgs e)
        {

            string computer_name = System.Windows.Forms.SystemInformation.ComputerName;
            string host_name = Dns.GetHostName();
            string ip = Dns.GetHostByName(host_name).AddressList[0].ToString();
            string std_name = name.Text;
            string std_pin = pin.Text;
            string lab_name = lab.Text;
            int per = int.Parse(periods.Text);
            int triger;
            string dandt1 = DateTime.Now.ToString("yyy-MM-dd");
            string dandt2 = DateTime.Now.ToString("HH:mm:ss");

            date_and_time.Text = dandt1+"---"+dandt2;
            //---------------------------------------------------//--------------------------
            
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                con_sts_btn.Text = "Connected";
                con_sts_btn.BackColor = Color.Green;
                con_sts_btn.ForeColor = Color.White;
                }
            }
            catch (Exception)
            {
                
                con_sts_btn.Text = "Not Connected";
                con_sts_btn.BackColor = Color.Red;
                con_sts_btn.ForeColor = Color.White;
                
            }
            //--------------------------------------------------------//-------------------------------

            
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "INSERT INTO lablog_table(student_name,student_pin,system_name,ip,reason,period_count,log_date,log_time)VALUES (@student_name,@student_pin,@system_name,@ip,@reason,@period_count,@log_date,@log_time)";
            cmd.Parameters.AddWithValue("@student_name",std_name);
            cmd.Parameters.AddWithValue("@student_pin",std_pin);
            cmd.Parameters.AddWithValue("@system_name", host_name);
            cmd.Parameters.AddWithValue("@ip", ip);
            cmd.Parameters.AddWithValue("@reason",lab_name);
            cmd.Parameters.AddWithValue("@period_count", per);
            cmd.Parameters.AddWithValue("@log_date", dandt1);
            cmd.Parameters.AddWithValue("@log_time", dandt2);
            triger=cmd.ExecuteNonQuery();
            //MessageBox.Show(triger.ToString(), "Done");
            if (triger > 0)
            {
                update_pin_flag = std_pin;
                update_time_flag = dandt2;
                update_date_flag = dandt1;
                MessageBox.Show("Record Submitted Sucessfully", "Done");
                this.WindowState = FormWindowState.Minimized;

                name.ReadOnly = true;
                pin.ReadOnly = true;
                lab.ReadOnly = true;
                periods.Enabled = false;
                logme.Enabled = false;
                logout_btn.Enabled = true;
                

            }
            }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void periods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    con_sts_btn.Text = "Connected";
                    con_sts_btn.BackColor = Color.Green;
                    con_sts_btn.ForeColor = Color.White;
                }
                else {
                    con_sts_btn.Text = "Not Connected";
                    con_sts_btn.BackColor = Color.Red;
                    con_sts_btn.ForeColor = Color.White;
                
                }
            }
            catch (Exception)
            {
                
                con_sts_btn.Text = "Not Connected";
                con_sts_btn.BackColor = Color.Red;
                con_sts_btn.ForeColor = Color.White;
                
            }
            
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            int triger_update;
            string date_end = DateTime.Now.ToString("yyy-MM-dd");
            string time_end = DateTime.Now.ToString("HH:mm:ss");
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE lablog_table SET end_date=@end_date,end_time=@end_time WHERE student_pin=@std_pin_t AND log_time=@log_t_t AND log_date=@log_d_t";
            //UPDATE lablog_table SET end_date=@end_date,end_time=@end_time WHERE student_pin=@std_pin_t AND log_time=@log_t_t AND log_date=@log_d_t
            cmd.Parameters.AddWithValue("@end_date", date_end);
            cmd.Parameters.AddWithValue("@end_time", time_end);
            cmd.Parameters.AddWithValue("@std_pin_t", update_pin_flag);
            cmd.Parameters.AddWithValue("@log_t_t", update_time_flag);
            cmd.Parameters.AddWithValue("@log_d_t", update_date_flag);
            triger_update = cmd.ExecuteNonQuery();
            if (triger_update > 0)
            {
                /////////////////////////////////////////////////////////////////////////////////////////
                System.Diagnostics.Process.Start("shutdown", "/l");/////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////
            }
        }
        
        
        

        }
    }

