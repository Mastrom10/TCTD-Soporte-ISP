﻿namespace GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCrearFamilia = new System.Windows.Forms.Button();
            this.txtboxNombrePermiso = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCrearNuevoGrupo = new System.Windows.Forms.Label();
            this.treeViewTodosLosPermisos = new System.Windows.Forms.TreeView();
            this.treeViewTodosLosPermisos2 = new System.Windows.Forms.TreeView();
            this.btnSumarPermiso = new System.Windows.Forms.Button();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.btnEliminarPermiso = new System.Windows.Forms.Button();
            this.lblListadoDeGrupos = new System.Windows.Forms.Label();
            this.lblTodosLosPermisos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCrearFamilia);
            this.panel1.Controls.Add(this.txtboxNombrePermiso);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 43);
            this.panel1.TabIndex = 2;
            // 
            // btnCrearFamilia
            // 
            this.btnCrearFamilia.Location = new System.Drawing.Point(204, 9);
            this.btnCrearFamilia.Name = "btnCrearFamilia";
            this.btnCrearFamilia.Size = new System.Drawing.Size(97, 23);
            this.btnCrearFamilia.TabIndex = 4;
            this.btnCrearFamilia.Text = "Crear Grupo";
            this.btnCrearFamilia.UseVisualStyleBackColor = true;
            this.btnCrearFamilia.Click += new System.EventHandler(this.btnCrearFamilia_Click);
            // 
            // txtboxNombrePermiso
            // 
            this.txtboxNombrePermiso.Location = new System.Drawing.Point(54, 12);
            this.txtboxNombrePermiso.Name = "txtboxNombrePermiso";
            this.txtboxNombrePermiso.Size = new System.Drawing.Size(145, 20);
            this.txtboxNombrePermiso.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCrearNuevoGrupo
            // 
            this.lblCrearNuevoGrupo.AutoSize = true;
            this.lblCrearNuevoGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearNuevoGrupo.Location = new System.Drawing.Point(12, 13);
            this.lblCrearNuevoGrupo.Name = "lblCrearNuevoGrupo";
            this.lblCrearNuevoGrupo.Size = new System.Drawing.Size(149, 17);
            this.lblCrearNuevoGrupo.TabIndex = 3;
            this.lblCrearNuevoGrupo.Text = "Crear Nuevo Grupo";
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
            this.btnEliminarPermiso.Text = "Eliminar Grupo";
            this.btnEliminarPermiso.UseVisualStyleBackColor = false;
            this.btnEliminarPermiso.Click += new System.EventHandler(this.btnEliminarPermiso_Click);
            // 
            // lblListadoDeGrupos
            // 
            this.lblListadoDeGrupos.AutoSize = true;
            this.lblListadoDeGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoDeGrupos.Location = new System.Drawing.Point(16, 130);
            this.lblListadoDeGrupos.Name = "lblListadoDeGrupos";
            this.lblListadoDeGrupos.Size = new System.Drawing.Size(142, 17);
            this.lblListadoDeGrupos.TabIndex = 9;
            this.lblListadoDeGrupos.Text = "Listado de Grupos";
            // 
            // lblTodosLosPermisos
            // 
            this.lblTodosLosPermisos.AutoSize = true;
            this.lblTodosLosPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodosLosPermisos.Location = new System.Drawing.Point(322, 130);
            this.lblTodosLosPermisos.Name = "lblTodosLosPermisos";
            this.lblTodosLosPermisos.Size = new System.Drawing.Size(150, 17);
            this.lblTodosLosPermisos.TabIndex = 10;
            this.lblTodosLosPermisos.Text = "Todos los Permisos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "<----";
            // 
            // frmGestorPermisosGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTodosLosPermisos);
            this.Controls.Add(this.lblListadoDeGrupos);
            this.Controls.Add(this.btnEliminarPermiso);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.btnSumarPermiso);
            this.Controls.Add(this.treeViewTodosLosPermisos2);
            this.Controls.Add(this.treeViewTodosLosPermisos);
            this.Controls.Add(this.lblCrearNuevoGrupo);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCrearFamilia;
        private System.Windows.Forms.TextBox txtboxNombrePermiso;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCrearNuevoGrupo;
        private System.Windows.Forms.TreeView treeViewTodosLosPermisos;
        private System.Windows.Forms.TreeView treeViewTodosLosPermisos2;
        private System.Windows.Forms.Button btnSumarPermiso;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.Button btnEliminarPermiso;
        private System.Windows.Forms.Label lblListadoDeGrupos;
        private System.Windows.Forms.Label lblTodosLosPermisos;
        private System.Windows.Forms.Label label5;
    }
}