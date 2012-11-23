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
using Validadores;

namespace sistemaCompras
{
    public partial class RegistrarUsuarioDlg : Form
    {
        private Validador validador;
        private GestorUsuario gestorUsuario =  GestorUsuario.Instancia();
        private GestorTipoUsuario gestorTipoUsuario = GestorTipoUsuario.Instancia();
        List<TipoUsuario> listaTipoUsuario;

        public RegistrarUsuarioDlg()
        {
            InitializeComponent();
            listaTipoUsuario = gestorTipoUsuario.SeleccionarListaTipoUsuarios();
            llenarCmbTipoUsuario();
            cmbTipoUsuario.SelectedIndex = 2;
            validador = new Validador(errorProvider1);
        }

        private void llenarCmbTipoUsuario()
        {

            for (int i = 0; i < listaTipoUsuario.Count; i++)
                cmbTipoUsuario.Items.Add(listaTipoUsuario[i].getDescripcion());
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            bool error = validarDatos();
            //if (txtContrasena.Text.Equals(txtConfirmarContrasena.Text))
            if(!error)
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
                TipoUsuario tipoUsuario=listaTipoUsuario[cmbTipoUsuario.SelectedIndex];

                u.setDni(dni);
                u.setNombre(nombre);
                u.setDireccion(direccion);
                u.setFechaNacimiento(fechaNacimiento);
                u.setEmail(email);
                u.setTelefono(telefono);
                u.setSueldo(sueldo);
                u.setNombreUsuario(usuario);
                u.setContrasena(contrasena);
                u.setTipoUsuario(tipoUsuario);

                gestorUsuario.agregarUsuario(u);
                this.Close();
            }
            else
                MessageBox.Show("El usuario o la contraseña son incorrectos");
        }

        private bool validarDatos()
        {
            bool error;
            error = validador.validarEmail(txtEmail);


            return error;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            validador.validarNumeroEntero(txtDni);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            validador.validarNumeroEntero(txtTelefono);
        }

        
        

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {
            validador.validarNumeroReal(txtSueldo);
        }
  
        
    }
}
