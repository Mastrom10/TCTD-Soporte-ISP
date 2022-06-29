using BE;
using DAL;
using NUnit.Framework;
using System;
using SERV;
using BLL;

namespace TEST
{
    public class BLLTest
    {
 


        Empleado unEmpleado;
        EmpleadoDAL empleadoDAL;
        Usuario unUsuario;
        UsuarioDAL usuarioDAL;

        UsuarioBLL usuarioBLL;

        int idPrueba = 999999;

        [SetUp]
        public void Setup()
        {

            unEmpleado = new Empleado();
            unEmpleado.Id = idPrueba;
            unEmpleado.Nombre = "Juan";
            unEmpleado.Apellido = "Perez";
            unEmpleado.NumeroRepresentante = 4483;
            unEmpleado.TipoEmpleado = TipoEmpleado.TecnicoDomiciliario;
            
            empleadoDAL = new EmpleadoDAL();


            unUsuario = new Usuario();
            unUsuario.Id = idPrueba;
            unUsuario.Email = "test@mail.com";
            unUsuario.Password = "123456";
            unUsuario.empleado = unEmpleado;

            usuarioDAL = new UsuarioDAL();
            usuarioBLL = new UsuarioBLL();

            usuarioDAL.Delete(unUsuario);
            empleadoDAL.Delete(unEmpleado);

        }

        [Test]
        public void ConfigureUser()
        {
            empleadoDAL.Create(unEmpleado);
            usuarioBLL.Create(unUsuario);
            Assert.AreEqual(idPrueba, unUsuario.Id);

        }

    }
}