using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//using System.Data;
using Gestores;

namespace sistemaCompras
{
    public partial class ModificarEliminarProveedor : Form
    {
        private GestorProveedor gestorProveedor = GestorProveedor.Instancia();        
        private VentanaPrincipal ventanaPrincipal = null;
        OleDbDataReader reader = null;
        public void referenciarVPrincipal(VentanaPrincipal vPrincipal)
        {
            ventanaPrincipal = vPrincipal;
        }

        public ModificarEliminarProveedor(string titulo)
        {
            InitializeComponent();
            Text = titulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntAceptar_Click(object sender, EventArgs e)
        {
            if (Text.Equals("Modificar Proveedor"))
            {
                ModificarProveedor modProveedor = new ModificarProveedor();
                modProveedor.ShowDialog(this);                
                modProveedor.referenciarVModElimProveedor(this);


            }
            else //Eliminar Proveedor
            {


            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //reader = gestorProveedor.filtrarProveedores(txtId.Text, txtRuc.Text, txtRazonSocial.Text);
            dgvProveedor.Rows.Clear();
            int fila = 0;
            while (reader.Read())
            {
                fila = dgvProveedor.Rows.Add();
                dgvProveedor.Rows[fila].Cells[0].Value = reader.GetInt32(0);
                dgvProveedor.Rows[fila].Cells[1].Value = reader.GetString(2);
                dgvProveedor.Rows[fila].Cells[2].Value = reader.GetInt32(1);
                dgvProveedor.Rows[fila].Cells[3].Value = reader.GetString(3);
                dgvProveedor.Rows[fila].Cells[4].Value = reader.GetString(4);                
            }
        }
    }
}
