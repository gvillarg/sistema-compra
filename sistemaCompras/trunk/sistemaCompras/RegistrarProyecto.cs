﻿using System;
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
        private List<Proyecto> lproyecto;

        public RegistrarProyecto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtId.Text);
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;

            Proyecto proy = new Proyecto();
            proy.setId(id);
            proy.setNombre(nombre);
            proy.setDescripcion(descripcion);

            gestorProyecto.agregarProyecto(proy);

            GrillaProyecto.Rows.Add(txtId.Text,txtNombre.Text,txtDescripcion.Text);
            //actualizarGrilla();
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
