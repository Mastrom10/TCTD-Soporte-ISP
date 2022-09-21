namespace GUI
{
    partial class frmDialogEditarTurnos
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
            this.lblEditarTurnoTitulo = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFranjaHoraria = new System.Windows.Forms.Label();
            this.comboBoxFranjaHoraria = new System.Windows.Forms.ComboBox();
            this.lblTurnosTomados = new System.Windows.Forms.Label();
            this.lblTurnosTomadosValue = new System.Windows.Forms.Label();
            this.lblTurnosDisponibles = new System.Windows.Forms.Label();
            this.textBoxTurnosDisponibles = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditarTurnoTitulo
            // 
            this.lblEditarTurnoTitulo.AutoSize = true;
            this.lblEditarTurnoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarTurnoTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblEditarTurnoTitulo.Name = "lblEditarTurnoTitulo";
            this.lblEditarTurnoTitulo.Size = new System.Drawing.Size(117, 20);
            this.lblEditarTurnoTitulo.TabIndex = 0;
            this.lblEditarTurnoTitulo.Text = "Editar Turnos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(17, 90);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(229, 20);
            this.dtpFecha.TabIndex = 1;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha";
            // 
            // lblFranjaHoraria
            // 
            this.lblFranjaHoraria.AutoSize = true;
            this.lblFranjaHoraria.Location = new System.Drawing.Point(17, 132);
            this.lblFranjaHoraria.Name = "lblFranjaHoraria";
            this.lblFranjaHoraria.Size = new System.Drawing.Size(73, 13);
            this.lblFranjaHoraria.TabIndex = 3;
            this.lblFranjaHoraria.Text = "Franja Horaria";
            // 
            // comboBoxFranjaHoraria
            // 
            this.comboBoxFranjaHoraria.FormattingEnabled = true;
            this.comboBoxFranjaHoraria.Location = new System.Drawing.Point(20, 148);
            this.comboBoxFranjaHoraria.Name = "comboBoxFranjaHoraria";
            this.comboBoxFranjaHoraria.Size = new System.Drawing.Size(226, 21);
            this.comboBoxFranjaHoraria.TabIndex = 4;
            this.comboBoxFranjaHoraria.SelectedIndexChanged += new System.EventHandler(this.comboBoxFranjaHoraria_SelectedIndexChanged);
            // 
            // lblTurnosTomados
            // 
            this.lblTurnosTomados.AutoSize = true;
            this.lblTurnosTomados.Location = new System.Drawing.Point(20, 187);
            this.lblTurnosTomados.Name = "lblTurnosTomados";
            this.lblTurnosTomados.Size = new System.Drawing.Size(87, 13);
            this.lblTurnosTomados.TabIndex = 5;
            this.lblTurnosTomados.Text = "Turnos Tomados";
            // 
            // lblTurnosTomadosValue
            // 
            this.lblTurnosTomadosValue.AutoSize = true;
            this.lblTurnosTomadosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnosTomadosValue.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTurnosTomadosValue.Location = new System.Drawing.Point(170, 182);
            this.lblTurnosTomadosValue.Name = "lblTurnosTomadosValue";
            this.lblTurnosTomadosValue.Size = new System.Drawing.Size(27, 20);
            this.lblTurnosTomadosValue.TabIndex = 6;
            this.lblTurnosTomadosValue.Text = "---";
            // 
            // lblTurnosDisponibles
            // 
            this.lblTurnosDisponibles.AutoSize = true;
            this.lblTurnosDisponibles.Location = new System.Drawing.Point(23, 229);
            this.lblTurnosDisponibles.Name = "lblTurnosDisponibles";
            this.lblTurnosDisponibles.Size = new System.Drawing.Size(103, 13);
            this.lblTurnosDisponibles.TabIndex = 7;
            this.lblTurnosDisponibles.Text = "Turnos Disponibles: ";
            // 
            // textBoxTurnosDisponibles
            // 
            this.textBoxTurnosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTurnosDisponibles.Location = new System.Drawing.Point(169, 221);
            this.textBoxTurnosDisponibles.Name = "textBoxTurnosDisponibles";
            this.textBoxTurnosDisponibles.Size = new System.Drawing.Size(77, 26);
            this.textBoxTurnosDisponibles.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(93, 271);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmDialogEditarTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 324);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBoxTurnosDisponibles);
            this.Controls.Add(this.lblTurnosDisponibles);
            this.Controls.Add(this.lblTurnosTomadosValue);
            this.Controls.Add(this.lblTurnosTomados);
            this.Controls.Add(this.comboBoxFranjaHoraria);
            this.Controls.Add(this.lblFranjaHoraria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblEditarTurnoTitulo);
            this.Name = "frmDialogEditarTurnos";
            this.Text = "frmDialogEditarTurnos";
            this.Load += new System.EventHandler(this.frmDialogEditarTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarTurnoTitulo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFranjaHoraria;
        private System.Windows.Forms.ComboBox comboBoxFranjaHoraria;
        private System.Windows.Forms.Label lblTurnosTomados;
        private System.Windows.Forms.Label lblTurnosTomadosValue;
        private System.Windows.Forms.Label lblTurnosDisponibles;
        private System.Windows.Forms.TextBox textBoxTurnosDisponibles;
        private System.Windows.Forms.Button btnGuardar;
    }
}