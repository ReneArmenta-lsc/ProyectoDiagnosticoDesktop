
namespace ProyectoDiagnosticoDesktop
{
    partial class Cliente
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
            this.LBLNombre = new System.Windows.Forms.Label();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.TXBNombre = new System.Windows.Forms.TextBox();
            this.TXBApellidoPat = new System.Windows.Forms.TextBox();
            this.LBLApellidoPat = new System.Windows.Forms.Label();
            this.TXBApellidoMat = new System.Windows.Forms.TextBox();
            this.LBLApellidoMat = new System.Windows.Forms.Label();
            this.CBSexo = new System.Windows.Forms.ComboBox();
            this.LBLSexo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LBLFechaNacimiento = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GBDatosPersonales = new System.Windows.Forms.GroupBox();
            this.TXBId = new System.Windows.Forms.TextBox();
            this.LBLId = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.GBDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBLNombre
            // 
            this.LBLNombre.AutoSize = true;
            this.LBLNombre.Location = new System.Drawing.Point(12, 20);
            this.LBLNombre.Name = "LBLNombre";
            this.LBLNombre.Size = new System.Drawing.Size(49, 13);
            this.LBLNombre.TabIndex = 0;
            this.LBLNombre.Text = "Nombres";
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNGuardar.Location = new System.Drawing.Point(632, 415);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(75, 23);
            this.BTNGuardar.TabIndex = 1;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // TXBNombre
            // 
            this.TXBNombre.Location = new System.Drawing.Point(15, 36);
            this.TXBNombre.Name = "TXBNombre";
            this.TXBNombre.Size = new System.Drawing.Size(233, 20);
            this.TXBNombre.TabIndex = 2;
            // 
            // TXBApellidoPat
            // 
            this.TXBApellidoPat.Location = new System.Drawing.Point(254, 36);
            this.TXBApellidoPat.Name = "TXBApellidoPat";
            this.TXBApellidoPat.Size = new System.Drawing.Size(206, 20);
            this.TXBApellidoPat.TabIndex = 4;
            // 
            // LBLApellidoPat
            // 
            this.LBLApellidoPat.AutoSize = true;
            this.LBLApellidoPat.Location = new System.Drawing.Point(251, 20);
            this.LBLApellidoPat.Name = "LBLApellidoPat";
            this.LBLApellidoPat.Size = new System.Drawing.Size(84, 13);
            this.LBLApellidoPat.TabIndex = 3;
            this.LBLApellidoPat.Text = "Apellido Paterno";
            // 
            // TXBApellidoMat
            // 
            this.TXBApellidoMat.Location = new System.Drawing.Point(467, 36);
            this.TXBApellidoMat.Name = "TXBApellidoMat";
            this.TXBApellidoMat.Size = new System.Drawing.Size(206, 20);
            this.TXBApellidoMat.TabIndex = 6;
            // 
            // LBLApellidoMat
            // 
            this.LBLApellidoMat.AutoSize = true;
            this.LBLApellidoMat.Location = new System.Drawing.Point(464, 20);
            this.LBLApellidoMat.Name = "LBLApellidoMat";
            this.LBLApellidoMat.Size = new System.Drawing.Size(86, 13);
            this.LBLApellidoMat.TabIndex = 5;
            this.LBLApellidoMat.Text = "Apellido Materno";
            // 
            // CBSexo
            // 
            this.CBSexo.FormattingEnabled = true;
            this.CBSexo.Location = new System.Drawing.Point(15, 74);
            this.CBSexo.Name = "CBSexo";
            this.CBSexo.Size = new System.Drawing.Size(121, 21);
            this.CBSexo.TabIndex = 7;
            // 
            // LBLSexo
            // 
            this.LBLSexo.AutoSize = true;
            this.LBLSexo.Location = new System.Drawing.Point(12, 58);
            this.LBLSexo.Name = "LBLSexo";
            this.LBLSexo.Size = new System.Drawing.Size(31, 13);
            this.LBLSexo.TabIndex = 8;
            this.LBLSexo.Text = "Sexo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // LBLFechaNacimiento
            // 
            this.LBLFechaNacimiento.AutoSize = true;
            this.LBLFechaNacimiento.Location = new System.Drawing.Point(153, 58);
            this.LBLFechaNacimiento.Name = "LBLFechaNacimiento";
            this.LBLFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.LBLFechaNacimiento.TabIndex = 10;
            this.LBLFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(289, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // GBDatosPersonales
            // 
            this.GBDatosPersonales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBDatosPersonales.Controls.Add(this.TXBNombre);
            this.GBDatosPersonales.Controls.Add(this.comboBox1);
            this.GBDatosPersonales.Controls.Add(this.LBLNombre);
            this.GBDatosPersonales.Controls.Add(this.LBLFechaNacimiento);
            this.GBDatosPersonales.Controls.Add(this.LBLApellidoPat);
            this.GBDatosPersonales.Controls.Add(this.dateTimePicker1);
            this.GBDatosPersonales.Controls.Add(this.TXBApellidoPat);
            this.GBDatosPersonales.Controls.Add(this.LBLSexo);
            this.GBDatosPersonales.Controls.Add(this.LBLApellidoMat);
            this.GBDatosPersonales.Controls.Add(this.CBSexo);
            this.GBDatosPersonales.Controls.Add(this.TXBApellidoMat);
            this.GBDatosPersonales.Location = new System.Drawing.Point(12, 51);
            this.GBDatosPersonales.Name = "GBDatosPersonales";
            this.GBDatosPersonales.Size = new System.Drawing.Size(695, 128);
            this.GBDatosPersonales.TabIndex = 12;
            this.GBDatosPersonales.TabStop = false;
            this.GBDatosPersonales.Text = "Datos Personales";
            // 
            // TXBId
            // 
            this.TXBId.Location = new System.Drawing.Point(15, 25);
            this.TXBId.Name = "TXBId";
            this.TXBId.ReadOnly = true;
            this.TXBId.Size = new System.Drawing.Size(99, 20);
            this.TXBId.TabIndex = 13;
            // 
            // LBLId
            // 
            this.LBLId.AutoSize = true;
            this.LBLId.Location = new System.Drawing.Point(12, 9);
            this.LBLId.Name = "LBLId";
            this.LBLId.Size = new System.Drawing.Size(18, 13);
            this.LBLId.TabIndex = 12;
            this.LBLId.Text = "ID";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNCancelar.Location = new System.Drawing.Point(551, 415);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(75, 23);
            this.BTNCancelar.TabIndex = 14;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.BTNGuardar);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.TXBId);
            this.Controls.Add(this.LBLId);
            this.Controls.Add(this.GBDatosPersonales);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.GBDatosPersonales.ResumeLayout(false);
            this.GBDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLNombre;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.TextBox TXBNombre;
        private System.Windows.Forms.TextBox TXBApellidoPat;
        private System.Windows.Forms.Label LBLApellidoPat;
        private System.Windows.Forms.TextBox TXBApellidoMat;
        private System.Windows.Forms.Label LBLApellidoMat;
        private System.Windows.Forms.ComboBox CBSexo;
        private System.Windows.Forms.Label LBLSexo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LBLFechaNacimiento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox GBDatosPersonales;
        private System.Windows.Forms.TextBox TXBId;
        private System.Windows.Forms.Label LBLId;
        private System.Windows.Forms.Button BTNCancelar;
    }
}