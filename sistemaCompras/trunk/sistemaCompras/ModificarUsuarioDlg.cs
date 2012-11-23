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
    public partial class ModificarUsuarioDlg : Form
    {
        private Usuario usuario;
        private Validador validador;
        private GestorUsuario gestorUsuario = GestorUsuario.Instancia();
        List<TipoUsuario> listaTipoUsuario;
        private UsuarioDlg padre;
        public ModificarUsuarioDlg(UsuarioDlg padre, Usuario usuario)
        {
            InitializeComponent();
            this.padre = padre;
            this.usuario = usuario;
            listaTipoUsuario = GestorTipoUsuario.Instancia().SeleccionarListaTipoUsuarios();
            llenarCmbTipoUsuario();
            llenarCampos();
            validador = new Validador(errorProvider);
        }

        private void llenarCampos()
        {
            txtId.Text = usuario.getId().ToString();
            txtDni.Text = usuario.getDni().ToString();
            txtNombre.Text = usuario.getNombre();
            txtDireccion.Text = usuario.getDireccion();
            dtpFechaNacimiento.Value = usuario.getFechaNacimiento();
            dtpFechaIngreso.Value = usuario.getFechaIngreso();
            txtEmail.Text = usuario.getEmail();
            txtTelefono.Text = usuario.getTelefono().ToString();
            txtSueldo.Text = usuario.getSueldo().ToString();
            txtUsuario.Text = usuario.getNombreUsuario();
            txtContrasena.Text = usuario.getContrasena();
            txtConfirmarContrasena.Text = usuario.getContrasena();
            cmbTipoUsuario.SelectedIndex = usuario.getTipoUsuario().getId() - 1;
        }
        private void llenarCmbTipoUsuario()
        {

            for (int i = 0; i < listaTipoUsuario.Count; i++)
                cmbTipoUsuario.Items.Add(listaTipoUsuario[i].getDescripcion());
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            error = error || validador.validarNumeroEntero(txtDni);
            error = error || validador.validarNumeroEntero(txtTelefono)||validador.validarNumeroReal(txtSueldo);
            error = error || validador.validarEmail(txtEmail)||validador.validarContrasena(txtConfirmarContrasena,txtContrasena);

            
            if (!error)
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
                TipoUsuario tipoUsuario = listaTipoUsuario[cmbTipoUsuario.SelectedIndex];

                usuario.setDni(dni);
                usuario.setNombre(nombre);
                usuario.setDireccion(direccion);
                usuario.setFechaNacimiento(fechaNacimiento);
                usuario.setEmail(email);
                usuario.setTelefono(telefono);
                usuario.setSueldo(sueldo);
                usuario.setNombreUsuario(nombreUsuario);
                usuario.setContrasena(contrasena);
                usuario.setTipoUsuario(tipoUsuario);



                if (gestorUsuario.modificarUsuario(usuario))
                {
                    padre.actualizarTabla();
                    MessageBox.Show("UsuarioModificado");
                    this.Close();
                }
                else
                    MessageBox.Show("Ha ocurrido un error");
            }
            else
                MessageBox.Show("Los datos no son correctos");
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
