namespace GUI
{
    partial class frmCambiarIdioma
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
            this.lblCambioDeIdiomaTitulo = new System.Windows.Forms.Label();
            this.lblIdiomaActual = new System.Windows.Forms.Label();
            this.lblIdiomaActualValue = new System.Windows.Forms.Label();
            this.comboBoxIdiomas = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarIdioma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCambioDeIdiomaTitulo
            // 
            this.lblCambioDeIdiomaTitulo.AutoSize = true;
            this.lblCambioDeIdiomaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambioDeIdiomaTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblCambioDeIdiomaTitulo.Name = "lblCambioDeIdiomaTitulo";
            this.lblCambioDeIdiomaTitulo.Size = new System.Drawing.Size(153, 20);
            this.lblCambioDeIdiomaTitulo.TabIndex = 0;
            this.lblCambioDeIdiomaTitulo.Text = "Cambio de Idioma";
            // 
            // lblIdiomaActual
            // 
            this.lblIdiomaActual.AutoSize = true;
            this.lblIdiomaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomaActual.Location = new System.Drawing.Point(12, 43);
            this.lblIdiomaActual.Name = "lblIdiomaActual";
            this.lblIdiomaActual.Size = new System.Drawing.Size(88, 13);
            this.lblIdiomaActual.TabIndex = 1;
            this.lblIdiomaActual.Text = "Idioma Actual:";
            // 
            // lblIdiomaActualValue
            // 
            this.lblIdiomaActualValue.AutoSize = true;
            this.lblIdiomaActualValue.Location = new System.Drawing.Point(14, 69);
            this.lblIdiomaActualValue.Name = "lblIdiomaActualValue";
            this.lblIdiomaActualValue.Size = new System.Drawing.Size(45, 13);
            this.lblIdiomaActualValue.TabIndex = 2;
            this.lblIdiomaActualValue.Text = "Español";
            // 
            // comboBoxIdiomas
            // 
            this.comboBoxIdiomas.FormattingEnabled = true;
            this.comboBoxIdiomas.Location = new System.Drawing.Point(17, 105);
            this.comboBoxIdiomas.Name = "comboBoxIdiomas";
            this.comboBoxIdiomas.Size = new System.Drawing.Size(193, 21);
            this.comboBoxIdiomas.TabIndex = 3;
            // 
            // btnSeleccionarIdioma
            // 
            this.btnSeleccionarIdioma.Location = new System.Drawing.Point(71, 132);
            this.btnSeleccionarIdioma.Name = "btnSeleccionarIdioma";
            this.btnSeleccionarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarIdioma.TabIndex = 4;
            this.btnSeleccionarIdioma.Text = "Seleccionar";
            this.btnSeleccionarIdioma.UseVisualStyleBackColor = true;
            this.btnSeleccionarIdioma.Click += new System.EventHandler(this.btnSeleccionarIdioma_Click);
            // 
            // frmCambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 193);
            this.Controls.Add(this.btnSeleccionarIdioma);
            this.Controls.Add(this.comboBoxIdiomas);
            this.Controls.Add(this.lblIdiomaActualValue);
            this.Controls.Add(this.lblIdiomaActual);
            this.Controls.Add(this.lblCambioDeIdiomaTitulo);
            this.Name = "frmCambiarIdioma";
            this.Text = "frmCambiarIdioma";
            this.Load += new System.EventHandler(this.frmCambiarIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCambioDeIdiomaTitulo;
        private System.Windows.Forms.Label lblIdiomaActual;
        private System.Windows.Forms.Label lblIdiomaActualValue;
        private System.Windows.Forms.ComboBox comboBoxIdiomas;
        private System.Windows.Forms.Button btnSeleccionarIdioma;
    }
}