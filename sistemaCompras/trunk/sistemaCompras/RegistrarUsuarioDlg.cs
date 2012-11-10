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
        public RegistrarUsuarioDlg()
        {
            InitializeComponent();
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
                String dni = txtDni.Text;
                String nombre = txtNombre.Text;
                String direccion = txtDireccion.Text;
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                String email = txtEmail.Text;
                int telefono = int.Parse(mtxtTelefono.Text);
                float Sueldo = float.Parse(txtSueldo.Text);
                String usuario = txtUsuario.Text;
            }
            else
                MessageBox.Show("La contraseña no concuerda");
        }
    }
}
