namespace GUI
{
    partial class frmOrdenTecnica
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
            this.lblTituloOrdenTecnica = new System.Windows.Forms.Label();
            this.groupBoxinfoClientes = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblValueNombre = new System.Windows.Forms.Label();
            this.lblValueNroCliente = new System.Windows.Forms.Label();
            this.lblFullNombre = new System.Windows.Forms.Label();
            this.labelNroCliente = new System.Windows.Forms.Label();
            this.groupBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.lblValueNodoRed = new System.Windows.Forms.Label();
            this.lblValueAltura = new System.Windows.Forms.Label();
            this.lblValuePiso = new System.Windows.Forms.Label();
            this.lblValueProcincia = new System.Windows.Forms.Label();
            this.lblValueCalle = new System.Windows.Forms.Label();
            this.lblValueLocalidad = new System.Windows.Forms.Label();
            this.lblValueDepto = new System.Windows.Forms.Label();
            this.lblValueCodigoPostal = new System.Windows.Forms.Label();
            this.lblClienteNododeRed = new System.Windows.Forms.Label();
            this.lblClienteAltura = new System.Windows.Forms.Label();
            this.lblClientePiso = new System.Windows.Forms.Label();
            this.lblClienteProvincia = new System.Windows.Forms.Label();
            this.lblClienteCalle = new System.Windows.Forms.Label();
            this.lblClienteLocalidad = new System.Windows.Forms.Label();
            this.lblClienteDepto = new System.Windows.Forms.Label();
            this.lblClienteCodigoPostal = new System.Windows.Forms.Label();
            this.lblNroTicket = new System.Windows.Forms.Label();
            this.lvlNroTIcketValue = new System.Windows.Forms.Label();
            this.lblTIpoService = new System.Windows.Forms.Label();
            this.comboBoxTipoService = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.lblTurnoValue = new System.Windows.Forms.Label();
            this.lblNotas = new System.Windows.Forms.Label();
            this.textBoxNotas = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblNroOrdenTecnica = new System.Windows.Forms.Label();
            this.lblNroOrdenTecnicaValue = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBoxinfoClientes.SuspendLayout();
            this.groupBoxDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloOrdenTecnica
            // 
            this.lblTituloOrdenTecnica.AutoSize = true;
            this.lblTituloOrdenTecnica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloOrdenTecnica.Location = new System.Drawing.Point(13, 13);
            this.lblTituloOrdenTecnica.Name = "lblTituloOrdenTecnica";
            this.lblTituloOrdenTecnica.Size = new System.Drawing.Size(180, 20);
            this.lblTituloOrdenTecnica.TabIndex = 0;
            this.lblTituloOrdenTecnica.Text = "Nueva Orden Técnica";
            // 
            // groupBoxinfoClientes
            // 
            this.groupBoxinfoClientes.Controls.Add(this.btnEditar);
            this.groupBoxinfoClientes.Controls.Add(this.lblValueNombre);
            this.groupBoxinfoClientes.Controls.Add(this.lblValueNroCliente);
            this.groupBoxinfoClientes.Controls.Add(this.lblFullNombre);
            this.groupBoxinfoClientes.Controls.Add(this.labelNroCliente);
            this.groupBoxinfoClientes.Location = new System.Drawing.Point(17, 68);
            this.groupBoxinfoClientes.Name = "groupBoxinfoClientes";
            this.groupBoxinfoClientes.Size = new System.Drawing.Size(586, 42);
            this.groupBoxinfoClientes.TabIndex = 17;
            this.groupBoxinfoClientes.TabStop = false;
            this.groupBoxinfoClientes.Text = "Datos del cliente";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(505, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // groupBoxDomicilio
            // 
            this.groupBoxDomicilio.Controls.Add(this.lblValueNodoRed);
            this.groupBoxDomicilio.Controls.Add(this.lblValueAltura);
            this.groupBoxDomicilio.Controls.Add(this.lblValuePiso);
            this.groupBoxDomicilio.Controls.Add(this.lblValueProcincia);
            this.groupBoxDomicilio.Controls.Add(this.lblValueCalle);
            this.groupBoxDomicilio.Controls.Add(this.lblValueLocalidad);
            this.groupBoxDomicilio.Controls.Add(this.lblValueDepto);
            this.groupBoxDomicilio.Controls.Add(this.lblValueCodigoPostal);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteNododeRed);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteAltura);
            this.groupBoxDomicilio.Controls.Add(this.lblClientePiso);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteProvincia);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteCalle);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteLocalidad);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteDepto);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteCodigoPostal);
            this.groupBoxDomicilio.Location = new System.Drawing.Point(17, 116);
            this.groupBoxDomicilio.Name = "groupBoxDomicilio";
            this.groupBoxDomicilio.Size = new System.Drawing.Size(586, 96);
            this.groupBoxDomicilio.TabIndex = 18;
            this.groupBoxDomicilio.TabStop = false;
            this.groupBoxDomicilio.Text = "Domicilio";
            // 
            // lblValueNodoRed
            // 
            this.lblValueNodoRed.AutoSize = true;
            this.lblValueNodoRed.Location = new System.Drawing.Point(427, 73);
            this.lblValueNodoRed.Name = "lblValueNodoRed";
            this.lblValueNodoRed.Size = new System.Drawing.Size(16, 13);
            this.lblValueNodoRed.TabIndex = 34;
            this.lblValueNodoRed.Text = "---";
            // 
            // lblValueAltura
            // 
            this.lblValueAltura.AutoSize = true;
            this.lblValueAltura.Location = new System.Drawing.Point(121, 37);
            this.lblValueAltura.Name = "lblValueAltura";
            this.lblValueAltura.Size = new System.Drawing.Size(16, 13);
            this.lblValueAltura.TabIndex = 27;
            this.lblValueAltura.Text = "---";
            // 
            // lblValuePiso
            // 
            this.lblValuePiso.AutoSize = true;
            this.lblValuePiso.Location = new System.Drawing.Point(121, 55);
            this.lblValuePiso.Name = "lblValuePiso";
            this.lblValuePiso.Size = new System.Drawing.Size(16, 13);
            this.lblValuePiso.TabIndex = 29;
            this.lblValuePiso.Text = "---";
            // 
            // lblValueProcincia
            // 
            this.lblValueProcincia.AutoSize = true;
            this.lblValueProcincia.Location = new System.Drawing.Point(427, 19);
            this.lblValueProcincia.Name = "lblValueProcincia";
            this.lblValueProcincia.Size = new System.Drawing.Size(16, 13);
            this.lblValueProcincia.TabIndex = 32;
            this.lblValueProcincia.Text = "---";
            // 
            // lblValueCalle
            // 
            this.lblValueCalle.AutoSize = true;
            this.lblValueCalle.Location = new System.Drawing.Point(121, 19);
            this.lblValueCalle.Name = "lblValueCalle";
            this.lblValueCalle.Size = new System.Drawing.Size(16, 13);
            this.lblValueCalle.TabIndex = 28;
            this.lblValueCalle.Text = "---";
            // 
            // lblValueLocalidad
            // 
            this.lblValueLocalidad.AutoSize = true;
            this.lblValueLocalidad.Location = new System.Drawing.Point(427, 37);
            this.lblValueLocalidad.Name = "lblValueLocalidad";
            this.lblValueLocalidad.Size = new System.Drawing.Size(16, 13);
            this.lblValueLocalidad.TabIndex = 31;
            this.lblValueLocalidad.Text = "---";
            // 
            // lblValueDepto
            // 
            this.lblValueDepto.AutoSize = true;
            this.lblValueDepto.Location = new System.Drawing.Point(121, 73);
            this.lblValueDepto.Name = "lblValueDepto";
            this.lblValueDepto.Size = new System.Drawing.Size(16, 13);
            this.lblValueDepto.TabIndex = 30;
            this.lblValueDepto.Text = "---";
            // 
            // lblValueCodigoPostal
            // 
            this.lblValueCodigoPostal.AutoSize = true;
            this.lblValueCodigoPostal.Location = new System.Drawing.Point(427, 55);
            this.lblValueCodigoPostal.Name = "lblValueCodigoPostal";
            this.lblValueCodigoPostal.Size = new System.Drawing.Size(16, 13);
            this.lblValueCodigoPostal.TabIndex = 33;
            this.lblValueCodigoPostal.Text = "---";
            // 
            // lblClienteNododeRed
            // 
            this.lblClienteNododeRed.AutoSize = true;
            this.lblClienteNododeRed.Location = new System.Drawing.Point(312, 73);
            this.lblClienteNododeRed.Name = "lblClienteNododeRed";
            this.lblClienteNododeRed.Size = new System.Drawing.Size(74, 13);
            this.lblClienteNododeRed.TabIndex = 26;
            this.lblClienteNododeRed.Text = "Nodo de Red:";
            // 
            // lblClienteAltura
            // 
            this.lblClienteAltura.AutoSize = true;
            this.lblClienteAltura.Location = new System.Drawing.Point(6, 37);
            this.lblClienteAltura.Name = "lblClienteAltura";
            this.lblClienteAltura.Size = new System.Drawing.Size(37, 13);
            this.lblClienteAltura.TabIndex = 12;
            this.lblClienteAltura.Text = "Altura:";
            // 
            // lblClientePiso
            // 
            this.lblClientePiso.AutoSize = true;
            this.lblClientePiso.Location = new System.Drawing.Point(6, 55);
            this.lblClientePiso.Name = "lblClientePiso";
            this.lblClientePiso.Size = new System.Drawing.Size(30, 13);
            this.lblClientePiso.TabIndex = 16;
            this.lblClientePiso.Text = "Piso:";
            // 
            // lblClienteProvincia
            // 
            this.lblClienteProvincia.AutoSize = true;
            this.lblClienteProvincia.Location = new System.Drawing.Point(312, 19);
            this.lblClienteProvincia.Name = "lblClienteProvincia";
            this.lblClienteProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblClienteProvincia.TabIndex = 22;
            this.lblClienteProvincia.Text = "Provincia:";
            // 
            // lblClienteCalle
            // 
            this.lblClienteCalle.AutoSize = true;
            this.lblClienteCalle.Location = new System.Drawing.Point(6, 19);
            this.lblClienteCalle.Name = "lblClienteCalle";
            this.lblClienteCalle.Size = new System.Drawing.Size(33, 13);
            this.lblClienteCalle.TabIndex = 14;
            this.lblClienteCalle.Text = "Calle:";
            // 
            // lblClienteLocalidad
            // 
            this.lblClienteLocalidad.AutoSize = true;
            this.lblClienteLocalidad.Location = new System.Drawing.Point(312, 37);
            this.lblClienteLocalidad.Name = "lblClienteLocalidad";
            this.lblClienteLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblClienteLocalidad.TabIndex = 20;
            this.lblClienteLocalidad.Text = "Localidad:";
            // 
            // lblClienteDepto
            // 
            this.lblClienteDepto.AutoSize = true;
            this.lblClienteDepto.Location = new System.Drawing.Point(6, 73);
            this.lblClienteDepto.Name = "lblClienteDepto";
            this.lblClienteDepto.Size = new System.Drawing.Size(39, 13);
            this.lblClienteDepto.TabIndex = 18;
            this.lblClienteDepto.Text = "Depto:";
            // 
            // lblClienteCodigoPostal
            // 
            this.lblClienteCodigoPostal.AutoSize = true;
            this.lblClienteCodigoPostal.Location = new System.Drawing.Point(312, 55);
            this.lblClienteCodigoPostal.Name = "lblClienteCodigoPostal";
            this.lblClienteCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.lblClienteCodigoPostal.TabIndex = 24;
            this.lblClienteCodigoPostal.Text = "Codigo Postal:";
            // 
            // lblNroTicket
            // 
            this.lblNroTicket.AutoSize = true;
            this.lblNroTicket.Location = new System.Drawing.Point(246, 43);
            this.lblNroTicket.Name = "lblNroTicket";
            this.lblNroTicket.Size = new System.Drawing.Size(60, 13);
            this.lblNroTicket.TabIndex = 16;
            this.lblNroTicket.Text = "Nro Ticket:";
            // 
            // lvlNroTIcketValue
            // 
            this.lvlNroTIcketValue.AutoSize = true;
            this.lvlNroTIcketValue.Location = new System.Drawing.Point(314, 43);
            this.lvlNroTIcketValue.Name = "lvlNroTIcketValue";
            this.lvlNroTIcketValue.Size = new System.Drawing.Size(16, 13);
            this.lvlNroTIcketValue.TabIndex = 19;
            this.lvlNroTIcketValue.Text = "---";
            // 
            // lblTIpoService
            // 
            this.lblTIpoService.AutoSize = true;
            this.lblTIpoService.Location = new System.Drawing.Point(26, 234);
            this.lblTIpoService.Name = "lblTIpoService";
            this.lblTIpoService.Size = new System.Drawing.Size(70, 13);
            this.lblTIpoService.TabIndex = 20;
            this.lblTIpoService.Text = "Tipo Service:";
            // 
            // comboBoxTipoService
            // 
            this.comboBoxTipoService.FormattingEnabled = true;
            this.comboBoxTipoService.Location = new System.Drawing.Point(102, 231);
            this.comboBoxTipoService.Name = "comboBoxTipoService";
            this.comboBoxTipoService.Size = new System.Drawing.Size(204, 21);
            this.comboBoxTipoService.TabIndex = 21;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(329, 234);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 22;
            this.lblTurno.Text = "Turno:";
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.Location = new System.Drawing.Point(505, 258);
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Size = new System.Drawing.Size(92, 23);
            this.btnAsignarTurno.TabIndex = 23;
            this.btnAsignarTurno.Text = "Asignar Turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = true;
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // lblTurnoValue
            // 
            this.lblTurnoValue.AutoSize = true;
            this.lblTurnoValue.Location = new System.Drawing.Point(379, 234);
            this.lblTurnoValue.Name = "lblTurnoValue";
            this.lblTurnoValue.Size = new System.Drawing.Size(25, 13);
            this.lblTurnoValue.TabIndex = 24;
            this.lblTurnoValue.Text = "------";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(26, 283);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 13);
            this.lblNotas.TabIndex = 25;
            this.lblNotas.Text = "Notas:";
            // 
            // textBoxNotas
            // 
            this.textBoxNotas.Location = new System.Drawing.Point(71, 287);
            this.textBoxNotas.Multiline = true;
            this.textBoxNotas.Name = "textBoxNotas";
            this.textBoxNotas.Size = new System.Drawing.Size(526, 120);
            this.textBoxNotas.TabIndex = 26;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(522, 424);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 27;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblNroOrdenTecnica
            // 
            this.lblNroOrdenTecnica.AutoSize = true;
            this.lblNroOrdenTecnica.Location = new System.Drawing.Point(23, 43);
            this.lblNroOrdenTecnica.Name = "lblNroOrdenTecnica";
            this.lblNroOrdenTecnica.Size = new System.Drawing.Size(101, 13);
            this.lblNroOrdenTecnica.TabIndex = 28;
            this.lblNroOrdenTecnica.Text = "Nro Orden Tecnica:";
            // 
            // lblNroOrdenTecnicaValue
            // 
            this.lblNroOrdenTecnicaValue.AutoSize = true;
            this.lblNroOrdenTecnicaValue.Location = new System.Drawing.Point(130, 43);
            this.lblNroOrdenTecnicaValue.Name = "lblNroOrdenTecnicaValue";
            this.lblNroOrdenTecnicaValue.Size = new System.Drawing.Size(16, 13);
            this.lblNroOrdenTecnicaValue.TabIndex = 29;
            this.lblNroOrdenTecnicaValue.Text = "---";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(441, 424);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 30;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmOrdenTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 463);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNroOrdenTecnicaValue);
            this.Controls.Add(this.lblNroOrdenTecnica);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textBoxNotas);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lblTurnoValue);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.comboBoxTipoService);
            this.Controls.Add(this.lblTIpoService);
            this.Controls.Add(this.lvlNroTIcketValue);
            this.Controls.Add(this.lblNroTicket);
            this.Controls.Add(this.groupBoxDomicilio);
            this.Controls.Add(this.groupBoxinfoClientes);
            this.Controls.Add(this.lblTituloOrdenTecnica);
            this.Name = "frmOrdenTecnica";
            this.Text = "frmOrdenTecnica";
            this.Load += new System.EventHandler(this.frmOrdenTecnica_Load);
            this.groupBoxinfoClientes.ResumeLayout(false);
            this.groupBoxinfoClientes.PerformLayout();
            this.groupBoxDomicilio.ResumeLayout(false);
            this.groupBoxDomicilio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloOrdenTecnica;
        private System.Windows.Forms.GroupBox groupBoxinfoClientes;
        private System.Windows.Forms.Label lblValueNombre;
        private System.Windows.Forms.Label lblValueNroCliente;
        private System.Windows.Forms.Label lblFullNombre;
        private System.Windows.Forms.Label labelNroCliente;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox groupBoxDomicilio;
        private System.Windows.Forms.Label lblValueNodoRed;
        private System.Windows.Forms.Label lblValueAltura;
        private System.Windows.Forms.Label lblValuePiso;
        private System.Windows.Forms.Label lblValueProcincia;
        private System.Windows.Forms.Label lblValueCalle;
        private System.Windows.Forms.Label lblValueLocalidad;
        private System.Windows.Forms.Label lblValueDepto;
        private System.Windows.Forms.Label lblValueCodigoPostal;
        private System.Windows.Forms.Label lblClienteNododeRed;
        private System.Windows.Forms.Label lblClienteAltura;
        private System.Windows.Forms.Label lblClientePiso;
        private System.Windows.Forms.Label lblClienteProvincia;
        private System.Windows.Forms.Label lblClienteCalle;
        private System.Windows.Forms.Label lblClienteLocalidad;
        private System.Windows.Forms.Label lblClienteDepto;
        private System.Windows.Forms.Label lblClienteCodigoPostal;
        private System.Windows.Forms.Label lblNroTicket;
        private System.Windows.Forms.Label lvlNroTIcketValue;
        private System.Windows.Forms.Label lblTIpoService;
        private System.Windows.Forms.ComboBox comboBoxTipoService;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Label lblTurnoValue;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.TextBox textBoxNotas;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblNroOrdenTecnica;
        private System.Windows.Forms.Label lblNroOrdenTecnicaValue;
        private System.Windows.Forms.Button btnCerrar;
    }
}