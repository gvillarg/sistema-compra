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
    public partial class ModificarEliminarProyecto : Form
    {
        private DataSet ds;

        public ModificarEliminarProyecto(string titulo)
        {
            InitializeComponent();
            Text = titulo;
        }

        private void ModificarProyecto_Load(object sender, EventArgs e)
        {
            ds = new DataSet();   
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proyectoTableAdapter.FillBy2(this.sistemas.Proyecto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.proyectoTableAdapter.FillBy2(this.sistemas.Proyecto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BuscarCliente testDialog = new BuscarCliente();
            //testDialog.SetRefPersonal(this);
            //testDialog.ShowDialog(this);
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\Sistemas.accdb");
            
            if(txtDescripcion.Text==""){
                try
                {
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Proyecto WHERE Nombre LIKE" + "'%" + txtNombre.Text + "%'", con);

                    da.Fill(ds, "Proyecto");
                    dataGridView1.DataSource = ds.Tables["proyecto"];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            if (txtNombre.Text == "")
            {
                try
                {              
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Proyecto WHERE Nombre LIKE" + "'%" + txtDescripcion.Text + "%'", con);

                    da.Fill(ds, "Proyecto");
                    dataGridView1.DataSource = ds.Tables["proyecto"];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        public void setProjectSearch(string nombre, string descripcion)
        {
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
        }

        private void btnBuscarDescripcion_Click(object sender, EventArgs e)
        {
            //BuscarDescripcion testDialog = new BuscarDescripcion();
            //testDialog.SetRefPersonal(this);
            //testDialog.ShowDialog(this);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //int Id = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            if (Text.Equals("Modificar Proyecto"))
            {
                String Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String lastname = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                Proyecto proy = new Proyecto();
                proy.SetRefPersonal(this);

                proy.agregarCampos(Name, lastname);
                proy.ShowDialog(this);
            }
            else { 
             //solo cambia campo        
                        
            }
  
        }        
    }
}
