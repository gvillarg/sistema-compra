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
        private List<Usuario> lusuario;
        private GestorUsuario gestorUsuario=GestorUsuario.Instancia();
        private Usuario seleccionado = null;
        private int modo;
        public UsuarioDlg(int modo)
        {
            InitializeComponent();
            actualizarTabla();
            this.modo = modo;
            if (modo == 0)
                this.Text = "Modificar Usuario";
            else
                this.Text = "Eliminar Usuario";
        }
        public void actualizarTabla()
        {
            while(tablaUsuario.Rows.Count>0)
                tablaUsuario.Rows.RemoveAt(0);

            lusuario = gestorUsuario.seleccionarUsuarios();
            String[] fila;
            Usuario u;
            for (int i = 0; i < lusuario.Count; i++)
            {
                u = lusuario[i];
                fila = new String[] {""+u.getId(),u.getNombre(),u.getEmail(),
                    ""+u.getTelefono(),""+u.getSueldo(),u.getTipoUsuario().getDescripcion() };
                tablaUsuario.Rows.Add(fila);
            }
        }




        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < lusuario.Count)
            {
                seleccionado = lusuario[e.RowIndex];
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
              //  gestorUsuario.filtrarUsuario(txtNombre.Text, lusuario[cmbTipo.SelectedIndex],cbMostrarEliminados.Checked);

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
