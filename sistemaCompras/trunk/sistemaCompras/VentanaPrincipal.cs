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
    public partial class VentanaPrincipal : Form
    {
        
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        
        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Console.Out.WriteLine("Hola mundo");
            //RegistrarProducto ap = new RegistrarProducto();
            //ap.Show();
            RegistrarProducto ventana = new RegistrarProducto();
            ventana.Show();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistrarProyecto regProyecto = new RegistrarProyecto();
            regProyecto.ShowDialog();
            this.Hide();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //EliminarProducto ep = new EliminarProducto();
            //ep.Show();
            ModificarEliminarProducto mep = new ModificarEliminarProducto(0);
            mep.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RegistrarProveedor regProveedor = new RegistrarProveedor();
            regProveedor.ShowDialog(this);
            regProveedor.referenciarVPrincipal(this);            
        }

        private void modificarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificarEliminarProveedor modProveedor = new ModificarEliminarProveedor("Modificar Proveedor");
            modProveedor.ShowDialog(this);
            modProveedor.referenciarVPrincipal(this);
        }

        private void eliminarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ModificarEliminarProveedor elimProveedor = new ModificarEliminarProveedor("Eliminar Proveedor");
            elimProveedor.ShowDialog(this);
            elimProveedor.referenciarVPrincipal(this);            
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ModificarProducto mp = new ModificarProducto();
            //mp.Show();
            ModificarEliminarProducto mep = new ModificarEliminarProducto(1);
            mep.Show();
        }
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioDlg ventana = new RegistrarUsuarioDlg();
            ventana.Show();    
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioDlg ventanaUsuarioDlg = new UsuarioDlg(0);
            ventanaUsuarioDlg.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioDlg ventanaUsuarioDlg = new UsuarioDlg(1);
            ventanaUsuarioDlg.Show();
        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    

       
    }
}
