namespace GUI
{
    partial class frmGestorClientes
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
            this.lblTituloGestorClientes = new System.Windows.Forms.Label();
            this.groupBoxBuscarCliente = new System.Windows.Forms.GroupBox();
            this.buttonGuadar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxDNICliente = new System.Windows.Forms.TextBox();
            this.textBoxNroClienteID = new System.Windows.Forms.TextBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBoxNroCliente = new System.Windows.Forms.TextBox();
            this.labelNroCliente = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.groupBoxInfoCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxDatosContacto = new System.Windows.Forms.GroupBox();
            this.textBoxTelPrincipal = new System.Windows.Forms.TextBox();
            this.lblTelPrincipal = new System.Windows.Forms.Label();
            this.lblTelSecundario = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelSecundario = new System.Windows.Forms.TextBox();
            this.groupBoxDomicilio = new System.Windows.Forms.GroupBox();
            this.comboBoxNodosDeRed = new System.Windows.Forms.ComboBox();
            this.lblClienteNododeRed = new System.Windows.Forms.Label();
            this.textBoxClienteLocalidad = new System.Windows.Forms.TextBox();
            this.lblClienteProvincia = new System.Windows.Forms.Label();
            this.lblClienteLocalidad = new System.Windows.Forms.Label();
            this.textBoxClienteProvincia = new System.Windows.Forms.TextBox();
            this.textBoxClienteCodigoPostal = new System.Windows.Forms.TextBox();
            this.lblClienteCodigoPostal = new System.Windows.Forms.Label();
            this.textBoxClienteDepto = new System.Windows.Forms.TextBox();
            this.lblClienteDepto = new System.Windows.Forms.Label();
            this.textBoxtextBoxClienteAltura = new System.Windows.Forms.TextBox();
            this.lblClienteCalle = new System.Windows.Forms.Label();
            this.lblClienteAltura = new System.Windows.Forms.Label();
            this.textBoxClienteCalle = new System.Windows.Forms.TextBox();
            this.textBoxClientePiso = new System.Windows.Forms.TextBox();
            this.lblClientePiso = new System.Windows.Forms.Label();
            this.groupBoxServicio = new System.Windows.Forms.GroupBox();
            this.buttonGestionarDispositivos = new System.Windows.Forms.Button();
            this.comboBoxEstadoServicio = new System.Windows.Forms.ComboBox();
            this.listBoxDispositivos = new System.Windows.Forms.ListBox();
            this.labelDispositivos = new System.Windows.Forms.Label();
            this.comboBoxServicePlan = new System.Windows.Forms.ComboBox();
            this.lblEstadoServicio = new System.Windows.Forms.Label();
            this.lblServicePlan = new System.Windows.Forms.Label();
            this.groupBoxBuscarCliente.SuspendLayout();
            this.groupBoxInfoCliente.SuspendLayout();
            this.groupBoxDatosContacto.SuspendLayout();
            this.groupBoxDomicilio.SuspendLayout();
            this.groupBoxServicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloGestorClientes
            // 
            this.lblTituloGestorClientes.AutoSize = true;
            this.lblTituloGestorClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGestorClientes.Location = new System.Drawing.Point(13, 9);
            this.lblTituloGestorClientes.Name = "lblTituloGestorClientes";
            this.lblTituloGestorClientes.Size = new System.Drawing.Size(167, 20);
            this.lblTituloGestorClientes.TabIndex = 0;
            this.lblTituloGestorClientes.Text = "Gestion de Clientes";
            // 
            // groupBoxBuscarCliente
            // 
            this.groupBoxBuscarCliente.Controls.Add(this.buttonGuadar);
            this.groupBoxBuscarCliente.Controls.Add(this.buttonNuevo);
            this.groupBoxBuscarCliente.Controls.Add(this.btnBuscar);
            this.groupBoxBuscarCliente.Controls.Add(this.textBoxDNICliente);
            this.groupBoxBuscarCliente.Controls.Add(this.textBoxNroClienteID);
            this.groupBoxBuscarCliente.Controls.Add(this.lblDNICliente);
            this.groupBoxBuscarCliente.Controls.Add(this.lblNroCliente);
            this.groupBoxBuscarCliente.Location = new System.Drawing.Point(17, 37);
            this.groupBoxBuscarCliente.Name = "groupBoxBuscarCliente";
            this.groupBoxBuscarCliente.Size = new System.Drawing.Size(681, 45);
            this.groupBoxBuscarCliente.TabIndex = 1;
            this.groupBoxBuscarCliente.TabStop = false;
            this.groupBoxBuscarCliente.Text = "Buscar Cliente";
            // 
            // buttonGuadar
            // 
            this.buttonGuadar.Location = new System.Drawing.Point(594, 13);
            this.buttonGuadar.Name = "buttonGuadar";
            this.buttonGuadar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuadar.TabIndex = 6;
            this.buttonGuadar.Text = "Guardar";
            this.buttonGuadar.UseVisualStyleBackColor = true;
            this.buttonGuadar.Click += new System.EventHandler(this.buttonGuadar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(513, 13);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 5;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
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
            this.textBoxDNICliente.TextChanged += new System.EventHandler(this.textBoxDNICliente_TextChanged);
            // 
            // textBoxNroClienteID
            // 
            this.textBoxNroClienteID.Location = new System.Drawing.Point(91, 16);
            this.textBoxNroClienteID.Name = "textBoxNroClienteID";
            this.textBoxNroClienteID.Size = new System.Drawing.Size(112, 20);
            this.textBoxNroClienteID.TabIndex = 2;
            this.textBoxNroClienteID.TextChanged += new System.EventHandler(this.textBoxNroClienteID_TextChanged);
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(91, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(202, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(382, 48);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(290, 20);
            this.textBoxApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(299, 51);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(45, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apelido:";
            // 
            // textBoxNroCliente
            // 
            this.textBoxNroCliente.Enabled = false;
            this.textBoxNroCliente.Location = new System.Drawing.Point(91, 22);
            this.textBoxNroCliente.Name = "textBoxNroCliente";
            this.textBoxNroCliente.Size = new System.Drawing.Size(202, 20);
            this.textBoxNroCliente.TabIndex = 9;
            // 
            // labelNroCliente
            // 
            this.labelNroCliente.AutoSize = true;
            this.labelNroCliente.Location = new System.Drawing.Point(10, 25);
            this.labelNroCliente.Name = "labelNroCliente";
            this.labelNroCliente.Size = new System.Drawing.Size(62, 13);
            this.labelNroCliente.TabIndex = 6;
            this.labelNroCliente.Text = "Nro Cliente:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(91, 74);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(202, 20);
            this.textBoxDNI.TabIndex = 7;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(10, 77);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI:";
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(382, 74);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(290, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 10;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(299, 80);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(75, 13);
            this.lblFechaNacimiento.TabIndex = 11;
            this.lblFechaNacimiento.Text = "F. Nacimiento:";
            // 
            // groupBoxInfoCliente
            // 
            this.groupBoxInfoCliente.Controls.Add(this.textBoxNombre);
            this.groupBoxInfoCliente.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxInfoCliente.Controls.Add(this.lblNombre);
            this.groupBoxInfoCliente.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxInfoCliente.Controls.Add(this.lblApellido);
            this.groupBoxInfoCliente.Controls.Add(this.textBoxDNI);
            this.groupBoxInfoCliente.Controls.Add(this.textBoxApellido);
            this.groupBoxInfoCliente.Controls.Add(this.lblDNI);
            this.groupBoxInfoCliente.Controls.Add(this.labelNroCliente);
            this.groupBoxInfoCliente.Controls.Add(this.textBoxNroCliente);
            this.groupBoxInfoCliente.Location = new System.Drawing.Point(17, 88);
            this.groupBoxInfoCliente.Name = "groupBoxInfoCliente";
            this.groupBoxInfoCliente.Size = new System.Drawing.Size(681, 105);
            this.groupBoxInfoCliente.TabIndex = 12;
            this.groupBoxInfoCliente.TabStop = false;
            this.groupBoxInfoCliente.Text = "Datos Personales";
            // 
            // groupBoxDatosContacto
            // 
            this.groupBoxDatosContacto.Controls.Add(this.textBoxTelPrincipal);
            this.groupBoxDatosContacto.Controls.Add(this.lblTelPrincipal);
            this.groupBoxDatosContacto.Controls.Add(this.lblTelSecundario);
            this.groupBoxDatosContacto.Controls.Add(this.lblEmail);
            this.groupBoxDatosContacto.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosContacto.Controls.Add(this.textBoxTelSecundario);
            this.groupBoxDatosContacto.Location = new System.Drawing.Point(17, 199);
            this.groupBoxDatosContacto.Name = "groupBoxDatosContacto";
            this.groupBoxDatosContacto.Size = new System.Drawing.Size(681, 74);
            this.groupBoxDatosContacto.TabIndex = 13;
            this.groupBoxDatosContacto.TabStop = false;
            this.groupBoxDatosContacto.Text = "Datos de Contacto";
            // 
            // textBoxTelPrincipal
            // 
            this.textBoxTelPrincipal.Location = new System.Drawing.Point(130, 19);
            this.textBoxTelPrincipal.Name = "textBoxTelPrincipal";
            this.textBoxTelPrincipal.Size = new System.Drawing.Size(150, 20);
            this.textBoxTelPrincipal.TabIndex = 13;
            // 
            // lblTelPrincipal
            // 
            this.lblTelPrincipal.AutoSize = true;
            this.lblTelPrincipal.Location = new System.Drawing.Point(10, 22);
            this.lblTelPrincipal.Name = "lblTelPrincipal";
            this.lblTelPrincipal.Size = new System.Drawing.Size(92, 13);
            this.lblTelPrincipal.TabIndex = 12;
            this.lblTelPrincipal.Text = "Telefono Principal";
            // 
            // lblTelSecundario
            // 
            this.lblTelSecundario.AutoSize = true;
            this.lblTelSecundario.Location = new System.Drawing.Point(10, 48);
            this.lblTelSecundario.Name = "lblTelSecundario";
            this.lblTelSecundario.Size = new System.Drawing.Size(109, 13);
            this.lblTelSecundario.TabIndex = 16;
            this.lblTelSecundario.Text = "Telefono Secundario:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(299, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(382, 19);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(290, 20);
            this.textBoxEmail.TabIndex = 17;
            // 
            // textBoxTelSecundario
            // 
            this.textBoxTelSecundario.Location = new System.Drawing.Point(130, 45);
            this.textBoxTelSecundario.Name = "textBoxTelSecundario";
            this.textBoxTelSecundario.Size = new System.Drawing.Size(150, 20);
            this.textBoxTelSecundario.TabIndex = 15;
            // 
            // groupBoxDomicilio
            // 
            this.groupBoxDomicilio.Controls.Add(this.comboBoxNodosDeRed);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteNododeRed);
            this.groupBoxDomicilio.Controls.Add(this.textBoxClienteLocalidad);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteProvincia);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteLocalidad);
            this.groupBoxDomicilio.Controls.Add(this.textBoxClienteProvincia);
            this.groupBoxDomicilio.Controls.Add(this.textBoxClienteCodigoPostal);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteCodigoPostal);
            this.groupBoxDomicilio.Controls.Add(this.textBoxClienteDepto);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteDepto);
            this.groupBoxDomicilio.Controls.Add(this.textBoxtextBoxClienteAltura);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteCalle);
            this.groupBoxDomicilio.Controls.Add(this.lblClienteAltura);
            this.groupBoxDomicilio.Controls.Add(this.textBoxClienteCalle);
            this.groupBoxDomicilio.Controls.Add(this.textBoxClientePiso);
            this.groupBoxDomicilio.Controls.Add(this.lblClientePiso);
            this.groupBoxDomicilio.Location = new System.Drawing.Point(17, 279);
            this.groupBoxDomicilio.Name = "groupBoxDomicilio";
            this.groupBoxDomicilio.Size = new System.Drawing.Size(681, 136);
            this.groupBoxDomicilio.TabIndex = 14;
            this.groupBoxDomicilio.TabStop = false;
            this.groupBoxDomicilio.Text = "Domicilio";
            // 
            // comboBoxNodosDeRed
            // 
            this.comboBoxNodosDeRed.FormattingEnabled = true;
            this.comboBoxNodosDeRed.Location = new System.Drawing.Point(382, 102);
            this.comboBoxNodosDeRed.Name = "comboBoxNodosDeRed";
            this.comboBoxNodosDeRed.Size = new System.Drawing.Size(290, 21);
            this.comboBoxNodosDeRed.TabIndex = 27;
            // 
            // lblClienteNododeRed
            // 
            this.lblClienteNododeRed.AutoSize = true;
            this.lblClienteNododeRed.Location = new System.Drawing.Point(296, 105);
            this.lblClienteNododeRed.Name = "lblClienteNododeRed";
            this.lblClienteNododeRed.Size = new System.Drawing.Size(74, 13);
            this.lblClienteNododeRed.TabIndex = 26;
            this.lblClienteNododeRed.Text = "Nodo de Red:";
            // 
            // textBoxClienteLocalidad
            // 
            this.textBoxClienteLocalidad.Location = new System.Drawing.Point(382, 50);
            this.textBoxClienteLocalidad.Name = "textBoxClienteLocalidad";
            this.textBoxClienteLocalidad.Size = new System.Drawing.Size(290, 20);
            this.textBoxClienteLocalidad.TabIndex = 23;
            // 
            // lblClienteProvincia
            // 
            this.lblClienteProvincia.AutoSize = true;
            this.lblClienteProvincia.Location = new System.Drawing.Point(295, 27);
            this.lblClienteProvincia.Name = "lblClienteProvincia";
            this.lblClienteProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblClienteProvincia.TabIndex = 22;
            this.lblClienteProvincia.Text = "Provincia:";
            // 
            // lblClienteLocalidad
            // 
            this.lblClienteLocalidad.AutoSize = true;
            this.lblClienteLocalidad.Location = new System.Drawing.Point(295, 53);
            this.lblClienteLocalidad.Name = "lblClienteLocalidad";
            this.lblClienteLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblClienteLocalidad.TabIndex = 20;
            this.lblClienteLocalidad.Text = "Localidad:";
            // 
            // textBoxClienteProvincia
            // 
            this.textBoxClienteProvincia.Location = new System.Drawing.Point(382, 24);
            this.textBoxClienteProvincia.Name = "textBoxClienteProvincia";
            this.textBoxClienteProvincia.Size = new System.Drawing.Size(290, 20);
            this.textBoxClienteProvincia.TabIndex = 21;
            // 
            // textBoxClienteCodigoPostal
            // 
            this.textBoxClienteCodigoPostal.Location = new System.Drawing.Point(382, 76);
            this.textBoxClienteCodigoPostal.Name = "textBoxClienteCodigoPostal";
            this.textBoxClienteCodigoPostal.Size = new System.Drawing.Size(290, 20);
            this.textBoxClienteCodigoPostal.TabIndex = 25;
            // 
            // lblClienteCodigoPostal
            // 
            this.lblClienteCodigoPostal.AutoSize = true;
            this.lblClienteCodigoPostal.Location = new System.Drawing.Point(295, 79);
            this.lblClienteCodigoPostal.Name = "lblClienteCodigoPostal";
            this.lblClienteCodigoPostal.Size = new System.Drawing.Size(75, 13);
            this.lblClienteCodigoPostal.TabIndex = 24;
            this.lblClienteCodigoPostal.Text = "Codigo Postal:";
            // 
            // textBoxClienteDepto
            // 
            this.textBoxClienteDepto.Location = new System.Drawing.Point(78, 102);
            this.textBoxClienteDepto.Name = "textBoxClienteDepto";
            this.textBoxClienteDepto.Size = new System.Drawing.Size(202, 20);
            this.textBoxClienteDepto.TabIndex = 19;
            // 
            // lblClienteDepto
            // 
            this.lblClienteDepto.AutoSize = true;
            this.lblClienteDepto.Location = new System.Drawing.Point(10, 105);
            this.lblClienteDepto.Name = "lblClienteDepto";
            this.lblClienteDepto.Size = new System.Drawing.Size(39, 13);
            this.lblClienteDepto.TabIndex = 18;
            this.lblClienteDepto.Text = "Depto:";
            // 
            // textBoxtextBoxClienteAltura
            // 
            this.textBoxtextBoxClienteAltura.Location = new System.Drawing.Point(78, 50);
            this.textBoxtextBoxClienteAltura.Name = "textBoxtextBoxClienteAltura";
            this.textBoxtextBoxClienteAltura.Size = new System.Drawing.Size(202, 20);
            this.textBoxtextBoxClienteAltura.TabIndex = 15;
            // 
            // lblClienteCalle
            // 
            this.lblClienteCalle.AutoSize = true;
            this.lblClienteCalle.Location = new System.Drawing.Point(9, 27);
            this.lblClienteCalle.Name = "lblClienteCalle";
            this.lblClienteCalle.Size = new System.Drawing.Size(33, 13);
            this.lblClienteCalle.TabIndex = 14;
            this.lblClienteCalle.Text = "Calle:";
            // 
            // lblClienteAltura
            // 
            this.lblClienteAltura.AutoSize = true;
            this.lblClienteAltura.Location = new System.Drawing.Point(9, 53);
            this.lblClienteAltura.Name = "lblClienteAltura";
            this.lblClienteAltura.Size = new System.Drawing.Size(37, 13);
            this.lblClienteAltura.TabIndex = 12;
            this.lblClienteAltura.Text = "Altura:";
            // 
            // textBoxClienteCalle
            // 
            this.textBoxClienteCalle.Location = new System.Drawing.Point(78, 24);
            this.textBoxClienteCalle.Name = "textBoxClienteCalle";
            this.textBoxClienteCalle.Size = new System.Drawing.Size(202, 20);
            this.textBoxClienteCalle.TabIndex = 13;
            // 
            // textBoxClientePiso
            // 
            this.textBoxClientePiso.Location = new System.Drawing.Point(78, 76);
            this.textBoxClientePiso.Name = "textBoxClientePiso";
            this.textBoxClientePiso.Size = new System.Drawing.Size(202, 20);
            this.textBoxClientePiso.TabIndex = 17;
            // 
            // lblClientePiso
            // 
            this.lblClientePiso.AutoSize = true;
            this.lblClientePiso.Location = new System.Drawing.Point(9, 79);
            this.lblClientePiso.Name = "lblClientePiso";
            this.lblClientePiso.Size = new System.Drawing.Size(30, 13);
            this.lblClientePiso.TabIndex = 16;
            this.lblClientePiso.Text = "Piso:";
            // 
            // groupBoxServicio
            // 
            this.groupBoxServicio.Controls.Add(this.buttonGestionarDispositivos);
            this.groupBoxServicio.Controls.Add(this.comboBoxEstadoServicio);
            this.groupBoxServicio.Controls.Add(this.listBoxDispositivos);
            this.groupBoxServicio.Controls.Add(this.labelDispositivos);
            this.groupBoxServicio.Controls.Add(this.comboBoxServicePlan);
            this.groupBoxServicio.Controls.Add(this.lblEstadoServicio);
            this.groupBoxServicio.Controls.Add(this.lblServicePlan);
            this.groupBoxServicio.Location = new System.Drawing.Point(17, 421);
            this.groupBoxServicio.Name = "groupBoxServicio";
            this.groupBoxServicio.Size = new System.Drawing.Size(681, 70);
            this.groupBoxServicio.TabIndex = 15;
            this.groupBoxServicio.TabStop = false;
            this.groupBoxServicio.Text = "Servicio";
            // 
            // buttonGestionarDispositivos
            // 
            this.buttonGestionarDispositivos.Location = new System.Drawing.Point(298, 39);
            this.buttonGestionarDispositivos.Name = "buttonGestionarDispositivos";
            this.buttonGestionarDispositivos.Size = new System.Drawing.Size(75, 23);
            this.buttonGestionarDispositivos.TabIndex = 7;
            this.buttonGestionarDispositivos.Text = "Gestionar";
            this.buttonGestionarDispositivos.UseVisualStyleBackColor = true;
            this.buttonGestionarDispositivos.Click += new System.EventHandler(this.buttonGestionarDispositivos_Click);
            // 
            // comboBoxEstadoServicio
            // 
            this.comboBoxEstadoServicio.FormattingEnabled = true;
            this.comboBoxEstadoServicio.Location = new System.Drawing.Point(110, 19);
            this.comboBoxEstadoServicio.Name = "comboBoxEstadoServicio";
            this.comboBoxEstadoServicio.Size = new System.Drawing.Size(170, 21);
            this.comboBoxEstadoServicio.TabIndex = 31;
            // 
            // listBoxDispositivos
            // 
            this.listBoxDispositivos.FormattingEnabled = true;
            this.listBoxDispositivos.Location = new System.Drawing.Point(382, 19);
            this.listBoxDispositivos.Name = "listBoxDispositivos";
            this.listBoxDispositivos.Size = new System.Drawing.Size(290, 43);
            this.listBoxDispositivos.TabIndex = 30;
            // 
            // labelDispositivos
            // 
            this.labelDispositivos.AutoSize = true;
            this.labelDispositivos.Location = new System.Drawing.Point(295, 22);
            this.labelDispositivos.Name = "labelDispositivos";
            this.labelDispositivos.Size = new System.Drawing.Size(63, 13);
            this.labelDispositivos.TabIndex = 29;
            this.labelDispositivos.Text = "Dispositivos";
            // 
            // comboBoxServicePlan
            // 
            this.comboBoxServicePlan.FormattingEnabled = true;
            this.comboBoxServicePlan.Location = new System.Drawing.Point(110, 45);
            this.comboBoxServicePlan.Name = "comboBoxServicePlan";
            this.comboBoxServicePlan.Size = new System.Drawing.Size(170, 21);
            this.comboBoxServicePlan.TabIndex = 28;
            // 
            // lblEstadoServicio
            // 
            this.lblEstadoServicio.AutoSize = true;
            this.lblEstadoServicio.Location = new System.Drawing.Point(6, 22);
            this.lblEstadoServicio.Name = "lblEstadoServicio";
            this.lblEstadoServicio.Size = new System.Drawing.Size(43, 13);
            this.lblEstadoServicio.TabIndex = 18;
            this.lblEstadoServicio.Text = "Estado:";
            // 
            // lblServicePlan
            // 
            this.lblServicePlan.AutoSize = true;
            this.lblServicePlan.Location = new System.Drawing.Point(6, 48);
            this.lblServicePlan.Name = "lblServicePlan";
            this.lblServicePlan.Size = new System.Drawing.Size(87, 13);
            this.lblServicePlan.TabIndex = 20;
            this.lblServicePlan.Text = "Plan de Servicio:";
            // 
            // frmGestorClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 503);
            this.Controls.Add(this.groupBoxServicio);
            this.Controls.Add(this.groupBoxDomicilio);
            this.Controls.Add(this.groupBoxDatosContacto);
            this.Controls.Add(this.groupBoxInfoCliente);
            this.Controls.Add(this.groupBoxBuscarCliente);
            this.Controls.Add(this.lblTituloGestorClientes);
            this.Name = "frmGestorClientes";
            this.Text = "frmGestorClientes";
            this.Load += new System.EventHandler(this.frmGestorClientes_Load);
            this.groupBoxBuscarCliente.ResumeLayout(false);
            this.groupBoxBuscarCliente.PerformLayout();
            this.groupBoxInfoCliente.ResumeLayout(false);
            this.groupBoxInfoCliente.PerformLayout();
            this.groupBoxDatosContacto.ResumeLayout(false);
            this.groupBoxDatosContacto.PerformLayout();
            this.groupBoxDomicilio.ResumeLayout(false);
            this.groupBoxDomicilio.PerformLayout();
            this.groupBoxServicio.ResumeLayout(false);
            this.groupBoxServicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloGestorClientes;
        private System.Windows.Forms.GroupBox groupBoxBuscarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxDNICliente;
        private System.Windows.Forms.TextBox textBoxNroClienteID;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox textBoxNroCliente;
        private System.Windows.Forms.Label labelNroCliente;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.GroupBox groupBoxInfoCliente;
        private System.Windows.Forms.GroupBox groupBoxDatosContacto;
        private System.Windows.Forms.TextBox textBoxTelPrincipal;
        private System.Windows.Forms.Label lblTelPrincipal;
        private System.Windows.Forms.Label lblTelSecundario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelSecundario;
        private System.Windows.Forms.GroupBox groupBoxDomicilio;
        private System.Windows.Forms.ComboBox comboBoxNodosDeRed;
        private System.Windows.Forms.Label lblClienteNododeRed;
        private System.Windows.Forms.TextBox textBoxClienteLocalidad;
        private System.Windows.Forms.Label lblClienteProvincia;
        private System.Windows.Forms.Label lblClienteLocalidad;
        private System.Windows.Forms.TextBox textBoxClienteProvincia;
        private System.Windows.Forms.TextBox textBoxClienteCodigoPostal;
        private System.Windows.Forms.Label lblClienteCodigoPostal;
        private System.Windows.Forms.TextBox textBoxClienteDepto;
        private System.Windows.Forms.Label lblClienteDepto;
        private System.Windows.Forms.TextBox textBoxtextBoxClienteAltura;
        private System.Windows.Forms.Label lblClienteCalle;
        private System.Windows.Forms.Label lblClienteAltura;
        private System.Windows.Forms.TextBox textBoxClienteCalle;
        private System.Windows.Forms.TextBox textBoxClientePiso;
        private System.Windows.Forms.Label lblClientePiso;
        private System.Windows.Forms.GroupBox groupBoxServicio;
        private System.Windows.Forms.Label lblEstadoServicio;
        private System.Windows.Forms.Label lblServicePlan;
        private System.Windows.Forms.ListBox listBoxDispositivos;
        private System.Windows.Forms.Label labelDispositivos;
        private System.Windows.Forms.ComboBox comboBoxServicePlan;
        private System.Windows.Forms.ComboBox comboBoxEstadoServicio;
        private System.Windows.Forms.Button buttonGuadar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonGestionarDispositivos;
    }
}