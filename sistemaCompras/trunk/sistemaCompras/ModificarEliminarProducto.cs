using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Beans;

namespace sistemaCompras
{
    public partial class ModificarEliminarProducto : Form
    {
        private int tipo;
        public ModificarEliminarProducto(int t)
        {
            this.tipo = t;
            InitializeComponent();
            if (this.tipo == 1) this.Text = "Modificar Producto";
            else this.Text = "Eliminar Producto";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cambiar esto por la busqueda
            //this.refrescarTabla(Gestores.GestorProducto.Instancia().getLproducto());
            this.refrescarTabla(Gestores.GestorProducto.Instancia().getProductosLikeNombre(this.txtNombre.Text));
        }

        public void refrescarTabla(List<Producto> lp) {
            DataTable tp = new DataTable();
            tp.Columns.Add("ID", typeof(int));
            tp.Columns.Add("Producto", typeof(string));
            tp.Columns.Add("Descripcion", typeof(string));
            tp.Columns.Add("Fabricante", typeof(string));
            int i;
            for (i = 0; i < lp.Count(); i++)
            {
                if (lp[i].getEliminado() == false)
                {
                    tp.Rows.Add(lp[i].getId(),
                    lp[i].getNombre(),
                    lp[i].getDescripcion(),
                    lp[i].getFabricante());
                }
            }

            this.dgvProductos.DataSource = tp;
        }

        private void ModificarEliminarProducto_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = this.dgvProductos.SelectedCells[0].RowIndex;
            int id = (int)this.dgvProductos.Rows[i].Cells[0].Value;

            if (this.tipo == 1)
            {
                Producto p = new Producto();
                p.setNombre(this.txtNombre.Text);
                p.setDescripcion(this.txtDescrip.Text);
                p.setFabricante(this.txtFab.Text);

                ModificarProducto mp = new ModificarProducto(id);
                mp.Show();
                
                
            }
            else
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar el producto " + this.dgvProductos.Rows[i].Cells[1].Value + "?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Gestores.GestorProducto.Instancia().eliminarProducto(id);
                    //this.refrescarTabla(Gestores.GestorProducto.Instancia().getProductosLikeNombre(this.txtNombre.Text));
                }
               
            }
            this.refrescarTabla(Gestores.GestorProducto.Instancia().getProductosLikeNombre(this.txtNombre.Text));
           // this.Close();
        }

        

        
    }
}
