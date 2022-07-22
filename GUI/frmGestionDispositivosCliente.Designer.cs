namespace GUI
{
    partial class frmGestionDispositivosCliente
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
            this.groupBoxDatosDelCliente = new System.Windows.Forms.GroupBox();
            this.lblNombreyApellido = new System.Windows.Forms.Label();
            this.lvlNroCLienteValue = new System.Windows.Forms.Label();
            this.lblNroCliente = new System.Windows.Forms.Label();
            this.lblGetsionDispositivoCliente = new System.Windows.Forms.Label();
            this.lblNombreyApellidoValue = new System.Windows.Forms.Label();
            this.listBoxDispositivosCliente = new System.Windows.Forms.ListBox();
            this.btnAgregarDispositivo = new System.Windows.Forms.Button();
            this.btnQuitarDispositivo = new System.Windows.Forms.Button();
            this.groupBoxDatosDelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBoxDatosDelCliente.Controls.Add(this.lblNombreyApellidoValue);
            this.groupBoxDatosDelCliente.Controls.Add(this.lblNombreyApellido);
            this.groupBoxDatosDelCliente.Controls.Add(this.lvlNroCLienteValue);
            this.groupBoxDatosDelCliente.Controls.Add(this.lblNroCliente);
            this.groupBoxDatosDelCliente.Location = new System.Drawing.Point(12, 37);
            this.groupBoxDatosDelCliente.Name = "groupBox1";
            this.groupBoxDatosDelCliente.Size = new System.Drawing.Size(404, 51);
            this.groupBoxDatosDelCliente.TabIndex = 0;
            this.groupBoxDatosDelCliente.TabStop = false;
            this.groupBoxDatosDelCliente.Text = "Datos del Cliente";
            // 
            // lblNombreyApellido
            // 
            this.lblNombreyApellido.AutoSize = true;
            this.lblNombreyApellido.Location = new System.Drawing.Point(255, 18);
            this.lblNombreyApellido.Name = "lblNombreyApellido";
            this.lblNombreyApellido.Size = new System.Drawing.Size(92, 13);
            this.lblNombreyApellido.TabIndex = 2;
            this.lblNombreyApellido.Text = "Nombre y Apellido";
            // 
            // lvlNroCLienteValue
            // 
            this.lvlNroCLienteValue.AutoSize = true;
            this.lvlNroCLienteValue.Location = new System.Drawing.Point(72, 31);
            this.lvlNroCLienteValue.Name = "lvlNroCLienteValue";
            this.lvlNroCLienteValue.Size = new System.Drawing.Size(13, 13);
            this.lvlNroCLienteValue.TabIndex = 1;
            this.lvlNroCLienteValue.Text = "0";
            this.lvlNroCLienteValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNroCliente
            // 
            this.lblNroCliente.AutoSize = true;
            this.lblNroCliente.Location = new System.Drawing.Point(37, 18);
            this.lblNroCliente.Name = "lblNroCliente";
            this.lblNroCliente.Size = new System.Drawing.Size(94, 13);
            this.lblNroCliente.TabIndex = 0;
            this.lblNroCliente.Text = "Numero de Cliente";
            // 
            // lblGetsionDispositivoCliente
            // 
            this.lblGetsionDispositivoCliente.AutoSize = true;
            this.lblGetsionDispositivoCliente.Location = new System.Drawing.Point(13, 13);
            this.lblGetsionDispositivoCliente.Name = "lblGetsionDispositivoCliente";
            this.lblGetsionDispositivoCliente.Size = new System.Drawing.Size(169, 13);
            this.lblGetsionDispositivoCliente.TabIndex = 1;
            this.lblGetsionDispositivoCliente.Text = "Gestion de Dispositivos del Cliente";
            // 
            // lblNombreyApellidoValue
            // 
            this.lblNombreyApellidoValue.AutoSize = true;
            this.lblNombreyApellidoValue.Location = new System.Drawing.Point(255, 31);
            this.lblNombreyApellidoValue.Name = "lblNombreyApellidoValue";
            this.lblNombreyApellidoValue.Size = new System.Drawing.Size(92, 13);
            this.lblNombreyApellidoValue.TabIndex = 3;
            this.lblNombreyApellidoValue.Text = "Nombre y Apellido";
            this.lblNombreyApellidoValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDispositivosCliente
            // 
            this.listBoxDispositivosCliente.FormattingEnabled = true;
            this.listBoxDispositivosCliente.Location = new System.Drawing.Point(16, 95);
            this.listBoxDispositivosCliente.Name = "listBoxDispositivosCliente";
            this.listBoxDispositivosCliente.Size = new System.Drawing.Size(204, 134);
            this.listBoxDispositivosCliente.TabIndex = 2;
            this.listBoxDispositivosCliente.SelectedIndexChanged += new System.EventHandler(this.listBoxDispositivosCliente_SelectedIndexChanged);
            // 
            // btnAgregarDispositivo
            // 
            this.btnAgregarDispositivo.Location = new System.Drawing.Point(254, 106);
            this.btnAgregarDispositivo.Name = "btnAgregarDispositivo";
            this.btnAgregarDispositivo.Size = new System.Drawing.Size(133, 26);
            this.btnAgregarDispositivo.TabIndex = 3;
            this.btnAgregarDispositivo.Text = "Agregar Dispositivo";
            this.btnAgregarDispositivo.UseVisualStyleBackColor = true;
            this.btnAgregarDispositivo.Click += new System.EventHandler(this.btnAgregarDispositivo_Click);
            // 
            // btnQuitarDispositivo
            // 
            this.btnQuitarDispositivo.Location = new System.Drawing.Point(254, 187);
            this.btnQuitarDispositivo.Name = "btnQuitarDispositivo";
            this.btnQuitarDispositivo.Size = new System.Drawing.Size(133, 26);
            this.btnQuitarDispositivo.TabIndex = 4;
            this.btnQuitarDispositivo.Text = "Quitar Dispositivo";
            this.btnQuitarDispositivo.UseVisualStyleBackColor = true;
            this.btnQuitarDispositivo.Click += new System.EventHandler(this.btnQuitarDispositivo_Click);
            // 
            // frmGestionDispositivosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 242);
            this.Controls.Add(this.btnQuitarDispositivo);
            this.Controls.Add(this.btnAgregarDispositivo);
            this.Controls.Add(this.listBoxDispositivosCliente);
            this.Controls.Add(this.lblGetsionDispositivoCliente);
            this.Controls.Add(this.groupBoxDatosDelCliente);
            this.Name = "frmGestionDispositivosCliente";
            this.Text = "frmGestionDispositivosCliente";
            this.Load += new System.EventHandler(this.frmGestionDispositivosCliente_Load);
            this.groupBoxDatosDelCliente.ResumeLayout(false);
            this.groupBoxDatosDelCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosDelCliente;
        private System.Windows.Forms.Label lblNombreyApellido;
        private System.Windows.Forms.Label lvlNroCLienteValue;
        private System.Windows.Forms.Label lblNroCliente;
        private System.Windows.Forms.Label lblGetsionDispositivoCliente;
        private System.Windows.Forms.Label lblNombreyApellidoValue;
        private System.Windows.Forms.ListBox listBoxDispositivosCliente;
        private System.Windows.Forms.Button btnAgregarDispositivo;
        private System.Windows.Forms.Button btnQuitarDispositivo;
    }
}