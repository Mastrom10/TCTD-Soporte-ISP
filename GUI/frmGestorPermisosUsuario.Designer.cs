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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUsuario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.btnQuitarPermiso = new System.Windows.Forms.Button();
            this.treeViewTodosLosPermisos = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asignacion y Desasignacion de Permisos a Usuarios";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permisos de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuario Seleccionado: ";
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUser.Location = new System.Drawing.Point(457, 88);
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
            this.btnQuitarPermiso.Click += new System.EventHandler(this.btnQuitarPermiso_Click_1);
            // 
            // treeViewTodosLosPermisos
            // 
            this.treeViewTodosLosPermisos.Location = new System.Drawing.Point(300, 143);
            this.treeViewTodosLosPermisos.Name = "treeViewTodosLosPermisos";
            this.treeViewTodosLosPermisos.Size = new System.Drawing.Size(218, 299);
            this.treeViewTodosLosPermisos.TabIndex = 9;
            this.treeViewTodosLosPermisos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTodosLosPermisos_AfterSelect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Todos los Permisos";
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
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click_1);
            // 
            // frmGestorPermisosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 654);
            this.Controls.Add(this.btnAgregarPermiso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeViewTodosLosPermisos);
            this.Controls.Add(this.btnQuitarPermiso);
            this.Controls.Add(this.lblSelectedUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewPermisosUsuario);
            this.Name = "frmGestorPermisosUsuario";
            this.Text = "frmGestorPermisos";
            this.Load += new System.EventHandler(this.frmGestorPermisos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeViewPermisosUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.Button btnQuitarPermiso;
        private System.Windows.Forms.TreeView treeViewTodosLosPermisos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarPermiso;
    }
}