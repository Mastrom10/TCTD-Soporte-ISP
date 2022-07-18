namespace GUI
{
    partial class frmGestorPermisosUsuario
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
            this.treeViewPermisosUsuario = new System.Windows.Forms.TreeView();
            this.lblTituloGestorPermisos = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblListPermisosDeUsuario = new System.Windows.Forms.Label();
            this.lblUsuarioSeleccionado = new System.Windows.Forms.Label();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.treeViewTodosLosPermisos = new System.Windows.Forms.TreeView();
            this.lblListTodosLosPermisos = new System.Windows.Forms.Label();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeViewPermisosUsuario
            // 
            this.treeViewPermisosUsuario.Location = new System.Drawing.Point(29, 143);
            this.treeViewPermisosUsuario.Name = "treeViewPermisosUsuario";
            this.treeViewPermisosUsuario.Size = new System.Drawing.Size(221, 299);
            this.treeViewPermisosUsuario.TabIndex = 1;
            this.treeViewPermisosUsuario.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPermisosUsuario_AfterSelect);
            // 
            // lblTituloGestorPermisos
            // 
            this.lblTituloGestorPermisos.AutoSize = true;
            this.lblTituloGestorPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGestorPermisos.Location = new System.Drawing.Point(25, 12);
            this.lblTituloGestorPermisos.Name = "lblTituloGestorPermisos";
            this.lblTituloGestorPermisos.Size = new System.Drawing.Size(427, 20);
            this.lblTituloGestorPermisos.TabIndex = 2;
            this.lblTituloGestorPermisos.Text = "Asignacion y Desasignacion de Permisos a Usuarios";
            // 
            // comboBoxUsuario
            // 
            this.comboBoxUsuario.FormattingEnabled = true;
            this.comboBoxUsuario.Location = new System.Drawing.Point(29, 87);
            this.comboBoxUsuario.Name = "comboBoxUsuario";
            this.comboBoxUsuario.Size = new System.Drawing.Size(221, 21);
            this.comboBoxUsuario.TabIndex = 3;
            this.comboBoxUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsuario_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(29, 71);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblListPermisosDeUsuario
            // 
            this.lblListPermisosDeUsuario.AutoSize = true;
            this.lblListPermisosDeUsuario.Location = new System.Drawing.Point(29, 127);
            this.lblListPermisosDeUsuario.Name = "lblListPermisosDeUsuario";
            this.lblListPermisosDeUsuario.Size = new System.Drawing.Size(103, 13);
            this.lblListPermisosDeUsuario.TabIndex = 5;
            this.lblListPermisosDeUsuario.Text = "Permisos de Usuario";
            // 
            // lblUsuarioSeleccionado
            // 
            this.lblUsuarioSeleccionado.AutoSize = true;
            this.lblUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioSeleccionado.Location = new System.Drawing.Point(298, 71);
            this.lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            this.lblUsuarioSeleccionado.Size = new System.Drawing.Size(154, 17);
            this.lblUsuarioSeleccionado.TabIndex = 6;
            this.lblUsuarioSeleccionado.Text = "Usuario Seleccionado: ";
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUser.Location = new System.Drawing.Point(298, 91);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(61, 17);
            this.lblSelectedUser.TabIndex = 7;
            this.lblSelectedUser.Text = "Ninguno";
            // 
            // btnQuitarPermiso
            // 
            this.btnQuitarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnQuitarPermiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuitarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuitarPermiso.Location = new System.Drawing.Point(32, 449);
            this.btnQuitarPermiso.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuitarPermiso.Name = "btnQuitarPermiso";
            this.btnQuitarPermiso.Size = new System.Drawing.Size(218, 23);
            this.btnQuitarPermiso.TabIndex = 8;
            this.btnQuitarPermiso.Text = "Quitar Permiso";
            this.btnQuitarPermiso.UseVisualStyleBackColor = false;
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click);
            // 
            // treeViewTodosLosPermisos
            // 
            this.treeViewTodosLosPermisos.Location = new System.Drawing.Point(300, 143);
            this.treeViewTodosLosPermisos.Name = "treeViewTodosLosPermisos";
            this.treeViewTodosLosPermisos.Size = new System.Drawing.Size(218, 299);
            this.treeViewTodosLosPermisos.TabIndex = 9;
            this.treeViewTodosLosPermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTodosLosPermisos_AfterSelect);
            // 
            // lblListTodosLosPermisos
            // 
            this.lblListTodosLosPermisos.AutoSize = true;
            this.lblListTodosLosPermisos.Location = new System.Drawing.Point(297, 127);
            this.lblListTodosLosPermisos.Name = "lblListTodosLosPermisos";
            this.lblListTodosLosPermisos.Size = new System.Drawing.Size(98, 13);
            this.lblListTodosLosPermisos.TabIndex = 10;
            this.lblListTodosLosPermisos.Text = "Todos los Permisos";
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarPermiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarPermiso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarPermiso.Location = new System.Drawing.Point(300, 449);
            this.btnAgregarPermiso.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(218, 23);
            this.btnAgregarPermiso.TabIndex = 11;
            this.btnAgregarPermiso.Text = "Asignar Permiso";
            this.btnAgregarPermiso.UseVisualStyleBackColor = false;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // frmGestorPermisosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 493);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.lblListTodosLosPermisos);
            this.Controls.Add(this.treeViewTodosLosPermisos);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.lblSelectedUser);
            this.Controls.Add(this.lblUsuarioSeleccionado);
            this.Controls.Add(this.lblListPermisosDeUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.lblTituloGestorPermisos);
            this.Controls.Add(this.treeViewPermisosUsuario);
            this.Name = "frmGestorPermisosUsuario";
            this.Text = "frmGestorPermisos";
            this.Load += new System.EventHandler(this.frmGestorPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewPermisosUsuario;
        private System.Windows.Forms.Label lblTituloGestorPermisos;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblListPermisosDeUsuario;
        private System.Windows.Forms.Label lblUsuarioSeleccionado;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.TreeView treeViewTodosLosPermisos;
        private System.Windows.Forms.Label lblListTodosLosPermisos;
        private System.Windows.Forms.Button btnAgregarPermiso;
    }
}