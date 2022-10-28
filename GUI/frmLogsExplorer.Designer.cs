namespace GUI
{
    partial class frmLogsExplorer
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
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTituloLogExplorer = new System.Windows.Forms.Label();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownLimit = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.lblMensajecontiene = new System.Windows.Forms.Label();
            this.textBoxMensajeContiene = new System.Windows.Forms.TextBox();
            this.textBoxDetalleContiene = new System.Windows.Forms.TextBox();
            this.lblDetalleContiene = new System.Windows.Forms.Label();
            this.textBoxClase = new System.Windows.Forms.TextBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.textBoxMetodo = new System.Windows.Forms.TextBox();
            this.lblMetodo = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToAddRows = false;
            this.dataGridViewLogs.AllowUserToDeleteRows = false;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(12, 191);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.ReadOnly = true;
            this.dataGridViewLogs.Size = new System.Drawing.Size(968, 397);
            this.dataGridViewLogs.TabIndex = 1;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(13, 62);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(54, 13);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Log Level";
            // 
            // lblTituloLogExplorer
            // 
            this.lblTituloLogExplorer.AutoSize = true;
            this.lblTituloLogExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogExplorer.Location = new System.Drawing.Point(12, 13);
            this.lblTituloLogExplorer.Name = "lblTituloLogExplorer";
            this.lblTituloLogExplorer.Size = new System.Drawing.Size(164, 20);
            this.lblTituloLogExplorer.TabIndex = 3;
            this.lblTituloLogExplorer.Text = "Explorador de Logs";
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Location = new System.Drawing.Point(82, 58);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(154, 21);
            this.comboBoxLogLevel.TabIndex = 4;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(260, 62);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 5;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(337, 58);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerFrom.TabIndex = 6;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(571, 62);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(71, 13);
            this.lblFechaHasta.TabIndex = 7;
            this.lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(648, 58);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(213, 20);
            this.dateTimePickerTo.TabIndex = 8;
            // 
            // numericUpDownLimit
            // 
            this.numericUpDownLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLimit.Location = new System.Drawing.Point(128, 95);
            this.numericUpDownLimit.Name = "numericUpDownLimit";
            this.numericUpDownLimit.Size = new System.Drawing.Size(108, 20);
            this.numericUpDownLimit.TabIndex = 9;
            this.numericUpDownLimit.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Location = new System.Drawing.Point(13, 99);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(109, 13);
            this.lblCantidadRegistros.TabIndex = 10;
            this.lblCantidadRegistros.Text = "Cantidad de registros:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(260, 99);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(337, 95);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(213, 20);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // lblMensajecontiene
            // 
            this.lblMensajecontiene.AutoSize = true;
            this.lblMensajecontiene.Location = new System.Drawing.Point(571, 99);
            this.lblMensajecontiene.Name = "lblMensajecontiene";
            this.lblMensajecontiene.Size = new System.Drawing.Size(95, 13);
            this.lblMensajecontiene.TabIndex = 13;
            this.lblMensajecontiene.Text = "Mensaje Contiene:";
            // 
            // textBoxMensajeContiene
            // 
            this.textBoxMensajeContiene.Location = new System.Drawing.Point(672, 95);
            this.textBoxMensajeContiene.Name = "textBoxMensajeContiene";
            this.textBoxMensajeContiene.Size = new System.Drawing.Size(189, 20);
            this.textBoxMensajeContiene.TabIndex = 14;
            // 
            // textBoxDetalleContiene
            // 
            this.textBoxDetalleContiene.Location = new System.Drawing.Point(665, 140);
            this.textBoxDetalleContiene.Name = "textBoxDetalleContiene";
            this.textBoxDetalleContiene.Size = new System.Drawing.Size(196, 20);
            this.textBoxDetalleContiene.TabIndex = 16;
            // 
            // lblDetalleContiene
            // 
            this.lblDetalleContiene.AutoSize = true;
            this.lblDetalleContiene.Location = new System.Drawing.Point(571, 144);
            this.lblDetalleContiene.Name = "lblDetalleContiene";
            this.lblDetalleContiene.Size = new System.Drawing.Size(88, 13);
            this.lblDetalleContiene.TabIndex = 15;
            this.lblDetalleContiene.Text = "Detalle Contiene:";
            // 
            // textBoxClase
            // 
            this.textBoxClase.Location = new System.Drawing.Point(302, 140);
            this.textBoxClase.Name = "textBoxClase";
            this.textBoxClase.Size = new System.Drawing.Size(248, 20);
            this.textBoxClase.TabIndex = 18;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(260, 144);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(36, 13);
            this.lblClase.TabIndex = 17;
            this.lblClase.Text = "Clase:";
            // 
            // textBoxMetodo
            // 
            this.textBoxMetodo.Location = new System.Drawing.Point(65, 140);
            this.textBoxMetodo.Name = "textBoxMetodo";
            this.textBoxMetodo.Size = new System.Drawing.Size(171, 20);
            this.textBoxMetodo.TabIndex = 20;
            // 
            // lblMetodo
            // 
            this.lblMetodo.AutoSize = true;
            this.lblMetodo.Location = new System.Drawing.Point(13, 144);
            this.lblMetodo.Name = "lblMetodo";
            this.lblMetodo.Size = new System.Drawing.Size(46, 13);
            this.lblMetodo.TabIndex = 19;
            this.lblMetodo.Text = "Metodo:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(877, 140);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(103, 23);
            this.buttonBuscar.TabIndex = 21;
            this.buttonBuscar.Text = "Buscar Logs";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // frmLogsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 602);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxMetodo);
            this.Controls.Add(this.lblMetodo);
            this.Controls.Add(this.textBoxClase);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.textBoxDetalleContiene);
            this.Controls.Add(this.lblDetalleContiene);
            this.Controls.Add(this.textBoxMensajeContiene);
            this.Controls.Add(this.lblMensajecontiene);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCantidadRegistros);
            this.Controls.Add(this.numericUpDownLimit);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.comboBoxLogLevel);
            this.Controls.Add(this.lblTituloLogExplorer);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.dataGridViewLogs);
            this.Name = "frmLogsExplorer";
            this.Text = "frmLogsExplorer";
            this.Load += new System.EventHandler(this.frmLogsExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTituloLogExplorer;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.NumericUpDown numericUpDownLimit;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label lblMensajecontiene;
        private System.Windows.Forms.TextBox textBoxMensajeContiene;
        private System.Windows.Forms.TextBox textBoxDetalleContiene;
        private System.Windows.Forms.Label lblDetalleContiene;
        private System.Windows.Forms.TextBox textBoxClase;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.TextBox textBoxMetodo;
        private System.Windows.Forms.Label lblMetodo;
        private System.Windows.Forms.Button buttonBuscar;
    }
}