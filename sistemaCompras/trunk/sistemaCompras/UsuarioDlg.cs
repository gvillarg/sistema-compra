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
    public partial class UsuarioDlg : Form
    {
        private GestorUsuario gestorUsuario = GestorUsuario.Instancia();
        List<Usuario> listaUsuario;
        private GestorTipoUsuario gestorTipoUsuario = GestorTipoUsuario.Instancia();
        List<TipoUsuario> listaTipoUsuario;
        private Usuario seleccionado = null;
        private int modo;
        public UsuarioDlg(int modo)
        {
            listaTipoUsuario = gestorTipoUsuario.SeleccionarListaTipoUsuarios();
            InitializeComponent();
            seleccionarUsuarios();
            actualizarTabla();
            llenarCmbTipoUsuario();
            
            this.modo = modo;
            if (modo == 0)
                this.Text = "Modificar Usuario";
            else
                this.Text = "Eliminar Usuario";
        }
        public void seleccionarUsuarios()
        {
            listaUsuario = gestorUsuario.seleccionarUsuarios();
        }
        public void filtrarUsuarios()
        {
            String nombre = "%";
            if (txtNombre.TextLength > 0)
                nombre = "%" + txtNombre.Text + "%";

            TipoUsuario tipo = null;
            if (cmbTipo.SelectedIndex != 0)
                tipo = gestorTipoUsuario.SeleccionarListaTipoUsuarios()[cmbTipo.SelectedIndex-1];
            listaUsuario=gestorUsuario.filtrarUsuarios(nombre, tipo, cbMostrarEliminados.Checked);
        }
        public void actualizarTabla()
        {
            while(tablaUsuario.Rows.Count>0)
                tablaUsuario.Rows.RemoveAt(0);
            String[] fila;
            Usuario u;
            for (int i = 0; i < listaUsuario.Count; i++)
            {
                u = listaUsuario[i];
                fila = new String[] {""+u.getId(),u.getNombre(),u.getEmail(),
                    ""+u.getTelefono(),""+u.getSueldo(),u.getTipoUsuario().getDescripcion() };
                tablaUsuario.Rows.Add(fila);
            }
        }
        private void llenarCmbTipoUsuario()
        {
            cmbTipo.Items.Add("Seleccionar Todos");
            for (int i = 0; i < listaTipoUsuario.Count; i++)
                cmbTipo.Items.Add(listaTipoUsuario[i].getDescripcion());
            cmbTipo.SelectedIndex=0;
        }
        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listaUsuario.Count)
            {
                seleccionado = listaUsuario[e.RowIndex];
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtrarUsuarios();
            actualizarTabla();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            if (modo == 0)
            {

                if (seleccionado != null)
                {
                    ModificarUsuarioDlg ventana = new ModificarUsuarioDlg(this, seleccionado);
                    ventana.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione un Usuario");
                }
            }
            else
            {
                if (seleccionado != null)
                {
                    if (MessageBox.Show("Está seguro que desea eliminar el Usuario?\n",
                        "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (gestorUsuario.eliminarUsuario(seleccionado))
                        {
                            MessageBox.Show("Usuario Eliminado");
                            actualizarTabla();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Usuario");
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
