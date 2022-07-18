namespace GUI
{
    partial class frmTraducciones
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
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.lblTraducciones = new System.Windows.Forms.Label();
            this.lblSeleccionarIdioma = new System.Windows.Forms.Label();
            this.dataGridViewTraducciones = new System.Windows.Forms.DataGridView();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Location = new System.Drawing.Point(129, 50);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(224, 21);
            this.comboBoxIdiomas.TabIndex = 0;
            this.comboBoxIdiomas.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdiomas_SelectedIndexChanged);
            // 
            // lblTraducciones
            // 
            this.lblTraducciones.AutoSize = true;
            this.lblTraducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraducciones.Location = new System.Drawing.Point(12, 9);
            this.lblTraducciones.Name = "lblTraducciones";
            this.lblTraducciones.Size = new System.Drawing.Size(116, 20);
            this.lblTraducciones.TabIndex = 1;
            this.lblTraducciones.Text = "Traducciones";
            // 
            // lblSeleccionarIdioma
            // 
            this.lblSeleccionarIdioma.AutoSize = true;
            this.lblSeleccionarIdioma.Location = new System.Drawing.Point(13, 53);
            this.lblSeleccionarIdioma.Name = "lblSeleccionarIdioma";
            this.lblSeleccionarIdioma.Size = new System.Drawing.Size(97, 13);
            this.lblSeleccionarIdioma.TabIndex = 2;
            this.lblSeleccionarIdioma.Text = "Seleccionar Idioma";
            // 
            // dataGridViewTraducciones
            // 
            this.dataGridViewTraducciones.AllowUserToAddRows = false;
            this.dataGridViewTraducciones.AllowUserToDeleteRows = false;
            this.dataGridViewTraducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraducciones.Location = new System.Drawing.Point(16, 96);
            this.dataGridViewTraducciones.Name = "dataGridViewTraducciones";
            this.dataGridViewTraducciones.Size = new System.Drawing.Size(489, 300);
            this.dataGridViewTraducciones.TabIndex = 3;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(178, 402);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(126, 23);
            this.btnGuardarCambios.TabIndex = 4;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // frmTraducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 442);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.dataGridViewTraducciones);
            this.Controls.Add(this.lblSeleccionarIdioma);
            this.Controls.Add(this.lblTraducciones);
            this.Controls.Add(this.comboBoxIdiomas);
            this.Name = "frmTraducciones";
            this.Text = "frmTraducciones";
            this.Load += new System.EventHandler(this.frmTraducciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdiomas;
        private System.Windows.Forms.Label lblTraducciones;
        private System.Windows.Forms.Label lblSeleccionarIdioma;
        private System.Windows.Forms.DataGridView dataGridViewTraducciones;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}