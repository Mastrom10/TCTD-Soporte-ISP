namespace GUI
{
    partial class frmDispositivosNoAsignados
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listBoxUnassignedDevices = new System.Windows.Forms.ListBox();
            this.lblDispositivosDisponibles = new System.Windows.Forms.Label();
            this.lblSeleccionarUnDispositivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(136, 314);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(12, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listBoxUnassignedDevices
            // 
            this.listBoxUnassignedDevices.FormattingEnabled = true;
            this.listBoxUnassignedDevices.Location = new System.Drawing.Point(13, 64);
            this.listBoxUnassignedDevices.Name = "listBoxUnassignedDevices";
            this.listBoxUnassignedDevices.Size = new System.Drawing.Size(198, 238);
            this.listBoxUnassignedDevices.TabIndex = 2;
            // 
            // lblDispositivosDisponibles
            // 
            this.lblDispositivosDisponibles.AutoSize = true;
            this.lblDispositivosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispositivosDisponibles.Location = new System.Drawing.Point(8, 9);
            this.lblDispositivosDisponibles.Name = "lblDispositivosDisponibles";
            this.lblDispositivosDisponibles.Size = new System.Drawing.Size(203, 20);
            this.lblDispositivosDisponibles.TabIndex = 3;
            this.lblDispositivosDisponibles.Text = "Dispositivos Disponibles";
            // 
            // lblSeleccionarUnDispositivo
            // 
            this.lblSeleccionarUnDispositivo.AutoSize = true;
            this.lblSeleccionarUnDispositivo.Location = new System.Drawing.Point(12, 48);
            this.lblSeleccionarUnDispositivo.Name = "lblSeleccionarUnDispositivo";
            this.lblSeleccionarUnDispositivo.Size = new System.Drawing.Size(130, 13);
            this.lblSeleccionarUnDispositivo.TabIndex = 4;
            this.lblSeleccionarUnDispositivo.Text = "Seleccionar un dispositivo";
            // 
            // frmDispositivosNoAsignados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 349);
            this.Controls.Add(this.lblSeleccionarUnDispositivo);
            this.Controls.Add(this.lblDispositivosDisponibles);
            this.Controls.Add(this.listBoxUnassignedDevices);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Name = "frmDispositivosNoAsignados";
            this.Text = "frmDispositivosNoAsignados";
            this.Load += new System.EventHandler(this.frmDispositivosNoAsignados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox listBoxUnassignedDevices;
        private System.Windows.Forms.Label lblDispositivosDisponibles;
        private System.Windows.Forms.Label lblSeleccionarUnDispositivo;
    }
}