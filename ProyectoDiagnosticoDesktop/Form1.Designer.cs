
namespace ProyectoDiagnosticoDesktop
{
    partial class Form1
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
            this.TXBBuscar = new System.Windows.Forms.TextBox();
            this.DGVClientes = new System.Windows.Forms.DataGridView();
            this.LBLBuscar = new System.Windows.Forms.Label();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CHBMostrarEliminados = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TXBBuscar
            // 
            this.TXBBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXBBuscar.Location = new System.Drawing.Point(31, 26);
            this.TXBBuscar.Name = "TXBBuscar";
            this.TXBBuscar.Size = new System.Drawing.Size(865, 20);
            this.TXBBuscar.TabIndex = 0;
            this.TXBBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DGVClientes
            // 
            this.DGVClientes.AllowUserToAddRows = false;
            this.DGVClientes.AllowUserToDeleteRows = false;
            this.DGVClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombres,
            this.ApellidoPaterno,
            this.ApellidoMaterno,
            this.Sexo,
            this.FechaNacimiento,
            this.Nacionalidad,
            this.Eliminar,
            this.Activo});
            this.DGVClientes.Location = new System.Drawing.Point(31, 69);
            this.DGVClientes.Name = "DGVClientes";
            this.DGVClientes.ReadOnly = true;
            this.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVClientes.ShowCellToolTips = false;
            this.DGVClientes.Size = new System.Drawing.Size(865, 350);
            this.DGVClientes.TabIndex = 1;
            this.DGVClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClientes_CellContentClick);
            this.DGVClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClientes_CellDoubleClick);
            this.DGVClientes.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVClientes_CellMouseEnter);
            // 
            // LBLBuscar
            // 
            this.LBLBuscar.AutoSize = true;
            this.LBLBuscar.Location = new System.Drawing.Point(28, 10);
            this.LBLBuscar.Name = "LBLBuscar";
            this.LBLBuscar.Size = new System.Drawing.Size(40, 13);
            this.LBLBuscar.TabIndex = 2;
            this.LBLBuscar.Text = "Buscar";
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNAgregar.Location = new System.Drawing.Point(821, 425);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 3;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // CHBMostrarEliminados
            // 
            this.CHBMostrarEliminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CHBMostrarEliminados.AutoSize = true;
            this.CHBMostrarEliminados.Location = new System.Drawing.Point(31, 425);
            this.CHBMostrarEliminados.Name = "CHBMostrarEliminados";
            this.CHBMostrarEliminados.Size = new System.Drawing.Size(113, 17);
            this.CHBMostrarEliminados.TabIndex = 4;
            this.CHBMostrarEliminados.Text = "Mostrar eliminados";
            this.CHBMostrarEliminados.UseVisualStyleBackColor = true;
            this.CHBMostrarEliminados.CheckedChanged += new System.EventHandler(this.CHBMostrarEliminados_CheckedChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombre";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "Apellido Materno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.HeaderText = "Nacionalidad";
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Activo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 478);
            this.Controls.Add(this.CHBMostrarEliminados);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.LBLBuscar);
            this.Controls.Add(this.DGVClientes);
            this.Controls.Add(this.TXBBuscar);
            this.Name = "Form1";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXBBuscar;
        private System.Windows.Forms.DataGridView DGVClientes;
        private System.Windows.Forms.Label LBLBuscar;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox CHBMostrarEliminados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}

