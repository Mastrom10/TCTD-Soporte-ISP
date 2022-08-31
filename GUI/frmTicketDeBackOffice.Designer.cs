namespace GUI
{
    partial class frmTicketDeBackOffice
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
            this.lblTituloTicketsBackOffice = new System.Windows.Forms.Label();
            this.listBoxticketsDerivados = new System.Windows.Forms.ListBox();
            this.btnRecuperarTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloTicketsBackOffice
            // 
            this.lblTituloTicketsBackOffice.AutoSize = true;
            this.lblTituloTicketsBackOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTicketsBackOffice.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTicketsBackOffice.Name = "lblTituloTicketsBackOffice";
            this.lblTituloTicketsBackOffice.Size = new System.Drawing.Size(262, 20);
            this.lblTituloTicketsBackOffice.TabIndex = 0;
            this.lblTituloTicketsBackOffice.Text = "Tickets Escalados a BackOffice";
            // 
            // listBoxticketsDerivados
            // 
            this.listBoxticketsDerivados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxticketsDerivados.FormattingEnabled = true;
            this.listBoxticketsDerivados.ItemHeight = 16;
            this.listBoxticketsDerivados.Location = new System.Drawing.Point(16, 44);
            this.listBoxticketsDerivados.Name = "listBoxticketsDerivados";
            this.listBoxticketsDerivados.Size = new System.Drawing.Size(432, 372);
            this.listBoxticketsDerivados.TabIndex = 1;
            this.listBoxticketsDerivados.SelectedIndexChanged += new System.EventHandler(this.listBoxticketsDerivados_SelectedIndexChanged);
            // 
            // btnRecuperarTicket
            // 
            this.btnRecuperarTicket.Location = new System.Drawing.Point(470, 44);
            this.btnRecuperarTicket.Name = "btnRecuperarTicket";
            this.btnRecuperarTicket.Size = new System.Drawing.Size(118, 23);
            this.btnRecuperarTicket.TabIndex = 2;
            this.btnRecuperarTicket.Text = "Recuperar TIcket";
            this.btnRecuperarTicket.UseVisualStyleBackColor = true;
            this.btnRecuperarTicket.Click += new System.EventHandler(this.btnRecuperarTicket_Click);
            // 
            // frmTicketDeBackOffice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnRecuperarTicket);
            this.Controls.Add(this.listBoxticketsDerivados);
            this.Controls.Add(this.lblTituloTicketsBackOffice);
            this.Name = "frmTicketDeBackOffice";
            this.Text = "frmTicketDeBackOffice";
            this.Load += new System.EventHandler(this.frmTicketDeBackOffice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTicketsBackOffice;
        private System.Windows.Forms.ListBox listBoxticketsDerivados;
        private System.Windows.Forms.Button btnRecuperarTicket;
    }
}