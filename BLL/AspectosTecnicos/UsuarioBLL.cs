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
            if (!Session.GetSession().TienePermiso(permisoEspecifico))
            {
                //logger.Log("El usuario  no tiene permiso para quitar permisos a usuarios", Level.Warning, null, "PermisoBLL", "QuitarPermisoAUsuario");
                logger.Log("El usuario no tiene permiso para crear usuarios", LogLevel.Warning, null, "UsuarioBLL", "Create");
                throw new Exception("SIN PERMISOS \nCodigo de Operacion: " + permisoEspecifico.ToString());
            }

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
                logger.Log("El usuario no existe", LogLevel.Debug, null, "UsuarioBLL", "Login");
                throw new LoginException(LoginResult.InvalidUsername);
            }

            if (Cryptography.CalculateHash(password).Equals(usuario.Password))
            {
                Session.GetSession().Login(usuario);
                logger.Log("El usuario " + usuario.Email + " se ha logueado", LogLevel.Info, null, "UsuarioBLL", "Login");
                return LoginResult.LoginOK;
            }
            else
            {
                logger.Log("El usuario " + usuario.Email + " ha ingresado una contraseña incorrecta", LogLevel.Debug, null, "UsuarioBLL", "Login");
                throw new LoginException(LoginResult.InvalidPassword);
            }

            throw new LoginException(LoginResult.UnknownError);

        }

        public void Logout()
        {
            if (Session.GetSession().IsLogged())
            {
                logger.Log("El usuario se ha deslogueado", LogLevel.Info, null, "UsuarioBLL", "Logout");
                Session.GetSession().Logout();
            }
            else
            {
                logger.Log("El usuario no estaba logueado", LogLevel.Debug, null, "UsuarioBLL", "Logout");
                throw new LoginException(LoginResult.NotLogged);
            }
        }

       



    }
}
