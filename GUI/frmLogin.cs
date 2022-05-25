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
    public partial class frmLogin : Form
    {

        UsuarioBLL usuarioBLL = new UsuarioBLL();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginResult loginResult = LoginResult.UnknownError;
            try {
                loginResult = usuarioBLL.Login(txtEmail.Text, txtPassword.Text);
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
            if (loginResult == LoginResult.LoginOK || loginResult == LoginResult.AlreadyLogged )
            {
                MessageBox.Show("Bienvenido " + Session.GetSession().usuario.empleado.NombreCompleto);
                this.Hide();
                frmSistemConteiner frmPrincipal = (frmSistemConteiner)this.MdiParent;
                frmPrincipal.ValidarSession();
                frmPrincipal.Show();
            }
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
