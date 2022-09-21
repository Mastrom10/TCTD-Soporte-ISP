namespace GUI
{
    partial class frmDialogTurnosDisponibles
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
            this.lblTituloTurnosDisponibles = new System.Windows.Forms.Label();
            this.listBoxTurnosDisponibles = new System.Windows.Forms.ListBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloTurnosDisponibles
            // 
            this.lblTituloTurnosDisponibles.AutoSize = true;
            this.lblTituloTurnosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTurnosDisponibles.Location = new System.Drawing.Point(13, 13);
            this.lblTituloTurnosDisponibles.Name = "lblTituloTurnosDisponibles";
            this.lblTituloTurnosDisponibles.Size = new System.Drawing.Size(162, 20);
            this.lblTituloTurnosDisponibles.TabIndex = 0;
            this.lblTituloTurnosDisponibles.Text = "Turnos Disponibles";
            // 
            // listBoxTurnosDisponibles
            // 
            this.listBoxTurnosDisponibles.FormattingEnabled = true;
            this.listBoxTurnosDisponibles.Location = new System.Drawing.Point(17, 49);
            this.listBoxTurnosDisponibles.Name = "listBoxTurnosDisponibles";
            this.listBoxTurnosDisponibles.Size = new System.Drawing.Size(283, 394);
            this.listBoxTurnosDisponibles.TabIndex = 1;
            this.listBoxTurnosDisponibles.SelectedIndexChanged += new System.EventHandler(this.listBoxTurnosDisponibles_SelectedIndexChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Enabled = false;
            this.btnSeleccionar.Location = new System.Drawing.Point(17, 449);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(283, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmDialogTurnosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 484);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.listBoxTurnosDisponibles);
            this.Controls.Add(this.lblTituloTurnosDisponibles);
            this.Name = "frmDialogTurnosDisponibles";
            this.Text = "frmDialogTurnosDisponibles";
            this.Load += new System.EventHandler(this.frmDialogTurnosDisponibles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTurnosDisponibles;
        private System.Windows.Forms.ListBox listBoxTurnosDisponibles;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}