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
            this.lblValueNombre.Location = new System.Drawing.Point(296, 19);
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
            this.lblFullNombre.Location = new System.Drawing.Point(196, 20);
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
            this.lblTicketNumerotitle.Location = new System.Drawing.Point(21, 25);
            this.lblTicketNumerotitle.Name = "lblTicketNumerotitle";
            this.lblTicketNumerotitle.Size = new System.Drawing.Size(95, 20);
            this.lblTicketNumerotitle.TabIndex = 17;
            this.lblTicketNumerotitle.Text = "Ticket Nro:";
            // 
            // lblTicketNumeroValue
            // 
            this.lblTicketNumeroValue.AutoSize = true;
            this.lblTicketNumeroValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNumeroValue.Location = new System.Drawing.Point(122, 25);
            this.lblTicketNumeroValue.Name = "lblTicketNumeroValue";
            this.lblTicketNumeroValue.Size = new System.Drawing.Size(19, 20);
            this.lblTicketNumeroValue.TabIndex = 18;
            this.lblTicketNumeroValue.Text = "0";
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 772);
            this.Controls.Add(this.lblTicketNumeroValue);
            this.Controls.Add(this.lblTicketNumerotitle);
            this.Controls.Add(this.groupBoxinfoClientes);
            this.Name = "frmTicket";
            this.Text = "frmTicket";
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
    }
}