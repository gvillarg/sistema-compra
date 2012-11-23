using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace sistemaCompras
{
    public partial class Form1 : Form
    {

        private DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\Sistemas.accdb");

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Proyecto", con);

                da.Fill(ds, "Proyecto");
                dataGridView1.DataSource = ds.Tables["proyecto"];
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }

        }





    }
}
