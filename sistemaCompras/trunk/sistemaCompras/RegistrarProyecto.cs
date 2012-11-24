using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Validadores;
using Beans;
using System.Data.OleDb;
using Gestores;

namespace sistemaCompras
{
    public partial class RegistrarProyecto : Form
    {
        private DataSet ds;
        private Validador validador;
        private GestorProyecto gestorProyecto = GestorProyecto.Instancia();

        public RegistrarProyecto()
        {
            InitializeComponent();
            validador = new Validador(errorProvider1);
        }

        private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemas);
        }

        private void RegistrarProyecto_Load(object sender, EventArgs e)
        {
              ds = new DataSet();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\ComprasDB.accdb");
            Beans.Proyecto p = new Beans.Proyecto();               
                
                String nombre = txtNombre.Text;
                String descripcion = txtDescripcion.Text;
                DateTime fechaInicio = dtInicio.Value;
                DateTime fechaFin = dtFin.Value;

                //if (txtNombre.Text == "" || txtDescripcion.Text=="") MessageBox.Show("Rellenar todos los campos");
                
                //if(txtNombre.Text!="" && txtDescripcion.Text!=""){
                    p.setNombre(nombre);
                    p.setDescripcion(descripcion);
                  //  p.setFechaInicio(fechaInicio);
                    p.setFechaFin(fechaFin);
                
                gestorProyecto.agregarProyecto(p);
                MessageBox.Show("Proyecto Registrado");
                //}
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            //validador(txtNombre);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
