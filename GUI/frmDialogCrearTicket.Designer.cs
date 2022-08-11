namespace GUI
{
    partial class frmDialogCrearTicket
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
            this.lblTituloCrearTicket = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.textBoxTituloTicket = new System.Windows.Forms.TextBox();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloCrearTicket
            // 
            this.lblTituloCrearTicket.AutoSize = true;
            this.lblTituloCrearTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCrearTicket.Location = new System.Drawing.Point(13, 13);
            this.lblTituloCrearTicket.Name = "lblTituloCrearTicket";
            this.lblTituloCrearTicket.Size = new System.Drawing.Size(106, 20);
            this.lblTituloCrearTicket.TabIndex = 0;
            this.lblTituloCrearTicket.Text = "Crear Ticket";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(14, 85);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 1;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(14, 51);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo";
            // 
            // textBoxTituloTicket
            // 
            this.textBoxTituloTicket.Location = new System.Drawing.Point(112, 48);
            this.textBoxTituloTicket.Name = "textBoxTituloTicket";
            this.textBoxTituloTicket.Size = new System.Drawing.Size(217, 20);
            this.textBoxTituloTicket.TabIndex = 3;
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Location = new System.Drawing.Point(112, 82);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(217, 21);
            this.comboBoxPrioridad.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(17, 131);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCrearTicket
            // 
            this.btnCrearTicket.Location = new System.Drawing.Point(124, 131);
            this.btnCrearTicket.Name = "btnCrearTicket";
            this.btnCrearTicket.Size = new System.Drawing.Size(205, 23);
            this.btnCrearTicket.TabIndex = 6;
            this.btnCrearTicket.Text = "Crear Ticket";
            this.btnCrearTicket.UseVisualStyleBackColor = true;
            this.btnCrearTicket.Click += new System.EventHandler(this.btnCrearTicket_Click);
            // 
            // frmDialogCrearTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 168);
            this.Controls.Add(this.btnCrearTicket);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.textBoxTituloTicket);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblTituloCrearTicket);
            this.Name = "frmDialogCrearTicket";
            this.Text = "frmDialogCrearTicket";
            this.Load += new System.EventHandler(this.frmDialogCrearTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCrearTicket;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox textBoxTituloTicket;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearTicket;
    }
}