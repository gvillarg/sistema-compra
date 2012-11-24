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
    public partial class RegistrarProveedor : Form
    {
        private GestorProveedor gestorProveedor = GestorProveedor.Instancia();        
        private VentanaPrincipal ventanaPrincipal = null;
        private Validador validador;

        public void referenciarVPrincipal(VentanaPrincipal vPrincipal)
        {
            ventanaPrincipal = vPrincipal;
        }

        public RegistrarProveedor()
        {
            InitializeComponent();
            validador = new Validador(errorProvider);
        }        

        private void bntCancelar_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {          
            if (!validarDatos())
            {
                Proveedor proveedor = new Proveedor();                
                proveedor.setRuc(Int32.Parse(txtRUC.Text));
                proveedor.setRazonSocial(txtRazon.Text);
                proveedor.setPaginaWeb(txtPagWeb.Text);
                proveedor.setRubro(txtRubro.Text);
                proveedor.setDireccion(txtDireccion.Text);
                proveedor.setNombreContacto(txtNombreContacto.Text);
                proveedor.setEmailContacto(txtEmailContacto.Text);
                proveedor.setTelefonoContacto(Int32.Parse(txtTelefonoContacto.Text));
                proveedor.setEliminado(false);

                if (gestorProveedor.agregarProveedor(proveedor))
                {
                    MessageBox.Show("Proveedor agregado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            else
            {
                MessageBox.Show("Los datos no son correctos");
            }
        }

        private bool validarDatos()
        {
            bool error;
            error = validador.validarNumeroEntero(txtRUC);
            error = error || validador.validarNumeroEntero(txtTelefonoContacto);
            error = error || validador.validarEmail(txtEmailContacto); 
            return error;
        }        

        private void txtRUC_TextChanged(object sender, EventArgs e)
        {
            validador.validarNumeroEntero(txtRUC);
        }

        private void txtTelefonoContacto_TextChanged(object sender, EventArgs e)
        {
            validador.validarNumeroEntero(txtTelefonoContacto);
        }

        private void txtEmailContacto_TextChanged(object sender, EventArgs e)
        {
            validador.validarEmail(txtEmailContacto);
        }        

    }
}
