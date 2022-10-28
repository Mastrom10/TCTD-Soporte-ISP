namespace GUI
{
    partial class frmControlCambiosClientes
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
            this.groupBoxBuscarCliente = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxDNICliente = new System.Windows.Forms.TextBox();
            this.textBoxNroClienteID = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.listBoxEstadosCliente = new System.Windows.Forms.ListBox();
            this.btnVerEstado = new System.Windows.Forms.Button();
            this.groupBoxBuscarCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuscarCliente
            // 
            this.groupBoxBuscarCliente.Controls.Add(this.btnLimpiar);
            this.groupBoxBuscarCliente.Controls.Add(this.btnBuscar);
            this.groupBoxBuscarCliente.Controls.Add(this.textBoxDNICliente);
            this.groupBoxBuscarCliente.Controls.Add(this.textBoxNroClienteID);
            this.groupBoxBuscarCliente.Controls.Add(this.lblDNICliente);
            this.groupBoxBuscarCliente.Controls.Add(this.lblNroCliente);
            this.groupBoxBuscarCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBuscarCliente.Name = "groupBoxBuscarCliente";
            this.groupBoxBuscarCliente.Size = new System.Drawing.Size(598, 45);
            this.groupBoxBuscarCliente.TabIndex = 3;
            this.groupBoxBuscarCliente.TabStop = false;
            this.groupBoxBuscarCliente.Text = "Buscar Cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(513, 13);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(432, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxDNICliente
            // 
            this.textBoxDNICliente.Location = new System.Drawing.Point(286, 15);
            this.textBoxDNICliente.Name = "textBoxDNICliente";
            this.textBoxDNICliente.Size = new System.Drawing.Size(130, 20);
            this.textBoxDNICliente.TabIndex = 3;
            // 
            // textBoxNroClienteID
            // 
            this.textBoxNroClienteID.Location = new System.Drawing.Point(91, 16);
            this.textBoxNroClienteID.Name = "textBoxNroClienteID";
            this.textBoxNroClienteID.Size = new System.Drawing.Size(112, 20);
            this.textBoxNroClienteID.TabIndex = 2;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(216, 19);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(64, 13);
            this.lblDNICliente.TabIndex = 1;
            this.lblDNICliente.Text = "DNI Cliente:";
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(9, 19);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(62, 13);
            this.lblNroCliente.TabIndex = 0;
            this.lblNroCliente.Text = "Nro Cliente:";
            // 
            // listBoxEstadosCliente
            // 
            this.listBoxEstadosCliente.FormattingEnabled = true;
            this.listBoxEstadosCliente.Location = new System.Drawing.Point(12, 88);
            this.listBoxEstadosCliente.Name = "listBoxEstadosCliente";
            this.listBoxEstadosCliente.Size = new System.Drawing.Size(507, 277);
            this.listBoxEstadosCliente.TabIndex = 4;
            // 
            // btnVerEstado
            // 
            this.btnVerEstado.Location = new System.Drawing.Point(525, 88);
            this.btnVerEstado.Name = "btnVerEstado";
            this.btnVerEstado.Size = new System.Drawing.Size(75, 23);
            this.btnVerEstado.TabIndex = 5;
            this.btnVerEstado.Text = "Ver estado";
            this.btnVerEstado.UseVisualStyleBackColor = true;
            this.btnVerEstado.Click += new System.EventHandler(this.btnVerEstado_Click);
            // 
            // frmControlCambiosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 507);
            this.Controls.Add(this.btnVerEstado);
            this.Controls.Add(this.listBoxEstadosCliente);
            this.Controls.Add(this.groupBoxBuscarCliente);
            this.Name = "frmControlCambiosClientes";
            this.Text = "frmControlCambiosClientes";
            this.Load += new System.EventHandler(this.frmControlCambiosClientes_Load);
            this.groupBoxBuscarCliente.ResumeLayout(false);
            this.groupBoxBuscarCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscarCliente;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxDNICliente;
        private System.Windows.Forms.TextBox textBoxNroClienteID;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.ListBox listBoxEstadosCliente;
        private System.Windows.Forms.Button btnVerEstado;
    }
}