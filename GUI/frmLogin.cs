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
            try {
                LoginResult loginResult = usuarioBLL.Login(txtEmail.Text, txtPassword.Text);
                
            }
        }
    }
}
