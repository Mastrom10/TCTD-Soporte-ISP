namespace GUI
{
    partial class frmDialogCerrarTicket
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrarTicket = new System.Windows.Forms.Button();
            this.lblTituloCerrarTicket = new System.Windows.Forms.Label();
            this.lblDetalleCerreTicket = new System.Windows.Forms.Label();
            this.textBoxDetalleCierre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(13, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCerrarTicket
            // 
            this.btnCerrarTicket.Location = new System.Drawing.Point(108, 144);
            this.btnCerrarTicket.Name = "btnCerrarTicket";
            this.btnCerrarTicket.Size = new System.Drawing.Size(252, 23);
            this.btnCerrarTicket.TabIndex = 1;
            this.btnCerrarTicket.Text = "Cerrar Ticket";
            this.btnCerrarTicket.UseVisualStyleBackColor = true;
            this.btnCerrarTicket.Click += new System.EventHandler(this.btnCerrarTicket_Click);
            // 
            // lblTituloCerrarTicket
            // 
            this.lblTituloCerrarTicket.AutoSize = true;
            this.lblTituloCerrarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCerrarTicket.Location = new System.Drawing.Point(13, 13);
            this.lblTituloCerrarTicket.Name = "lblTituloCerrarTicket";
            this.lblTituloCerrarTicket.Size = new System.Drawing.Size(112, 20);
            this.lblTituloCerrarTicket.TabIndex = 2;
            this.lblTituloCerrarTicket.Text = "Cerrar Ticket";
            // 
            // lblDetalleCerreTicket
            // 
            this.lblDetalleCerreTicket.AutoSize = true;
            this.lblDetalleCerreTicket.Location = new System.Drawing.Point(13, 49);
            this.lblDetalleCerreTicket.Name = "lblDetalleCerreTicket";
            this.lblDetalleCerreTicket.Size = new System.Drawing.Size(88, 13);
            this.lblDetalleCerreTicket.TabIndex = 3;
            this.lblDetalleCerreTicket.Text = "Detalle de Cierre:";
            // 
            // textBoxDetalleCierre
            // 
            this.textBoxDetalleCierre.Location = new System.Drawing.Point(13, 66);
            this.textBoxDetalleCierre.Multiline = true;
            this.textBoxDetalleCierre.Name = "textBoxDetalleCierre";
            this.textBoxDetalleCierre.Size = new System.Drawing.Size(347, 57);
            this.textBoxDetalleCierre.TabIndex = 4;
            // 
            // frmDialogCerrarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 179);
            this.Controls.Add(this.textBoxDetalleCierre);
            this.Controls.Add(this.lblDetalleCerreTicket);
            this.Controls.Add(this.lblTituloCerrarTicket);
            this.Controls.Add(this.btnCerrarTicket);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmDialogCerrarTicket";
            this.Text = "frmDialogCerrarTicket";
            this.Load += new System.EventHandler(this.frmDialogCerrarTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrarTicket;
        private System.Windows.Forms.Label lblTituloCerrarTicket;
        private System.Windows.Forms.Label lblDetalleCerreTicket;
        private System.Windows.Forms.TextBox textBoxDetalleCierre;
    }
}