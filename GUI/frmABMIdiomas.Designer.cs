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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxIdiomas = new System.Windows.Forms.ListBox();
            this.btnEliminarIdioma = new System.Windows.Forms.Button();
            this.btnGuardarIdioma = new System.Windows.Forms.Button();
            this.textBoxModificarIdioma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuevoIdioma = new System.Windows.Forms.Button();
            this.textBoxNuevoIdioma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idiomas";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modificar idioma";
            // 
            // btnNuevoIdioma
            // 
            this.btnNuevoIdioma.Location = new System.Drawing.Point(149, 182);
            this.btnNuevoIdioma.Name = "btnNuevoIdioma";
            this.btnNuevoIdioma.Size = new System.Drawing.Size(130, 23);
            this.btnNuevoIdioma.TabIndex = 6;
            this.btnNuevoIdioma.Text = "Crear";
            this.btnNuevoIdioma.UseVisualStyleBackColor = true;
            this.btnNuevoIdioma.Click += new System.EventHandler(this.btnNuevoIdioma_Click);
            // 
            // textBoxNuevoIdioma
            // 
            this.textBoxNuevoIdioma.Location = new System.Drawing.Point(150, 156);
            this.textBoxNuevoIdioma.Name = "textBoxNuevoIdioma";
            this.textBoxNuevoIdioma.Size = new System.Drawing.Size(130, 20);
            this.textBoxNuevoIdioma.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nuevo Idioma";
            // 
            // frmABMIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNuevoIdioma);
            this.Controls.Add(this.btnNuevoIdioma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxModificarIdioma);
            this.Controls.Add(this.btnGuardarIdioma);
            this.Controls.Add(this.btnEliminarIdioma);
            this.Controls.Add(this.listBoxIdiomas);
            this.Controls.Add(this.label1);
            this.Name = "frmABMIdiomas";
            this.Text = "frmABMIdiomas";
            this.Load += new System.EventHandler(this.frmABMIdiomas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxIdiomas;
        private System.Windows.Forms.Button btnEliminarIdioma;
        private System.Windows.Forms.Button btnGuardarIdioma;
        private System.Windows.Forms.TextBox textBoxModificarIdioma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNuevoIdioma;
        private System.Windows.Forms.TextBox textBoxNuevoIdioma;
        private System.Windows.Forms.Label label3;
    }
}