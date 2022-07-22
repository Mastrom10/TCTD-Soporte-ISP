namespace GUI
{
    partial class frmGestorServicePlan
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.textBoxIdServicePlan = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.textBoxServicePlanDescripcion = new System.Windows.Forms.TextBox();
            this.listBoxServicePlan = new System.Windows.Forms.ListBox();
            this.lblServicePlanTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(194, 254);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 23);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(194, 224);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(194, 194);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 23);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // textBoxIdServicePlan
            // 
            this.textBoxIdServicePlan.Enabled = false;
            this.textBoxIdServicePlan.Location = new System.Drawing.Point(194, 67);
            this.textBoxIdServicePlan.Name = "textBoxIdServicePlan";
            this.textBoxIdServicePlan.Size = new System.Drawing.Size(114, 20);
            this.textBoxIdServicePlan.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(191, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "Id";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(191, 104);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // textBoxServicePlanDescripcion
            // 
            this.textBoxServicePlanDescripcion.Location = new System.Drawing.Point(194, 120);
            this.textBoxServicePlanDescripcion.Name = "textBoxServicePlanDescripcion";
            this.textBoxServicePlanDescripcion.Size = new System.Drawing.Size(111, 20);
            this.textBoxServicePlanDescripcion.TabIndex = 15;
            // 
            // listBoxServicePlan
            // 
            this.listBoxServicePlan.FormattingEnabled = true;
            this.listBoxServicePlan.Location = new System.Drawing.Point(23, 51);
            this.listBoxServicePlan.Name = "listBoxServicePlan";
            this.listBoxServicePlan.Size = new System.Drawing.Size(162, 225);
            this.listBoxServicePlan.TabIndex = 16;
            this.listBoxServicePlan.SelectedIndexChanged += new System.EventHandler(this.listBoxServicePlan_SelectedIndexChanged);
            // 
            // lblServicePlanTitle
            // 
            this.lblServicePlanTitle.AutoSize = true;
            this.lblServicePlanTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePlanTitle.Location = new System.Drawing.Point(23, 13);
            this.lblServicePlanTitle.Name = "lblServicePlanTitle";
            this.lblServicePlanTitle.Size = new System.Drawing.Size(202, 20);
            this.lblServicePlanTitle.TabIndex = 17;
            this.lblServicePlanTitle.Text = "Gestor de Service Plans";
            // 
            // frmGestorServicePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 314);
            this.Controls.Add(this.lblServicePlanTitle);
            this.Controls.Add(this.listBoxServicePlan);
            this.Controls.Add(this.textBoxServicePlanDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.textBoxIdServicePlan);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmGestorServicePlan";
            this.Text = "frmGestorServicePlan";
            this.Load += new System.EventHandler(this.frmGestorServicePlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox textBoxIdServicePlan;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBoxServicePlanDescripcion;
        private System.Windows.Forms.ListBox listBoxServicePlan;
        private System.Windows.Forms.Label lblServicePlanTitle;
    }
}