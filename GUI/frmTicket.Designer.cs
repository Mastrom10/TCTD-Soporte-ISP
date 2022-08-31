namespace GUI
{
    partial class frmTicket
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
            this.groupBoxinfoClientes = new System.Windows.Forms.GroupBox();
            this.lblValueNombre = new System.Windows.Forms.Label();
            this.lblValueNroCliente = new System.Windows.Forms.Label();
            this.lblFullNombre = new System.Windows.Forms.Label();
            this.labelNroCliente = new System.Windows.Forms.Label();
            this.lblTicketNumerotitle = new System.Windows.Forms.Label();
            this.lblTicketNumeroValue = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEstadoValue = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.lblFechaCreacionValue = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaCierreValue = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.lblFechaUltimaModificacionValue = new System.Windows.Forms.Label();
            this.lblUltimaModificacion = new System.Windows.Forms.Label();
            this.lblCreadoPor = new System.Windows.Forms.Label();
            this.lblCreadoPorValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDerivar = new System.Windows.Forms.Button();
            this.btnCerrarTicket = new System.Windows.Forms.Button();
            this.groupBoxinfoClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxinfoClientes
            // 
            this.groupBoxinfoClientes.Controls.Add(this.lblValueNombre);
            this.groupBoxinfoClientes.Controls.Add(this.lblValueNroCliente);
            this.groupBoxinfoClientes.Controls.Add(this.lblFullNombre);
            this.groupBoxinfoClientes.Controls.Add(this.labelNroCliente);
            this.groupBoxinfoClientes.Location = new System.Drawing.Point(12, 59);
            this.groupBoxinfoClientes.Name = "groupBoxinfoClientes";
            this.groupBoxinfoClientes.Size = new System.Drawing.Size(663, 42);
            this.groupBoxinfoClientes.TabIndex = 16;
            this.groupBoxinfoClientes.TabStop = false;
            this.groupBoxinfoClientes.Text = "Datos del cliente";
            // 
            // lblValueNombre
            // 
            this.lblValueNombre.AutoSize = true;
            this.lblValueNombre.Location = new System.Drawing.Point(260, 19);
            this.lblValueNombre.Name = "lblValueNombre";
            this.lblValueNombre.Size = new System.Drawing.Size(16, 13);
            this.lblValueNombre.TabIndex = 12;
            this.lblValueNombre.Text = "---";
            // 
            // lblValueNroCliente
            // 
            this.lblValueNroCliente.AutoSize = true;
            this.lblValueNroCliente.Location = new System.Drawing.Point(74, 19);
            this.lblValueNroCliente.Name = "lblValueNroCliente";
            this.lblValueNroCliente.Size = new System.Drawing.Size(16, 13);
            this.lblValueNroCliente.TabIndex = 14;
            this.lblValueNroCliente.Text = "---";
            // 
            // lblFullNombre
            // 
            this.lblFullNombre.AutoSize = true;
            this.lblFullNombre.Location = new System.Drawing.Point(160, 19);
            this.lblFullNombre.Name = "lblFullNombre";
            this.lblFullNombre.Size = new System.Drawing.Size(94, 13);
            this.lblFullNombre.TabIndex = 2;
            this.lblFullNombre.Text = "Nombre Completo:";
            // 
            // labelNroCliente
            // 
            this.labelNroCliente.AutoSize = true;
            this.labelNroCliente.Location = new System.Drawing.Point(6, 19);
            this.labelNroCliente.Name = "labelNroCliente";
            this.labelNroCliente.Size = new System.Drawing.Size(62, 13);
            this.labelNroCliente.TabIndex = 6;
            this.labelNroCliente.Text = "Nro Cliente:";
            // 
            // lblTicketNumerotitle
            // 
            this.lblTicketNumerotitle.AutoSize = true;
            this.lblTicketNumerotitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumerotitle.Location = new System.Drawing.Point(17, 25);
            this.lblTicketNumerotitle.Name = "lblTicketNumerotitle";
            this.lblTicketNumerotitle.Size = new System.Drawing.Size(95, 20);
            this.lblTicketNumerotitle.TabIndex = 17;
            this.lblTicketNumerotitle.Text = "Ticket Nro:";
            // 
            // lblTicketNumeroValue
            // 
            this.lblTicketNumeroValue.AutoSize = true;
            this.lblTicketNumeroValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumeroValue.Location = new System.Drawing.Point(118, 25);
            this.lblTicketNumeroValue.Name = "lblTicketNumeroValue";
            this.lblTicketNumeroValue.Size = new System.Drawing.Size(19, 20);
            this.lblTicketNumeroValue.TabIndex = 18;
            this.lblTicketNumeroValue.Text = "0";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(21, 122);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 228);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(122, 119);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(553, 20);
            this.textBoxTitulo.TabIndex = 21;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(122, 228);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescripcion.Size = new System.Drawing.Size(553, 74);
            this.textBoxDescripcion.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(21, 153);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 23;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEstadoValue
            // 
            this.lblEstadoValue.AutoSize = true;
            this.lblEstadoValue.Location = new System.Drawing.Point(119, 153);
            this.lblEstadoValue.Name = "lblEstadoValue";
            this.lblEstadoValue.Size = new System.Drawing.Size(16, 13);
            this.lblEstadoValue.TabIndex = 24;
            this.lblEstadoValue.Text = "---";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(465, 153);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(51, 13);
            this.lblPrioridad.TabIndex = 25;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.Enabled = false;
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(522, 149);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(153, 21);
            this.comboBoxPrioridad.TabIndex = 26;
            // 
            // lblFechaCreacionValue
            // 
            this.lblFechaCreacionValue.AutoSize = true;
            this.lblFechaCreacionValue.Location = new System.Drawing.Point(21, 192);
            this.lblFechaCreacionValue.Name = "lblFechaCreacionValue";
            this.lblFechaCreacionValue.Size = new System.Drawing.Size(16, 13);
            this.lblFechaCreacionValue.TabIndex = 28;
            this.lblFechaCreacionValue.Text = "---";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(21, 176);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(85, 13);
            this.lblFechaCreacion.TabIndex = 27;
            this.lblFechaCreacion.Text = "Fecha Creacion:";
            // 
            // lblFechaCierreValue
            // 
            this.lblFechaCierreValue.AutoSize = true;
            this.lblFechaCierreValue.Location = new System.Drawing.Point(250, 192);
            this.lblFechaCierreValue.Name = "lblFechaCierreValue";
            this.lblFechaCierreValue.Size = new System.Drawing.Size(16, 13);
            this.lblFechaCierreValue.TabIndex = 30;
            this.lblFechaCierreValue.Text = "---";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(250, 176);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(70, 13);
            this.lblFechaCierre.TabIndex = 29;
            this.lblFechaCierre.Text = "Fecha Cierre:";
            // 
            // lblFechaUltimaModificacionValue
            // 
            this.lblFechaUltimaModificacionValue.AutoSize = true;
            this.lblFechaUltimaModificacionValue.Location = new System.Drawing.Point(465, 192);
            this.lblFechaUltimaModificacionValue.Name = "lblFechaUltimaModificacionValue";
            this.lblFechaUltimaModificacionValue.Size = new System.Drawing.Size(16, 13);
            this.lblFechaUltimaModificacionValue.TabIndex = 32;
            this.lblFechaUltimaModificacionValue.Text = "---";
            // 
            // lblUltimaModificacion
            // 
            this.lblUltimaModificacion.AutoSize = true;
            this.lblUltimaModificacion.Location = new System.Drawing.Point(464, 176);
            this.lblUltimaModificacion.Name = "lblUltimaModificacion";
            this.lblUltimaModificacion.Size = new System.Drawing.Size(102, 13);
            this.lblUltimaModificacion.TabIndex = 31;
            this.lblUltimaModificacion.Text = "Ultima Modificacion:";
            // 
            // lblCreadoPor
            // 
            this.lblCreadoPor.AutoSize = true;
            this.lblCreadoPor.Location = new System.Drawing.Point(250, 153);
            this.lblCreadoPor.Name = "lblCreadoPor";
            this.lblCreadoPor.Size = new System.Drawing.Size(62, 13);
            this.lblCreadoPor.TabIndex = 15;
            this.lblCreadoPor.Text = "Creado por:";
            // 
            // lblCreadoPorValue
            // 
            this.lblCreadoPorValue.AutoSize = true;
            this.lblCreadoPorValue.Location = new System.Drawing.Point(318, 153);
            this.lblCreadoPorValue.Name = "lblCreadoPorValue";
            this.lblCreadoPorValue.Size = new System.Drawing.Size(16, 13);
            this.lblCreadoPorValue.TabIndex = 33;
            this.lblCreadoPorValue.Text = "---";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 355);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(651, 360);
            this.flowLayoutPanel1.TabIndex = 34;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(600, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 35;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(519, 308);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDerivar
            // 
            this.btnDerivar.Location = new System.Drawing.Point(21, 308);
            this.btnDerivar.Name = "btnDerivar";
            this.btnDerivar.Size = new System.Drawing.Size(114, 23);
            this.btnDerivar.TabIndex = 37;
            this.btnDerivar.Text = "Derivar Ticket";
            this.btnDerivar.UseVisualStyleBackColor = true;
            this.btnDerivar.Click += new System.EventHandler(this.btnDerivarTicket_Click);
            // 
            // btnCerrarTicket
            // 
            this.btnCerrarTicket.Location = new System.Drawing.Point(265, 308);
            this.btnCerrarTicket.Name = "btnCerrarTicket";
            this.btnCerrarTicket.Size = new System.Drawing.Size(114, 23);
            this.btnCerrarTicket.TabIndex = 38;
            this.btnCerrarTicket.Text = "Cerrar Ticket";
            this.btnCerrarTicket.UseVisualStyleBackColor = true;
            this.btnCerrarTicket.Click += new System.EventHandler(this.btnCerrarTicket_Click);
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 772);
            this.Controls.Add(this.btnCerrarTicket);
            this.Controls.Add(this.btnDerivar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCreadoPorValue);
            this.Controls.Add(this.lblCreadoPor);
            this.Controls.Add(this.lblFechaUltimaModificacionValue);
            this.Controls.Add(this.lblUltimaModificacion);
            this.Controls.Add(this.lblFechaCierreValue);
            this.Controls.Add(this.lblFechaCierre);
            this.Controls.Add(this.lblFechaCreacionValue);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblEstadoValue);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTicketNumeroValue);
            this.Controls.Add(this.lblTicketNumerotitle);
            this.Controls.Add(this.groupBoxinfoClientes);
            this.Name = "frmTicket";
            this.Text = "frmTicket";
            this.Load += new System.EventHandler(this.frmTicket_Load);
            this.groupBoxinfoClientes.ResumeLayout(false);
            this.groupBoxinfoClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxinfoClientes;
        private System.Windows.Forms.Label lblValueNombre;
        private System.Windows.Forms.Label lblValueNroCliente;
        private System.Windows.Forms.Label lblFullNombre;
        private System.Windows.Forms.Label labelNroCliente;
        private System.Windows.Forms.Label lblTicketNumerotitle;
        private System.Windows.Forms.Label lblTicketNumeroValue;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEstadoValue;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.Label lblFechaCreacionValue;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaCierreValue;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label lblFechaUltimaModificacionValue;
        private System.Windows.Forms.Label lblUltimaModificacion;
        private System.Windows.Forms.Label lblCreadoPor;
        private System.Windows.Forms.Label lblCreadoPorValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDerivar;
        private System.Windows.Forms.Button btnCerrarTicket;
    }
}