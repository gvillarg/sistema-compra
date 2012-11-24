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
    
    public partial class RegistrarProducto : Form
    {
        public RegistrarProducto()
        {
            InitializeComponent();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.validaCampos())
            {
                Producto p = new Producto();
                p.setId(int.Parse(this.txtId.Text));
                p.setDescripcion(this.txtDescrip.Text);
                p.setFabricante(this.txtFab.Text);
                p.setNombre(this.txtNombre.Text);
                p.setEliminado(false);
                GestorProducto.Instancia().agregarProducto(p);
                MessageBox.Show("Se registró en el sistema la información sobre el producto. Para dejar de registrar productos haga clic en Cancelar.", "Producto nuevo: " + this.txtNombre.Text);
                this.blankFields();

            }
            else
            {
                MessageBox.Show("Información del producto es insuficiente.", "Datos");
            }
            
         


        }
        public bool validaCampos()
        {
            return !this.txtId.Text.Equals("") && !this.txtDescrip.Text.Equals("") && !this.txtFab.Text.Equals("") && !txtNombre.Text.Equals("");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void blankFields() {
            this.txtId.Text = "";
            this.txtDescrip.Text = "";
            this.txtFab.Text = "";
            this.txtNombre.Text = "";
        }
        
    }
}
