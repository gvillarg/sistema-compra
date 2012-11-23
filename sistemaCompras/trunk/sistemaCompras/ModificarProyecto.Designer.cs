namespace sistemaCompras
{
    partial class ModificarProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label eliminadoLabel;
            this.sistemas = new sistemaCompras.Sistemas();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoTableAdapter = new sistemaCompras.SistemasTableAdapters.ProyectoTableAdapter();
            this.tableAdapterManager = new sistemaCompras.SistemasTableAdapters.TableAdapterManager();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.eliminadoCheckBox = new System.Windows.Forms.CheckBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarDescripcion = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            eliminadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(40, 33);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(36, 70);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // eliminadoLabel
            // 
            eliminadoLabel.AutoSize = true;
            eliminadoLabel.Location = new System.Drawing.Point(36, 114);
            eliminadoLabel.Name = "eliminadoLabel";
            eliminadoLabel.Size = new System.Drawing.Size(55, 13);
            eliminadoLabel.TabIndex = 5;
            eliminadoLabel.Text = "Eliminado:";
            // 
            // sistemas
            // 
            this.sistemas.DataSetName = "Sistemas";
            this.sistemas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.sistemas;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProyectoTableAdapter = this.proyectoTableAdapter;
            this.tableAdapterManager.UpdateOrder = sistemaCompras.SistemasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(133, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proyectoBindingSource, "Descripcion", true));
            this.txtDescripcion.Location = new System.Drawing.Point(133, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // eliminadoCheckBox
            // 
            this.eliminadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.proyectoBindingSource, "Eliminado", true));
            this.eliminadoCheckBox.Location = new System.Drawing.Point(133, 109);
            this.eliminadoCheckBox.Name = "eliminadoCheckBox";
            this.eliminadoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.eliminadoCheckBox.TabIndex = 6;
            this.eliminadoCheckBox.Text = "checkBox1";
            this.eliminadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(108, 168);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 36);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(250, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(632, 170);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "&BuscarNombre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarDescripcion
            // 
            this.btnBuscarDescripcion.Location = new System.Drawing.Point(256, 69);
            this.btnBuscarDescripcion.Name = "btnBuscarDescripcion";
            this.btnBuscarDescripcion.Size = new System.Drawing.Size(105, 33);
            this.btnBuscarDescripcion.TabIndex = 14;
            this.btnBuscarDescripcion.Text = "&BuscarDescripcion";
            this.btnBuscarDescripcion.UseVisualStyleBackColor = true;
            this.btnBuscarDescripcion.Click += new System.EventHandler(this.btnBuscarDescripcion_Click);
            // 
            // ModificarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 487);
            this.Controls.Add(this.btnBuscarDescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(eliminadoLabel);
            this.Controls.Add(this.eliminadoCheckBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.txtNombre);
            this.Name = "ModificarProyecto";
            this.Text = "ModificarProyecto";
            this.Load += new System.EventHandler(this.ModificarProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sistemas sistemas;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private SistemasTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
        private SistemasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox eliminadoCheckBox;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarDescripcion;
    }
}