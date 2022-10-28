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
            this.gestorGruposDePermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMIdiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLogsEnTiempoRealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nodosDeRedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsDeBackOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscadorTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeAgendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBUGLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusSession = new System.Windows.Forms.ToolStripStatusLabel();
            this.controlDeCambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.topMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topMenu
            // 
            this.topMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.gestoresToolStripMenuItem,
            this.gestoresToolStripMenuItem1,
            this.soporteTécnicoToolStripMenuItem,
            this.serviceTécnicoToolStripMenuItem,
            this.dEBUGLOGINToolStripMenuItem,
            this.debugFormToolStripMenuItem});
            this.topMenu.Location = new System.Drawing.Point(0, 0);
            this.topMenu.Name = "topMenu";
            this.topMenu.Size = new System.Drawing.Size(1081, 24);
            this.topMenu.TabIndex = 1;
            this.topMenu.Text = "Menu";
            this.topMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.topMenu_ItemClicked);
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
            this.gestorGruposDePermisosToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.controlDeCambiosToolStripMenuItem});
            this.gestoresToolStripMenuItem.Name = "gestoresToolStripMenuItem";
            this.gestoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.gestoresToolStripMenuItem.Text = "Configuracion";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.permisosToolStripMenuItem.Text = "Permisos de Usuario";
            this.permisosToolStripMenuItem.Click += new System.EventHandler(this.permisosToolStripMenuItem_Click);
            // 
            // gestorGruposDePermisosToolStripMenuItem
            // 
            this.gestorGruposDePermisosToolStripMenuItem.Name = "gestorGruposDePermisosToolStripMenuItem";
            this.gestorGruposDePermisosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestorGruposDePermisosToolStripMenuItem.Text = "Grupos de Permisos";
            this.gestorGruposDePermisosToolStripMenuItem.Click += new System.EventHandler(this.gestorGruposDePermisosToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMIdiomasToolStripMenuItem,
            this.traduccionesToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem});
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // aBMIdiomasToolStripMenuItem
            // 
            this.aBMIdiomasToolStripMenuItem.Name = "aBMIdiomasToolStripMenuItem";
            this.aBMIdiomasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aBMIdiomasToolStripMenuItem.Text = "ABM Idiomas";
            this.aBMIdiomasToolStripMenuItem.Click += new System.EventHandler(this.aBMIdiomasToolStripMenuItem_Click);
            // 
            // traduccionesToolStripMenuItem
            // 
            this.traduccionesToolStripMenuItem.Name = "traduccionesToolStripMenuItem";
            this.traduccionesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.traduccionesToolStripMenuItem.Text = "Traducciones";
            this.traduccionesToolStripMenuItem.Click += new System.EventHandler(this.traduccionesToolStripMenuItem_Click);
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarLogsToolStripMenuItem,
            this.verLogsEnTiempoRealToolStripMenuItem});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // buscarLogsToolStripMenuItem
            // 
            this.buscarLogsToolStripMenuItem.Name = "buscarLogsToolStripMenuItem";
            this.buscarLogsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.buscarLogsToolStripMenuItem.Text = "Explorar Logs";
            this.buscarLogsToolStripMenuItem.Click += new System.EventHandler(this.buscarLogsToolStripMenuItem_Click);
            // 
            // verLogsEnTiempoRealToolStripMenuItem
            // 
            this.verLogsEnTiempoRealToolStripMenuItem.Name = "verLogsEnTiempoRealToolStripMenuItem";
            this.verLogsEnTiempoRealToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verLogsEnTiempoRealToolStripMenuItem.Text = "Ver Logs en tiempo real";
            this.verLogsEnTiempoRealToolStripMenuItem.Click += new System.EventHandler(this.verLogsEnTiempoRealToolStripMenuItem_Click);
            // 
            // gestoresToolStripMenuItem1
            // 
            this.gestoresToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nodosDeRedToolStripMenuItem,
            this.planesDeServicioToolStripMenuItem,
            this.dispositivosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestoresToolStripMenuItem1.Name = "gestoresToolStripMenuItem1";
            this.gestoresToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.gestoresToolStripMenuItem1.Text = "Gestores";
            // 
            // nodosDeRedToolStripMenuItem
            // 
            this.nodosDeRedToolStripMenuItem.Name = "nodosDeRedToolStripMenuItem";
            this.nodosDeRedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nodosDeRedToolStripMenuItem.Text = "Nodos de Red";
            this.nodosDeRedToolStripMenuItem.Click += new System.EventHandler(this.nodosDeRedToolStripMenuItem_Click);
            // 
            // planesDeServicioToolStripMenuItem
            // 
            this.planesDeServicioToolStripMenuItem.Name = "planesDeServicioToolStripMenuItem";
            this.planesDeServicioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.planesDeServicioToolStripMenuItem.Text = "Planes de Servicio";
            this.planesDeServicioToolStripMenuItem.Click += new System.EventHandler(this.planesDeServicioToolStripMenuItem_Click);
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            this.dispositivosToolStripMenuItem.Click += new System.EventHandler(this.dispositivosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.ticketsDeBackOfficeToolStripMenuItem,
            this.buscadorTicketsToolStripMenuItem});
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte Técnico";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // ticketsDeBackOfficeToolStripMenuItem
            // 
            this.ticketsDeBackOfficeToolStripMenuItem.Name = "ticketsDeBackOfficeToolStripMenuItem";
            this.ticketsDeBackOfficeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.ticketsDeBackOfficeToolStripMenuItem.Text = "Tickets de BackOffice";
            this.ticketsDeBackOfficeToolStripMenuItem.Click += new System.EventHandler(this.ticketsDeBackOfficeToolStripMenuItem_Click);
            // 
            // buscadorTicketsToolStripMenuItem
            // 
            this.buscadorTicketsToolStripMenuItem.Name = "buscadorTicketsToolStripMenuItem";
            this.buscadorTicketsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.buscadorTicketsToolStripMenuItem.Text = "Tickets";
            this.buscadorTicketsToolStripMenuItem.Click += new System.EventHandler(this.buscadorTicketsToolStripMenuItem_Click);
            // 
            // serviceTécnicoToolStripMenuItem
            // 
            this.serviceTécnicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeAgendaToolStripMenuItem});
            this.serviceTécnicoToolStripMenuItem.Name = "serviceTécnicoToolStripMenuItem";
            this.serviceTécnicoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.serviceTécnicoToolStripMenuItem.Text = "Service Técnico";
            // 
            // gestionDeAgendaToolStripMenuItem
            // 
            this.gestionDeAgendaToolStripMenuItem.Name = "gestionDeAgendaToolStripMenuItem";
            this.gestionDeAgendaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionDeAgendaToolStripMenuItem.Text = "Gestion de Agenda";
            this.gestionDeAgendaToolStripMenuItem.Click += new System.EventHandler(this.gestionDeAgendaToolStripMenuItem_Click);
            // 
            // dEBUGLOGINToolStripMenuItem
            // 
            this.dEBUGLOGINToolStripMenuItem.Name = "dEBUGLOGINToolStripMenuItem";
            this.dEBUGLOGINToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.dEBUGLOGINToolStripMenuItem.Text = "DEBUG LOGIN";
            this.dEBUGLOGINToolStripMenuItem.Click += new System.EventHandler(this.dEBUGLOGINToolStripMenuItem_Click_1);
            // 
            // debugFormToolStripMenuItem
            // 
            this.debugFormToolStripMenuItem.Name = "debugFormToolStripMenuItem";
            this.debugFormToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.debugFormToolStripMenuItem.Text = "DebugForm";
            this.debugFormToolStripMenuItem.Click += new System.EventHandler(this.debugFormToolStripMenuItem_Click);
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
            // controlDeCambiosToolStripMenuItem
            // 
            this.controlDeCambiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem2});
            this.controlDeCambiosToolStripMenuItem.Name = "controlDeCambiosToolStripMenuItem";
            this.controlDeCambiosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.controlDeCambiosToolStripMenuItem.Text = "Control de Cambios";
            // 
            // clientesToolStripMenuItem2
            // 
            this.clientesToolStripMenuItem2.Name = "clientesToolStripMenuItem2";
            this.clientesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem2.Text = "Clientes";
            this.clientesToolStripMenuItem2.Click += new System.EventHandler(this.clientesToolStripMenuItem2_Click);
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
            this.Load += new System.EventHandler(this.frmSistemConteiner_Load);
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
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMIdiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nodosDeRedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dEBUGLOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsDeBackOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeAgendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscadorTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLogsEnTiempoRealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeCambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem2;
    }
}

