using BE;
using DAL;
using NUnit.Framework;
using System;
using SERV;

namespace TEST
{
    public class Tests
    {

        Empleado unEmpleado;
        EmpleadoDAL empleadoDAL;
        Usuario unUsuario;
        UsuarioDAL usuarioDAL;

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


            usuarioDAL.Delete(unUsuario);
            empleadoDAL.Delete(unEmpleado);
        }

        [Test]
        public void TestEmpleadoDAL()
        {
          
            empleadoDAL.Create(unEmpleado);


            Empleado empleadoRecuperado = empleadoDAL.GetById(idPrueba);

            Assert.AreEqual(unEmpleado.Nombre, empleadoRecuperado.Nombre);

            unEmpleado.Nombre = "Ramon";

            empleadoDAL.Update(unEmpleado);

            Empleado empleadoRecuperado2 = empleadoDAL.GetById(idPrueba);

            Assert.AreEqual(unEmpleado.Nombre, empleadoRecuperado2.Nombre);

            empleadoDAL.Delete(unEmpleado);

            Empleado empleadoBorrado = empleadoDAL.GetById(idPrueba);

            Assert.IsNull(empleadoBorrado.Nombre);
        }

        [Test]
        public void TestUsuarioDAL()
        {

            empleadoDAL.Create(unEmpleado);
            usuarioDAL.Create(unUsuario);

            Assert.AreEqual(idPrueba, unUsuario.Id);

            Usuario usuarioRecuperado = usuarioDAL.GetById(idPrueba);

            Assert.AreEqual(unUsuario.Email, usuarioRecuperado.Email);

            unUsuario.Email = "otro@mail.com";

            usuarioDAL.Update(unUsuario);

            Usuario usuarioRecuperado2 = usuarioDAL.GetById(idPrueba);

            Assert.AreEqual(unUsuario.Email, usuarioRecuperado2.Email);

            usuarioDAL.Delete(unUsuario);
            empleadoDAL.Delete(unEmpleado);

            Usuario usuarioBorrado = usuarioDAL.GetById(idPrueba);

            Assert.IsNull(usuarioBorrado.Email);
        }

        [Test]
        public void ConfigureUser() {
            empleadoDAL.Create(unEmpleado);
            usuarioDAL.Create(unUsuario);
            Assert.AreEqual(idPrueba, unUsuario.Id);

        }

    }
}