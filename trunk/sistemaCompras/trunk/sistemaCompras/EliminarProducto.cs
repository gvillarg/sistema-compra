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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
            this.refrescarTabla();
           
        }


        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable tp = this.
            int i = this.dgvProductos.SelectedCells[0].RowIndex;
            int id = (int) this.dgvProductos.Rows[i].Cells[0].Value;
            Gestores.GestorProducto.Instancia().eliminarProducto(id);
        }                  

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
