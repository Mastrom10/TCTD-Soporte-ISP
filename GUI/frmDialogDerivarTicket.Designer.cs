namespace GUI
{
    partial class frmDialogDerivarTicket
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
            this.lblTituloDerivacion = new System.Windows.Forms.Label();
            this.lblTipoDerivacion = new System.Windows.Forms.Label();
            this.comboBoxTipoDerivacion = new System.Windows.Forms.ComboBox();
            this.lblMotivoEscalamiento = new System.Windows.Forms.Label();
            this.textBoxMotivoEscalamiento = new System.Windows.Forms.TextBox();
            this.lblFranjaHoraria = new System.Windows.Forms.Label();
            this.comboBoxFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDerivar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloDerivacion
            // 
            this.lblTituloDerivacion.AutoSize = true;
            this.lblTituloDerivacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDerivacion.Location = new System.Drawing.Point(13, 13);
            this.lblTituloDerivacion.Name = "lblTituloDerivacion";
            this.lblTituloDerivacion.Size = new System.Drawing.Size(119, 20);
            this.lblTituloDerivacion.TabIndex = 0;
            this.lblTituloDerivacion.Text = "Derivar Ticket";
            // 
            // lblTipoDerivacion
            // 
            this.lblTipoDerivacion.AutoSize = true;
            this.lblTipoDerivacion.Location = new System.Drawing.Point(17, 58);
            this.lblTipoDerivacion.Name = "lblTipoDerivacion";
            this.lblTipoDerivacion.Size = new System.Drawing.Size(88, 13);
            this.lblTipoDerivacion.TabIndex = 1;
            this.lblTipoDerivacion.Text = "Tipo Derivacion: ";
            // 
            // comboBoxTipoDerivacion
            // 
            this.comboBoxTipoDerivacion.FormattingEnabled = true;
            this.comboBoxTipoDerivacion.Location = new System.Drawing.Point(132, 55);
            this.comboBoxTipoDerivacion.Name = "comboBoxTipoDerivacion";
            this.comboBoxTipoDerivacion.Size = new System.Drawing.Size(248, 21);
            this.comboBoxTipoDerivacion.TabIndex = 2;
            this.comboBoxTipoDerivacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDerivacion_SelectedIndexChanged);
            // 
            // lblMotivoEscalamiento
            // 
            this.lblMotivoEscalamiento.AutoSize = true;
            this.lblMotivoEscalamiento.Location = new System.Drawing.Point(17, 89);
            this.lblMotivoEscalamiento.Name = "lblMotivoEscalamiento";
            this.lblMotivoEscalamiento.Size = new System.Drawing.Size(108, 13);
            this.lblMotivoEscalamiento.TabIndex = 3;
            this.lblMotivoEscalamiento.Text = "Motivo Escalamiento:";
            // 
            // textBoxMotivoEscalamiento
            // 
            this.textBoxMotivoEscalamiento.Location = new System.Drawing.Point(132, 86);
            this.textBoxMotivoEscalamiento.Name = "textBoxMotivoEscalamiento";
            this.textBoxMotivoEscalamiento.Size = new System.Drawing.Size(248, 20);
            this.textBoxMotivoEscalamiento.TabIndex = 4;
            // 
            // lblFranjaHoraria
            // 
            this.lblFranjaHoraria.AutoSize = true;
            this.lblFranjaHoraria.Location = new System.Drawing.Point(17, 121);
            this.lblFranjaHoraria.Name = "lblFranjaHoraria";
            this.lblFranjaHoraria.Size = new System.Drawing.Size(73, 13);
            this.lblFranjaHoraria.TabIndex = 5;
            this.lblFranjaHoraria.Text = "Franja Horaria";
            // 
            // comboBoxFranjaHoraria
            // 
            this.comboBoxFranjaHoraria.FormattingEnabled = true;
            this.comboBoxFranjaHoraria.Location = new System.Drawing.Point(132, 118);
            this.comboBoxFranjaHoraria.Name = "comboBoxFranjaHoraria";
            this.comboBoxFranjaHoraria.Size = new System.Drawing.Size(248, 21);
            this.comboBoxFranjaHoraria.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(17, 157);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDerivar
            // 
            this.btnDerivar.Location = new System.Drawing.Point(132, 157);
            this.btnDerivar.Name = "btnDerivar";
            this.btnDerivar.Size = new System.Drawing.Size(248, 23);
            this.btnDerivar.TabIndex = 8;
            this.btnDerivar.Text = "Derivar Ticket";
            this.btnDerivar.UseVisualStyleBackColor = true;
            this.btnDerivar.Click += new System.EventHandler(this.btnDerivar_Click);
            // 
            // frmDialogDerivarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 192);
            this.Controls.Add(this.btnDerivar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.comboBoxFranjaHoraria);
            this.Controls.Add(this.lblFranjaHoraria);
            this.Controls.Add(this.textBoxMotivoEscalamiento);
            this.Controls.Add(this.lblMotivoEscalamiento);
            this.Controls.Add(this.comboBoxTipoDerivacion);
            this.Controls.Add(this.lblTipoDerivacion);
            this.Controls.Add(this.lblTituloDerivacion);
            this.Name = "frmDialogDerivarTicket";
            this.Text = "frmDialogDerivarTicket";
            this.Load += new System.EventHandler(this.frmDialogDerivarTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDerivacion;
        private System.Windows.Forms.Label lblTipoDerivacion;
        private System.Windows.Forms.ComboBox comboBoxTipoDerivacion;
        private System.Windows.Forms.Label lblMotivoEscalamiento;
        private System.Windows.Forms.TextBox textBoxMotivoEscalamiento;
        private System.Windows.Forms.Label lblFranjaHoraria;
        private System.Windows.Forms.ComboBox comboBoxFranjaHoraria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDerivar;
    }
}