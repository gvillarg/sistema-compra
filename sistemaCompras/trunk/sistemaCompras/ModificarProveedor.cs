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
    public partial class ModificarProveedor : Form
    {
        private ModificarEliminarProveedor modElimProvedor= null;
        public void referenciarVModElimProveedor(ModificarEliminarProveedor vModProveedor)
        {
            modElimProvedor = vModProveedor;
        }
        public ModificarProveedor()
        {
            InitializeComponent();
        }
    }
}
