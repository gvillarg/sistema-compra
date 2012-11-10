using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Beans;

namespace sistemaCompras { }
/*{
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
            this.refrescarTabla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void ModificarProducto_Load(object sender, EventArgs e)
        {

        }

        public void refrescarTabla()
        {
            DataTable tp = new DataTable();
            tp.Columns.Add("ID", typeof(int));
            tp.Columns.Add("Producto", typeof(string));
            tp.Columns.Add("Descripcion", typeof(string));
            tp.Columns.Add("Fabricante", typeof(string));
            int i;
            for (i = 0; i < Gestores.GestorProducto.Instancia().getLproducto().Count(); i++)
            {
                if (Gestores.GestorProducto.Instancia().getLproducto()[i].getEliminado() == false)
                {
                    tp.Rows.Add(Gestores.GestorProducto.Instancia().getLproducto()[i].getId(),
                    Gestores.GestorProducto.Instancia().getLproducto()[i].getNombre(),
                    Gestores.GestorProducto.Instancia().getLproducto()[i].getDescripcion(),
                    Gestores.GestorProducto.Instancia().getLproducto()[i].getFabricante());
                }
            }

            this.dgvProductos.DataSource = tp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.setId(int.Parse(this.txtId.Text));
            p.setNombre(this.txtNombre.Text);
            p.setDescripcion(this.txtDescrip.Text);
            p.setEliminado(false);
            p.setFabricante(this.txtFab.Text);
            Gestores.GestorProducto.Instancia().modificarProducto(p);
            this.refrescarTabla();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show("hola");
            int i = this.dgvProductos.SelectedCells[0].RowIndex;
            this.txtId.Text = this.dgvProductos.Rows[i].Cells[0].Value.ToString();
            this.txtNombre.Text = this.dgvProductos.Rows[i].Cells[1].Value.ToString();
            this.txtDescrip.Text = this.dgvProductos.Rows[i].Cells[2].Value.ToString();
            this.txtFab.Text = this.dgvProductos.Rows[i].Cells[3].Value.ToString();

        }

       

        
    }
}
    */