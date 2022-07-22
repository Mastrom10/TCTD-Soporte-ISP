namespace GUI
{
    partial class frmGestorDispositivo
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
            this.lblId = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.listBoxDispositivos = new System.Windows.Forms.ListBox();
            this.lblGestorDispositivo = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textBoxMacAdress = new System.Windows.Forms.TextBox();
            this.textBoxNumerodeSerie = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMacAdress = new System.Windows.Forms.Label();
            this.lblNroSerie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(280, 61);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "Id";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(283, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(114, 23);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(283, 297);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(283, 267);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 23);
            this.btnNuevo.TabIndex = 13;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // listBoxDispositivos
            // 
            this.listBoxDispositivos.FormattingEnabled = true;
            this.listBoxDispositivos.Location = new System.Drawing.Point(12, 62);
            this.listBoxDispositivos.Name = "listBoxDispositivos";
            this.listBoxDispositivos.Size = new System.Drawing.Size(262, 290);
            this.listBoxDispositivos.TabIndex = 17;
            this.listBoxDispositivos.SelectedIndexChanged += new System.EventHandler(this.listBoxDispositivos_SelectedIndexChanged);
            // 
            // lblGestorDispositivo
            // 
            this.lblGestorDispositivo.AutoSize = true;
            this.lblGestorDispositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestorDispositivo.Location = new System.Drawing.Point(12, 13);
            this.lblGestorDispositivo.Name = "lblGestorDispositivo";
            this.lblGestorDispositivo.Size = new System.Drawing.Size(190, 20);
            this.lblGestorDispositivo.TabIndex = 18;
            this.lblGestorDispositivo.Text = "Gestor de Dispositivos";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(283, 77);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(114, 20);
            this.textBoxID.TabIndex = 19;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(283, 122);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(114, 20);
            this.textBoxTipo.TabIndex = 20;
            // 
            // textBoxMacAdress
            // 
            this.textBoxMacAdress.Location = new System.Drawing.Point(283, 170);
            this.textBoxMacAdress.Name = "textBoxMacAdress";
            this.textBoxMacAdress.Size = new System.Drawing.Size(114, 20);
            this.textBoxMacAdress.TabIndex = 21;
            // 
            // textBoxNumerodeSerie
            // 
            this.textBoxNumerodeSerie.Location = new System.Drawing.Point(283, 220);
            this.textBoxNumerodeSerie.Name = "textBoxNumerodeSerie";
            this.textBoxNumerodeSerie.Size = new System.Drawing.Size(114, 20);
            this.textBoxNumerodeSerie.TabIndex = 22;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(280, 106);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "Tipo";
            // 
            // lblMacAdress
            // 
            this.lblMacAdress.AutoSize = true;
            this.lblMacAdress.Location = new System.Drawing.Point(280, 154);
            this.lblMacAdress.Name = "lblMacAdress";
            this.lblMacAdress.Size = new System.Drawing.Size(63, 13);
            this.lblMacAdress.TabIndex = 24;
            this.lblMacAdress.Text = "Mac Adress";
            // 
            // lblNroSerie
            // 
            this.lblNroSerie.AutoSize = true;
            this.lblNroSerie.Location = new System.Drawing.Point(280, 204);
            this.lblNroSerie.Name = "lblNroSerie";
            this.lblNroSerie.Size = new System.Drawing.Size(86, 13);
            this.lblNroSerie.TabIndex = 25;
            this.lblNroSerie.Text = "Numero de Serie";
            // 
            // frmGestorDispositivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 385);
            this.Controls.Add(this.lblNroSerie);
            this.Controls.Add(this.lblMacAdress);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.textBoxNumerodeSerie);
            this.Controls.Add(this.textBoxMacAdress);
            this.Controls.Add(this.textBoxTipo);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.lblGestorDispositivo);
            this.Controls.Add(this.listBoxDispositivos);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmGestorDispositivo";
            this.Text = "frmGestorDispositivo";
            this.Load += new System.EventHandler(this.frmGestorDispositivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox listBoxDispositivos;
        private System.Windows.Forms.Label lblGestorDispositivo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.TextBox textBoxMacAdress;
        private System.Windows.Forms.TextBox textBoxNumerodeSerie;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMacAdress;
        private System.Windows.Forms.Label lblNroSerie;
    }
}