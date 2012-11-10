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
        private GestorProveedor gestorProveedor = GestorProveedor.Instancia();
        private List<Proveedor> lproveedor;
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
            proveedor.setEliminado(false);

            gestorProveedor.agregarProveedor(proveedor);
            actualizarTabla();

        }
        public void actualizarTabla()
        {
            for (int i = 0; i < tablaProveedor.Rows.Count; i++)
                tablaProveedor.Rows.RemoveAt(i);

            gestorProveedor = GestorProveedor.Instancia();
            lproveedor = gestorProveedor.seleccionarProveedores();
            String[] fila;
            Proveedor proveedor;
            for (int i = 0; i < lproveedor.Count; i++)
            {
                proveedor = lproveedor[i];
                fila = new String[] {""+proveedor.getId(),proveedor.getRazonSocial(), ""+proveedor.getRuc(),
                    proveedor.getDireccion() };
                tablaProveedor.Rows.Add(fila);
            }
        }

    }
}
