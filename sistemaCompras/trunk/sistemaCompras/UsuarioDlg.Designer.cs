namespace sistemaCompras
{
    partial class UsuarioDlg
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
            this.tablaUsuario = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaUsuario
            // 
            this.tablaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.colEmail,
            this.colTelefono,
            this.colSueldo,
            this.colTipoUsuario});
            this.tablaUsuario.Location = new System.Drawing.Point(12, 12);
            this.tablaUsuario.Name = "tablaUsuario";
            this.tablaUsuario.Size = new System.Drawing.Size(723, 209);
            this.tablaUsuario.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 130;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            // 
            // colSueldo
            // 
            this.colSueldo.HeaderText = "Sueldo";
            this.colSueldo.Name = "colSueldo";
            // 
            // colTipoUsuario
            // 
            this.colTipoUsuario.HeaderText = "Tipo de Usuario";
            this.colTipoUsuario.Name = "colTipoUsuario";
            this.colTipoUsuario.Width = 150;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(159, 227);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(75, 23);
            this.botonRegistrar.TabIndex = 1;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(333, 227);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 2;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(503, 227);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 3;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // UsuarioDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 262);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.tablaUsuario);
            this.Name = "UsuarioDlg";
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoUsuario;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
    }
}