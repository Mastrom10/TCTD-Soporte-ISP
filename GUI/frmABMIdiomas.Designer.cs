namespace GUI
{
    partial class frmABMIdiomas
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
            this.lblTitleIdiomas = new System.Windows.Forms.Label();
            this.listBoxIdiomas = new System.Windows.Forms.ListBox();
            this.btnEliminarIdioma = new System.Windows.Forms.Button();
            this.btnGuardarIdioma = new System.Windows.Forms.Button();
            this.textBoxModificarIdioma = new System.Windows.Forms.TextBox();
            this.lblModificarIdioma = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.textBoxNuevoIdioma = new System.Windows.Forms.TextBox();
            this.lblNuevoIdioma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleIdiomas
            // 
            this.lblTitleIdiomas.AutoSize = true;
            this.lblTitleIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleIdiomas.Location = new System.Drawing.Point(13, 13);
            this.lblTitleIdiomas.Name = "lblTitleIdiomas";
            this.lblTitleIdiomas.Size = new System.Drawing.Size(72, 20);
            this.lblTitleIdiomas.TabIndex = 0;
            this.lblTitleIdiomas.Text = "Idiomas";
            // 
            // listBoxIdiomas
            // 
            this.listBoxIdiomas.FormattingEnabled = true;
            this.listBoxIdiomas.Location = new System.Drawing.Point(17, 36);
            this.listBoxIdiomas.Name = "listBoxIdiomas";
            this.listBoxIdiomas.Size = new System.Drawing.Size(126, 251);
            this.listBoxIdiomas.TabIndex = 1;
            this.listBoxIdiomas.SelectedIndexChanged += new System.EventHandler(this.listBoxIdiomas_SelectedIndexChanged);
            // 
            // btnEliminarIdioma
            // 
            this.btnEliminarIdioma.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarIdioma.Location = new System.Drawing.Point(150, 263);
            this.btnEliminarIdioma.Name = "btnEliminarIdioma";
            this.btnEliminarIdioma.Size = new System.Drawing.Size(131, 23);
            this.btnEliminarIdioma.TabIndex = 2;
            this.btnEliminarIdioma.Text = "Eliminar Idioma";
            this.btnEliminarIdioma.UseVisualStyleBackColor = false;
            this.btnEliminarIdioma.Click += new System.EventHandler(this.btnEliminarIdioma_Click);
            // 
            // btnGuardarIdioma
            // 
            this.btnGuardarIdioma.Location = new System.Drawing.Point(149, 78);
            this.btnGuardarIdioma.Name = "btnGuardarIdioma";
            this.btnGuardarIdioma.Size = new System.Drawing.Size(131, 23);
            this.btnGuardarIdioma.TabIndex = 3;
            this.btnGuardarIdioma.Text = "Guardar";
            this.btnGuardarIdioma.UseVisualStyleBackColor = true;
            this.btnGuardarIdioma.Click += new System.EventHandler(this.btnGuardarIdioma_Click);
            // 
            // textBoxModificarIdioma
            // 
            this.textBoxModificarIdioma.Location = new System.Drawing.Point(149, 52);
            this.textBoxModificarIdioma.Name = "textBoxModificarIdioma";
            this.textBoxModificarIdioma.Size = new System.Drawing.Size(131, 20);
            this.textBoxModificarIdioma.TabIndex = 4;
            // 
            // lblModificarIdioma
            // 
            this.lblModificarIdioma.AutoSize = true;
            this.lblModificarIdioma.Location = new System.Drawing.Point(149, 36);
            this.lblModificarIdioma.Name = "lblModificarIdioma";
            this.lblModificarIdioma.Size = new System.Drawing.Size(83, 13);
            this.lblModificarIdioma.TabIndex = 5;
            this.lblModificarIdioma.Text = "Modificar idioma";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(149, 182);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(130, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnNuevoIdioma_Click);
            // 
            // textBoxNuevoIdioma
            // 
            this.textBoxNuevoIdioma.Location = new System.Drawing.Point(150, 156);
            this.textBoxNuevoIdioma.Name = "textBoxNuevoIdioma";
            this.textBoxNuevoIdioma.Size = new System.Drawing.Size(130, 20);
            this.textBoxNuevoIdioma.TabIndex = 7;
            // 
            // lblNuevoIdioma
            // 
            this.lblNuevoIdioma.AutoSize = true;
            this.lblNuevoIdioma.Location = new System.Drawing.Point(149, 137);
            this.lblNuevoIdioma.Name = "lblNuevoIdioma";
            this.lblNuevoIdioma.Size = new System.Drawing.Size(73, 13);
            this.lblNuevoIdioma.TabIndex = 8;
            this.lblNuevoIdioma.Text = "Nuevo Idioma";
            // 
            // frmABMIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 308);
            this.Controls.Add(this.lblNuevoIdioma);
            this.Controls.Add(this.textBoxNuevoIdioma);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblModificarIdioma);
            this.Controls.Add(this.textBoxModificarIdioma);
            this.Controls.Add(this.btnGuardarIdioma);
            this.Controls.Add(this.btnEliminarIdioma);
            this.Controls.Add(this.listBoxIdiomas);
            this.Controls.Add(this.lblTitleIdiomas);
            this.Name = "frmABMIdiomas";
            this.Text = "frmABMIdiomas";
            this.Load += new System.EventHandler(this.frmABMIdiomas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleIdiomas;
        private System.Windows.Forms.ListBox listBoxIdiomas;
        private System.Windows.Forms.Button btnEliminarIdioma;
        private System.Windows.Forms.Button btnGuardarIdioma;
        private System.Windows.Forms.TextBox textBoxModificarIdioma;
        private System.Windows.Forms.Label lblModificarIdioma;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox textBoxNuevoIdioma;
        private System.Windows.Forms.Label lblNuevoIdioma;
    }
}