using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Beans;
using Gestores;

namespace sistemaCompras
{
    public partial class RegistrarProyecto : Form
    {
        private GestorProyecto gestorProyecto = GestorProyecto.Instancia();
        private int id=0;

        public RegistrarProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //int id = Int32.Parse(txtId.Text);

            id = id + 1;
            txtId.Text = "" + id;
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;

            Proyecto proy = new Proyecto();

            gestorProyecto.agregarProyecto(proy);

            GrilaProyecto.Rows.Add(""+id,txtNombre.Text,txtDescripcion.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
