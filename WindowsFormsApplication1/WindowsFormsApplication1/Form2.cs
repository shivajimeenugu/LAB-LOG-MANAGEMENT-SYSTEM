using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logdb1DataSet.logtable' table. You can move, or remove it, as needed.

                
                string dbpath = "//SYS1/";
                string strProvider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:/logdb1.accdb";
                string strSql = "Select * from logtable";
                OleDbConnection con = new OleDbConnection(strProvider);
                OleDbCommand cmd = new OleDbCommand(strSql, con);
                con.Open();
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable logtb = new DataTable();
                da.Fill(logtb);
                dataGridView1.DataSource = logtb;
            
            
             
            //this.logtableTableAdapter.Fill(this.logdb1DataSet.logtable);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Form2_Load(sender, e);


        }
    }
}
