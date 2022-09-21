using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using SERV;
using SERV.MultiIdioma;

namespace GUI
{
    public partial class frmSistemConteiner : Form, IIdiomaObserver
    {
        TraduccionBLL traduccionBLL;
        List<Traduccion> traducciones;
        public frmSistemConteiner()
        {
            InitializeComponent();
            traduccionBLL = new TraduccionBLL();

        }


        internal void ValidarSession() {

            Session session = Session.GetSession();
            
            this.itemMenuLogIn.Enabled = !session.IsLogged();
            this.itemMenuLogOut.Enabled = session.IsLogged();

            if (session.IsLogged()) {
                this.StatusSession.Text = Tag("TagYesSessionEmpleadoID") +
                    session.usuario.empleado.NumeroRepresentante.ToString() +
                    " - " + session.usuario.empleado.Nombre + ", "
                    + session.usuario.empleado.Apellido;
            }
            else
            {
                this.StatusSession.Text = Tag("TagNoSession");
            }
            

        }

        private void itemMenuExit_Click(object sender, EventArgs e)
        {
            //Confirmacion ¿Desea Salir?
            if (MessageBox.Show(Tag("TagConfirmarSalir"), Tag("TagSalir"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //cerrar session
                if (Session.GetSession().IsLogged())
                {
                    Session.GetSession().Logout();
                }
                Application.Exit();
            }
        }

        private void itemMenuLogIn_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.MdiParent = this;
            login.Show();
        }

        private void itemMenuLogOut_Click(object sender, EventArgs e)
        {
            //Confirmacion ¿Seguro desea cerrar sesion?
            if (MessageBox.Show(Tag("TagConfirmarCerrarSesion"), Tag("TagCerrarSesion"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Session.GetSession().Logout();
                ValidarSession();
            }
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorPermisosUsuario gestorPermisos = new frmGestorPermisosUsuario();
            gestorPermisos.MdiParent = this;
            gestorPermisos.Show();
            
        }

        private void gestorGruposDePermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorPermisosGrupos gestorPermisosGrupos = new frmGestorPermisosGrupos();
            gestorPermisosGrupos.MdiParent = this;
            gestorPermisosGrupos.Show();
            
        }

        private void operacionProtegidaTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestBLL test = new TestBLL();
            try
            {
                MessageBox.Show(test.MostrarMensajeProtegido());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Tag("TagError"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void aBMIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMIdiomas frmABMIdiomas = new frmABMIdiomas();
            frmABMIdiomas.MdiParent = this;
            frmABMIdiomas.Show();
        }

        private void traduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraducciones frmTraducciones = new frmTraducciones();
            frmTraducciones.MdiParent = this;
            frmTraducciones.Show();
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiarIdioma frmCambiarIdioma = new frmCambiarIdioma();
            frmCambiarIdioma.MdiParent = this;
            frmCambiarIdioma.Show();
            
        }

        private void frmSistemConteiner_Load(object sender, EventArgs e)
        {
            Session.SuscribirObservador(this);
            ActualizarIdioma(Session.GetSession().usuario?.idioma ?? Session.defaultIdioma);
            
            ValidarSession();
        }


        Func<string, string> Tag = IdiomaUtils.Tag;

        public void ActualizarIdioma(Idioma idioma)
        {

            IdiomaUtils.traducciones = new TraduccionBLL().GetAllByIdioma(idioma);            
            
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                this.Text = Tag("frmSistemConteiner");
                inicioToolStripMenuItem.Text = Tag("inicioToolStripMenuItem");
                itemMenuLogIn.Text = Tag("itemMenuLogIn");
                itemMenuLogOut.Text = Tag("itemMenuLogOut");
                itemMenuExit.Text = Tag("itemMenuExit");
                permisosToolStripMenuItem.Text = Tag("permisosToolStripMenuItem");
                gestoresToolStripMenuItem.Text = Tag("gestoresToolStripMenuItem");
                gestorGruposDePermisosToolStripMenuItem.Text = Tag("gestorGruposDePermisosToolStripMenuItem");
                idiomaToolStripMenuItem.Text = Tag("idiomaToolStripMenuItem");
                aBMIdiomasToolStripMenuItem.Text = Tag("aBMIdiomasToolStripMenuItem");
                traduccionesToolStripMenuItem.Text = Tag("traduccionesToolStripMenuItem");
                cambiarIdiomaToolStripMenuItem.Text = Tag("cambiarIdiomaToolStripMenuItem");
                nodosDeRedToolStripMenuItem.Text = Tag("nodosDeRedToolStripMenuItem");
                gestoresToolStripMenuItem1.Text = Tag("gestoresToolStripMenuItem1");
                planesDeServicioToolStripMenuItem.Text = Tag("planesDeServicioToolStripMenuItem");
                dispositivosToolStripMenuItem.Text = Tag("dispositivosToolStripMenuItem");
                clientesToolStripMenuItem.Text = Tag("clientesToolStripMenuItem");
                soporteTécnicoToolStripMenuItem.Text = Tag("soporteTécnicoToolStripMenuItem");
                clientesToolStripMenuItem1.Text = Tag("clientesToolStripMenuItem");
                ticketsDeBackOfficeToolStripMenuItem.Text = Tag("ticketsDeBackOfficeToolStripMenuItem");
                serviceTécnicoToolStripMenuItem.Text = Tag("serviceTécnicoToolStripMenuItem");
                gestionDeAgendaToolStripMenuItem.Text = Tag("gestionDeAgendaToolStripMenuItem");
                buscadorTicketsToolStripMenuItem.Text = Tag("buscadorTicketsToolStripMenuItem");
                usuariosToolStripMenuItem.Text = Tag("usuariosToolStripMenuItem");
                empleadosToolStripMenuItem.Text = Tag("empleadosToolStripMenuItem");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }


        private void nodosDeRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorNodoRed gestorNodoRed = new frmGestorNodoRed();
            gestorNodoRed.MdiParent = this;
            gestorNodoRed.Show();
        }

        private void planesDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorServicePlan gestorServicePlan = new frmGestorServicePlan();
            gestorServicePlan.MdiParent = this;
            gestorServicePlan.Show();
            
        }

        private void dispositivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorDispositivo gestorDispositivo = new frmGestorDispositivo();
            gestorDispositivo.MdiParent = this;
            gestorDispositivo.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorClientes gestorClientes = new frmGestorClientes();
            gestorClientes.MdiParent = this;
            gestorClientes.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSoporteClientes soporteClientes = new frmSoporteClientes();
            soporteClientes.MdiParent = this;
            soporteClientes.Show();
        }

        private void dEBUGLOGINToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            LoginResult loginResult = LoginResult.UnknownError;
            try
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                loginResult = usuarioBLL.Login("admin", "123456");
            }
            catch (LoginException ex)
            {
                if (ex.Result == LoginResult.InvalidUsername)
                {
                    MessageBox.Show("Usuario no encontrado");
                }
                else if (ex.Result == LoginResult.InvalidPassword)
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
                else
                {
                    MessageBox.Show("Error desconocido");
                }
            }
            if (loginResult == LoginResult.LoginOK || loginResult == LoginResult.AlreadyLogged)
            {
                ValidarSession();

            }
        }

        private void ticketsDeBackOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicketDeBackOffice ticketDeBackOffice = new frmTicketDeBackOffice();
            ticketDeBackOffice.MdiParent = this;
            ticketDeBackOffice.Show();
        }


        private void gestionDeAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestiondeAgenda frmgestiondeAgenda = new frmGestiondeAgenda();
            frmgestiondeAgenda.MdiParent = this;
            frmgestiondeAgenda.Show();
        }

        private void topMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buscadorTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscadorTickets ticketfinder = new frmBuscadorTickets();
            ticketfinder.MdiParent = this;
            ticketfinder.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }   
}
