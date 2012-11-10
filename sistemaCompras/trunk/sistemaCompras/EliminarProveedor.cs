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
    public partial class EliminarProveedor : Form
    {
        private VentanaPrincipal ventanaPrincipal = null;
        public void referenciarVPrincipal(VentanaPrincipal vPrincipal)
        {
            ventanaPrincipal = vPrincipal;
        }

        public EliminarProveedor()
        {
            InitializeComponent();
        }
    }
}
