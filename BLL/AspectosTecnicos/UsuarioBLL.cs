using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERV;
using DAL;
using BE;

namespace BLL
{
    public class UsuarioBLL : GenericBLL<Usuario>
    {
        public UsuarioBLL()
        {
            permiso = TipoPermiso.CRUDUsuario;
            dal = new UsuarioDAL();
        }

        public override void Create(Usuario usuario) {
            TipoPermiso permisoEspecifico = TipoPermiso.CrearUsuario;
            if (!Session.GetSession().TienePermiso(permisoEspecifico)) throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());


            usuario.Password = Cryptography.CalculateHash(usuario.Password);
            base.Create(usuario);
        }


        public LoginResult Login(string email, string password)
        {
            if (Session.GetSession().IsLogged()) {
                return LoginResult.AlreadyLogged;
            }

            //TODO buscar solo el usuario ingresado. 
            Usuario usuario = dal.GetByField("email", email);
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
