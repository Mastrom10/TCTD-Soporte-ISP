namespace GUI
{
    partial class frmGestiondeAgenda
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblGestiondeAgendatitulo = new System.Windows.Forms.Label();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnVerTurnos = new System.Windows.Forms.Button();
            this.dataGridViewTurnos = new System.Windows.Forms.DataGridView();
            this.btnEditarTurnos = new System.Windows.Forms.Button();
            this.groupBoxBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(63, 19);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // lblGestiondeAgendatitulo
            // 
            this.lblGestiondeAgendatitulo.AutoSize = true;
            this.lblGestiondeAgendatitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestiondeAgendatitulo.Location = new System.Drawing.Point(13, 13);
            this.lblGestiondeAgendatitulo.Name = "lblGestiondeAgendatitulo";
            this.lblGestiondeAgendatitulo.Size = new System.Drawing.Size(164, 20);
            this.lblGestiondeAgendatitulo.TabIndex = 1;
            this.lblGestiondeAgendatitulo.Text = "Gestion de Agenda";
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Controls.Add(this.btnVerTurnos);
            this.groupBoxBusqueda.Controls.Add(this.lblHasta);
            this.groupBoxBusqueda.Controls.Add(this.lblDesde);
            this.groupBoxBusqueda.Controls.Add(this.dtpHasta);
            this.groupBoxBusqueda.Controls.Add(this.dtpDesde);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(17, 53);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(674, 51);
            this.groupBoxBusqueda.TabIndex = 2;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda de Turnos";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(350, 19);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(16, 23);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(306, 23);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnVerTurnos
            // 
            this.btnVerTurnos.Location = new System.Drawing.Point(586, 19);
            this.btnVerTurnos.Name = "btnVerTurnos";
            this.btnVerTurnos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTurnos.TabIndex = 4;
            this.btnVerTurnos.Text = "Ver Turnos";
            this.btnVerTurnos.UseVisualStyleBackColor = true;
            this.btnVerTurnos.Click += new System.EventHandler(this.btnVerTurnos_Click);
            // 
            // dataGridViewTurnos
            // 
            this.dataGridViewTurnos.AllowUserToAddRows = false;
            this.dataGridViewTurnos.AllowUserToDeleteRows = false;
            this.dataGridViewTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurnos.Location = new System.Drawing.Point(17, 128);
            this.dataGridViewTurnos.Name = "dataGridViewTurnos";
            this.dataGridViewTurnos.ReadOnly = true;
            this.dataGridViewTurnos.Size = new System.Drawing.Size(674, 205);
            this.dataGridViewTurnos.TabIndex = 3;
            // 
            // btnEditarTurnos
            // 
            this.btnEditarTurnos.Location = new System.Drawing.Point(17, 352);
            this.btnEditarTurnos.Name = "btnEditarTurnos";
            this.btnEditarTurnos.Size = new System.Drawing.Size(109, 23);
            this.btnEditarTurnos.TabIndex = 5;
            this.btnEditarTurnos.Text = "Editar Turnos";
            this.btnEditarTurnos.UseVisualStyleBackColor = true;
            this.btnEditarTurnos.Click += new System.EventHandler(this.btnEditarTurnos_Click);
            // 
            // frmGestiondeAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 396);
            this.Controls.Add(this.btnEditarTurnos);
            this.Controls.Add(this.dataGridViewTurnos);
            this.Controls.Add(this.groupBoxBusqueda);
            this.Controls.Add(this.lblGestiondeAgendatitulo);
            this.Name = "frmGestiondeAgenda";
            this.Text = "frmGestiondeAgenda";
            this.Load += new System.EventHandler(this.frmGestiondeAgenda_Load);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblGestiondeAgendatitulo;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button btnVerTurnos;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DataGridView dataGridViewTurnos;
        private System.Windows.Forms.Button btnEditarTurnos;
    }
}