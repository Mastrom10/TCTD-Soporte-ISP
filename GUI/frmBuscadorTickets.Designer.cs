namespace GUI
{
    partial class frmBuscadorTickets
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
            this.lblTituloBuscadorTickets = new System.Windows.Forms.Label();
            this.listBoxticketsDerivados = new System.Windows.Forms.ListBox();
            this.btnRecuperarTicket = new System.Windows.Forms.Button();
            this.groupBoxCriterioBusqueda = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.groupBoxCriterioBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloBuscadorTickets
            // 
            this.lblTituloBuscadorTickets.AutoSize = true;
            this.lblTituloBuscadorTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBuscadorTickets.Location = new System.Drawing.Point(12, 9);
            this.lblTituloBuscadorTickets.Name = "lblTituloBuscadorTickets";
            this.lblTituloBuscadorTickets.Size = new System.Drawing.Size(172, 20);
            this.lblTituloBuscadorTickets.TabIndex = 0;
            this.lblTituloBuscadorTickets.Text = "Buscador de Tickets";
            // 
            // listBoxticketsDerivados
            // 
            this.listBoxticketsDerivados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxticketsDerivados.FormattingEnabled = true;
            this.listBoxticketsDerivados.ItemHeight = 16;
            this.listBoxticketsDerivados.Location = new System.Drawing.Point(16, 44);
            this.listBoxticketsDerivados.Name = "listBoxticketsDerivados";
            this.listBoxticketsDerivados.Size = new System.Drawing.Size(385, 372);
            this.listBoxticketsDerivados.TabIndex = 1;
            this.listBoxticketsDerivados.SelectedIndexChanged += new System.EventHandler(this.listBoxticketsDerivados_SelectedIndexChanged);
            // 
            // btnRecuperarTicket
            // 
            this.btnRecuperarTicket.Location = new System.Drawing.Point(441, 154);
            this.btnRecuperarTicket.Name = "btnRecuperarTicket";
            this.btnRecuperarTicket.Size = new System.Drawing.Size(118, 23);
            this.btnRecuperarTicket.TabIndex = 2;
            this.btnRecuperarTicket.Text = "Recuperar TIcket";
            this.btnRecuperarTicket.UseVisualStyleBackColor = true;
            this.btnRecuperarTicket.Click += new System.EventHandler(this.btnRecuperarTicket_Click);
            // 
            // groupBoxCriterioBusqueda
            // 
            this.groupBoxCriterioBusqueda.Controls.Add(this.comboBoxEstado);
            this.groupBoxCriterioBusqueda.Controls.Add(this.lblEstado);
            this.groupBoxCriterioBusqueda.Location = new System.Drawing.Point(407, 44);
            this.groupBoxCriterioBusqueda.Name = "groupBoxCriterioBusqueda";
            this.groupBoxCriterioBusqueda.Size = new System.Drawing.Size(181, 92);
            this.groupBoxCriterioBusqueda.TabIndex = 3;
            this.groupBoxCriterioBusqueda.TabStop = false;
            this.groupBoxCriterioBusqueda.Text = "Criterio Busqueda";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 25);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(9, 42);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(166, 21);
            this.comboBoxEstado.TabIndex = 1;
            this.comboBoxEstado.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstado_SelectedIndexChanged);
            // 
            // frmBuscadorTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.groupBoxCriterioBusqueda);
            this.Controls.Add(this.btnRecuperarTicket);
            this.Controls.Add(this.listBoxticketsDerivados);
            this.Controls.Add(this.lblTituloBuscadorTickets);
            this.Name = "frmBuscadorTickets";
            this.Text = "frmTicketDeBackOffice";
            this.Load += new System.EventHandler(this.frmTicketDeBackOffice_Load);
            this.groupBoxCriterioBusqueda.ResumeLayout(false);
            this.groupBoxCriterioBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloBuscadorTickets;
        private System.Windows.Forms.ListBox listBoxticketsDerivados;
        private System.Windows.Forms.Button btnRecuperarTicket;
        private System.Windows.Forms.GroupBox groupBoxCriterioBusqueda;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}