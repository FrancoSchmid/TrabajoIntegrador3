namespace pryTrabajoIntegrador3
{
    partial class frmListaDeudores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadCliente = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblPromedioD = new System.Windows.Forms.Label();
            this.lblCantidadC = new System.Windows.Forms.Label();
            this.lblTotalD = new System.Windows.Forms.Label();
            this.dgvListaClientesD = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientesD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPromedioDeuda);
            this.groupBox1.Controls.Add(this.lblCantidadCliente);
            this.groupBox1.Controls.Add(this.lblTotalDeuda);
            this.groupBox1.Controls.Add(this.lblPromedioD);
            this.groupBox1.Controls.Add(this.lblCantidadC);
            this.groupBox1.Controls.Add(this.lblTotalD);
            this.groupBox1.Controls.Add(this.dgvListaClientesD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de datos";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.BackColor = System.Drawing.Color.SlateGray;
            this.lblPromedioDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioDeuda.Location = new System.Drawing.Point(584, 397);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(71, 18);
            this.lblPromedioDeuda.TabIndex = 25;
            // 
            // lblCantidadCliente
            // 
            this.lblCantidadCliente.BackColor = System.Drawing.Color.SlateGray;
            this.lblCantidadCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantidadCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadCliente.Location = new System.Drawing.Point(584, 362);
            this.lblCantidadCliente.Name = "lblCantidadCliente";
            this.lblCantidadCliente.Size = new System.Drawing.Size(71, 18);
            this.lblCantidadCliente.TabIndex = 24;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.BackColor = System.Drawing.Color.SlateGray;
            this.lblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(584, 329);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(71, 18);
            this.lblTotalDeuda.TabIndex = 23;
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.Azure;
            this.btnListar.Location = new System.Drawing.Point(455, 452);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(220, 32);
            this.btnListar.TabIndex = 22;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            // 
            // lblPromedioD
            // 
            this.lblPromedioD.AutoSize = true;
            this.lblPromedioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioD.Location = new System.Drawing.Point(440, 397);
            this.lblPromedioD.Name = "lblPromedioD";
            this.lblPromedioD.Size = new System.Drawing.Size(140, 18);
            this.lblPromedioD.TabIndex = 21;
            this.lblPromedioD.Text = "Promedio de Deuda";
            // 
            // lblCantidadC
            // 
            this.lblCantidadC.AutoSize = true;
            this.lblCantidadC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadC.Location = new System.Drawing.Point(440, 362);
            this.lblCantidadC.Name = "lblCantidadC";
            this.lblCantidadC.Size = new System.Drawing.Size(143, 18);
            this.lblCantidadC.TabIndex = 20;
            this.lblCantidadC.Text = "Cantidad de Clientes";
            // 
            // lblTotalD
            // 
            this.lblTotalD.AutoSize = true;
            this.lblTotalD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalD.Location = new System.Drawing.Point(440, 329);
            this.lblTotalD.Name = "lblTotalD";
            this.lblTotalD.Size = new System.Drawing.Size(105, 18);
            this.lblTotalD.TabIndex = 19;
            this.lblTotalD.Text = "Total de deuda";
            // 
            // dgvListaClientesD
            // 
            this.dgvListaClientesD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaClientesD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Deuda});
            this.dgvListaClientesD.Location = new System.Drawing.Point(6, 19);
            this.dgvListaClientesD.Name = "dgvListaClientesD";
            this.dgvListaClientesD.Size = new System.Drawing.Size(657, 302);
            this.dgvListaClientesD.TabIndex = 18;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Deuda
            // 
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // frmListaDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(701, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnListar);
            this.Name = "frmListaDeudores";
            this.Text = "Lista de deudores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaClientesD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadCliente;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Label lblPromedioD;
        private System.Windows.Forms.Label lblCantidadC;
        private System.Windows.Forms.Label lblTotalD;
        private System.Windows.Forms.DataGridView dgvListaClientesD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.Button btnListar;
    }
}