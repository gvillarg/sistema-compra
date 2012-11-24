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
    public partial class Proyecto : Form
    {
        private ModificarEliminarProyecto RefpForm = null;

        public void SetRefPersonal(ModificarEliminarProyecto pform)
        {
            RefpForm = pform;
        }

        public Proyecto()
        {
            InitializeComponent();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void agregarCampos(string nombre, string descripcion)
        {
            txtNombre.Text = nombre;
            txtDescripcion.Text = descripcion;
        }





    }
}
