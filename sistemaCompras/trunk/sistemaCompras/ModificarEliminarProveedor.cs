using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaCompras
{
    public partial class ModificarEliminarProveedor : Form
    {
        private VentanaPrincipal ventanaPrincipal = null;
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
            
        }
    }
}
