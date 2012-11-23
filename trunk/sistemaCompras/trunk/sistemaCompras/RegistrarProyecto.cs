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
    public partial class RegistrarProyecto : Form
    {
        public RegistrarProyecto()
        {
            InitializeComponent();
        }

        //private DataSet ds;

        private void proyectoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proyectoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemas);

        }

        private void RegistrarProyecto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemas.Proyecto' table. You can move, or remove it, as needed.
            //this.proyectoTableAdapter.Fill(this.sistemas.Proyecto);



        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           // =@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\Access\Sistemas.accdb";
        }
    }
}
