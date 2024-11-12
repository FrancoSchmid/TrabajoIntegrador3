namespace pryTrabajoIntegrador3
{
    partial class frmDesarollador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesarollador));
            this.pctFranco = new System.Windows.Forms.PictureBox();
            this.lblDesarrollador = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctFranco)).BeginInit();
            this.SuspendLayout();
            // 
            // pctFranco
            // 
            this.pctFranco.Image = ((System.Drawing.Image)(resources.GetObject("pctFranco.Image")));
            this.pctFranco.Location = new System.Drawing.Point(12, 12);
            this.pctFranco.Name = "pctFranco";
            this.pctFranco.Size = new System.Drawing.Size(161, 167);
            this.pctFranco.TabIndex = 0;
            this.pctFranco.TabStop = false;
            // 
            // lblDesarrollador
            // 
            this.lblDesarrollador.AutoSize = true;
            this.lblDesarrollador.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrollador.Location = new System.Drawing.Point(179, 26);
            this.lblDesarrollador.Name = "lblDesarrollador";
            this.lblDesarrollador.Size = new System.Drawing.Size(216, 19);
            this.lblDesarrollador.TabIndex = 1;
            this.lblDesarrollador.Text = "Desarrollador: Franco Schmid";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(179, 64);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(113, 19);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI: 41681377";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(179, 140);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(225, 19);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Laboratorio de programacion II";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComision.Location = new System.Drawing.Point(179, 102);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(156, 19);
            this.lblComision.TabIndex = 5;
            this.lblComision.Text = "Comision: Mañana A";
            // 
            // frmDesarollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(430, 193);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblDesarrollador);
            this.Controls.Add(this.pctFranco);
            this.Name = "frmDesarollador";
            this.Text = "Acerca del desarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pctFranco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFranco;
        private System.Windows.Forms.Label lblDesarrollador;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
    }
}