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
        public UsuarioDlg()
        {
            InitializeComponent();
        }
        private void botonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioDlg ventana = new RegistrarUsuarioDlg();
            ventana.Show();
            GestorUsuario gestorUsuario= GestorUsuario.Instancia();
            lusuario = gestorUsuario.seleccionarUsuarios();
            String []fila;
            Usuario u;
            for (int i = 0; i < lusuario.Count; i++)
            {
                u=lusuario[i];
                fila = new String[] {""+u.getId(),u.getNombre(),u.getEmail(),
                    ""+u.getTelefono(),""+u.getSueldo(),u.getTipoUsuario().getDescripcion() };
                tablaUsuario.Rows.Add(fila);
            }
        }
    }
}
