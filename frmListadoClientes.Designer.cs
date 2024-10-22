namespace pryTrabajoIntegrador3
{
    partial class frmListadoClientes
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
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadCliente = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadC = new System.Windows.Forms.Label();
            this.lblTotalD = new System.Windows.Forms.Label();
            this.dgvListaClientes = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnDeuda = new System.Windows.Forms.RadioButton();
            this.rbtnCiudad = new System.Windows.Forms.RadioButton();
            this.rbtnLimite = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.comboBox1);
            this.grpConsulta.Controls.Add(this.rbtnLimite);
            this.grpConsulta.Controls.Add(this.rbtnCiudad);
            this.grpConsulta.Controls.Add(this.rbtnDeuda);
            this.grpConsulta.Controls.Add(this.rbtnNombre);
            this.grpConsulta.Controls.Add(this.label1);
            this.grpConsulta.Controls.Add(this.lblCantidadCliente);
            this.grpConsulta.Controls.Add(this.lblTotalDeuda);
            this.grpConsulta.Controls.Add(this.lblPromedioDeuda);
            this.grpConsulta.Controls.Add(this.lblCantidadC);
            this.grpConsulta.Controls.Add(this.lblTotalD);
            this.grpConsulta.Controls.Add(this.dgvListaClientes);
            this.grpConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsulta.Location = new System.Drawing.Point(12, 12);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(669, 452);
            this.grpConsulta.TabIndex = 0;
            this.grpConsulta.TabStop = false;
            this.grpConsulta.Text = " ";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 20;
            // 
            // lblCantidadCliente
            // 
            this.lblCantidadCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCliente.Location = new System.Drawing.Point(580, 376);
            this.lblCantidadCliente.Name = "lblCantidadCliente";
            this.lblCantidadCliente.Size = new System.Drawing.Size(71, 13);
            this.lblCantidadCliente.TabIndex = 19;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(580, 343);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(71, 13);
            this.lblTotalDeuda.TabIndex = 18;
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDeuda.Location = new System.Drawing.Point(436, 411);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(140, 18);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de Deuda";
            // 
            // lblCantidadC
            // 
            this.lblCantidadC.AutoSize = true;
            this.lblCantidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadC.Location = new System.Drawing.Point(436, 376);
            this.lblCantidadC.Name = "lblCantidadC";
            this.lblCantidadC.Size = new System.Drawing.Size(143, 18);
            this.lblCantidadC.TabIndex = 2;
            this.lblCantidadC.Text = "Cantidad de Clientes";
            // 
            // lblTotalD
            // 
            this.lblTotalD.AutoSize = true;
            this.lblTotalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalD.Location = new System.Drawing.Point(436, 343);
            this.lblTotalD.Name = "lblTotalD";
            this.lblTotalD.Size = new System.Drawing.Size(105, 18);
            this.lblTotalD.TabIndex = 1;
            this.lblTotalD.Text = "Total de deuda";
            // 
            // dgvListaClientes
            // 
            this.dgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientes.Location = new System.Drawing.Point(6, 19);
            this.dgvListaClientes.Name = "dgvListaClientes";
            this.dgvListaClientes.Size = new System.Drawing.Size(657, 302);
            this.dgvListaClientes.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Azure;
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(18, 470);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(216, 32);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.Azure;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(240, 470);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(216, 32);
            this.btnGenerarReporte.TabIndex = 2;
            this.btnGenerarReporte.Text = "GENERAR REPORTE";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Azure;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(462, 470);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(213, 32);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(18, 372);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(80, 22);
            this.rbtnNombre.TabIndex = 21;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnDeuda
            // 
            this.rbtnDeuda.AutoSize = true;
            this.rbtnDeuda.Location = new System.Drawing.Point(18, 400);
            this.rbtnDeuda.Name = "rbtnDeuda";
            this.rbtnDeuda.Size = new System.Drawing.Size(69, 22);
            this.rbtnDeuda.TabIndex = 22;
            this.rbtnDeuda.TabStop = true;
            this.rbtnDeuda.Text = "Deuda";
            this.rbtnDeuda.UseVisualStyleBackColor = true;
            // 
            // rbtnCiudad
            // 
            this.rbtnCiudad.AutoSize = true;
            this.rbtnCiudad.Location = new System.Drawing.Point(104, 400);
            this.rbtnCiudad.Name = "rbtnCiudad";
            this.rbtnCiudad.Size = new System.Drawing.Size(72, 22);
            this.rbtnCiudad.TabIndex = 23;
            this.rbtnCiudad.TabStop = true;
            this.rbtnCiudad.Text = "Ciudad";
            this.rbtnCiudad.UseVisualStyleBackColor = true;
            // 
            // rbtnLimite
            // 
            this.rbtnLimite.AutoSize = true;
            this.rbtnLimite.Location = new System.Drawing.Point(104, 372);
            this.rbtnLimite.Name = "rbtnLimite";
            this.rbtnLimite.Size = new System.Drawing.Size(65, 22);
            this.rbtnLimite.TabIndex = 24;
            this.rbtnLimite.TabStop = true;
            this.rbtnLimite.Text = "Limite";
            this.rbtnLimite.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ascendente ",
            "Descendente"});
            this.comboBox1.Location = new System.Drawing.Point(18, 340);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 25;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(694, 514);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.btnGenerarReporte);
            this.Name = "frmListadoClientes";
            this.Text = "frmListadoClientes";
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.DataGridView dgvListaClientes;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadC;
        private System.Windows.Forms.Label lblTotalD;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadCliente;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbtnLimite;
        private System.Windows.Forms.RadioButton rbtnCiudad;
        private System.Windows.Forms.RadioButton rbtnDeuda;
        private System.Windows.Forms.RadioButton rbtnNombre;
    }
}