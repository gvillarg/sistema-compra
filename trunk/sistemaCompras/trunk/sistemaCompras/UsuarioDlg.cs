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
        private GestorUsuario gestorUsuario;
        private Usuario seleccionado = null;
        public UsuarioDlg()
        {
            InitializeComponent();
            actualizarTabla();
        }
        public void actualizarTabla()
        {
            while(tablaUsuario.Rows.Count>0)
                tablaUsuario.Rows.RemoveAt(0);

            gestorUsuario = GestorUsuario.Instancia();
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
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioDlg ventana = new RegistrarUsuarioDlg(this);
            ventana.Show();          
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                if (MessageBox.Show("Está seguro que desea eliminar el Usuario?\n",
                    "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gestorUsuario.eliminarUsuario(seleccionado);
                    actualizarTabla();
                }
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                ModificarUsuarioDlg ventana = new ModificarUsuarioDlg(this,seleccionado);
                ventana.Show();
            }
        }



        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < lusuario.Count)
            {
                seleccionado = lusuario[e.RowIndex];
            }
        }
    }
}
