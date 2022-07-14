using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using SERV;

namespace GUI
{
    public partial class frmSistemConteiner : Form
    {
        
        public frmSistemConteiner()
        {
            InitializeComponent();
            ValidarSession();
        }


        internal void ValidarSession() {

            Session session = Session.GetSession();
            
            this.itemMenuLogIn.Enabled = !session.IsLogged();
            this.itemMenuLogOut.Enabled = session.IsLogged();

            if (session.IsLogged()) {
                this.StatusSession.Text = "Sesion Iniciada. Nro Empleado: " +
                    session.usuario.empleado.NumeroRepresentante.ToString() +
                    " - " + session.usuario.empleado.Nombre + ", "
                    + session.usuario.empleado.Apellido;
            }
            else
            {
                this.StatusSession.Text = "Sesion no iniciada";
            }
            

        }

        private void itemMenuExit_Click(object sender, EventArgs e)
        {
            //Confirmacion ¿Desea Salir?
            if (MessageBox.Show("¿Desea Salir Realmente?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (MessageBox.Show("¿Seguro desea cerrar sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }   
}
