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
    public partial class BuscarDescripcion : Form
    {
        private DataSet ds;
        public BuscarDescripcion()
        {
            InitializeComponent();
        }

        private ModificarProyecto RefpForm = null;

        public void SetRefPersonal(ModificarProyecto pform)
        {
            RefpForm = pform;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\Sistemas.accdb");

                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Proyecto WHERE Nombre LIKE" + "'%" + txtDescripcion.Text + "%'", con);

                da.Fill(ds, "Proyecto");
                dataGridView1.DataSource = ds.Tables["proyecto"];
            }
            catch (Exception ex)
            {
            }
        }

        private void BuscarDescripcion_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
        }


        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                int Id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                String Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String descripcion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String elim = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                RefpForm.setProjectSearch(Name, descripcion);

                this.Dispose();
            }
            catch (Exception)
            {
                //Console.WriteLine(ex.ToString());
            }
        }
    }
}
