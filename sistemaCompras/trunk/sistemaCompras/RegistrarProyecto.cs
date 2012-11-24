using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Validadores;
using System.Data.OleDb;

namespace sistemaCompras
{
    public partial class RegistrarProyecto : Form
    {
        private DataSet ds;
        private Validador validador;

        public RegistrarProyecto()
        {
            InitializeComponent();
            validador = new Validador(errorProvider1);
        }

        //private DataSet ds;

        private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemas);

        }

        private void RegistrarProyecto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemas.Proyecto' table. You can move, or remove it, as needed.
            //this.proyectoTableAdapter.Fill(this.sistemas.Proyecto);
             ds = new DataSet();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // =@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\Sistemas.accdb";
            if (txtNombre.Text != "" && txtDescripcion.Text != "")
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\Sistemas.accdb");

                if (txtDescripcion.Text != "")
                {
                    try
                    {
                        OleDbDataAdapter da = new OleDbDataAdapter("INSERT INTO Proyecto(Nombre,Descripcion)" + "'%" + txtNombre.Text + "%'", con);

                        da.Fill(ds, "Proyecto");
                        //dataGridView1.DataSource = ds.Tables["proyecto"];
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    MessageBox.Show("Proyecto Agregado");
                }
                else
                {
                    MessageBox.Show("Datos no validos");
                }
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            //validador(txtNombre);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
