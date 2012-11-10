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
    public partial class RegistrarProveedor : Form
    {
        private GestorProveedor gestorUsuario = GestorProveedor.Instancia();
        private VentanaPrincipal ventanaPrincipal = null;
        public void referenciarVPrincipal(VentanaPrincipal vPrincipal)
        {
            ventanaPrincipal = vPrincipal;
        }

        public RegistrarProveedor()
        {
            InitializeComponent();
        }        

        private void bntCancelar_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            Proveedor proveedor = new Proveedor();
            proveedor.setId(int.Parse(txtId.Text));
            proveedor.setRuc(int.Parse(txtRUC.Text));
            proveedor.setRazonSocial(txtRazon.Text);
            proveedor.setPaginaWeb(txtPagWeb.Text);
            proveedor.setRubro(txtRubro.Text);
            proveedor.setDireccion(txtDireccion.Text);
            proveedor.setNombreContacto(txtNombreContacto.Text);
            proveedor.setEmailContacto(txtEmailContacto.Text);
            proveedor.setTelefonoContacto(int.Parse(txtTelefonoContacto.Text));

            gestorUsuario.

        }


    }
}
