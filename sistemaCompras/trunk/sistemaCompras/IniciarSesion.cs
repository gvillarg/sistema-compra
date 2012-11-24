using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistemaCompras
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            //C:\Users\Jonatan\Documents\Visual Studio 2010\Projects\sistemaCompras(7)\Gestores\DB
            InitializeComponent();
            //label3.Text=Directory.GetCurrentDirectory()+"\\..\\..\\";              
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();            
            ventanaPrincipal.Show();
            this.Hide();            
        }

    }
}
