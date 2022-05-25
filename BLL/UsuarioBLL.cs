using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV;
using DAL;

namespace BLL
{
    public class UsuarioBLL : GenericBLL<Usuario>
    {
        public UsuarioBLL()
        {
            dal = new UsuarioDAL();
        }

        public override void Create(Usuario usuario) {
            usuario.Password = Cryptography.CalculateHash(usuario.Password);
            base.Create(usuario);
        }


        public LoginResult Login(string email, string password)
        {
            if (Session.GetSession().IsLogged()) {
                return LoginResult.AlreadyLogged;
            }

            Usuario usuario = dal.GetAll().Where(u => u.Email == email).FirstOrDefault();
            if (usuario == null)
            {
                throw new LoginException(LoginResult.InvalidUsername);
            }

            if (Cryptography.CalculateHash(password).Equals(usuario.Password))
            {
                Session.GetSession().Login(usuario);
                return LoginResult.LoginOK;
            }
            else
            {
                throw new LoginException(LoginResult.InvalidPassword);
            }

            throw new LoginException(LoginResult.UnknownError);

        }

        public void Logout()
        {
            if (Session.GetSession().IsLogged())
            {
                Session.GetSession().Logout();
            }
            else
            {
                throw new LoginException(LoginResult.NotLogged);
            }
        }




    }
}
