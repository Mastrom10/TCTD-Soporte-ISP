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
            CargarIdioma();
            ValidarSession();
        }

        private void CargarIdioma()
        {
            if (Session.GetSession().IsLogged())
            {
                ActualizarIdioma(Session.GetSession().usuario.idioma);
            }
            else
            {
                ActualizarIdioma(Session.defaultIdioma);
            }
        }
        
        public void ActualizarIdioma(Idioma idioma)
        {
            traducciones = traduccionBLL.GetAllByIdioma(idioma);
            try
            {
                inicioToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "inicioToolStripMenuItem").traduccion;
                itemMenuLogIn.Text = traducciones.Find(x => x.etiqueta.Nombre == "itemMenuLogIn").traduccion;
                itemMenuLogOut.Text = traducciones.Find(x => x.etiqueta.Nombre == "itemMenuLogOut").traduccion;
                itemMenuExit.Text = traducciones.Find(x => x.etiqueta.Nombre == "itemMenuExit").traduccion;
                gestoresToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "gestoresToolStripMenuItem").traduccion;
                permisosToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "permisosToolStripMenuItem").traduccion;
                gestorGruposDePermisosToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "gestorGruposDePermisosToolStripMenuItem").traduccion;
                idiomaToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "idiomaToolStripMenuItem").traduccion;
                aBMIdiomasToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "aBMIdiomasToolStripMenuItem").traduccion;
                traduccionesToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "traduccionesToolStripMenuItem").traduccion;
                cambiarIdiomaToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "cambiarIdiomaToolStripMenuItem").traduccion;
                this.Text = traducciones.Find(x => x.etiqueta.Nombre == "frmSistemConteiner").traduccion;
                nodosDeRedToolStripMenuItem.Text = traducciones.Find(x => x.etiqueta.Nombre == "nodosDeRedToolStripMenuItem").traduccion;
                gestoresToolStripMenuItem1.Text = traducciones.Find(x => x.etiqueta.Nombre == "gestoresToolStripMenuItem1").traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para el idioma seleccionado");

            }
        }

        public string Tag(string tag)
        {
            string traduccion = tag;
            try
            {
                traduccion = traducciones.Find(x => x.etiqueta.Nombre == tag).traduccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontraron/ Faltan traducciones para la etiqueta " + tag);
            }
            return traduccion;
        }

        private void nodosDeRedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestorNodoRed gestorNodoRed = new frmGestorNodoRed();
            gestorNodoRed.MdiParent = this;
            gestorNodoRed.Show();
        }

        private void topMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dEBUGLOGINToolStripMenuItem_Click(object sender, EventArgs e)
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
    }   
}
