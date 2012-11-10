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
    public partial class ModificarUsuarioDlg : Form
    {
        private Usuario usuario;
        private GestorUsuario gestorUsuario = GestorUsuario.Instancia();
        private UsuarioDlg padre;
        public ModificarUsuarioDlg(UsuarioDlg padre,Usuario usuario)
        {
            InitializeComponent();
            this.padre = padre;
            this.usuario = usuario;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals(txtConfirmarContrasena.Text))
            {
                int dni = int.Parse(txtDni.Text);
                String nombre = txtNombre.Text;
                String direccion = txtDireccion.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                String email = txtEmail.Text;
                int telefono = int.Parse(txtTelefono.Text);
                float sueldo = float.Parse(txtSueldo.Text);
                String nombreUsuario = txtUsuario.Text;
                String contrasena = txtContrasena.Text;

                usuario.setDni(dni);
                usuario.setNombre(nombre);
                usuario.setDireccion(direccion);
                usuario.setFechaNacimiento(fechaNacimiento);
                usuario.setEmail(email);
                usuario.setTelefono(telefono);
                usuario.setSueldo(sueldo);
                usuario.setNombreUsuario(nombreUsuario);
                usuario.setContrasena(contrasena);

                gestorUsuario.modificarUsuario(usuario);
                this.Close();
            }
            else
                MessageBox.Show("La contraseña no concuerda");
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
