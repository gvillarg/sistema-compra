using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaCompras
{
    public partial class ModificarProyecto : Form
    {
        public ModificarProyecto()
        {
            InitializeComponent();
        }

        //private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.proyectoBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.sistemas);

        //}

        private void ModificarProyecto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemas.Proyecto' table. You can move, or remove it, as needed.
            //this.proyectoTableAdapter.Fill(this.sistemas.Proyecto);

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
            BuscarCliente testDialog = new BuscarCliente();
            testDialog.SetRefPersonal(this);
            testDialog.ShowDialog(this);
        }

        public void setProjectSearch(string nombre, string descripcion)
        {
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
        }

        private void btnBuscarDescripcion_Click(object sender, EventArgs e)
        {
            BuscarDescripcion testDialog = new BuscarDescripcion();
            testDialog.SetRefPersonal(this);
            testDialog.ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;




        }

    }
}
