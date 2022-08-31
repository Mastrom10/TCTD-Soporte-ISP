namespace GUI
{
    partial class frmSoporteClientes
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxDNICliente = new System.Windows.Forms.TextBox();
            this.textBoxNroClienteID = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
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
            this.groupBoxDatosContacto = new System.Windows.Forms.GroupBox();
            this.lblValueTelPrincipal = new System.Windows.Forms.Label();
            this.lblValueTelSecundario = new System.Windows.Forms.Label();
            this.lblValueEmail = new System.Windows.Forms.Label();
            this.lblTelPrincipal = new System.Windows.Forms.Label();
            this.lblTelSecundario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.lblValueFNacimiento = new System.Windows.Forms.Label();
            this.lblValueNombre = new System.Windows.Forms.Label();
            this.lblValueApellido = new System.Windows.Forms.Label();
            this.lblValueDNI = new System.Windows.Forms.Label();
            this.lblValueNroCliente = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.labelNroCliente = new System.Windows.Forms.Label();
            this.groupBoxServicio = new System.Windows.Forms.GroupBox();
            this.lblValueDispositivos = new System.Windows.Forms.Label();
            this.lblValueEstado = new System.Windows.Forms.Label();
            this.lblValuePlanServicio = new System.Windows.Forms.Label();
            this.labelDispositivos = new System.Windows.Forms.Label();
            this.lblEstadoServicio = new System.Windows.Forms.Label();
            this.lblServicePlan = new System.Windows.Forms.Label();
            this.groupBoxUltimosTickets = new System.Windows.Forms.GroupBox();
            this.btnVerTicket = new System.Windows.Forms.Button();
            this.listBoxTicketCliente = new System.Windows.Forms.ListBox();
            this.btnCrearTicket = new System.Windows.Forms.Button();
            this.groupBoxBuscarCliente.SuspendLayout();
            this.groupBoxDomicilio.SuspendLayout();
            this.groupBoxDatosContacto.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            this.groupBoxServicio.SuspendLayout();
            this.groupBoxUltimosTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBuscarCliente
            // 
            this.groupBoxBuscarCliente.Controls.Add(this.btnLimpiar);
            this.groupBoxBuscarCliente.Controls.Add(this.btnModificar);
            this.groupBoxBuscarCliente.Controls.Add(this.btnBuscar);
            this.groupBoxBuscarCliente.Controls.Add(this.textBoxDNICliente);
            this.groupBoxBuscarCliente.Controls.Add(this.textBoxNroClienteID);
            this.groupBoxBuscarCliente.Controls.Add(this.lblDNICliente);
            this.groupBoxBuscarCliente.Controls.Add(this.lblNroCliente);
            this.groupBoxBuscarCliente.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBuscarCliente.Name = "groupBoxBuscarCliente";
            this.groupBoxBuscarCliente.Size = new System.Drawing.Size(677, 45);
            this.groupBoxBuscarCliente.TabIndex = 2;
            this.groupBoxBuscarCliente.TabStop = false;
            this.groupBoxBuscarCliente.Text = "Buscar Cliente";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(594, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(513, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            this.groupBoxDomicilio.Location = new System.Drawing.Point(401, 63);
            this.groupBoxDomicilio.Name = "groupBoxDomicilio";
            this.groupBoxDomicilio.Size = new System.Drawing.Size(287, 168);
            this.groupBoxDomicilio.TabIndex = 17;
            this.groupBoxDomicilio.TabStop = false;
            this.groupBoxDomicilio.Text = "Domicilio";
            // 
            // lblValueNodoRed
            // 
            this.lblValueNodoRed.AutoSize = true;
            this.lblValueNodoRed.Location = new System.Drawing.Point(121, 145);
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
            this.lblValueProcincia.Location = new System.Drawing.Point(121, 91);
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
            this.lblValueLocalidad.Location = new System.Drawing.Point(121, 109);
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
            this.lblValueCodigoPostal.Location = new System.Drawing.Point(121, 127);
            this.lblValueCodigoPostal.Name = "lblValueCodigoPostal";
            this.lblValueCodigoPostal.Size = new System.Drawing.Size(16, 13);
            this.lblValueCodigoPostal.TabIndex = 33;
            this.lblValueCodigoPostal.Text = "---";
            // 
            // lblClienteNododeRed
            // 
            this.lblClienteNododeRed.AutoSize = true;
            this.lblClienteNododeRed.Location = new System.Drawing.Point(6, 145);
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
            this.lblClienteProvincia.Location = new System.Drawing.Point(6, 91);
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
            this.lblClienteLocalidad.Location = new System.Drawing.Point(6, 109);
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
            this.lblClienteCodigoPostal.Location = new System.Drawing.Point(6, 127);
            this.lblClienteCodigoPostal.Name = "lblClienteCodigoPostal";
            this.lblClienteCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.lblClienteCodigoPostal.TabIndex = 24;
            this.lblClienteCodigoPostal.Text = "Codigo Postal:";
            // 
            // groupBoxDatosContacto
            // 
            this.groupBoxDatosContacto.Controls.Add(this.lblValueTelPrincipal);
            this.groupBoxDatosContacto.Controls.Add(this.lblValueTelSecundario);
            this.groupBoxDatosContacto.Controls.Add(this.lblValueEmail);
            this.groupBoxDatosContacto.Controls.Add(this.lblTelPrincipal);
            this.groupBoxDatosContacto.Controls.Add(this.lblTelSecundario);
            this.groupBoxDatosContacto.Controls.Add(this.lblEmail);
            this.groupBoxDatosContacto.Location = new System.Drawing.Point(12, 161);
            this.groupBoxDatosContacto.Name = "groupBoxDatosContacto";
            this.groupBoxDatosContacto.Size = new System.Drawing.Size(384, 70);
            this.groupBoxDatosContacto.TabIndex = 16;
            this.groupBoxDatosContacto.TabStop = false;
            this.groupBoxDatosContacto.Text = "Datos de Contacto";
            // 
            // lblValueTelPrincipal
            // 
            this.lblValueTelPrincipal.AutoSize = true;
            this.lblValueTelPrincipal.Location = new System.Drawing.Point(147, 14);
            this.lblValueTelPrincipal.Name = "lblValueTelPrincipal";
            this.lblValueTelPrincipal.Size = new System.Drawing.Size(16, 13);
            this.lblValueTelPrincipal.TabIndex = 17;
            this.lblValueTelPrincipal.Text = "---";
            // 
            // lblValueTelSecundario
            // 
            this.lblValueTelSecundario.AutoSize = true;
            this.lblValueTelSecundario.Location = new System.Drawing.Point(147, 29);
            this.lblValueTelSecundario.Name = "lblValueTelSecundario";
            this.lblValueTelSecundario.Size = new System.Drawing.Size(16, 13);
            this.lblValueTelSecundario.TabIndex = 19;
            this.lblValueTelSecundario.Text = "---";
            // 
            // lblValueEmail
            // 
            this.lblValueEmail.AutoSize = true;
            this.lblValueEmail.Location = new System.Drawing.Point(147, 44);
            this.lblValueEmail.Name = "lblValueEmail";
            this.lblValueEmail.Size = new System.Drawing.Size(16, 13);
            this.lblValueEmail.TabIndex = 18;
            this.lblValueEmail.Text = "---";
            // 
            // lblTelPrincipal
            // 
            this.lblTelPrincipal.AutoSize = true;
            this.lblTelPrincipal.Location = new System.Drawing.Point(9, 16);
            this.lblTelPrincipal.Name = "lblTelPrincipal";
            this.lblTelPrincipal.Size = new System.Drawing.Size(95, 13);
            this.lblTelPrincipal.TabIndex = 12;
            this.lblTelPrincipal.Text = "Telefono Principal:";
            // 
            // lblTelSecundario
            // 
            this.lblTelSecundario.AutoSize = true;
            this.lblTelSecundario.Location = new System.Drawing.Point(9, 31);
            this.lblTelSecundario.Name = "lblTelSecundario";
            this.lblTelSecundario.Size = new System.Drawing.Size(109, 13);
            this.lblTelSecundario.TabIndex = 16;
            this.lblTelSecundario.Text = "Telefono Secundario:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(9, 46);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.Controls.Add(this.lblValueFNacimiento);
            this.groupBoxInfoCliente.Controls.Add(this.lblValueNombre);
            this.groupBoxInfoCliente.Controls.Add(this.lblValueApellido);
            this.groupBoxInfoCliente.Controls.Add(this.lblValueDNI);
            this.groupBoxInfoCliente.Controls.Add(this.lblValueNroCliente);
            this.groupBoxInfoCliente.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxInfoCliente.Controls.Add(this.lblNombre);
            this.groupBoxInfoCliente.Controls.Add(this.lblApellido);
            this.groupBoxInfoCliente.Controls.Add(this.lblDNI);
            this.groupBoxInfoCliente.Controls.Add(this.labelNroCliente);
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(12, 63);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(383, 97);
            this.groupBoxInfoCliente.TabIndex = 15;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Datos Personales";
            // 
            // lblValueFNacimiento
            // 
            this.lblValueFNacimiento.AutoSize = true;
            this.lblValueFNacimiento.Location = new System.Drawing.Point(147, 75);
            this.lblValueFNacimiento.Name = "lblValueFNacimiento";
            this.lblValueFNacimiento.Size = new System.Drawing.Size(16, 13);
            this.lblValueFNacimiento.TabIndex = 16;
            this.lblValueFNacimiento.Text = "---";
            // 
            // lblValueNombre
            // 
            this.lblValueNombre.AutoSize = true;
            this.lblValueNombre.Location = new System.Drawing.Point(146, 33);
            this.lblValueNombre.Name = "lblValueNombre";
            this.lblValueNombre.Size = new System.Drawing.Size(16, 13);
            this.lblValueNombre.TabIndex = 12;
            this.lblValueNombre.Text = "---";
            // 
            // lblValueApellido
            // 
            this.lblValueApellido.AutoSize = true;
            this.lblValueApellido.Location = new System.Drawing.Point(148, 61);
            this.lblValueApellido.Name = "lblValueApellido";
            this.lblValueApellido.Size = new System.Drawing.Size(16, 13);
            this.lblValueApellido.TabIndex = 13;
            this.lblValueApellido.Text = "---";
            // 
            // lblValueDNI
            // 
            this.lblValueDNI.AutoSize = true;
            this.lblValueDNI.Location = new System.Drawing.Point(147, 47);
            this.lblValueDNI.Name = "lblValueDNI";
            this.lblValueDNI.Size = new System.Drawing.Size(16, 13);
            this.lblValueDNI.TabIndex = 15;
            this.lblValueDNI.Text = "---";
            // 
            // lblValueNroCliente
            // 
            this.lblValueNroCliente.AutoSize = true;
            this.lblValueNroCliente.Location = new System.Drawing.Point(146, 19);
            this.lblValueNroCliente.Name = "lblValueNroCliente";
            this.lblValueNroCliente.Size = new System.Drawing.Size(16, 13);
            this.lblValueNroCliente.TabIndex = 14;
            this.lblValueNroCliente.Text = "---";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(8, 75);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(75, 13);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "F. Nacimiento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(45, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apelido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(8, 47);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI:";
            // 
            // labelNroCliente
            // 
            this.labelNroCliente.AutoSize = true;
            this.labelNroCliente.Location = new System.Drawing.Point(7, 19);
            this.labelNroCliente.Name = "labelNroCliente";
            this.labelNroCliente.Size = new System.Drawing.Size(62, 13);
            this.labelNroCliente.TabIndex = 6;
            this.labelNroCliente.Text = "Nro Cliente:";
            // 
            // groupBoxServicio
            // 
            this.groupBoxServicio.Controls.Add(this.lblValueDispositivos);
            this.groupBoxServicio.Controls.Add(this.lblValueEstado);
            this.groupBoxServicio.Controls.Add(this.lblValuePlanServicio);
            this.groupBoxServicio.Controls.Add(this.labelDispositivos);
            this.groupBoxServicio.Controls.Add(this.lblEstadoServicio);
            this.groupBoxServicio.Controls.Add(this.lblServicePlan);
            this.groupBoxServicio.Location = new System.Drawing.Point(12, 237);
            this.groupBoxServicio.Name = "groupBoxServicio";
            this.groupBoxServicio.Size = new System.Drawing.Size(676, 65);
            this.groupBoxServicio.TabIndex = 18;
            this.groupBoxServicio.TabStop = false;
            this.groupBoxServicio.Text = "Servicio";
            // 
            // lblValueDispositivos
            // 
            this.lblValueDispositivos.AutoSize = true;
            this.lblValueDispositivos.Location = new System.Drawing.Point(395, 16);
            this.lblValueDispositivos.Name = "lblValueDispositivos";
            this.lblValueDispositivos.Size = new System.Drawing.Size(16, 13);
            this.lblValueDispositivos.TabIndex = 32;
            this.lblValueDispositivos.Text = "---";
            // 
            // lblValueEstado
            // 
            this.lblValueEstado.AutoSize = true;
            this.lblValueEstado.Location = new System.Drawing.Point(148, 22);
            this.lblValueEstado.Name = "lblValueEstado";
            this.lblValueEstado.Size = new System.Drawing.Size(16, 13);
            this.lblValueEstado.TabIndex = 30;
            this.lblValueEstado.Text = "---";
            // 
            // lblValuePlanServicio
            // 
            this.lblValuePlanServicio.AutoSize = true;
            this.lblValuePlanServicio.Location = new System.Drawing.Point(148, 42);
            this.lblValuePlanServicio.Name = "lblValuePlanServicio";
            this.lblValuePlanServicio.Size = new System.Drawing.Size(16, 13);
            this.lblValuePlanServicio.TabIndex = 31;
            this.lblValuePlanServicio.Text = "---";
            // 
            // labelDispositivos
            // 
            this.labelDispositivos.AutoSize = true;
            this.labelDispositivos.Location = new System.Drawing.Point(320, 16);
            this.labelDispositivos.Name = "labelDispositivos";
            this.labelDispositivos.Size = new System.Drawing.Size(63, 13);
            this.labelDispositivos.TabIndex = 29;
            this.labelDispositivos.Text = "Dispositivos";
            // 
            // lblEstadoServicio
            // 
            this.lblEstadoServicio.AutoSize = true;
            this.lblEstadoServicio.Location = new System.Drawing.Point(9, 22);
            this.lblEstadoServicio.Name = "lblEstadoServicio";
            this.lblEstadoServicio.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoServicio.TabIndex = 18;
            this.lblEstadoServicio.Text = "Estado:";
            // 
            // lblServicePlan
            // 
            this.lblServicePlan.AutoSize = true;
            this.lblServicePlan.Location = new System.Drawing.Point(8, 42);
            this.lblServicePlan.Name = "lblServicePlan";
            this.lblServicePlan.Size = new System.Drawing.Size(87, 13);
            this.lblServicePlan.TabIndex = 20;
            this.lblServicePlan.Text = "Plan de Servicio:";
            // 
            // groupBoxUltimosTickets
            // 
            this.groupBoxUltimosTickets.Controls.Add(this.btnVerTicket);
            this.groupBoxUltimosTickets.Controls.Add(this.listBoxTicketCliente);
            this.groupBoxUltimosTickets.Controls.Add(this.btnCrearTicket);
            this.groupBoxUltimosTickets.Location = new System.Drawing.Point(12, 308);
            this.groupBoxUltimosTickets.Name = "groupBoxUltimosTickets";
            this.groupBoxUltimosTickets.Size = new System.Drawing.Size(676, 211);
            this.groupBoxUltimosTickets.TabIndex = 33;
            this.groupBoxUltimosTickets.TabStop = false;
            this.groupBoxUltimosTickets.Text = "Ultimos Tickets";
            // 
            // btnVerTicket
            // 
            this.btnVerTicket.Enabled = false;
            this.btnVerTicket.Location = new System.Drawing.Point(594, 28);
            this.btnVerTicket.Name = "btnVerTicket";
            this.btnVerTicket.Size = new System.Drawing.Size(75, 23);
            this.btnVerTicket.TabIndex = 2;
            this.btnVerTicket.Text = "Ver Ticket";
            this.btnVerTicket.UseVisualStyleBackColor = true;
            this.btnVerTicket.Click += new System.EventHandler(this.btnVerTicket_Click);
            // 
            // listBoxTicketCliente
            // 
            this.listBoxTicketCliente.Enabled = false;
            this.listBoxTicketCliente.FormattingEnabled = true;
            this.listBoxTicketCliente.Location = new System.Drawing.Point(12, 28);
            this.listBoxTicketCliente.Name = "listBoxTicketCliente";
            this.listBoxTicketCliente.Size = new System.Drawing.Size(576, 173);
            this.listBoxTicketCliente.TabIndex = 1;
            this.listBoxTicketCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxTicketCliente_SelectedIndexChanged);
            // 
            // btnCrearTicket
            // 
            this.btnCrearTicket.Location = new System.Drawing.Point(595, 57);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTicket.TabIndex = 0;
            this.btnCrearTicket.Text = "Crear Ticket";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // frmSoporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 600);
            this.Controls.Add(this.groupBoxUltimosTickets);
            this.Controls.Add(this.groupBoxServicio);
            this.Controls.Add(this.groupBoxDomicilio);
            this.Controls.Add(this.groupBoxDatosContacto);
            this.Controls.Add(this.groupBoxInfoCliente);
            this.Controls.Add(this.groupBoxBuscarCliente);
            this.Name = "frmSoporteClientes";
            this.Text = "frmSoporteClientes";
            this.Load += new System.EventHandler(this.frmSoporteClientes_Load);
            this.Enter += new System.EventHandler(this.frmSoporteClientes_Enter);
            this.groupBoxBuscarCliente.ResumeLayout(false);
            this.groupBoxBuscarCliente.PerformLayout();
            this.groupBoxDomicilio.ResumeLayout(false);
            this.groupBoxDomicilio.PerformLayout();
            this.groupBoxDatosContacto.ResumeLayout(false);
            this.groupBoxDatosContacto.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            this.groupBoxServicio.ResumeLayout(false);
            this.groupBoxServicio.PerformLayout();
            this.groupBoxUltimosTickets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxDNICliente;
        private System.Windows.Forms.TextBox textBoxNroClienteID;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBoxDomicilio;
        private System.Windows.Forms.Label lblClienteNododeRed;
        private System.Windows.Forms.Label lblClienteProvincia;
        private System.Windows.Forms.Label lblClienteLocalidad;
        private System.Windows.Forms.Label lblClienteCodigoPostal;
        private System.Windows.Forms.Label lblClienteDepto;
        private System.Windows.Forms.Label lblClienteCalle;
        private System.Windows.Forms.Label lblClienteAltura;
        private System.Windows.Forms.Label lblClientePiso;
        private System.Windows.Forms.GroupBox groupBoxDatosContacto;
        private System.Windows.Forms.Label lblTelPrincipal;
        private System.Windows.Forms.Label lblTelSecundario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label labelNroCliente;
        private System.Windows.Forms.Label lblValueNodoRed;
        private System.Windows.Forms.Label lblValueAltura;
        private System.Windows.Forms.Label lblValuePiso;
        private System.Windows.Forms.Label lblValueProcincia;
        private System.Windows.Forms.Label lblValueCalle;
        private System.Windows.Forms.Label lblValueLocalidad;
        private System.Windows.Forms.Label lblValueDepto;
        private System.Windows.Forms.Label lblValueCodigoPostal;
        private System.Windows.Forms.Label lblValueTelPrincipal;
        private System.Windows.Forms.Label lblValueTelSecundario;
        private System.Windows.Forms.Label lblValueEmail;
        private System.Windows.Forms.Label lblValueFNacimiento;
        private System.Windows.Forms.Label lblValueNombre;
        private System.Windows.Forms.Label lblValueApellido;
        private System.Windows.Forms.Label lblValueDNI;
        private System.Windows.Forms.Label lblValueNroCliente;
        private System.Windows.Forms.GroupBox groupBoxServicio;
        private System.Windows.Forms.Label lblValueDispositivos;
        private System.Windows.Forms.Label lblValueEstado;
        private System.Windows.Forms.Label lblValuePlanServicio;
        private System.Windows.Forms.Label labelDispositivos;
        private System.Windows.Forms.Label lblEstadoServicio;
        private System.Windows.Forms.Label lblServicePlan;
        private System.Windows.Forms.GroupBox groupBoxUltimosTickets;
        private System.Windows.Forms.Button btnCrearTicket;
        private System.Windows.Forms.ListBox listBoxTicketCliente;
        private System.Windows.Forms.Button btnVerTicket;
    }
}