namespace GUI
{
    partial class frmGestorPermisosGrupos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckEsGrupo = new System.Windows.Forms.CheckBox();
            this.comboBoxPermisosEnum = new System.Windows.Forms.ComboBox();
            this.btnCrearPermisoBasico = new System.Windows.Forms.Button();
            this.txtboxNombrePermiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewTodosLosPermisos = new System.Windows.Forms.TreeView();
            this.treeViewTodosLosPermisos2 = new System.Windows.Forms.TreeView();
            this.btnSumarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Permisos de Sistema";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckEsGrupo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxPermisosEnum);
            this.panel1.Controls.Add(this.btnCrearPermisoBasico);
            this.panel1.Controls.Add(this.txtboxNombrePermiso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 100);
            this.panel1.TabIndex = 2;
            // 
            // CheckEsGrupo
            // 
            this.CheckEsGrupo.AutoSize = true;
            this.CheckEsGrupo.Location = new System.Drawing.Point(212, 15);
            this.CheckEsGrupo.Name = "CheckEsGrupo";
            this.CheckEsGrupo.Size = new System.Drawing.Size(80, 17);
            this.CheckEsGrupo.TabIndex = 6;
            this.CheckEsGrupo.Text = "¿Es grupo?";
            this.CheckEsGrupo.UseVisualStyleBackColor = true;
            this.CheckEsGrupo.CheckedChanged += new System.EventHandler(this.checkEsGrupo_CheckedChanged);
            // 
            // comboBoxPermisosEnum
            // 
            this.comboBoxPermisosEnum.FormattingEnabled = true;
            this.comboBoxPermisosEnum.Location = new System.Drawing.Point(113, 43);
            this.comboBoxPermisosEnum.Name = "comboBoxPermisosEnum";
            this.comboBoxPermisosEnum.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPermisosEnum.TabIndex = 0;
            // 
            // btnCrearPermisoBasico
            // 
            this.btnCrearPermisoBasico.Location = new System.Drawing.Point(102, 74);
            this.btnCrearPermisoBasico.Name = "btnCrearPermisoBasico";
            this.btnCrearPermisoBasico.Size = new System.Drawing.Size(97, 23);
            this.btnCrearPermisoBasico.TabIndex = 4;
            this.btnCrearPermisoBasico.Text = "Crear";
            this.btnCrearPermisoBasico.UseVisualStyleBackColor = true;
            this.btnCrearPermisoBasico.Click += new System.EventHandler(this.btnCrearPermiso_Click);
            // 
            // txtboxNombrePermiso
            // 
            this.txtboxNombrePermiso.Location = new System.Drawing.Point(54, 12);
            this.txtboxNombrePermiso.Name = "txtboxNombrePermiso";
            this.txtboxNombrePermiso.Size = new System.Drawing.Size(145, 20);
            this.txtboxNombrePermiso.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Crear Nuevo permiso";
            // 
            // treeViewTodosLosPermisos
            // 
            this.treeViewTodosLosPermisos.AllowDrop = true;
            this.treeViewTodosLosPermisos.Location = new System.Drawing.Point(19, 159);
            this.treeViewTodosLosPermisos.Name = "treeViewTodosLosPermisos";
            this.treeViewTodosLosPermisos.Size = new System.Drawing.Size(183, 292);
            this.treeViewTodosLosPermisos.TabIndex = 4;
            this.treeViewTodosLosPermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTodosLosPermisos_AfterSelect);
            // 
            // treeViewTodosLosPermisos2
            // 
            this.treeViewTodosLosPermisos2.Location = new System.Drawing.Point(325, 159);
            this.treeViewTodosLosPermisos2.Name = "treeViewTodosLosPermisos2";
            this.treeViewTodosLosPermisos2.Size = new System.Drawing.Size(183, 292);
            this.treeViewTodosLosPermisos2.TabIndex = 5;
            this.treeViewTodosLosPermisos2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTodosLosPermisos2_AfterSelect);
            // 
            // btnSumarPermiso
            // 
            this.btnSumarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSumarPermiso.Location = new System.Drawing.Point(325, 458);
            this.btnSumarPermiso.Name = "btnSumarPermiso";
            this.btnSumarPermiso.Size = new System.Drawing.Size(183, 23);
            this.btnSumarPermiso.TabIndex = 6;
            this.btnSumarPermiso.Text = "Sumar Permiso";
            this.btnSumarPermiso.UseVisualStyleBackColor = false;
            this.btnSumarPermiso.Click += new System.EventHandler(this.btnSumarPermiso_Click);
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuitarPermiso.Location = new System.Drawing.Point(19, 458);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(183, 23);
            this.btnQuitarPermiso.TabIndex = 7;
            this.btnQuitarPermiso.Text = "Quitar Permiso";
            this.btnQuitarPermiso.UseVisualStyleBackColor = false;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // btnEliminarPermiso
            // 
            this.btnEliminarPermiso.BackColor = System.Drawing.Color.Red;
            this.btnEliminarPermiso.Location = new System.Drawing.Point(325, 488);
            this.btnEliminarPermiso.Name = "btnEliminarPermiso";
            this.btnEliminarPermiso.Size = new System.Drawing.Size(183, 23);
            this.btnEliminarPermiso.TabIndex = 8;
            this.btnEliminarPermiso.Text = "EliminarPermiso";
            this.btnEliminarPermiso.UseVisualStyleBackColor = false;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // frmGestorPermisosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 559);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.btnSumarPermiso);
            this.Controls.Add(this.treeViewTodosLosPermisos2);
            this.Controls.Add(this.treeViewTodosLosPermisos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestorPermisosGrupos";
            this.Text = "frmGestorPermisosGrupos";
            this.Load += new System.EventHandler(this.frmGestorPermisosGrupos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearPermisoBasico;
        private System.Windows.Forms.TextBox txtboxNombrePermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPermisosEnum;
        private System.Windows.Forms.CheckBox CheckEsGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewTodosLosPermisos;
        private System.Windows.Forms.TreeView treeViewTodosLosPermisos2;
        private System.Windows.Forms.Button btnSumarPermiso;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.Button btnEliminarPermiso;
    }
}