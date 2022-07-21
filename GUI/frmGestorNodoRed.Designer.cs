namespace GUI
{
    partial class frmGestorNodoRed
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
            this.lblGestorNodosRedTitle = new System.Windows.Forms.Label();
            this.listBoxNodosRed = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblnombreNodoRed = new System.Windows.Forms.Label();
            this.lblEstadoNodoRed = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textBoxIdNodoRed = new System.Windows.Forms.TextBox();
            this.textBoxNombreNodoRed = new System.Windows.Forms.TextBox();
            this.comboBoxEstadoNodoRed = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblGestorNodosRedTitle
            // 
            this.lblGestorNodosRedTitle.AutoSize = true;
            this.lblGestorNodosRedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestorNodosRedTitle.Location = new System.Drawing.Point(13, 13);
            this.lblGestorNodosRedTitle.Name = "lblGestorNodosRedTitle";
            this.lblGestorNodosRedTitle.Size = new System.Drawing.Size(208, 20);
            this.lblGestorNodosRedTitle.TabIndex = 0;
            this.lblGestorNodosRedTitle.Text = "Gestor de Nodos de Red";
            // 
            // listBoxNodosRed
            // 
            this.listBoxNodosRed.FormattingEnabled = true;
            this.listBoxNodosRed.Location = new System.Drawing.Point(17, 68);
            this.listBoxNodosRed.Name = "listBoxNodosRed";
            this.listBoxNodosRed.Size = new System.Drawing.Size(137, 290);
            this.listBoxNodosRed.TabIndex = 1;
            this.listBoxNodosRed.SelectedIndexChanged += new System.EventHandler(this.listBoxNodosRed_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(168, 75);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // lblnombreNodoRed
            // 
            this.lblnombreNodoRed.AutoSize = true;
            this.lblnombreNodoRed.Location = new System.Drawing.Point(168, 121);
            this.lblnombreNodoRed.Name = "lblnombreNodoRed";
            this.lblnombreNodoRed.Size = new System.Drawing.Size(90, 13);
            this.lblnombreNodoRed.TabIndex = 3;
            this.lblnombreNodoRed.Text = "Nombre del Nodo";
            // 
            // lblEstadoNodoRed
            // 
            this.lblEstadoNodoRed.AutoSize = true;
            this.lblEstadoNodoRed.Location = new System.Drawing.Point(168, 179);
            this.lblEstadoNodoRed.Name = "lblEstadoNodoRed";
            this.lblEstadoNodoRed.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoNodoRed.TabIndex = 4;
            this.lblEstadoNodoRed.Text = "Estado";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(171, 258);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(157, 23);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(171, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(171, 318);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textBoxIdNodoRed
            // 
            this.textBoxIdNodoRed.Enabled = false;
            this.textBoxIdNodoRed.Location = new System.Drawing.Point(171, 92);
            this.textBoxIdNodoRed.Name = "textBoxIdNodoRed";
            this.textBoxIdNodoRed.Size = new System.Drawing.Size(157, 20);
            this.textBoxIdNodoRed.TabIndex = 9;
            // 
            // textBoxNombreNodoRed
            // 
            this.textBoxNombreNodoRed.Location = new System.Drawing.Point(171, 138);
            this.textBoxNombreNodoRed.Name = "textBoxNombreNodoRed";
            this.textBoxNombreNodoRed.Size = new System.Drawing.Size(157, 20);
            this.textBoxNombreNodoRed.TabIndex = 10;
            // 
            // comboBoxEstadoNodoRed
            // 
            this.comboBoxEstadoNodoRed.FormattingEnabled = true;
            this.comboBoxEstadoNodoRed.Location = new System.Drawing.Point(171, 195);
            this.comboBoxEstadoNodoRed.Name = "comboBoxEstadoNodoRed";
            this.comboBoxEstadoNodoRed.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEstadoNodoRed.TabIndex = 11;
            // 
            // frmGestorNodoRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 403);
            this.Controls.Add(this.comboBoxEstadoNodoRed);
            this.Controls.Add(this.textBoxNombreNodoRed);
            this.Controls.Add(this.textBoxIdNodoRed);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblEstadoNodoRed);
            this.Controls.Add(this.lblnombreNodoRed);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.listBoxNodosRed);
            this.Controls.Add(this.lblGestorNodosRedTitle);
            this.Name = "frmGestorNodoRed";
            this.Text = "frmGestorNodoRed";
            this.Load += new System.EventHandler(this.frmGestorNodoRed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestorNodosRedTitle;
        private System.Windows.Forms.ListBox listBoxNodosRed;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblnombreNodoRed;
        private System.Windows.Forms.Label lblEstadoNodoRed;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBoxIdNodoRed;
        private System.Windows.Forms.TextBox textBoxNombreNodoRed;
        private System.Windows.Forms.ComboBox comboBoxEstadoNodoRed;
    }
}