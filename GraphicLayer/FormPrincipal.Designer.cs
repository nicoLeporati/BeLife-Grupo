namespace GraphicLayer
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnAgregarContrato = new System.Windows.Forms.Button();
            this.btnListarClientes = new System.Windows.Forms.Button();
            this.btnListarContratos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(29, 181);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 68);
            this.btnAgregarCliente.TabIndex = 0;
            this.btnAgregarCliente.Text = "AGREGAR CLIENTE";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnAgregarContrato
            // 
            this.btnAgregarContrato.Location = new System.Drawing.Point(110, 181);
            this.btnAgregarContrato.Name = "btnAgregarContrato";
            this.btnAgregarContrato.Size = new System.Drawing.Size(75, 68);
            this.btnAgregarContrato.TabIndex = 1;
            this.btnAgregarContrato.Text = "AGREGAR CONTRATO";
            this.btnAgregarContrato.UseVisualStyleBackColor = true;
            // 
            // btnListarClientes
            // 
            this.btnListarClientes.Location = new System.Drawing.Point(191, 181);
            this.btnListarClientes.Name = "btnListarClientes";
            this.btnListarClientes.Size = new System.Drawing.Size(75, 68);
            this.btnListarClientes.TabIndex = 2;
            this.btnListarClientes.Text = "LISTAR CLIENTES";
            this.btnListarClientes.UseVisualStyleBackColor = true;
            // 
            // btnListarContratos
            // 
            this.btnListarContratos.Location = new System.Drawing.Point(272, 181);
            this.btnListarContratos.Name = "btnListarContratos";
            this.btnListarContratos.Size = new System.Drawing.Size(75, 68);
            this.btnListarContratos.TabIndex = 3;
            this.btnListarContratos.Text = "LISTAR CONTRATO";
            this.btnListarContratos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GraphicLayer.Properties.Resources.Logo_BeLife;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(377, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListarContratos);
            this.Controls.Add(this.btnListarClientes);
            this.Controls.Add(this.btnAgregarContrato);
            this.Controls.Add(this.btnAgregarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BeLife - Inicio";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnAgregarContrato;
        private System.Windows.Forms.Button btnListarClientes;
        private System.Windows.Forms.Button btnListarContratos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

