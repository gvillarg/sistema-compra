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
    public partial class RegistrarUsuarioDlg : Form
    {
        private GestorUsuario gestorUsuario =  GestorUsuario.Instancia();
        private UsuarioDlg padre;
        public RegistrarUsuarioDlg(UsuarioDlg padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(txtConfirmarContrasena.Text))
            {
                Usuario u = new Usuario();
                int dni = int.Parse(txtDni.Text);
                String nombre = txtNombre.Text;
                String direccion = txtDireccion.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                String email = txtEmail.Text;
                int telefono = int.Parse(txtTelefono.Text);
                float sueldo = float.Parse(txtSueldo.Text);
                String usuario = txtUsuario.Text;
                String contrasena = txtContrasena.Text;

                u.setDni(dni);
                u.setNombre(nombre);
                u.setDireccion(direccion);
                u.setFechaNacimiento(fechaNacimiento);
                u.setEmail(email);
                u.setTelefono(telefono);
                u.setSueldo(sueldo);
                u.setNombreUsuario(usuario);
                u.setContrasena(contrasena);

                gestorUsuario.agregarUsuario(u);
                padre.actualizarTabla();
                this.Close();
            }
            else
                MessageBox.Show("La contraseña no concuerda");
        }
    }
}
