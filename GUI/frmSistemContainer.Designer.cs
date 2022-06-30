namespace GUI
{
    partial class frmSistemConteiner
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSistemConteiner));
            this.topMenu = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuLogIn = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gestoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusSession = new System.Windows.Forms.ToolStripStatusLabel();
            this.gestorGruposDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.gestoresToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1081, 24);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "Menu";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenuLogIn,
            this.itemMenuLogOut,
            this.itemMenuExit});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // itemMenuLogIn
            // 
            this.itemMenuLogIn.Name = "itemMenuLogIn";
            this.itemMenuLogIn.Size = new System.Drawing.Size(143, 22);
            this.itemMenuLogIn.Text = "Iniciar Sesion";
            this.itemMenuLogIn.Click += new System.EventHandler(this.itemMenuLogIn_Click);
            // 
            // itemMenuLogOut
            // 
            this.itemMenuLogOut.Name = "itemMenuLogOut";
            this.itemMenuLogOut.Size = new System.Drawing.Size(143, 22);
            this.itemMenuLogOut.Text = "Cerrar Sesion";
            this.itemMenuLogOut.Click += new System.EventHandler(this.itemMenuLogOut_Click);
            // 
            // itemMenuExit
            // 
            this.itemMenuExit.Name = "itemMenuExit";
            this.itemMenuExit.Size = new System.Drawing.Size(143, 22);
            this.itemMenuExit.Text = "Salir";
            this.itemMenuExit.Click += new System.EventHandler(this.itemMenuExit_Click);
            // 
            // gestoresToolStripMenuItem
            // 
            this.gestoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosToolStripMenuItem,
            this.gestorGruposDePermisosToolStripMenuItem});
            this.gestoresToolStripMenuItem.Name = "gestoresToolStripMenuItem";
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.gestoresToolStripMenuItem.Text = "Gestores";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.permisosToolStripMenuItem.Text = "Gestor Permisos de Usuario";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusSession});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusSession
            // 
            this.StatusSession.Name = "StatusSession";
            this.StatusSession.Size = new System.Drawing.Size(100, 17);
            this.StatusSession.Text = "¿Session Iniciada?";
            // 
            // gestorGruposDePermisosToolStripMenuItem
            // 
            this.gestorGruposDePermisosToolStripMenuItem.Name = "gestorGruposDePermisosToolStripMenuItem";
            this.gestorGruposDePermisosToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.gestorGruposDePermisosToolStripMenuItem.Text = "Gestor Grupos de Permisos";
            this.gestorGruposDePermisosToolStripMenuItem.Click += new System.EventHandler(this.gestorGruposDePermisosToolStripMenuItem_Click);
            // 
            // frmSistemConteiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 623);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.topMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.topMenu;
            this.Name = "frmSistemConteiner";
            this.Text = "Soporte ISP";
            this.topMenu.ResumeLayout(false);
            this.topMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip topMenu;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMenuLogIn;
        private System.Windows.Forms.ToolStripMenuItem itemMenuLogOut;
        private System.Windows.Forms.ToolStripMenuItem itemMenuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusSession;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestorGruposDePermisosToolStripMenuItem;
    }
}

